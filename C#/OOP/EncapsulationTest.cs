using System;
public class EncapsulatedData
{
	private string studentName;
	private int studentAge;

	public string Name
	{
		get
		{
			return studentName;
		}
		set
		{
			studentName = value;
		}
	}
	public int Age
	{
		get
		{
			return studentAge;
		}
		set
		{
			studentAge = value;
		}
	}
}
class EncapsulationTest
{	
	static void Main()
	{
		EncapsulatedData edata = new EncapsulatedData();
		edata.Name = "Sohel";
		edata.Age = 21;
		Console.WriteLine("Student Name :{0}\nStudent Age :{1}", edata.Name, edata.Age);
	}
}