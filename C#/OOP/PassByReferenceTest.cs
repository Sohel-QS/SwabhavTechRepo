using System;
class PassByReferenceTest
{
	public static void Main()
	{	
		//Example code for Pass by Reference
		int MakeItSquare = 5;
		Console.WriteLine("Variable value before calling method ByReference :" + MakeItSquare);
		ByReference(ref MakeItSquare);
		Console.WriteLine("Variable value after calling method ByReference :" + MakeItSquare);
		Console.WriteLine("Press Enter To Exit");
		Console.ReadLine();
	}
		
	//By Reference method declaration
	public static void ByReference(ref int num)
	{
		num *= num;
		Console.WriteLine("Variable Value Inside Method :" + num);
	}
}