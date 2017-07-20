using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationConsole
{
    class StudentInfo
    {
        static void Main(string[] args)
        {
            bool br = true;
            int class_name=0;
            Console.WriteLine("enter the student information :");
            
            string student_name = GetString("enter the name of the student:");
           
            int roll_number = Convert.ToInt32(GetString("enter the roll number :"));
            int age = Convert.ToInt32(GetString("enter the age :"));
            while (br)
            {
                Console.WriteLine("enter the class of student :");
                if (Int32.TryParse(Console.ReadLine(), out class_name))
                {
                    br = false;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            string university_name = GetString("enter the university name :");
            Console.WriteLine(student_name);
            Console.WriteLine(roll_number);
            Console.WriteLine(age);
            Console.WriteLine(class_name);
            Console.WriteLine(university_name);
             Console.ReadKey();
             }
        private static string GetString(string statement)
        {
            Console.WriteLine(statement);
            return Console.ReadLine();
        }
    }
}
