using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe1 = 0;
            Console.WriteLine("Wie viele Einträge möchtest du im Array haben?");
            int Einträge = Convert.ToInt32(Console.ReadLine());
            double[] Array = new double[Einträge];
            for (int Index = 0; Index < Array.Length; Index++)
            {
                Console.WriteLine("Bitte geben sie eine Fließkommazahl ein.");
                Array[Index] = Convert.ToDouble(Console.ReadLine());
            }
            for (int Index = 0; Index < Array.Length; Index++)
            {
                summe1 += Array[Index];
            }
            Console.WriteLine($"Summe for-Schleife = {summe1}");
            double summe2 = 0;
            foreach(double value in Array )
            {
                summe2 += value;
            }
            Console.WriteLine($"Summe foreach-Schleife = {summe2}");
            double summe3 = 0;
            int a = 0;
            while(a != Array.Length)
                    {
                summe3 += Array[a];
                a += 1;
            }
            Console.WriteLine($"Summe while-Schleife = {summe3}");
        }
    }
}



