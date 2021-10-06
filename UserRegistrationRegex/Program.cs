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
            RegularExpressionUsingLambda reL = new RegularExpressionUsingLambda();
            Console.WriteLine("Enter option number");
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("1. First name\n2. Second Name\n3. Email\n4. Phone number\n5. User Password");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter first name");
                        string fname = Console.ReadLine();
                        re.FirstName(fname);
                        Console.WriteLine(reL.TestFirstName(fname, RegularExpressionUsingLambda.NAMEPARAMETER));
                        break;
                    case 2:
                        Console.WriteLine("Enter last name");
                        string lname = Console.ReadLine();
                        re.LastName(lname);
                        Console.WriteLine(reL.TestLastName(lname, RegularExpressionUsingLambda.NAMEPARAMETER));
                        break;
                    case 3:
                        Console.WriteLine("Enter Email address");
                        string email = Console.ReadLine();
                        re.Email(email);
                        Console.WriteLine(reL.TestEmailName(email, RegularExpressionUsingLambda.EMAILRegularExpression));
                        break;
                    case 4:
                        Console.WriteLine("Enter phone number ");
                        string phoneNumber = Console.ReadLine();
                        re.PhoneNumber(phoneNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();
                        re.Password(password);
                        break;
                    default:
                        keepLooping = false;
                        break;

                }
            }
        }
    }
}
