using System;
using Homework_W5_OOP_advanced.Exercise7;

namespace Homework_W5_OOP_advanced
{
	public class Hotel
	{ 
		public string HotelName { get; set; }
		public string Location { get; set; }
		public int PostalCode { get; set; }

		public Hotel()
		{
			HotelName = "Hotel International";
			Location = "Iasi";
			PostalCode = 700032;
        }
	}
}

