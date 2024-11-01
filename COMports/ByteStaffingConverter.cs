using System.Text;

namespace COMports
{
    public static class ByteStaffingConverter
    {
        public const int AmountDataBytes = 9;

        public static byte[] StartFlag
        {
            get
            {
                Encoding cp866 = Encoding.GetEncoding(866);
                string test = $"@{(char)('a' + (AmountDataBytes - 1))}";
                return cp866.GetBytes(test);
            }
        }

        public const byte ReplaceCode = 0x7D;

        public static List<string> CreateFrames(string data, int sourcePort, int destinationPort = 0)
        {
            List<string> frames = [];

            for (int i = 0; i < data.Length; i += AmountDataBytes)
            {
                int lenght = Math.Min(AmountDataBytes, data.Length - i);
                string frameData = data.Substring(i, lenght);
                string frame = CreateFrame(frameData, sourcePort, destinationPort);
                frames.Add(frame);
            }

            return frames;
        }

        public static string CreateFrame(string data, int sourcePort, int destinationPort = 0)
        {
            string frame = $"{StartFlag[0]:X2}" + $"{StartFlag[1]:X2}"
                + $"{destinationPort:X2}" + $"{sourcePort:X2}";

            Encoding cp866 = Encoding.GetEncoding(866);
            byte[] bytes = cp866.GetBytes(data);

            for (int b = 0; b < AmountDataBytes; b++)
            {
                if (b < bytes.Length - 1 && bytes[b] == StartFlag[0] && bytes[b + 1] == StartFlag[1])
                {
                    frame += $"{ReplaceCode:X2}5D";
                    b++;
                }
                else if (b < bytes.Length && bytes[b] == ReplaceCode)
                {
                    frame += $"{ReplaceCode:X2}5E";
                }
                else
                {
                    frame += b < bytes.Length ? $"{bytes[b]:X2}" : $"{0:X2}";
                }
            }

            frame += Coding.GetRemain(data);

            return frame;
        }

        public static string GetData(string staffedBytes)
        {
            List<string> frames = new(staffedBytes.Split($"{StartFlag[0]:X2}{StartFlag[1]:X2}"));
            frames.RemoveAt(0);

            Encoding cp866 = Encoding.GetEncoding(866);

            string temp = string.Empty;
            foreach (string frame in frames)
            {
                string data = string.Empty;
                string dataFrame = frame[4..^0];
                for(int i = 0; i < dataFrame.Length - 2; i+=2)
                {
                    string hexByte = dataFrame.Substring(i, 2);
                    if(hexByte == $"{ReplaceCode:X2}")
                    {
                        i+= 2;
                        hexByte = dataFrame.Substring(i, 2);
                        if(hexByte == "5D")
                        {
                            data += "@i";
                        }
                        else if (hexByte == "5E")
                        {
                            data += "}";
                        }
                    }
                    else
                    {
                        byte hexCode = Convert.ToByte(hexByte, 16);
                        string result = cp866.GetString([hexCode]);
                        data += result;
                    }
                }
                byte remain = Convert.ToByte(dataFrame.Substring(dataFrame.Length - 2), 16);
                string remainString = cp866.GetString([remain]);
                string fixFrame = Coding.FixData(data, remainString);

                temp += data;
            }

            return temp;
        }
    }
}
