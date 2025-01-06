using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMports
{
    public static class Coding
    {
        private readonly static Random _random = new();

        public readonly static BitArray Polinom = new([true, false, false, false, false, true, true, true]); // 10000111 

        public static BitArray DividePolynomials(BitArray data)
        {
            BitArray remainder = MergeBitArrays(data, new(Polinom.Length - 1));

            for (int i = 0; i <= remainder.Length - Polinom.Length; i++)
            {
                if (remainder[i])
                {
                    for (int j = 0; j < Polinom.Length; j++)
                        remainder[i + j] = remainder[i + j] ^ Polinom[j];
                }
            }

            return new(remainder.Cast<bool>().Skip(remainder.Length - Polinom.Length + 1).Take(Polinom.Length - 1).ToArray());
        }

        public static BitArray HexBytesToBitArray(byte[] dataBytes)
        {
            return new BitArray(dataBytes);
        }

        public static string BitArrayToString(BitArray bitArray)
        {
            byte[] byteArray = new byte[(bitArray.Length + 7) / 8];
            bitArray.CopyTo(byteArray, 0);
            Encoding cp866 = Encoding.GetEncoding("cp866");
            return cp866.GetString(byteArray);
        }

        public static BitArray XorBitArrays(BitArray data, BitArray remaind)
        {
            BitArray result = new(data);
            for (int i = 0; i < remaind.Length; i++)
                result[^(i + 1)] ^= remaind[^(i + 1)];

            return result;
        }

        public static BitArray MergeBitArrays(BitArray array1, BitArray array2)
        {
            bool[] mergedArray = new bool[array1.Length + array2.Length];
            array1.CopyTo(mergedArray, 0);
            array2.CopyTo(mergedArray, array1.Length);
            return new BitArray(mergedArray);
        }

        public static BitArray CreateMistake(BitArray data)
        {
            int chance = _random.Next(100);

            if(chance <= 40)
            {
                int misIndex = _random.Next(0, data.Length);
                data[misIndex] = !data[misIndex];
            }
            return data;
        }

        public static BitArray LeftRotate(BitArray bitArray)
        {
            BitArray result = new(bitArray);
            bool lastBit = bitArray[0];
            result.RightShift(1);
            result[^1] = lastBit;
            return result;
        }

        public static BitArray RightRotate(BitArray bitArray)
        {
            BitArray result = new(bitArray);
            bool lastBit = bitArray[^1];
            result.LeftShift(1);
            result[0] = lastBit;
            return result;
        }

        public static string FixMistake(string data, string FCS)
        {
            Encoding cp866 = Encoding.GetEncoding("cp866");
            BitArray bitsData = HexBytesToBitArray(cp866.GetBytes(data));
            BitArray fcsData = ByteToBitArray(Convert.ToByte(FCS, 16));

            BitArray tempData = MergeBitArrays(bitsData, fcsData);
            BitArray remaind = DividePolynomials(tempData);

            if(remaind.Cast<bool>().Count(b => b) == 0)
            {
                return data;
            }

            int amountShift = 0;
            while (true)
            {
                remaind = DividePolynomials(tempData);

                if (remaind.Cast<bool>().Count(b => b) > 1)
                {
                    LeftRotate(tempData);
                    amountShift++;
                }
                else
                {
                    XorBitArrays(tempData, remaind);
                    for (int i = 0; i < amountShift; i++)
                        RightRotate(tempData);

                    BitArray fixData = new(tempData.Cast<bool>().Skip(tempData.Length - Polinom.Length + 1).Take(Polinom.Length - 1).ToArray());
                    data = BitArrayToString(fixData);
                    break;
                }
            }
            return data;
        }

        public static byte BitArrayToByte(BitArray bitArray)
        {
            byte resultByte = 0;
            for (int i = 0; i < 7; i++)
            {
                if (bitArray[i])
                    resultByte |= (byte)(1 << (6 - i));  
            }
            return resultByte;
        }

        public static BitArray ByteToBitArray(byte b)
        {
            BitArray bitArray = new(7);
            for(int i = 0; i < 7; i++)
                bitArray[i] = (b & (1 << (6 - i))) != 0; 
            return bitArray;
        }
    }
}
