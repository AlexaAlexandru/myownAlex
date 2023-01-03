using System;
namespace Homework_W5_OOP_advanced
{
	public class Client: Hotel, IChecking
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public int Phone { get; set; }
		private double _numberNights;
		private DateTime _checkInDate;
		private DateTime _checkOutDate;
		public Client(string name,string surname,string email, int phone)
		{
			Name = name;
			Surname = surname;
			Email = email;
			Phone = phone;
		}

        public void CheckIn(DateTime checkInDate)
        {
			_checkInDate = checkInDate;
            Console.WriteLine($"The check-in date is {checkInDate}");
        }

        public void CheckOut(DateTime checkOutDate)
        {
			_checkOutDate = checkOutDate;
            Console.WriteLine($"The check-out date is {checkOutDate}");
        }

        public double NumberOfNights()
        {
			_numberNights = (_checkOutDate - _checkInDate).Days;
			return _numberNights;
        }


    }
}

