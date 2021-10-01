using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;
using System;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Custom Exception For First Name As Empty
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow("")]
        [DataRow("Kalpesh")]
        public void CustomExceptionForFirstNameAsEmpty(string name)
        {
            try
            {
                //Arrange
                RegularExpression re = new RegularExpression();
                //Action
                re.FirstName(name);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Entered empty string as input", ce.Message);
            }
        }
        /// <summary>
        /// Custom Exception For Last Name
        /// </summary>
        /// <param name="name"></param>
        [TestMethod]
        [DataRow(null)]
        [DataRow("Kalpesh")]
        public void CustomExceptionForLasttName(string name)
        {
            try
            {
                //Arrange
                RegularExpression re = new RegularExpression();
                //Action
                re.LastName(name);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Entered null as input", ce.Message);
            }
            
        }
        /// <summary>
        /// Custom Exception For PhoneNumber
        /// </summary>
        /// <param name="number"></param>
        [TestMethod]
        [DataRow("3 9920036999")]
        public void CustomExceptionForPhoneNumber(string number)
        {
            try
            {
                //Arrange
                RegularExpression re = new RegularExpression();
                //Action
                re.PhoneNumber(number);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Failed to follow input rule", ce.Message);
            }
        }

        /// <summary>
        /// Custom Exception For Email
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]
        [DataRow("kalpsh@gmail")]
        public void CustomExceptionForEmail(string email)
        {
            try
            {
                //Arrange
                RegularExpression re = new RegularExpression();
                //Action
                re.Email(email);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Failed to follow input rule", ce.Message);
            }
        }

        [TestMethod]
        [DataRow("kalpsh@gmail")]
        public void CustomExceptionForPassword(string password)
        {
            try
            {
                //Arrange
                RegularExpression re = new RegularExpression();
                //Action
                re.Password(password);
            }
            catch (CustomException ce)
            {
                Assert.AreEqual("Failed to follow input rule", ce.Message);
            }
        }

        [TestMethod]
        public void GivenRegularExpressionClassName_ShouldReturnRegularExpressionObject()
        {
            
            object expected = new RegularExpression();
            object obj = UserRegistrationReflection.CreateUserRegistration("UserRegistrationRegex.RegularExpression", "RegularExpression");
            expected.Equals(obj);
        }

        //[TestMethod]
        //[DataRow("Kalpesh")]
        //public void MethodInvokeUsingReflection()
        //{
        //    string expectedError = "Entered null as input";
        //    string expectValue = "true";
        //    try
        //    {
        //        string result = UserRegistrationReflection.InvokeRegularExpressionMethod("FirstName","Kalpesh");
        //        Assert.AreEqual(expectValue, result);
        //    }
        //    catch (CustomException ce)
        //    {
        //        Assert.AreEqual(expectedError, ce.Message);
        //    }
            
        //}
    }
}
