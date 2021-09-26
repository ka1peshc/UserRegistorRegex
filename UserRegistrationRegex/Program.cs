using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string pattern = @"^[A-Z]{1}[a-z]{2,20}$";
            Regex rx = new Regex(pattern);
            Console.WriteLine("Enter First name");
            string firstname = Console.ReadLine();
            Console.WriteLine(rx.Match(firstname));
            
        }
    }
}
