using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersConsole
{
    class Swap
    {
        static void Main(string[] args)
        {
            int first_number;
            int second_number;
            Console.WriteLine("enter the first number");
            first_number = Convert.ToInt32(Console.ReadLine());
            second_number = Convert.ToInt32(Console.ReadLine());
            first_number = first_number + second_number;
            second_number = first_number - second_number;
            first_number = first_number - second_number;
            Console.WriteLine("first number is {0}",first_number);
            Console.WriteLine("second number is {0}", second_number);

            Console.ReadKey();




        }
    }
}
