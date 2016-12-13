using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class Course
    {
        private Student[] studArr = new Student[3];
        private Teacher teacher;
        private String name;

        public Student[] Students
        {
            get
            {
                return studArr;
            }
            set
            {
                this.studArr = value;
            }
        }

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Course(Student[] studs, Teacher teachers, String name)
        {
            this.studArr = studs;
            this.teacher = teachers;
            this.Name = name;
        }
    }
}
