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
		public Status StatusRoom { get; set; } = 0;
		
		public void ChangeRoomStatus()
		{
			StatusRoom = Status.Booked;
		}

		public Status ClearRoom()
		{
			return Status.Available;
		}

		public string  RoomType()
		{
			string message = string.Empty;
			if (BedRooms == 1)
			{
				message = "single room";
            }
            if (BedRooms == 2)
            {
                message = "double room";
            }
            if (BedRooms == 3)
            {
                message = "luxury room";
            }
			return message;

        }

	}
}

