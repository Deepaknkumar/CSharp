using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8
{
    class Teacher : Person
    {
        private String teacherID;

        public String TeacherID
        {
            get
            {
                return teacherID;
            }
            set
            {
                this.teacherID = value;
            }
        }

        public Teacher(String fname, String lname, String dob, String add, String city, String id) : base(fname, lname, dob, add, city)
        {
            this.TeacherID = id;
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher Grades the test.");
        }
    }
}
