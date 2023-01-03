using System;

namespace Homework_W5_OOP_advanced
{
	public class Reception : Hotel,Ireservation,Iaccount
	{
		private bool IsRoomFree { get; set; }
		private int CostofRoom { get; set; } = 50;

        public void CheckRoomStatus()
        {
            throw new NotImplementedException();
        }

        public double GetPriceRoom()
        {
            throw new NotImplementedException();
        }

        public string GetReservationNumber()
        {
            throw new NotImplementedException();
        }

        public string GenerateAccount()
        {
            throw new NotImplementedException();
        }

        public List<string> ReservationDetails()
        {
            throw new NotImplementedException();
        }
    }
}

