using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String dob;
        private String address;
        private String city;

        #region Properties
        public String FirstName
        {
            get {
                return firstName;
            }
            set
            {
                this.firstName = value;
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
                this.lastName = value;
            }
        }

        public String Birthday
        {
            get
            {
                return dob;
            }
            set
            {
                this.dob = value;
            }
        }

        public String Address
        {
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
        #endregion Properties

        public Person(String fname, String lname, String dob, String add, String city) {
            this.FirstName = fname;
            this.LastName = lname;
            this.Birthday = dob;
            this.Address = add;
            this.City = city;
        }
    }
}
