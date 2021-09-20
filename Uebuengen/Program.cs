using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Zahlen = new List<int> (){ 5, 3, 7 };
            int stop = 0;
            while (stop == 0)
            {
                Console.WriteLine("Bitte gib ein, welche Zahl du hinzufügen möchtest.");
                string P = Console.ReadLine();
                if (P == "")
                {
                    stop = 1;
                }
                else
                {
                    Zahlen.Add(Convert.ToInt32(P));
                }
            }
            Ausgabe(Zahlen);
            Zahlen.Insert(2, 99);
            Ausgabe(Zahlen);
            Zahlen.Insert(3, 105);
            Zahlen.AddRange(new int[] { 91, 92, 93 });
            Ausgabe(Zahlen);
            Zahlen.RemoveAt(0);
            Ausgabe(Zahlen);
            Zahlen.Remove(99);
            Ausgabe(Zahlen);
            Zahlen.RemoveAt(Zahlen.Count - 1);
            Ausgabe(Zahlen);
            Zahlen.RemoveAll(number => number > 80);
            Ausgabe(Zahlen);
        }
        static void Ausgabe(List<int> egalwasmanhierschreibt)
        {
            for (int Index = 0; Index < egalwasmanhierschreibt.Count; Index++)
            {
                Console.WriteLine(egalwasmanhierschreibt[Index]);
            }
        }
    }
}



