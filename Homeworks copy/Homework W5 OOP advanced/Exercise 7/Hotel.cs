using System;
using System.Linq;
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

		public void RegisterClient(string cnp, string firstName, string lastName, string email, string phone)
		{
			Clients.Add(new Client(cnp, firstName, lastName, email, phone));
		}

		public void RemoveClient( string CNP)
		{
			Clients.RemoveAll(client => client.CNP == CNP);
		}

		public List<Room> Rooms { get; set; } = new List<Room>();

		public void AddSingleRoom(int number, int floor)
		{
			Rooms.Add(new SingleRoom(number,floor));
		}

        public void AddDoubleRoom(int number, int floor)
        {
            Rooms.Add(new DoubleRoom(number, floor));
        }

        public void AddLuxuryRoom(int number, int floor)
        {
            Rooms.Add(new LuxuryRoom(number, floor));
        }

        public void UpdteRoomPrice(int roomNumber,double price)
		{
			Rooms.Find((Room room) => room.Number == roomNumber)
				.Price = price;
		}

		public void ShowAllRooms()
		{
			foreach (Room room in Rooms)
			{
				string message= $"the room {room.Number} {room.RoomType} at the floor {room.Floor} the price is {room.Price}";
				Console.WriteLine(message);
            }
        }

		public void ShowAvailableRooms(DateTime from,DateTime to) // still need to implement the timeframe 
		{
			Console.WriteLine("The following rooms are available : ");
			foreach (Room room in Rooms)
			{
				if (room.StatusRoom==0)
				{
					Console.WriteLine($"{room.Number} type {room.RoomType}");
				}
			}
		}


		public List<Booking> Bookings { get; set; } = new List<Booking>();

		public void AddBooking(Guid clientId,Guid roomId,DateTime checkIn,DateTime checkOut)
		{
			Bookings.Add(new Booking(checkIn, checkOut,Clients.Find((Client client)=>client.Id==clientId),Rooms.Find((Room room)=>room.Id==roomId)));
		}

		public void AllBookings()
		{
			foreach (var item in Bookings)
			{
				Console.WriteLine(item);
            }
		}

		public void ActiveBooking()
		{
			foreach (var item in Bookings)
			{
				if (item.CheckOut>DateTime.Today)
				{
					Console.WriteLine(item);
				}
			}
		}
		public void ClearBookingId(Guid bookingId)
		{
			Bookings.RemoveAll(b => b.Id == bookingId);
		}
	}
}

