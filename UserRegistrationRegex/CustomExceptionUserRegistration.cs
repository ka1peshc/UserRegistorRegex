using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationRegex
{
    public class CustomException:Exception
    {
        /// <summary>
        /// List of custome errors
        /// </summary>
        public enum ExceptionName
        {
            Entered_Null,
            Entered_Empty,
            Expected_Minimum_length,
            Failed_To_Follow_Regex
        }

        ExceptionName exceptionType;
        /// <summary>
        /// Constructor to set enum variable type
        /// </summary>
        /// <param name="exName"></param>
        /// <param name="msg"></param>
        public CustomException(ExceptionName exName, string msg):base(msg)
        {
            this.exceptionType = exName;
        }
    }
}
