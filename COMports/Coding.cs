using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace COMports
{
    public static class Coding
    {
        public const string Polinom = "10000111"; //135

        private static Random _random = new();

        private static string ConvertToBin(string data)
        {
            Encoding cp866 = Encoding.GetEncoding(866);
            List<byte> bytes = new List<byte>(cp866.GetBytes(data));

            string binaryString = string.Join("", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
            return binaryString;
        }

        private static string ConvertToHex(string binaryString)
        {
            string hexValue = string.Empty;
            for (int i = 0; i < binaryString.Length; i += 8)
            {
                string byteString = binaryString.Substring(i, 8);
                int decimalValue = Convert.ToInt32(byteString, 2);
                hexValue += decimalValue.ToString("X2");
            }

            return hexValue;
        }

        public static string GetRemain(string data)
        {
            string binaryString = ConvertToBin(data);

            for (int j = 0; j < (9 - data.Length) * 8 + Polinom.Length - 1; j++)
                binaryString += "0";

            string remainBin = Divide(binaryString);

            int decimalValue = Convert.ToInt32(remainBin, 2);
            return decimalValue.ToString("X2");
        }

        public static string Divide(string dividend)
        {
            int dividendLength = dividend.Length;
            int divisorLength = Polinom.Length;

            char[] remainder = dividend.ToCharArray();

            for (int i = 0; i <= dividendLength - divisorLength; i++)
            {
                if (remainder[i] == '1')
                {
                    for (int j = 0; j < divisorLength; j++)
                    {
                        remainder[i + j] = remainder[i + j] == Polinom[j] ? '0' : '1';
                    }
                }
            }

            string remainderResult = new string(remainder).Substring(dividendLength - divisorLength + 1);

            return remainderResult;
        }

        public static string CycleShiftRight(string data)
        {
            StringBuilder sb = new();
            sb.Append(data[^1]);
            sb.Append(data.Substring(0, data.Length - 1));
            return sb.ToString();
        }

        public static string CycleShiftLeft(string data)
        {
            StringBuilder sb = new();
            sb.Append(data.Substring(1, data.Length - 1));
            sb.Append(data[0]);
            return sb.ToString();
        }

        public static string CreateMistake(string data)
        {
            data = data.Substring(8); 
            data = data.Substring(0, data.Length - 2);

            data = ConvertToBin(data);
            StringBuilder sb = new(data);

            int chance = _random.Next(0, 100);
            if(chance <= 40)
            {
                int bitNum = _random.Next(0, data.Length);
                sb[bitNum] = sb[bitNum] == '1' ? '0' : '1';
            }

            return ConvertToHex(sb.ToString());
        }

        public static string FixData(string data, string remain)
        {
            string fixData = ConvertToBin(data);

            int test = (9 - data.Length) * 8;
            for (int i = 0; i < test; i++)
                fixData += '0';

            remain = ConvertToBin(remain);
            fixData += remain.Substring(1);
            remain = Divide(fixData);

            int weight = remain.Count(ch => ch == '1');
            int amountShift = 0;
            if (weight != 0)
            {
                fixData = CycleShiftLeft(fixData);
                remain = Divide(fixData);

                weight = remain.Count(ch => ch == '1');
                if (weight == 1)
                {
                    fixData = XORString(fixData, remain);
                    for(int i = 0; i < amountShift; i++)
                    {
                        fixData = CycleShiftRight(fixData);
                    }
                }

                amountShift++;
            }

            return data;
        }

        public static string XORString(string data1, string data2)
        {
            StringBuilder result = new();

            int i1 = data1.Length - 1, i2 = data2.Length - 1;
            while (i1 >= 0 && i2 >= 0)
            {
                if (data1[i1] == data2[i2])
                {
                    result.Insert(0, '0');
                }
                else
                {
                    result.Insert(0, '1');
                }
                i1--; i2--;
            }

            while (i1 >= 0)
            {
                result.Insert(0, data1[i1--]);
            }
            while (i2 >= 0)
            {
                result.Insert(0, data2[i2--]);
            }

            return result.ToString();
        }
    }
}
