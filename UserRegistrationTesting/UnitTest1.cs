using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;
using System;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("")]
        [DataRow("Kalpesh")]
        public void CustomeExceptionForFirstNameAsEmpty(string name)
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

        [TestMethod]
        [DataRow(null)]
        [DataRow("Kalpesh")]
        public void CustomeExceptionForLasttName(string name)
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

        [TestMethod]
        [DataRow("3 9920036999")]
        public void CustomeExceptionForPhoneNumber(string number)
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

        [TestMethod]
        [DataRow("kalpsh@gmail")]
        public void CustomeExceptionForEmail(string email)
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
        public void CustomeExceptionForPassword(string password)
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
    }
}
