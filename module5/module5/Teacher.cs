using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Teacher
    {
        private String firstName;
        private String lastName;
        private String birthday;
        private String subject;

        public String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public String Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public String Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public Teacher(String fname, String lname, String bday, String sub)
        {
            this.FirstName = fname;
            this.lastName = lname;
            this.Birthday = bday;
            this.Subject = sub;
        }
    }
}
