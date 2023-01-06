using System;
using Homework_W5_OOP_advanced.Exercise7;

namespace Homework_W5_OOP_advanced
{
	public class Hotel
	{
		public Guid Id { get; set; }
		public string HotelName { get; set; }
		public string Location { get; set; }
		public int PostalCode { get; set; }

		public Hotel() { }

		Client client;
		Room room;
		Booking booking;

		public List<Client> Clients { get; set;}

		public void RegisterClient()
		{
			Clients.Add(client);
		}

		public void RemoveClient( string CNP)
		{
			Clients.RemoveAll(client => client.CNP==CNP);
		}


		public List<Room> Rooms { get; set; }

		public List<Booking> Bookings { get; set; }

	}
}

