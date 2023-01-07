namespace Homework_W5_OOP_advanced
{
    public class LuxuryRoom: Room
    {
		public LuxuryRoom(int number, int floor)
		{
            Id = Guid.NewGuid();
            BedRooms = 3;
			Price = 150;
		}
    }
}

