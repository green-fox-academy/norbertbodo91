using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();

            student.Question(teacher);
            teacher.Teach(student);
           

            Console.ReadLine();
        }  
    }
}
