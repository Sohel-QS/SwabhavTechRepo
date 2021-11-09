using System;
class PassByValueTest
{
	public static void Main()
	{
		//Example code for Pass by Value
		int x = 100;
		Console.WriteLine("Variable Value Before Calling Method ByValue :" + x);
		ByValue(x);	
		Console.WriteLine("Variable Value After Calling Method ByValue :" + x);
		Console.WriteLine("Press Enter To Exit");
		Console.ReadLine();
	}
	
	//ByValue method declaration
	public static void ByValue(int number)
	{
		number += 5;
		Console.WriteLine("Variable Value Inside Method :" + number);
	}
	
}