using System;
namespace Homework_W5_OOP_advanced
{
	public class Manager:Employee
	{
        private Department department;
        
        public Manager(string Name, int Age, double Salary, Department department)
		{
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.department = department;
		}

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public override string GetContactInfo()
        {
            string nameEmail = Name.ToLower().Substring(0, Name.IndexOf(" "));
            string surnameEmail = Name.ToLower().Substring(Name.IndexOf(" ") + 1).Substring(0, 1);
            Email = nameEmail + "." + surnameEmail + "@";
            string contactInfo = $"Namel :{Name},  Age :{Age}, Deparment: {department} , Email: {Email}, Phone : {Phone}";
            return contactInfo;
        }
    }
}

