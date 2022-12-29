using System;
namespace Homework_W5_OOP_advanced
{
	public class Circle : Shape
	{
		public double Radius { get; set; }
		public Circle(string Color,double Radius)
		{
			this.Color = Color;
			this.Radius = Radius;
		}

        public override double CalculateArea()
        {
			return Area = Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
			return Perimeter = 2 * Math.PI * Radius;
        }
    }
}

