using System;
namespace Homework_W5_OOP_advanced
{
	public abstract class Employee
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public double Salary { get; set; }
		public string contactInfo;
		public string Email { get; set; }
        public int Phone { get; set; }
		public abstract double CalculateBonus();

		public virtual string GetContactInfo()
		{
			return contactInfo;
		}
		
	}
}

