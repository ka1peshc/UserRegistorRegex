using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Expression for name
            string NamePattern = @"^[A-Z]{1}[a-z]{2,20}$";
            Regex rx = new Regex(NamePattern);
            Console.WriteLine("Enter First name");
            string firstname = Console.ReadLine();
            if(rx.IsMatch(firstname) == true)
            {
                Console.WriteLine("{0} pass regular expression",firstname);
            }
            else
            {
                Console.WriteLine("{0} fail to pass regular expression",firstname);
            }

            Console.WriteLine("Enter last name");
            string lastname = Console.ReadLine();
            if(rx.IsMatch(lastname) == true)
            {
                Console.WriteLine("{0} pass regular expression", lastname);
            }
            else
            {
                Console.WriteLine("{0} pass regular expression", lastname);
            }

        }
    }
}
