// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace UserRegistration
{
    /// <summary>
    /// entry point for Regex program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            ///options for user to enter details
            Console.WriteLine(" welcome to User Registration");
            Console.WriteLine("1. Press 1 for validation of  first name");
            Console.WriteLine("2. Press 2 for validation of last name");
            Console.WriteLine("3. Press 3 for validation of Phone number");
            Console.WriteLine("4. Press 4 for validation of email address");
            Console.WriteLine("5. Press 5 for validation of password");
            Console.WriteLine("6. Press 6 to exit");
            ///creating object of UserDetails class to access its functions
            UsersDetails usersDetails = new UsersDetails();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select the number 1. first name  2. last name 3. phone number 4. email  5. password 6. Exit ");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        usersDetails.FirstNameDetail();
                        break;
                    case 2:
                        usersDetails.LastNameDetail();
                        break;
                    case 3:
                        usersDetails.PhoneDetail();
                        break;
                    case 4:
                        usersDetails.EmailDetail();
                        break;
                    case 5:
                        usersDetails.Password();
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("please enter a valid number");
                        break;
                }
            }
        }
    }
}

