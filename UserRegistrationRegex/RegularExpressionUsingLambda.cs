using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class RegularExpressionUsingLambda
    {
        public const string NAMEPARAMETER = @"^[A-Z]{1}[a-z]{2,20}$";
        public const string EMAILRegularExpression = @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        public const string phoneRE = @"^[0-9]{2}\s[0-9]{10}$";

        public Func<string, string, bool> TestFirstName = (firstName, NAMEPARAMETER) => Regex.IsMatch(firstName, NAMEPARAMETER);

        public Func<string, string, bool> TestLastName = (lastName, NAMEPARAMETER) => Regex.IsMatch(lastName, NAMEPARAMETER);

        public Func<string, string, bool> TestEmailName = (email, EMAILRegularExpression) => Regex.IsMatch(email, EMAILRegularExpression);

        public Func<string, string, bool> TestPhoneNumber = (phoneNumber, EMAILRegularExpression) => Regex.IsMatch(phoneNumber, EMAILRegularExpression);
    }
}
