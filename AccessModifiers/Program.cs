using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("Kenan");

            Console.WriteLine(student.GetName());

            student.SetBirthdate(new DateTime(1987, 05, 21));
            Console.WriteLine(student.GetBirthDate().ToShortTimeString());

            Console.WriteLine(student.GetAge());
        }

    }
}
