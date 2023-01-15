using System;
namespace Homeworks_W7__Exceptions__LINQ__Lambdas.Exercise6
{
	public static class ToBinaryExtension
	{
		public static string NumberToBinary ( this int n )
		{
			var binary = Convert.ToString(n, 2);
			return binary;
		}

        public static string ToFullDateString1(this DateTime d)
        {
            string a = "a";
            return a;
        }
    }
}

