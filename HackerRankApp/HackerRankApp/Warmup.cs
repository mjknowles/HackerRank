using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Warmup
    {
        public void isFibo()
        {
            int totalInputs = Convert.ToInt32(Console.ReadLine());
            List<string> allNumberInputs = new List<string>();
            for (int i = 0; i < totalInputs; i++)
            {
                allNumberInputs.Add(Console.ReadLine());
            }
            for (int j = 0; j < totalInputs; j++)
            {
                bool continueLoop = true;
                UInt64 fib1 = 0;
                UInt64 fib2 = 1;
                UInt64 fibSum = 0;
                UInt64 userInput = 0;
                try
                {
                    userInput = Convert.ToUInt64(allNumberInputs[j]);
                }
                catch
                {
                    Console.WriteLine("IsNotFibo");
                    continue;
                }
                if (userInput > Math.Pow(10, 10))
                {
                    Console.WriteLine("IsNotFibo");
                    continue;
                }
                while (continueLoop)
                {
                    try
                    {
                        fibSum = fib1 + fib2;
                    }
                    catch
                    {
                        Console.WriteLine("IsNotFibo");
                        break;
                    }
                    if (fibSum == userInput)
                    {
                        continueLoop = false;
                        Console.WriteLine("IsFibo");
                    }
                    else if (fibSum > userInput)
                    {
                        continueLoop = false;
                        Console.WriteLine("IsNotFibo");
                    }
                    else
                    {
                        fib1 = fib2;
                        fib2 = fibSum;
                    }
                }
            }
        }

        public void FindDigits()
        {
            int totalInputs = Convert.ToInt32(Console.ReadLine());
            List<string> allNumberInputs = new List<string>();
            for (int i = 0; i < totalInputs; i++)
            {
                allNumberInputs.Add(Console.ReadLine());
            }
            for (int j = 0; j < totalInputs; j++)
            {
                List<int> allDigits = new List<int>();
                for (int i = 0; i < allNumberInputs[j].Length; i++)
                {
                    allDigits.Add(Convert.ToInt32(allNumberInputs[j][i].ToString()));
                }

                int dividesEvenlyCounter = 0;
                int fullInputNumber = Convert.ToInt32(allNumberInputs[j]);
                foreach (int digit in allDigits)
                {
                    if (digit == 0) { }
                    else if (fullInputNumber % digit == 0)
                    {
                        dividesEvenlyCounter++;
                    }
                }
                Console.WriteLine(dividesEvenlyCounter);
            }
        }
    }
}
