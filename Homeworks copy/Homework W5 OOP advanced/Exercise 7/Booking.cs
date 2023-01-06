using System;
namespace Homework_W5_OOP_advanced
{
	public class Booking
	{
		public Guid Id { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		Client client;
		Room room;


        public double GetNumberOfNights()
        {
            double numberNights = (CheckOut - CheckIn).Days;
            return numberNights;
        }

		public double GetFinalPrice()
		{
			return GetNumberOfNights() * room.Price;
		}


    }
}

