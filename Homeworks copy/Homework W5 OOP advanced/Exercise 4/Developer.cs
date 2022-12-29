using System;
namespace Homework_W5_OOP_advanced
{
	public class Developer:Employee
	{
        public List<string> skills = new List<string>();
        public bool IsJunior { get; set; }
        public Developer(string Name,int Age,double Salary,List<string> skills,bool IsJunior)
		{
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.skills = skills;
            this.IsJunior = IsJunior;
		}

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }

        public override string GetContactInfo()
        {
            string nameEmail = Name.ToLower().Substring(0, Name.IndexOf(" "));
            string surnameEmail = Name.ToLower().Substring(Name.IndexOf(" ") + 1).Substring(0, 1);
            Email = nameEmail + "." + surnameEmail + "@";
            object[] skillsArray = skills.ToArray();
            string contactInfo = $"Namel :{Name},  Age :{Age}, Skills:  {skillsArray} , Email: {Email}, Phone : {Phone}";
            return contactInfo;
        }
    }
}

