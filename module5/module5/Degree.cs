using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Degree
    {
        private Course[] courseArr;
        private String degName;

        public String DegreeName
        {
            get
            {
                return degName;
            }
            set
            {
                this.degName = value;
            }
        }

        public Course[] Courses
        {
            get
            {
                return courseArr;
            }
            set
            {
                this.courseArr = value;
            }
        }

        public Degree(Course[] courses, String name)
        {
            this.courseArr = new Course[courses.Length];
            this.courseArr = courses;
            this.DegreeName = name;
        }
    }
}
