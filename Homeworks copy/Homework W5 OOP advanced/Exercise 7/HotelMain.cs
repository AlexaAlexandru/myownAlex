using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
	public static class HotelMain
	{
        public static void Run()
        {
            while (true)
            {
                MenuHotel();

                string option = Console.ReadLine();

                if (option == "1")
                {
                }

            }
        }
        private static void MenuHotel()
        {
            Console.WriteLine($"Welcome");
            Console.WriteLine("Choose from menu:");
            Console.WriteLine("1. Client page ");
            Console.WriteLine("2. Internal Hotel management ");
        }

    }
}

