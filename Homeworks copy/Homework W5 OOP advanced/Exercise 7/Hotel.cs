using System;
using System.Linq;
using Homework_W5_OOP_advanced.Exercise7;

namespace Homework_W5_OOP_advanced
{
	public class Hotel
	{
		private Guid Id { get; set; }
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

        internal void ShowAllClients()
        {
			Console.WriteLine("All registered Clients: ");
            foreach (Client client in Clients)
            {
                string message = $" {client.FirstName} {client.LastName}";
                Console.WriteLine(message);
            }
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
				string message= $"the room {room.Number} {room.RoomType()} at the floor {room.Floor} the price is {room.Price}";
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
					Console.WriteLine($"{room.Number} type {room.RoomType()}");
				}
				
			}           
        }


		public List<Booking> Bookings { get; set; } = new List<Booking>();

		public void AddBooking(string CNP,int number,DateTime checkIn,DateTime checkOut)
		{
			var roomStatus = Rooms.First(room => room.Number == number).StatusRoom;

            if (roomStatus==Status.Booked)
			{
				throw new InvalidRoomStatus("Please choose another room, this is already booked");
			}
			else
			{
                Bookings.Add(new Booking(Clients.First(client => client.CNP == CNP), Rooms.First(room => room.Number == number), checkIn, checkOut));
                Rooms.Find(room => room.Number == number)
                    .ChangeRoomStatus();
            }
			
		}

		public void AllBookings()
		{
			Console.WriteLine("All bookings: ");

			foreach (Booking booking in Bookings)
			{
				string message = $"The room {booking.Room.Number} is booked by {booking.Client.FirstName} {booking.Client.LastName} from the {booking.CheckIn} till the {booking.CheckOut}";
				Console.WriteLine(message);
			}
		}

		public void ActiveBooking()
		{
			Console.WriteLine("The active bookings are : ");

			foreach (Booking booking in Bookings)
			{
				if (booking.CheckOut>DateTime.Today)
				{
					string message = $"The room {booking.Room.Number} is booked by {booking.Client.FirstName}{booking.Client.LastName} till the {booking.CheckOut}";
					Console.WriteLine(message);
				}
			}
		}
		public void ClearBookingId(string CNP)
		{
			Bookings.Find(b => b.Client.CNP == CNP).Room.ClearRoom();
            Bookings.RemoveAll(b => b.Client.CNP== CNP);

		}

        
    }
}

