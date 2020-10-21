// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomExceptions.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace Regex_LambdaFunction
{
    class CustomExceptions :Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME,INVALID_PASSWORD,INVALID_EMAIL,INVALID_PHONENO,NULL,EMPTY
        }
        private readonly ExceptionType type;
        public CustomExceptions(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
