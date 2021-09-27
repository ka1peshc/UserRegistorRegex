using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RegularExpression re = new RegularExpression();
            Console.WriteLine("Enter option number");
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("1. First name\n2. Second Name\n3. Email\n4. Phone number\n5. User Password");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        re.FirstName();
                        break;
                    case 2:
                        re.LastName();
                        break;
                    case 3:
                        re.Email();
                        break;
                    case 4:
                        re.PhoneNumber();
                        break;
                    case 5:
                        re.Password();
                        break;
                    default:
                        keepLooping = false;
                        break;

                }
            }
        }
    }
}
