using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddressConsole
{
    public class User_Mailing_Address
    {
        static void Main(string[] args)
        {
            bool br = true;
            int pin=0;
            Console.WriteLine("entering the user complete mailing information");
            string user_name = GetString("enter the user name");
            string city_name = GetString("enter the city name");
            string street_name = GetString("enter the street you live in");
            while (br)
            {
                Console.WriteLine("enter the pin code");
                if (Int32.TryParse(Console.ReadLine(), out pin))
                {
                    br = false;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }

            int house_number = Convert.ToInt32(GetString("enter the house number"));
            string concatenated_string = user_name + " " + city_name + " " + house_number + " " + street_name + " " + pin;
            Console.WriteLine("the information is {0}", concatenated_string);
            Console.ReadKey();
        }

        private static string GetString(string statement)
        {
            Console.WriteLine(statement);
            return Console.ReadLine();
        }


    }
}
