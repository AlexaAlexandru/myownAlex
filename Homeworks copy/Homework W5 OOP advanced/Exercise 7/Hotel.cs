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

		public List<Client> Clients { get; set; } = new List<Client>();

		public void RegisterClient(string CNP,string firstName) // add parameters;
		{
			//Clients.Add(new Client(CNP,firstName);
		}

		public void RemoveClient( string CNP)
		{
			Clients.RemoveAll(client => client.CNP==CNP);
		}


		public List<Room> Rooms { get; set; } = new List<Room>();

		public void AddRoom()
		{
			//Rooms.Add();

		}

		public void UpdteRoomPrice(int price)
		{

			//var changePrice = Rooms.ElementAt(room.Number)
				//.Price = price;
		}

		public void ShowAllRooms()
		{
			foreach (Room room in Rooms)
			{
				string message= $"the room {room.Number} at the floor {room.Floor} the price is {room.Price}";
				Console.WriteLine(message);
            }
        }


		public List<Booking> Bookings { get; set; } = new List<Booking>();


	}
}

