using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternConsole
{
    class PatternLogic
    {
        static void Main(string[] args)
        {

            int index1, index2, index3, index4, range;

            Console.WriteLine("enter the range=");
            range = Convert.ToInt32(Console.ReadLine());
            for (index1 = 1; index1 <= range; index1++)
            {
                for (index2 = 1; index2 <= range - index1; index2++)
                {
                    Console.WriteLine(" ");
                }
                for (index3 = 1; index3 <= index1; index3++)
                {
                    Console.WriteLine(index3);
                }
                for (index4 = index1 - 1; index4 >= 1; index4--)
                {
                    Console.WriteLine(index4);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            Console.ReadKey();
        }



    }
    }

