using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class RegularExpressionUsingLambda
    {
        public const string NAMEPARAMETER = @"^[A-Z]{1}[a-z]{2,20}$";

        public Func<string, string, bool> TestFirstName = (firstName, NAMEPARAMETER) => Regex.IsMatch(firstName, NAMEPARAMETER);
    }
}
