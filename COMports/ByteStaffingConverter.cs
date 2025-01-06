using System.Collections.Generic;
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

            List<byte> bytesList = Enumerable.Repeat((byte)0x00, 9).ToList();
            int i = 0;
            foreach (var b in cp866.GetBytes(data))
                bytesList[i++] = b;

            for (int b = 0; b < AmountDataBytes; b++)
            {
                if (b < bytesList.Count - 1 && bytesList[b] == StartFlag[0] && bytesList[b + 1] == StartFlag[1])
                {
                    frame += $"{ReplaceCode:X2}5D";
                    b++;
                }
                else if (b < bytesList.Count && bytesList[b] == ReplaceCode)
                {
                    frame += $"{ReplaceCode:X2}5E";
                }
                else
                {
                    frame += b < bytesList.Count ? $"{bytesList[b]:X2}" : $"{0:X2}";
                }
            }

            var test = Coding.DividePolynomials(Coding.HexBytesToBitArray(bytesList.ToArray()));
            frame += $"{Coding.BitArrayToByte(test):X2}";

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
                //Coding.CreateMistake(Coding.HexBytesToBitArray(cp866.GetBytes(dataFrame[0..^2])));
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
                data = Coding.FixMistake(data, frame[^2..^0]);
                temp += data;
            }

            return temp.Replace("\0", "");
        }
    }
}
