using System;
class ArrayTest
{
	public static void Main()
	{
		int choice = 0;

		//looping until choice is 4
		while (choice != 4)
		{
			//label
			Console.WriteLine("--------Array Type ?--------");

			//choices for Array DataTypes
			Console.WriteLine("1)Int\n2)String\n3)Double\n4)Exit\n\nEnter Your Choice:");

			//geting input for choice from user
			choice = Convert.ToInt32(Console.ReadLine());

			//puting choice in switch-case
			switch(choice)
            		{
				case 1:
					//Array of Type Int
					int[] Array_Int = new int[5];
					Console.WriteLine("Enter 5 Integers:");
					for(int index = 0; index<5; index++)
                    			{
						Array_Int[index] = Convert.ToInt32(Console.ReadLine());
                    			}
					Console.WriteLine("Your Elements Are --> " + String.Join(" ", Array_Int));
					break;
				case 2:
					//Array of Type String
					string[] Array_String = new string[5];
					Console.WriteLine("Enter 5 Strings:");
					for (int index = 0; index < 5; index++)
					{
						Array_String[index] = Console.ReadLine();
					}
					Console.WriteLine("Your Elements Are --> " + String.Join(" ", Array_String));
					break;
				case 3:
					//Array of Type Double
					double[] Array_Double = new double[5];
					Console.WriteLine("Enter 5 Doubles:");
					for (int index = 0; index < 5; index++)
					{
						Array_Double[index] = Convert.ToDouble(Console.ReadLine());
					}
					Console.WriteLine("Your Elements Are --> " + String.Join(" ", Array_Double));
					break;
				case 4:
					//program execution stops here
					Console.WriteLine("--------Exit!!--------");
					break;
				default:
					//for choice which is not here
					Console.WriteLine("--------Invalid Choice!!--------");
					break;
			}
		}
	}
}