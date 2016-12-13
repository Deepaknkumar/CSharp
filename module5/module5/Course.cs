using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Course
    {
        private Student[] studArr = new Student[3];
        private Teacher[] teacherArr = new Teacher[3];
        private String name;

        public Student[]  Students{
            get
            {
                return studArr;
            }
            set
            {
                this.studArr = value;
            }
        }

        public Teacher[] Teachers
        {
            get
            {
                return teacherArr;
            }
            set
            {
                this.teacherArr = value;
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

        public Course(Student[] studs, Teacher[] teachers, String name)
        {
            this.studArr = studs;
            this.teacherArr = teachers;
            this.Name = name;
        }
    }
}
