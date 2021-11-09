using System;
class CmdLineArgsTest
{
	public static void Main(String[] names)
	{
		//part1
		Console.WriteLine("Length Is : " + names.Length);

		//part2
		foreach(string items in names)
		{
			Console.WriteLine(items);
		}
	}
}