using System;
class Student
{
	public int Id;
	public String Name;
	public int TotalMarks;
	public int TotalM(int Math, int Sci, int Eng)
	{
			return Math+Sci+Eng;
	}
}
class StudentInfo
{
	
	public static void Main()
	{
		Student st = new Student(); // Creating Object of Student Class
		
		//Getting input for student id
		Console.WriteLine("Enter Student Id :");
		st.Id = Convert.ToInt32(Console.ReadLine());

		//Getting input for student name
		Console.WriteLine("Enter Student Name :");
		st.Name = Console.ReadLine();

		//Getting input for student marks
		Console.WriteLine("Enter Math Marks :");
		int math = Convert.ToInt32(Console.ReadLine());//math marks

		Console.WriteLine("Enter Science Marks :");
		int sci = Convert.ToInt32(Console.ReadLine());//science marks

		Console.WriteLine("Enter English Marks :");
		int eng = Convert.ToInt32(Console.ReadLine());//englisg marks
		
		//Adding all marks storing in TotalMarks
		st.TotalMarks = st.TotalM(math, sci, eng);
		
		//Printing All Data
		Console.WriteLine("----- Student Info -----");
		Console.WriteLine("Id : {0}\nName : {1}\nTotal Marks : {2}", st.Id, st.Name, st.TotalMarks);
	}	
}