using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int zufallszahl = r.Next(2, 200);
            Console.WriteLine("Welche Zahl ist gesucht?");
            int a = Convert.ToInt32(Console.ReadLine());
            while(a != zufallszahl)
            {
                if(a< zufallszahl)
                {
                    Console.WriteLine("Deine Zahl ist zu klein");
                }
                else
                {
                    Console.WriteLine("Deine Zahl ist zu groß");
                }
                Console.WriteLine("Welche Zahl ist gesucht?");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sie haben gewonnen!");
        }
    }
}



