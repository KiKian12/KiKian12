using System;
using System.IO;

namespace Soubory1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\r\tEnter full file path with file name: ");
            var filePath = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("\r\tEnter amount of lines: ");
            int fileLinesAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            List<string> fileText = new List<string>();
            for (int i = 0; i != fileLinesAmount; i++)
            {
                string fileLine = Console.ReadLine();
                fileText.Add(fileLine);
            }
            File.AppendAllLines(filePath, fileText);
            if (File.Exists(filePath))
            {
                Console.WriteLine("");
                Console.WriteLine("\r\tFile sucessfully created!");
            }

        }
    }
}