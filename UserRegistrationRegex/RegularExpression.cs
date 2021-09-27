using System;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistrationRegex
{
    class RegularExpression
    {
        string NamePattern = @"^[A-Z]{1}[a-z]{2,20}$";
        
        internal void FirstName()
        {
            Regex rx = new Regex(NamePattern);
            Console.WriteLine("Enter First name");
            string firstname = Console.ReadLine();
            if (rx.IsMatch(firstname) == true)
            {
                Console.WriteLine("{0} pass regular expression", firstname);
            }
            else
            {
                Console.WriteLine("{0} fail to pass regular expression", firstname);
            }
        }
        internal void LastName()
        {
            Regex rx = new Regex(NamePattern);
            Console.WriteLine("Enter last name");
            string lastname = Console.ReadLine();
            if (rx.IsMatch(lastname) == true)
            {
                Console.WriteLine("{0} pass regular expression", lastname);
            }
            else
            {
                Console.WriteLine("{0} pass regular expression", lastname);
            }
        }
        internal void Email()
        {
            string emailRE = @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            //string emailRE = @"^[A-Za-z0-9]+[@][a-z]+[\.][a-z](2,3)$";
            Regex rx = new Regex(emailRE);
            Console.WriteLine("Enter email address");
            string email = Console.ReadLine();
            if (rx.IsMatch(email))
            {
                Console.WriteLine("{0} valid email",email);
            }
            else
            {
                Console.WriteLine("{0} Invalid email", email);
            }
        }

        internal void PhoneNumber()
        {
            string phoneRE = @"^[0-9]{2}\s[0-9]{10}$";
            Regex rx = new Regex(phoneRE);
            Console.WriteLine("Enter phone number with contry code");
            string phone = Console.ReadLine();
            if (rx.IsMatch(phone))
            {
                Console.WriteLine("Valid phone number");
            }
            else
            {
                Console.WriteLine("Invalid phone number");
            }
        }
    }
}
