using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8
{
    class Course
    {
        private List<Student> studentList = new List<Student>();
        private Teacher teacher;
        private String name;

        #region Properties
        public List<Student> Students
        {
            get {
                return this.studentList;
            }
            set
            {
                this.studentList = value;
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
            this.studentList.Add(stud);
            this.teacher = teacher;
            this.Name = name;
        }
        public void ListStudents()
        {
            foreach( Student stud in studentList)
            {
                Console.WriteLine("Student name: {0}{1}, ID: {2}",stud.FirstName,stud.LastName,stud.StudentID);
            }
        }
    }
}
