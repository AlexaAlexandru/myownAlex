using System;
namespace Homework_W5_OOP_advanced
{
    public class SingleRoom: Room
    {
		public SingleRoom(int number, int floor)
		{
            Id = Guid.NewGuid();
            Number = number;
            Floor = floor;
            BedRooms = 1;
			Price = 50;
		}
    }
}

