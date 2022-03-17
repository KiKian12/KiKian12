using System;
using System.IO;

namespace NoChance
{
    internal class Program
    {
        static int j = int.MinValue;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Path: ");
            var filePath = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("ARE YOU SURE WITH STARTING THE PROCESS? (y/n): ");
            string startProcess = Console.ReadLine();
            if (startProcess.Equals("y"))
            {
                Console.WriteLine("");
                Console.WriteLine("PROCESS RUNNING...");
                for (int i = 0; i != j; i++)
                {
                    File.WriteAllText(filePath + "OOPS" + i + ".txt", "C#...");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("PROCESS CANCELLED BY USER");
            }
            

        }
    }
}