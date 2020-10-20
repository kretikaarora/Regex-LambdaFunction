using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UsersDetails
    {
        UserValidation userValidation = new UserValidation();

        public void FirstNameDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your first name");
                string firstName = Console.ReadLine();
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
        }
        public void LastNameDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your last name");
                string lastName = Console.ReadLine();

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
        }
        public void EmailDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your email");
                string email = Console.ReadLine();
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
        }
        public void PhoneDetail()
        {
            while (true)
            {
                Console.WriteLine("please enter your phone number");
                string phoneNumber = Console.ReadLine();

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
        }
        public void Password()
        {
            while (true)
            {
                Console.WriteLine("please enter your password ");
                string password = Console.ReadLine();

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
        }
    }
}