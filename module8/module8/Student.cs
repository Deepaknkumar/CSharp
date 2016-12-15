using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8
{
    class Student : Person
    {
        private String studID;
        private Stack<double> grades = new Stack<double>();

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

        public Stack<double> Grades
        {
            get
            {
                return this.grades;
            }
            set
            {
                this.grades = value;
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
