using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheString
{
   public class ReverseString
    {
        static void Main(string[] args)
        {

            int index;
            string s = "SAKSHI";
            char[] character_array = s.ToCharArray();
            for (index = 0; index < character_array.Length; index++)

            {
                Console.Write(character_array[index] + " ");


            }
            Console.WriteLine(" ");
            for (index = character_array.Length - 1; index >= 0; index--)
            {
                Console.Write(character_array[index] + " ");
            }
            Console.ReadKey();










        }
    }
}
