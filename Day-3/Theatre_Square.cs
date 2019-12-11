using System;

namespace TheatreSquare
{
	class Program
	{
		static void Main(string[] args)
		{
			var numberStrings = Console.ReadLine() ? .Split();
			var m = Convert.ToInt64(numberStrings ? [0]);
			var n = Convert.ToInt64(numberStrings ? [1]);
			var a = Convert.ToInt64(numberStrings ? [2]);
			var  result =
				((n * m) == (a * a) ? 1 : ((n % a != 0 ? (n / a) + 1 : (n / a)) * (m % a != 0 ? (m / a) + 1 : (m / a))));
			Console.WriteLine(result);

		}

	}
}