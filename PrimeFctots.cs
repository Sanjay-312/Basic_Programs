using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFctots
    {
        public static void getPrimeFactors()
        {
            Console.WriteLine("enter the number");

            int number = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    int result = checkForPrime(i);
                    if (result > 1)
                    {
                        Console.WriteLine(result);
                    }

                }

            }
        }

        public static int checkForPrime(int prime)
        {

            int factors = 0;

            for (int i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    factors++;
                }
            }
            if (factors == 0)
            {
                return prime;
            }
            else
            {
                return 0;
            }



            
        }
    }
}
