namespace Homework_W5_OOP_advanced
{
    public class DoubleRoom : Room
    {
		public DoubleRoom(int number, int floor): base(number, floor)
		{
            Id = Guid.NewGuid();
            Number = number;
            Floor = floor;
            BedRooms = 2;
			Price = 80;
		}
    }
}

