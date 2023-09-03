using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlippingCoin
    {
       public static void getPercentage()
        {
            Random random = new Random();

            int number = random.Next(0, 2);
            string result;
           
            
            if(number < 0.5)
            {
               result = "Tails";
            }
            else
            {
                result = "Heads";  
            }
            Console.WriteLine(result);
        }

        
        
    }
}
