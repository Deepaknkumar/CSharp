using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class UProgram
    {
        private Degree degree;
        private String name;

        public Degree DegreeType
        {
            get
            {
                return degree;
            }
            set
            {
                this.degree = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public UProgram(Degree degree, String name)
        {
            this.degree = degree;
            this.Name = name;
        }
    }
}
