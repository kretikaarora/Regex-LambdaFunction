using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        public bool CheckNameValidation(string name)
        {
            // Comparing namePattern to input given by user
            // Capital first name and min 3 letters 
            string namePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            return Regex.IsMatch(name, namePattern);
        }

        public bool CheckEmailValidation(string email)
        {
            string pattern = @"^([a-z0-9A-Z])+([._+-]?[a-z0-9A-Z]+)*[@]{1}[a-z0-9A-Z]+[.]{1}[a-zA-Z]{2,}([.]{1}[a-z]{2,})?$";
            return Regex.IsMatch(email, pattern);
        }
        public bool CheckPhoneNumber(string phoneNo)
        {
            string pattern = @"^[1-9]{2}[ ]{1}[0-9]{10}$";
            return Regex.IsMatch(phoneNo, pattern);
        }
        public bool CheckPassword(String password)
        {
            // string pattern = @"^(?=.{8,}$)(?=.*[A-Z])(?=.*[@#$%^&*])";
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

    }
}

