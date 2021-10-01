using System;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistrationRegex
{
    public class RegularExpression
    {
        string NamePattern = @"^[A-Z]{1}[a-z]{2,20}$";
        public RegularExpression() { }
        /// <summary>
        /// Check first name of user with given pattern
        /// </summary>
        public void FirstName(string firstname)
        {
            Regex rx = new Regex(NamePattern);
            try
            {   
                if (firstname.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionName.Entered_Empty, "Entered empty string as input");
                }
                if (rx.IsMatch(firstname) == true)
                {
                    Console.WriteLine("{0} pass regular expression", firstname);    
                }
                else
                {
                    Console.WriteLine("{0} fail to pass regular expression", firstname);
                    throw new CustomException(CustomException.ExceptionName.Failed_To_Follow_Regex, "Failed to follow input rule");
                    
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionName.Entered_Null, "Entered null as input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Check last name of user with given pattern
        /// </summary>
        public void LastName(string lastname)
        {
            Regex rx = new Regex(NamePattern);
            try
            {
                
                if (lastname.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionName.Entered_Empty, "Entered empty string as input");
                }
                if (rx.IsMatch(lastname) == true)
                {
                    Console.WriteLine("{0} pass regular expression", lastname);
                }
                else
                {
                    Console.WriteLine("{0} pass regular expression", lastname);
                    throw new CustomException(CustomException.ExceptionName.Failed_To_Follow_Regex, "Failed to follow input rule");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionName.Entered_Null, "Entered null as input");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// Checking user entered email with our pattern
        /// </summary>
        public void Email(string email)
        {
            string emailRE = @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            //string emailRE = @"^[A-Za-z0-9]+[@][a-z]+[\.][a-z](2,3)$";
            Regex rx = new Regex(emailRE);
            try
            {
                
                if (rx.IsMatch(email))
                {
                    Console.WriteLine("{0} valid email", email);
                }
                else
                {
                    Console.WriteLine("{0} Invalid email", email);
                    throw new CustomException(CustomException.ExceptionName.Failed_To_Follow_Regex, "Failed to follow input rule");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionName.Entered_Null, "Entered null as input");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// Check phone number with country code and 10 digit number
        /// </summary>
        public void PhoneNumber(string phone)
        {
            string phoneRE = @"^[0-9]{2}\s[0-9]{10}$";
            Regex rx = new Regex(phoneRE);
            try
            {
                
                if (phone.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionName.Entered_Empty, "Entered empty string as input");
                }
                if (rx.IsMatch(phone))
                {
                    Console.WriteLine("Valid phone number");
                }
                else
                {
                    Console.WriteLine("Invalid phone number");
                    throw new CustomException(CustomException.ExceptionName.Failed_To_Follow_Regex, "Failed to follow input rule");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionName.Entered_Null, "Entered null as input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Check user password with given four rules
        /// </summary>
        public void Password(string password)
        {
            string passwordRE = @"^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*`~_+]).{8,20})$";
            
            Regex rx = new Regex(passwordRE);
            
            try {
                
                if (password.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionName.Entered_Empty, "Entered empty string as input");
                }
                if (rx.IsMatch(password))
                {
                    Console.WriteLine("Valid password number");
                }
                else
                {
                    Console.WriteLine("Invalid password number");
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionName.Entered_Null, "Entered null as input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
