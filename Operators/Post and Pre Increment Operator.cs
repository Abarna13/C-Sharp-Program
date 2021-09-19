using System;

namespace Operator
{
	class UnaryOperator
	{
		public static void Main(string[] args)
		{
			int number = 10;

			Console.WriteLine((number++));
			Console.WriteLine((number));

			Console.WriteLine((++number));
			Console.WriteLine((number));
		}
	}
}
