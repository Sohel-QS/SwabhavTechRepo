using System;

namespace DotComGameApp.Model
{
    public class GameHelper
    {
        public string getUserInput(string prompt)
        {
            string inputLine = "";
            Console.Write(prompt + " :");
            try
            {
                inputLine = Console.ReadLine();
                if (inputLine.Length == 0)
                    return null;
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            return inputLine;
        }
    }
}
