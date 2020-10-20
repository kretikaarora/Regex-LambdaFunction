using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserValidationMsTest
{
    [TestClass]
    public class MsTestForUser
    {
        [TestCategory("First Name")]
        [TestMethod]
        [DataRow("Kretika", true)]
        [DataRow("Kre", true)]
        [DataRow("aayush", false)]
        public void FirstNameTest(string firstName, bool expected)
        {
            UserValidation userValidation = new UserValidation();
            bool actual = userValidation.CheckNameValidation(firstName);
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Last Name")]
        [TestMethod]
        [DataRow("Arora", true)]
        [DataRow("Ar@", false)]
        [DataRow("aayush", false)]
        public void LastNameTest(string lastName, bool expected)
        {
            UserValidation userValidation = new UserValidation();
            bool actual = userValidation.CheckNameValidation(lastName);
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Email Id")]
        [TestMethod]
        [DataRow("abc@.com.co", false)]
        [DataRow("xyz@gmail.com.co.in", false)]
        [DataRow("Kre@-**.com", false)]
        [DataRow(".abc@abc.com", false)]
        [DataRow("abc@1.com", true)]
        [DataRow("abc-88@yahoo.com", true)]
        public void EmailTest(string email, bool expected)
        {
            UserValidation userValidation = new UserValidation();
            bool actual = userValidation.CheckEmailValidation(email);
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Phone Number")]
        [TestMethod]
        [DataRow("91 9650925666", true)]
        [DataRow("9 8529637412", false)]
        [DataRow("91 9874563", false)]
        public void PhoneNumberTest(string phoneNumber, bool expected)
        {
            UserValidation userValidation = new UserValidation();
            bool actual = userValidation.CheckPhoneNumber(phoneNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Password")]
        [TestMethod]
        [DataRow("khAsdrytu@45", true)]
        [DataRow("kjh$5", false)]
        [DataRow("khuu677#@#AS", false)]
        public void PasswordTest(string password, bool expected)
        {
            UserValidation userValidation = new UserValidation();
            bool actual = userValidation.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

    }
}

