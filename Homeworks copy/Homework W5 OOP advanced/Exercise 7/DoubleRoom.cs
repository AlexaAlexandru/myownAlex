namespace Homework_W5_OOP_advanced
{
    public class DoubleRoom : Room
    {
        public string View { get; set; }

        public DoubleRoom(int number, int floor): base(number, floor)
		{
            View = "City view with balcony";
            BedRooms = 2;
			Price = 80;
		}
    }
}

