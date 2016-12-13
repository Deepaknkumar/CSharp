using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Student
    {
        private String firstName;
        private String lastName;
        private String birthday;
        private String address;
        private String city;
        private static int studCount=0;

        public String FirstName {
            get {
                return firstName;
            }
            set {
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

        public String Birthday {
            get {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public String Address {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public Student(String fname, String lname, String bday, String address, String city) {
            this.FirstName = fname;
            this.LastName = lname;
            this.Birthday = bday;
            this.Address = address;
            this.City = city;
            studCount++;
        }

        public static int studentCount()
        {
            return studCount;
        }

    }
}
