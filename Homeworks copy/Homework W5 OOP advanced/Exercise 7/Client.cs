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
		
		public Client(string cnp, string firstName, string lastName, string email, string phone)
		{
			Id = Guid.NewGuid();
			CNP = cnp;
			FirstName = firstName;
			LastName = lastName;
            Phone = phone;

            if ( email.Contains("@") || email.Length < 4 || email.Contains("."))
			{
				throw new InvalidEmail("Please note that the mail inserted is wrong formatted");
			}
			else
			{
                Email = email;
            }
			
		}

    }

}

