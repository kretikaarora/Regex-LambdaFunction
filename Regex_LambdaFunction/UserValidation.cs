// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserValidation.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------using Regex_LambdaFunction;
using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// Validating the user details
    /// </summary>
    public class UserValidation
    {
        /// <summary>
        /// patterns for validating user details
        /// </summary>
        string namePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
        string emailPattern = @"^([a-z0-9A-Z])+([._+-]?[a-z0-9A-Z]+)*[@]{1}[a-z0-9A-Z]+[.]{1}[a-zA-Z]{2,}([.]{1}[a-z]{2,})?$";
        string phonePattern = @"^[1-9]{2}[ ]{1}[0-9]{10}$";
        string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        /// <summary>
        /// returns true if pattern matches otherwise throwd an exception error of invalid name 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckNameValidation(string name) => Regex.IsMatch(name, namePattern) ? true : throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.INVALID_NAME, "name not valid");
        
        /// <summary>
        /// returns true if pattern matches otherwise throwd an exception error of invalid email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns      
        public bool CheckEmailValidation(string email) => Regex.IsMatch(email, emailPattern) ? true : throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.INVALID_EMAIL, "email not valid");
       
        /// <summary>
        /// returns true if pattern matches otherwise throwd an exception error of invalid phone number
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <returns></returns>       
        public bool CheckPhoneNumber(string phoneNo)=> Regex.IsMatch(phoneNo, phonePattern) ? true : throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.INVALID_PHONENO, "phone number not valid");
       
        /// <summary>
        /// returns true if pattern matches otherwise throwd an exception error of invalid password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPassword(String password) => Regex.IsMatch(password, passwordPattern) ? true : throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.INVALID_PASSWORD, "Password not valid");
       

    }
}

