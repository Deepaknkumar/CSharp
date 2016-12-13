using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3
{
    class Program
    {
        static void getStudentInfo()
        {
            Console.Write("Enter Student's first Name: ");
            String sFirstName = Console.ReadLine();

            Console.Write("Enter Student's Last Name: ");
            String sLastName = Console.ReadLine();

            Console.Write("Enter Student's Birthday: ");
            String sBirthDay = Console.ReadLine();
        }

        static void printStudentDetails(String FirstName, String LastName, String Bday) {
            Console.WriteLine("{0} {1} was born on {2}", FirstName, LastName, Bday);
        }



        static void getTeacherInfo()
        {
            Console.Write("Enter Teacher's first Name: ");
            String tFirstName = Console.ReadLine();

            Console.Write("Enter Teacher's Last Name: ");
            String tLastName = Console.ReadLine();

            Console.Write("Enter Teacher's Birthday: ");
            String tBirthDay = Console.ReadLine();

            Console.Write("Enter Teacher's Field of Expertise: ");
            String foE = Console.ReadLine();
        }

        static void printTeacherDetails(String FirstName, String LastName, String Bday, String foE)
        {
            Console.WriteLine("{0} {1} was born on {2} and Teaches {3} Subject.", FirstName, LastName, Bday,foE);
        }


        static void getCourseInfo()
        {
            Console.Write("Enter Course Name: ");
            String courseName = Console.ReadLine();

            Console.Write("Enter Course Category: ");
            String courseCat = Console.ReadLine();

            Console.Write("Enter Course Level: ");
            String courseLevel = Console.ReadLine();
        }

        static void printCourseDetails(String cName, String cCat, String cLevel)
        {
            Console.WriteLine("Course on {0} belongs to {1} Category and is a {2} Level Course.", cName, cCat, cLevel);
        }

        static void getUprogramInfo()
        {
            Console.Write("Enter Program Name: ");
            String pName = Console.ReadLine();

            Console.Write("Enter Program's Department: ");
            String pdept = Console.ReadLine();

            Console.Write("Acceptance rate: ");
            String pAccr = Console.ReadLine();
        }

        static void printUprogramDetails(String progName, String dept, String accr)
        {
            Console.WriteLine("{0} in {1} has an Acceptance rate of {2} % last year.", progName, dept, accr);
        }


        static void getDegreeInfo()
        {
            Console.Write("Enter Degree Name: ");
            String dName = Console.ReadLine();

            Console.Write("Enter Department : ");
            String ddept = Console.ReadLine();

            Console.Write("Enter Duration (int years): ");
            String ddur = Console.ReadLine();
        }

        static void printDegreeDetails(String degName, String degDept, String degDur)
        {
            Console.WriteLine("{0} in {1} is of {2} year(s).", degName, degDept, degDur);
        }

        static void Main(string[] args)
        {
            getStudentInfo();
            printStudentDetails("Deepak","Kumar","10/10/1994");
            Console.WriteLine();

            getTeacherInfo();
            printTeacherDetails("Yves", "Lucet", "10/07/1977", "Computer Science");
            Console.WriteLine();

            getCourseInfo();
            printCourseDetails("Advanced Algorithms", "Computer Science", "5 Level");
            Console.WriteLine();

            getUprogramInfo();
            printUprogramDetails("Master of Science", "Computer Science","20");
            Console.WriteLine();

            getDegreeInfo();
            printDegreeDetails("Master of Science","Computer Science","2");

        }

    }
}
