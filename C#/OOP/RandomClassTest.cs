using System;
class RandomClassTest
{
	static void Main()
	{
		Random obj = new Random();
		int random=0;
		while(random != 1)
		{
			random = obj.Next(1,6);
			Console.WriteLine(random);
		}
	}
}