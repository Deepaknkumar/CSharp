using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module7
{
    class Course
    {
        private ArrayList studArr = new ArrayList();
        private Teacher teacher;
        private String name;

        #region Properties
        public ArrayList Students
        {
            get
            {
                return studArr;
            }
            set
            {
                this.studArr.Add(value);
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
        #endregion Properties

        public Course(Student stud, Teacher teacher, String name)
        {
            this.studArr.Add(stud);
            this.teacher = teacher;
            this.Name = name;
        }

        public void ListStudents()
        {
            foreach(Student stud in studArr)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }
        }
    }
}
