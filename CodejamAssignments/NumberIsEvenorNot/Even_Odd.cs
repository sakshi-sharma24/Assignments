using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberIsEvenorNot
{
    public class Even_Odd
    {
        static void Main(string[] args)
        {
            int number=0;
            bool brr = true;
            string ans="";
            while (brr)
            {
                Console.WriteLine("enter the number : ");
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    brr = false;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }

            }
            if (number % 2 == 0 && number > 0)
            {
                ans = "EVEN";
            }
            else
            {
                ans="ODD";
            }
            Console.WriteLine( ans+" NUMBER");
            Console.ReadKey();
        }
       
    }
}
