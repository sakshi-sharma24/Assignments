using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyTwoArraysConsole
{
    public class CopyArrayElements
    {
        static void Main(string[] args)
        {

            int[] array_one=new int[100];
            int[] array_two=new int[100];

            Console.WriteLine("ENTER THE SIZE OF BOTH ARRAYS");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("enter the elements into the array");
                    array_one[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int j = 0; j < n; j++)
                {
                    array_two[j] = array_one[j];
                }

                Console.WriteLine("Copied elements");

                for (int i = 0; i < n; i++)
                    Console.WriteLine("Array copies is {0} {1}", i, array_two[i]);

                Console.ReadKey();


            }






        }
    }

