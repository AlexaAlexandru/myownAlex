namespace Homework_W5_OOP_advanced
{
    public class LuxuryRoom: Room
    {
		public LuxuryRoom(int number, int floor): base(number, floor)
		{
            Id = Guid.NewGuid();
            Number = number;
            Floor = floor;
            BedRooms = 3;
			Price = 150;
		}
    }
}

