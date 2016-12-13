using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            String lastName;
            String birthday;
            String addressLine1;
            String addressLine2;
            String city;
            String province;
            String postalCode;  // Cannot use INT because CANADA's postal code have Letters in it.
            String country;

            Console.WriteLine("Please Fill Details of a Student:");
            
            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Birthday(DD/MM/YYYY): ");
            birthday = Console.ReadLine();

            Console.Write("Address(Line 1): ");
            addressLine1 = Console.ReadLine();

            Console.Write("Address(Line 2): ");
            addressLine2 = Console.ReadLine();

            Console.Write("City: ");
            city = Console.ReadLine();

            Console.Write("Province: ");
            province = Console.ReadLine();

            Console.Write("Postal Code: ");
            postalCode = Console.ReadLine();

            Console.Write("Country: ");
            country = Console.ReadLine();
            
                    
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthday);
            Console.WriteLine(addressLine1);
            Console.WriteLine(addressLine2);
            Console.WriteLine(city);
            Console.WriteLine(province);
            Console.WriteLine(postalCode);
            Console.WriteLine(country);
        }
    }
}
