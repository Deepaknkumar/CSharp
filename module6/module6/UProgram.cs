using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module6
{
    class UProgram
    {
        private Degree degree;
        private String name;

        #region Properties
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
        #endregion Properties

        public UProgram(Degree degree, String name)
        {
            this.degree = degree;
            this.Name = name;
        }
    }
}
