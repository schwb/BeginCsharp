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
            int max = Einträge[0];
            for (int Index = 0; Index < tabel; Index++)
            {
                if (max < Einträge[Index])
                {
                    max = Einträge[Index];
                }
            }
            Console.WriteLine("Das Maximum lautet " + max);
            int min = Einträge[0];
            for (int Index = 0; Index < tabel; Index++)
            {
                if (min > Einträge[Index])
                {
                    min = Einträge[Index];
                }
            }
            Console.WriteLine("Das Minimum lautet " + min);
            double summe = 0;
            for (int d = 0; Index < tabel; d++)
                summe += Einträge[d];
                    summe = summe / tabel;
                Console.WriteLine(summe);     
        }
    }
}


