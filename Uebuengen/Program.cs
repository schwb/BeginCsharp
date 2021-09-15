using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Spalten soll das Array haben?");
            int tabel = Convert.ToInt32(Console.ReadLine());
            int[] Einträge = new int[tabel];
            
            for (int Index = 0; Index < tabel; Index ++)
            {
                Console.WriteLine("Welche Zahl als nächstes?");
                Einträge[Index] = Convert.ToInt32(Console.ReadLine());
            }
            for (int Index = 0; Index < tabel; Index ++)
            {
                Console.WriteLine(Einträge[Index]);
            }
        }
    }
}


