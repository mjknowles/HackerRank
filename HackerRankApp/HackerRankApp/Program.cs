using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static int maxXor(int _l, int _r)
        {
            List<int[]> byteReps = GetIntBitArray(_l, _r);
            int xorVal = 0;
            int maxVal = 0;
            for (int j = 0; j < _r - _l; j++)
            {
                for (int k = j; k < _r - _l; k++)
                {
                    xorVal = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (byteReps[j][i] != byteReps[k][i])
                        {
                            xorVal += Convert.ToInt32(Math.Pow(2, i));
                        }
                    }
                    if (xorVal > maxVal)
                        maxVal = xorVal;
                }
            }
            return maxVal;
        }

        private static List<int[]> GetIntBitArray(int in1, int in2)
        {
            List<int[]> bitArrayList = new List<int[]>();
            for (int j = in1; j <= in2; j++)
            {
                int[] numByteRep = new int[10];
                int tempNum = j;
                int numToSecondPower;

                for (int i = numByteRep.Length - 1; i > -1; i--)
                {
                    numToSecondPower = Convert.ToInt32(Math.Pow(2, i));
                    if (j >= numToSecondPower)
                    {
                        numByteRep[i] = 1;
                        tempNum = tempNum - numToSecondPower;
                    }
                    else
                        numByteRep[i] = 0;
                }
                bitArrayList.Add(numByteRep);
            }
            return bitArrayList;
        }
    }
}
