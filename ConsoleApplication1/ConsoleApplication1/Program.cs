﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comments
            int myVar = 2;
            int secondVar;
            secondVar = 10;

            int sum = myVar + secondVar;
            int product = myVar * secondVar;
            int remainder = myVar % secondVar;
            double value = (double)myVar / (double)secondVar;
            Console.WriteLine(sum.ToString());
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(value);

            string firstName = "Deepak";
            string lastName = "Kumar";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine("{1} {0}",firstName,lastName);
        }
    }
}
