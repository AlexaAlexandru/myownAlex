using System;
namespace Homework_W5_OOP_advanced.Exercise3
{
	public class Rectangle : Shape
	{
        

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string Color,double Width,double Height)
        {
            this.Color = Color;
            this.Width = Width;
            this.Height = Height;
        }

        public override double CalculateArea()
        {
            return Area = Width * Height;
        }

        public override double GetPerimeter()
        {
            return Perimeter = 2 * (Width + Height);
        }
    }
}

