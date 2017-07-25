using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoClassesConsole
{
    class TwoClass
    {
        static void Main(string[] args)
        {
            FirstClass f = new FirstClass();
            f.method();
            SecondClass s = new SecondClass();
            s.method_two();
        }
    }
    public class FirstClass
    {
        public void method()
        {
            double number;
            int result;
            Console.WriteLine("enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            result = (int)Math.Sqrt(number);
            Console.WriteLine("squareroot is {0}",result);
        }

    }


    public class SecondClass
    {
        public void method_two()
        {
            double number;
            int result;
            Console.WriteLine("enter the number");
            number = Convert.ToDouble(Console.ReadLine());
            result = (int)Math.Ceiling(number);
            Console.WriteLine("ceiling value is {0}", result);
        }

    }


}







