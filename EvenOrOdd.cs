using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOrOdd
    {
        public static void checkEvenOdd() 
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("given number is even");
            }
            else
            {
                Console.WriteLine("given number is odd");
            }


        }
       
        

    }
}
