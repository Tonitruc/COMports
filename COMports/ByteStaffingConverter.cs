using System.Text;

namespace COMports
{
    public static class ByteStaffingConverter
    {
        public const int AmountBytesInFrame = 9;

        public static byte[] StartFlag
        {
            get
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding cp866 = Encoding.GetEncoding(866);
                string test = $"@{(char)('a' + (AmountBytesInFrame - 1))}";
                return cp866.GetBytes(test);
            }
        }

        public const byte ReplaceCode = 0x7D;

        public static Dictionary<byte, byte[]> ReplacementBytes = new() {
            {StartFlag[0], [ReplaceCode, 0x5D] },
            {StartFlag[1], [ReplaceCode, 0x5E] },
            {ReplaceCode, [ReplaceCode, 0x5F] } };


        public static List<string> CreateFrames(string data, int sourcePort, int destinationPort = 0,
            string separator = "")
        {
            string result = string.Empty;

            List<string> frames = [];

            for (int i = 0; i < data.Length; i += AmountBytesInFrame)
            {
                int lenght = Math.Min(AmountBytesInFrame, data.Length - i);
                string frameData = data.Substring(i, lenght);
                string frame = CreateFrame(frameData, sourcePort, destinationPort, separator);
                frames.Add(frame);
            }

            return frames;
        }

        public static string CreateFrame(string data, int sourcePort, int destinationPort = 0,
            string separator = "")
        {
            byte[] test = StartFlag;
            string frame = $"{StartFlag[0]:X2}" + $"{StartFlag[1]:X2}"
                + $"{sourcePort:X2}" + $"{destinationPort:X2}";

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding cp866 = Encoding.GetEncoding(866);
            byte[] bytes = cp866.GetBytes(data);

            for (int b = 0; b <= AmountBytesInFrame; b++)
            {

                if (b < bytes.Length - 1 && bytes[b] == StartFlag[0] && bytes[b + 1] == StartFlag[1])
                {
                    frame += $"{ReplacementBytes[StartFlag[0]][0]:X2}{ReplacementBytes[StartFlag[0]][1]:X2}"
                        + $"{ReplacementBytes[StartFlag[1]][0]:X2}{ReplacementBytes[StartFlag[1]][1]:X2}";
                    b++;
                }
                else if (b < bytes.Length && bytes[b] == ReplaceCode)
                {
                    frame += $"{ReplacementBytes[ReplaceCode][0]:X2}{ReplacementBytes[ReplaceCode][1]:X2}";
                }
                else if (b < bytes.Length)
                {
                    frame += $"{bytes[b]:X2}";
                }
                else
                {
                    frame += $"{0:X2}";
                }
            }

            return frame;
        }

        public static string GetData(string staffedBytes)
        {
            List<string> frames = staffedBytes.Split("4069").ToList();
            frames.RemoveAt(0);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding cp866 = Encoding.GetEncoding(866);

            string test = "";
            foreach (string frame in frames)
            {
                string data = "";
                string dataFrame = frame.Substring(4);
                for(int i = 0; i < dataFrame.Length - 2; i+=2)
                {
                    string hexByte = dataFrame.Substring(i, 2);
                    if(hexByte == "7D")
                    {
                        if(i < dataFrame.Length - 4)
                        {
                            i+= 2;
                            hexByte = dataFrame.Substring(i, 2);
                            if(hexByte == "5D")
                            {
                                data += "@";
                            }
                            else if(hexByte == "5E")
                            {
                                data += "i";
                            }
                            else if (hexByte == "5F")
                            {
                                data += "}";
                            }
                        }
                    }
                    else
                    {
                        byte hexCode = Convert.ToByte(hexByte, 16);
                        string result = cp866.GetString([hexCode]);
                        data += result;
                    }
                }
                test += data;
            }

            return test;
        }
    }
}
