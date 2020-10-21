// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetials.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using Regex_LambdaFunction;
using System;

namespace UserRegistration
{
    /// <summary>
    /// Accepts the details of the user
    /// </summary>
    class UsersDetails
    {
        UserValidation userValidation = new UserValidation();
        /// <summary>
        /// accepts the first name 
        /// </summary>
        public void FirstNameDetail()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("please enter your first name");
                    string firstName = Console.ReadLine();
                    /// throws custom exception for empty value``
                    if (firstName == " ")
                    {
                        throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.EMPTY, "name cant be empty");
                    }   
                    bool check = userValidation.CheckNameValidation(firstName);                   
                    if (check == true)
                    {
                        Console.WriteLine("the name {0} is valid", firstName);
                        Console.WriteLine("successful entry");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unsuccessful entry");
                        Console.WriteLine("the name {0} is not valid", firstName);
                        Console.WriteLine("enter a valid name with min three alphabets and first letter capital ");
                    }
                }               
                catch(CustomExceptions ex)
                {
                    Console.WriteLine(ex.Message + "\n"+ex);
                    FirstNameDetail();
                }                
            }
        }
        /// <summary>
        /// accepts the last name 
        /// </summary>
        public void LastNameDetail()
        {
            while (true)
            {
                try
                {
                Console.WriteLine("please enter your last name");
                string lastName = Console.ReadLine();
                /// throws custom exception for empty value
                if (lastName == " ")
                {
                    throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.EMPTY, "name cant be empty");
                }
                bool check = userValidation.CheckNameValidation(lastName);              
                    if (check == true)
                    {
                        Console.WriteLine("the name {0} is valid", lastName);
                        Console.WriteLine("successful entry");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unsuccessful entry");
                        Console.WriteLine("the name {0} is not valid", lastName);
                        Console.WriteLine("enter a valid name with min three alphabets and first letter capital ");
                    }
                }
                catch(CustomExceptions ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex);
                    LastNameDetail();
                }
            }
        }
        /// <summary>
        /// accepts the email address
        /// </summary>
        public void EmailDetail()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("please enter your email");
                string email = Console.ReadLine();
                 /// throws custom exception for empty value
                if (email == " ")
                {
                    throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.EMPTY, "name cant be empty");
                }
                bool check = userValidation.CheckEmailValidation(email);             
                    if (check == true)
                    {
                        Console.WriteLine("the email id {0} is valid", email);
                        Console.WriteLine("successful entry");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unsuccessful entry");
                        Console.WriteLine("the email id {0} is not valid", email);
                        Console.WriteLine(" enter an email id with proper format");
                    }
                }
                catch (CustomExceptions ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex);
                    EmailDetail();
                }
            }
        }
        /// <summary>
        /// accepts the phone detail
        /// </summary>
        public void PhoneDetail()
        {
            while (true)
            {
                try
                {
                Console.WriteLine("please enter your phone number");
                string phoneNumber = Console.ReadLine();
                /// throws custom exception for empty value
                if (phoneNumber== " ")
                {
                    throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.EMPTY, "name cant be empty");
                }

                bool check = userValidation.CheckPhoneNumber(phoneNumber);
                
                    if (check == true)
                    {
                        Console.WriteLine("the phone number  entered is valid");
                        Console.WriteLine("successful entry");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unsuccessful entry");
                        Console.WriteLine("the phone number entered is not valid");
                        Console.WriteLine("enter a  phone number with a gap in between 10 digit number and pincode ");
                    }
                }
                catch(CustomExceptions ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex);
                    PhoneDetail();
                }
            }
        }
        /// <summary>
        /// accepts the password
        /// </summary>
        public void Password()
        {
            while (true)
            {
                try
                {
                Console.WriteLine("please enter your password ");
                string password = Console.ReadLine();
                    /// throws custom exception for empty value               
                    if (password == " ")
                    {
                        throw new Regex_LambdaFunction.CustomExceptions(Regex_LambdaFunction.CustomExceptions.ExceptionType.EMPTY, "name cant be empty");
                    }
                    bool check = userValidation.CheckPassword(password);               
                    if (check == true)
                    {
                        Console.WriteLine("the password {0} is valid", password);
                        Console.WriteLine("successful entry");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unsuccessful entry");
                        Console.WriteLine("the password entered is not valid");
                        Console.WriteLine("enter a valid password with \n 1.atleast one capital letter \n 2.atleast one small letter");
                        Console.WriteLine(" 3.one special character \n 4.atleast one digit");
                    }
                }
                catch(CustomExceptions ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex);
                    Password();
                }
            }
        }
    }
}