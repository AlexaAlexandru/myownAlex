using System;
namespace Homework_W5_OOP_advanced
{
    public class InvalidRoomStatus : Exception
    {
        public InvalidRoomStatus(string? message) : base(message)
        {
        }
    }
}

