
using System;

namespace sdafsjkdsjjdsfjsd
{
	using System;

	public static class Program
	{
		public static void Main()
		{
			Action a = M1;
			a += M2;
			WriteAction(a);
		}


		public static void WriteAction(Action action)
		{
			Console.WriteLine(action.Method.Name);
		}

		public static void M1()
		{

		}

		public static void M2()
		{

		}
	}
}
