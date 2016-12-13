using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4hop
{
    class Program
    {
        public struct Student{
            public String Name { get; set; }
            public String dateofBirth { get; set; }
        }

        public enum Day{ Sunday=1,Monday, Tuesday, Wednesday,Thursday, Friday, Saturday };
        public enum Month { January=1, February, Mar, Apr, May, Jun, July, Aug, Sep, Oct, Nov, Dec};

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Deepak Kumar";
            s1.dateofBirth = "10th October, 1994";
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.dateofBirth);
            int daylen = Enum.GetNames(typeof(Day)).Length;
            foreach (String S in Enum.GetNames(typeof(Day)))
            {
                Console.WriteLine(S);
            }
            int[] dayVal = new int[Enum.GetNames(typeof(Day)).Length];
            int[] dayVal1 = (int[]) Enum.GetValues(typeof(Day));

            int i = dayVal.Length - 1;
            while (i >= 0)
            {
                Console.WriteLine(dayVal1[i]);
                i--;
            }
            Console.ReadLine();
        }
    }
}
