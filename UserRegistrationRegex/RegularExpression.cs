using System;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistrationRegex
{
    class RegularExpression
    {
        string NamePattern = @"^[A-Z]{1}[a-z]{2,20}$";
        /// <summary>
        /// Check first name of user with given pattern
        /// </summary>
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
        /// <summary>
        /// Check last name of user with given pattern
        /// </summary>
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
        /// <summary>
        /// Checking user entered email with our pattern
        /// </summary>
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
        /// <summary>
        /// Check phone number with country code and 10 digit number
        /// </summary>
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
        /// <summary>
        /// Check user password with given four rules
        /// </summary>
        internal void Password()
        {
            string passwordRE = @"^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*`~_+]).{8,20})$";
            
            Regex rx = new Regex(passwordRE);
            Console.WriteLine("Enter password minimum 8 character");
            string password = Console.ReadLine();
            if (rx.IsMatch(password))
            {
                Console.WriteLine("Valid password number");
            }
            else
            {
                Console.WriteLine("Invalid password number");
            }
        }
    }
}
