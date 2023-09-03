using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void isLeapYear()
        {

            Console.WriteLine("enter the year");

            int year =Convert.ToInt16(Console.ReadLine());

            if (Convert.ToString( year).Length==4 )
            {
                if (year % 4 ==0)
                {
                    Console.WriteLine("this is a Leap Year");
                }
                else
                {
                    Console.WriteLine("this is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("enter a valid year");
            }
        }
    }
        
        
}

    

