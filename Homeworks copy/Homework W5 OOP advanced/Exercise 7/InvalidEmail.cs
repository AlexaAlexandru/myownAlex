using System;
namespace Homework_W5_OOP_advanced
{
    public class InvalidEmail : Exception
    {
        public InvalidEmail(string? message) : base(message)
        {
        }
    }
}

