using System;

namespace Operator
{
	class UnaryOperator
	{
		public static void Main(string[] args)
		{
			int number = 10, result;
			bool flag = true;

			result = +number;
			Console.WriteLine("+number = " + result);

			result = -number;
			Console.WriteLine("-number = " + result);

			result = ++number;
			Console.WriteLine("++number = " + result);

			result = --number;
			Console.WriteLine("--number = " + result);

			Console.WriteLine("!flag = " + (!flag));
		}
	}
}
