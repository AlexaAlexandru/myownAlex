using System;
namespace Homework_W5_OOP_advanced
{
	public class SingleRoom: Room, IDefaultStatus
    {
        public List<int> SingleRooms { get; set; } = new List<int>(10);
		public SingleRoom()
		{
			Name = "Single Room";
			Price = 50;
		}

        void IDefaultStatus.SetRoomsStatus()
        {
            foreach (int room in SingleRooms)
            {
                SingleRooms.Add((int)Status.Available);
            }
        }
    }

	public class DoubleRoom : Room, IDefaultStatus
    {
		public List<int> DoubleRooms { get; set; } = new List<int>(10);

		public DoubleRoom()
		{
			Name = "Double Room";
			Price = 80;
		}

        public void SetRoomsStatus()
        {
            foreach (int room in DoubleRooms)
            {
                DoubleRooms.Add((int)Status.Available);
            }
        }
    }

	public class LuxuryRoom: Room, IDefaultStatus
    {
		public List<int> LuxuryRooms { get; set; }= new List<int>(10);

		public LuxuryRoom()
		{
			Name = "Luxury Room";
			Price = 150;
		}

        public void SetRoomsStatus()
        {
            foreach (int room in LuxuryRooms)
            {
                LuxuryRooms.Add((int)Status.Available);
            }
        }
    }
}

