using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientReminder
    {

        public static void getQuitientReminder()
        {
            Console.WriteLine("enter first number");
            int first_number=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("enter second number");
            int second_number = Convert.ToInt16(Console.ReadLine());

            int quotient = first_number / second_number;
            int reminder=first_number % second_number;

            Console.WriteLine("quotient is: " +quotient);

            Console.WriteLine("reminder is : " + reminder);
        }
    }
}
