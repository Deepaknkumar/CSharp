using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4
{
    class Program
    {
        public struct Student {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String dateofBirth { get; set; }
            public String address { get; set; }
            public String city { get; set; }
            public Student(String fn, String ln, String dob, String add, String city)
            {
                this.firstName = fn;
                this.lastName = ln;
                this.dateofBirth = dob;
                this.address = add;
                this.city = city;
            }
        }


        public struct Teacher
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String dateofBirth { get; set; }
            public String address { get; set; }
            public String city { get; set; }
            public Teacher(String fn, String ln, String dob, String add, String city)
            {
                this.firstName = fn;
                this.lastName = ln;
                this.dateofBirth = dob;
                this.address = add;
                this.city = city;
            }
        }


        public struct program
        { 
            public String name { get; set; }
            public String dept { get; set; }
            public String years { get; set; }
            public program(String name, String department, String years)
            {
                this.name = name;
                this.dept = department;
                this.years = years;
            }
        }

        public struct course
        {
            public String name { get; set; }
            public String code { get; set; }
            public String dept { get; set; }
            public course(String name, String code,String department)
            {
                this.name = name;
                this.dept = department;
                this.code = code;
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0].firstName = "Deepak";
            students[0].lastName = "Kumar";
            students[0].dateofBirth = "10/01/1994";
            students[0].address = "The University of British Columbia";
            students[0].city = "Vancouver";

            Console.WriteLine(students[0].firstName);
            Console.WriteLine(students[0].lastName);
            Console.WriteLine(students[0].dateofBirth);
            Console.WriteLine(students[0].address);
            Console.WriteLine(students[0].city);

            Console.WriteLine("Press any Key to exit.......");
            Console.ReadLine();
        }
    }
}
