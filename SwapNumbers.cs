using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public static void swapTwoNumbers() 
        {
            Console.WriteLine("enter the first number");
            int first_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int second_number= Convert.ToInt32(Console.ReadLine());
            first_number = first_number - second_number;
            second_number = second_number + first_number;
            first_number=second_number - first_number;
            Console.WriteLine(first_number);
            Console.WriteLine(second_number);
        }
    }
}
