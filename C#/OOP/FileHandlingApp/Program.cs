using System;
using System.IO;

namespace FileHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //WritingIntoFiloe();
            ReadingFromFile();
        }

        private static void ReadingFromFile()
        {
            foreach (char txt in File.ReadAllText("Test.txt"))
            {
                Console.Write(txt);
            }
        }

        private static void WritingIntoFiloe()
        {
            AddTextToFile("Test.txt", "Sohel\n");
            AddTextToFile("Test.txt", "Chinmay\n");
            AddTextToFile("Test.txt", "Samnit\n");
            AddTextToFile("Test.txt", "Vipul\n");
            AddTextToFile("Test.txt", "Manish\n");
            AddTextToFile("Test.txt", "Sagar\n");
        }

        private static void AddTextToFile(string fileName, string text)
        {
            if (!File.Exists(fileName))
                File.WriteAllText(fileName, text);
            else
                File.AppendAllText(fileName,text);
        }
    }
}
