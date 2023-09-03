using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestAmongThree
    {
        public static void getLargest()
        {
            Console.WriteLine("enter the first number");
            int first_number=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int second_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the third number");
            int third_number = Convert.ToInt32(Console.ReadLine());

            if (first_number>second_number && first_number > third_number)
            {
                Console.WriteLine("first number is largest");
            }
            else if (second_number > third_number)
            {
                Console.WriteLine("second number is largest");
            }
            else
            {
                Console.WriteLine("third number is largest");
            }
        }
    }
}
