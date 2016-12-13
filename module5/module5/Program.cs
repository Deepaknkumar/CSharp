using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Deepak","Kumar","10/10/1994","UBC","Vancouver");
            Student student2 = new Student("Mahdi", "Aziz", "20/03/1990", "UBC", "Vancouver");
            Student student3 = new Student("Megan", "Kruz", "21/03/1994", "UBC", "Vancouver");

            Student[] students = { student1, student2, student3 };
            Teacher[] teachers = new Teacher[3];
            Course course0 = new Course(students, teachers, "Programming with C#");
            Degree deg1 = new Degree(new Course[] { course0 }, "Bachelor of Science");
            UProgram program1 = new UProgram(deg1, "Information Technology");

            Console.WriteLine("The {0} Program contain the {1} degree.",program1.Name,deg1.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}.", deg1.DegreeName, course0.Name);
            Console.WriteLine("The {0} course contains {1} student(s).",course0.Name,course0.Students.Length);
        }
    }
}
