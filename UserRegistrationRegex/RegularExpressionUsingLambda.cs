using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class RegularExpressionUsingLambda
    {
        public const string NAMEPARAMETER = @"^[A-Z]{1}[a-z]{2,20}$";
        public const string EMAILRegularExpression = @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        public Func<string, string, bool> TestFirstName = (firstName, NAMEPARAMETER) => Regex.IsMatch(firstName, NAMEPARAMETER);

        public Func<string, string, bool> TestLastName = (lastName, NAMEPARAMETER) => Regex.IsMatch(lastName, NAMEPARAMETER);

        public Func<string, string, bool> TestEmailName = (email, EMAILRegularExpression) => Regex.IsMatch(email, EMAILRegularExpression);
    }
}
