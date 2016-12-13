using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Deepak", "Kumar", "10/10/1994", "UBC", "Vancouver", "G73717151");
            Student student2 = new Student("Mahdi", "Aziz", "20/03/1990", "UBC", "Vancouver", "G82502472");
            Student student3 = new Student("Megan", "Kruz", "21/03/1994", "UBC", "Vancouver", "U95837028");

            student1.Grades.Push(10);
            student1.Grades.Push(10);
            student1.Grades.Push(9.75);
            student1.Grades.Push(10);
            student1.Grades.Push(10);

            student2.Grades.Push(10);
            student2.Grades.Push(9.75);
            student2.Grades.Push(9.5);
            student2.Grades.Push(10);
            student2.Grades.Push(10);

            student3.Grades.Push(10);
            student3.Grades.Push(10);
            student3.Grades.Push(9.25);
            student3.Grades.Push(10);
            student3.Grades.Push(10);
            Teacher teacher1 = new Teacher("Yves", "Lucet", "14/09/1981", "UBC", "Vancouver", "E19470792");
            Course course1 = new Course(student1,teacher1,"Programming with C#");
            course1.Students.Add(student2);
            course1.Students.Add(student3);
            course1.ListStudents();
        }
    }
}
