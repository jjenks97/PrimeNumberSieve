using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        void primeNumberSieve(int min, int max)
        {
            int numIndexes = max + 1;
            bool[] primeArray = new bool[numIndexes];
            for (int i = 0; i < numIndexes; i++)
            {
                primeArray[i] = true;
            }

            for (int x = 2; x <= Math.Sqrt(numIndexes); x++)
            {
                for (int y = Convert.ToInt32(Math.Pow(x, 2)); y < numIndexes; y = y + x)
                {
                    primeArray[y] = false;
                }
            }
            Console.Write("Primes: ");
            for (int i = min; i < numIndexes; i++)
            {
                if ((primeArray[i] == true) && (i >= 2))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            Program prime = new Program();
            do
            {
                Console.WriteLine("Enter a minimum value: ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a maximum value: ");
                max = Convert.ToInt32(Console.ReadLine());
            } while ((min >= max) || (min < 0) || (max < 0));
            prime.primeNumberSieve(min, max);
            
        }
    }
}
