using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen beliebigen Text ein, der jedoch keine Zahlen enthält");
            string first = Console.ReadLine();
            first = first.Replace("U", "G").Replace("u", "g");
            Console.WriteLine(first);
        }
    }
}
