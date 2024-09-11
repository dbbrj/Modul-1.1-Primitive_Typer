using System;

class Program
{
	static void Main()
	{
		int test = 2147483647;
		Console.WriteLine(test);
		test++;
		Console.WriteLine(test);//This shows that when the higest value are passed its starts over		
	}
}