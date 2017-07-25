using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePowerOfNumberConsole
{
   public class Power_Of_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number whom you find the power of");
            double number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the power");
            double power = Convert.ToInt32(Console.ReadLine());
            double result = Math.Pow(number, power);
            Console.WriteLine("power of a number : " + result);

            Console.ReadKey();

        }
    }
}
