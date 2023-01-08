using System;
namespace Homework_W5_OOP_advanced
{
    public class SingleRoom: Room
    {
        public string CustomSingleProperty { get; set; }

		public SingleRoom(int number, int floor): base(number, floor)
        {
            CustomSingleProperty = "custom";
            BedRooms = 1;
			Price = 50;
		}
    }
}

