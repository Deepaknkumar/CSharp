using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class Student : Person
    {
        private String studID;

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

        public void TakeTest()
        {
            Console.WriteLine("Student Takes a Test.");
        }

        public Student(String fname, String lname, String dob, String add, String city, String id) : base(fname,lname,dob,add,city) {
            this.StudentID = id;
        }
    }
}
