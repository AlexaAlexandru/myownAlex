using System;
namespace Homework_W5_OOP_advanced
{
	public interface IChecking
	{
		void CheckIn(DateTime checkInDate);
		void CheckOut(DateTime checkOutDate);
		double NumberOfNights();
	}
}

