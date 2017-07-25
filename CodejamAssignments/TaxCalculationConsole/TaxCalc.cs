using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculationConsole
{
   public class TaxCaclc
    {
        static void Main(string[] args)
        {
            int choice=0;
            int money;
            int tax;
            bool brkk = true; 
            Console.WriteLine("enter the money for which the corressponding tax is needed to be calculated");
            money = Convert.ToInt32(Console.ReadLine());
            while (brkk)
            {
                Console.WriteLine("ENTER YOUR CHOICE :");
                Console.WriteLine("PRESS <1> If Money is less than 10,000");
                Console.WriteLine("PRESS <2> If money is from 10,000 and 100,000");
                Console.WriteLine("PRESS <3> If money is above 100,000");
                if (Int32.TryParse(Console.ReadLine(), out choice))
                    brkk = false;
                else Console.WriteLine("INVALID INPUT");
            }
            switch (choice)
            {

                case 1:
                    if (money < 10000)
                    {
                        tax = (5 / 100) * money;
                        Console.WriteLine(tax);
                    }
                    break;

                case 2:
                    if ((money <= 100000))
                    {
                        tax = (8 / 100) * money;
                        Console.WriteLine(tax);
                    }
                    break;

                case 3:
                    if (money > 100000)
                    {
                        tax = ((85) / 1000) * money;
                        Console.WriteLine(tax);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Case");
                    break;


            }

            Console.ReadKey();

        }

    }
}

