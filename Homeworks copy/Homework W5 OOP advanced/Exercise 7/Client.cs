using System;
namespace Homework_W5_OOP_advanced
{
	public class Client
	{
        public Guid Id { get; set; }
		public string CNP { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		
		public Client(Guid Id,string cnp,string firstName,string lastName,string email, string phone)
		{
			CNP = cnp;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Phone = phone;

		}
    }

}

