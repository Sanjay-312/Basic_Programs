using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void get_powers_of_2()
        {
            Console.WriteLine("enter the value of N ");
            int N=Convert.ToInt16( Console.ReadLine());

            if (N >= 0 && N<31)
            {
                for (int i = 0; i <= N; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
