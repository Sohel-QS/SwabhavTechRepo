using System;
class LoopTest
{
	public static void Main()
	{
		//declaring array with five elements 1,2,3,4,5
		int[] Array = new int[5]{1,2,3,4,5};

		Console.WriteLine("Printing Array Element With For Loop");

		//for loop for print Array Elements
		for(int i=0; i<5; i++)
		{
			Console.WriteLine(Array[i]);
		}

		//making index value 0 for while loop
		int index = 0;
		Console.WriteLine("Printing Array Element With While Loop");
		//while loop for printing Array Elements
		while (index<5)
		{
			Console.WriteLine(Array[index]);
			index += 1;
		}

		//making index value 0 for do-while loop
		index = 0;
		Console.WriteLine("Printing Array Element With Do-While Loop");
		//do-while loop for printing Array Elements
		do
		{
			Console.WriteLine(Array[index]);
			index += 1;
		}while(index < 5);


		Console.WriteLine("Printing Array Element With ForEach Loop");
		//foreach loop for printing Array Elements
		foreach (int item in Array)
		{
			Console.WriteLine(item);
		}
	}
}