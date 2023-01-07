using System;
namespace Homework_W5_OOP_advanced
{
	public abstract class Room
	{
		public Guid Id { get; set; }
		public int Number { get; set; }
		public int Floor { get; set; }
		public int BedRooms { get; set; }
		public double Price { get; set; }

		public Status BookRoom()
		{
			return Status.Booked;
		}

		public Status ClearRoom()
		{
			return Status.Available;
		}

	}
}

