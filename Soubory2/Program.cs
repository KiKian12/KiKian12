using System;
using System.IO;

namespace Soubory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = File.ReadAllText("Cesta.txt");
            bool b = true;
            int i = 0;
            while (b != false)
            {
                i++;
                File.Create(path + i);
            }
        }
    }
}