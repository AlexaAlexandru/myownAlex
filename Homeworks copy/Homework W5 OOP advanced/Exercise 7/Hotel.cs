using System;
namespace Homework_W5_OOP_advanced
{
	public class Hotel
	{
		public string HotelName { get; set; }
		public string Location { get; set; }
		public int PostalCode { get; set; }
		private List<int> Rooms { get; set; } = new List<int>(10);

		public Hotel()
		{
			HotelName = "Hotel International";
			Location = "Iasi";
			PostalCode = 700032;
        }




	}
}

