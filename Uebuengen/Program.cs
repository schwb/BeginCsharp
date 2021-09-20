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
            for (int Index=0; Index<Zahlen.Count;Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
            Zahlen.Insert(2, 99);
            for (int Index = 0; Index < Zahlen.Count; Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
            Zahlen.Insert(3, 105);
            Zahlen.AddRange(new int[] { 91, 92, 93 });
            for (int Index = 0; Index < Zahlen.Count; Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
            Zahlen.RemoveAt(0);
            for (int Index = 0; Index < Zahlen.Count; Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
            Zahlen.Remove(99);
            for (int Index = 0; Index < Zahlen.Count; Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
            Zahlen.RemoveAt(Zahlen.Count - 1);
            for (int Index = 0; Index < Zahlen.Count; Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
            for (int Index = 0; Index<Zahlen.Count; Index++)
            {
                if (Zahlen[Index]>80)
                {
                    Zahlen.RemoveAt(Index);
                    Index -= 1;
                }
            }
            for (int Index = 0; Index < Zahlen.Count; Index++)
            {
                Console.WriteLine(Zahlen[Index]);
            }
        }
    }
}



