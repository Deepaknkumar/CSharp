using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module7
{
    class Student : Person
    {
        private String studID;
        private Stack grades = new Stack();

        #region Properties
        public String StudentID
        {
            get
            {
                return studID;
            }
            set
            {
                this.studID = value;
            }
        }

        public Stack Grades
        {
            get
            {
                return grades;
            }
            set
            {
                this.grades.Push(value);
            }
        } 
        #endregion Properties

        public void TakeTest()
        {
            Console.WriteLine("Student Takes a Test.");
        }

        public Student(String fname, String lname, String dob, String add, String city, String id) : base(fname, lname, dob, add, city)
        {
            this.StudentID = id;
        }
    }
}
