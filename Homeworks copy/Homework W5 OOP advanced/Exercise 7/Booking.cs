using System;
namespace Homework_W5_OOP_advanced
{
	public class Booking
	{
		public Guid Id { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		public Client Client {  get; private set; }
		public Room Room {  get; private set; }

		public Booking(DateTime checkin,DateTime checkout, Client client,Room room)
		{
			Id = Guid.NewGuid();
			CheckIn = checkin;
			CheckOut = checkout;
			Client = client;
		}
        public double GetNumberOfNights()
        {
            double numberNights = (CheckOut - CheckIn).Days;
            return numberNights;
        }

		public double GetFinalPrice()
		{
			return GetNumberOfNights() * Room.Price;
		}

    }
}

