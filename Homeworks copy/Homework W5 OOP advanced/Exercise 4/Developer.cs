﻿using System;
namespace Homework_W5_OOP_advanced
{
	public class Developer:Employee
	{
        private List<string> _skills;
        public bool IsJunior { get; set; }

        public Developer(string name,int age,double salary,List<string> skills,bool isJunior)
		{
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            _skills = skills;
            this.IsJunior = isJunior;
		}

        public override double CalculateBonus()
        {
            return Salary * 0.2;
        }

        public override string GetContactInfo()
        {
            /*
            string nameEmail = Name.ToLower().Substring(0, Name.IndexOf(" "));
            string surnameEmail = Name.ToLower().Substring(Name.IndexOf(" ") + 1).Substring(0, 1);
            Email = nameEmail + "." + surnameEmail + "@";
            string contactInfo = $"Name :{Name},  Age :{Age}, Skills:  , Email: {Email}, Phone : {Phone}";
            */
            string skillsString = string.Empty;
            _skills.ForEach(l => skillsString = skillsString + l+ ",");
            string contactInfo = $"Name :{Name},  Age :{Age}, Skills: {skillsString}";
            return contactInfo;
        }
    }
}

