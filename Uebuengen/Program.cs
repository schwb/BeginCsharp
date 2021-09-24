using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1:Gebe aus seiner Liste von Zahlen nur die Zahlen aus, welche durch 2 Teilbar sind 
            List<int> Zahlen = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 44, 55, 66, 77, 88 };
            List<int> Geradezahlen = Zahlen.Where(a => a % 2 == 0).Select(u => u).ToList();
            foreach (int z in Geradezahlen)
            {
                Console.WriteLine($"{z}");
            }
            //Aufgabe 2:Gebe aus einer Liste von Zahlen nur die ungeraden Werte aus 
            List<int> ungeradezahlen = Zahlen.Where(a => a % 2 != 0).Select(u => u).ToList();
            foreach (int z in ungeradezahlen)
            {
                Console.WriteLine($"{z}");
            }
            //Aufgabe 3:Gebe für die angegebenen Zahlen , die Zahl sowie die Quadratzahl aus, wobei die Quadratzahl größer als 20 sein soll 
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            var Ausgabe = arr1.Where(a => a * a > 20).Select(a => a).ToList();
            foreach (int z in Ausgabe)
            {
                Console.WriteLine($"Zahl: {z},Quadratzahl {z * z}");
            }
            //Aufgabe 4:Gehe eine Liste von zahlen durch, und gebe die Zahl sowie die Häufigkeit, wie oft diese in der Liste auftritt 
            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var arr3 = arr2.GroupBy(i => i);
            foreach (var grp in arr3)
            {
                Console.WriteLine($"Type: {grp.Key}, occurance {grp.Count()}");
            }
            //Aufgabe 5:Gebe die Häufigkeit jeden Buchstabens des angegebenen Strings aus. 
            //Lasse den Nutzer ein eigenes Wort eingeben
            Console.WriteLine("Bitte gib eine Zeichenfolge deiner Wahl ein.");
            string str = Console.ReadLine();
            var arr4 = str.GroupBy(i => i);
            foreach (var grp in arr4)
            {
                Console.WriteLine($"Type: {grp.Key}, occurance {grp.Count()}");
            }
            //Aufgabe 6:Gebe die Zahl, das Auftreten der Zahl im Array, sowie die Multiplikation der Zahl mit der Zahl ihres Auftretens 
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var arr6 = nums.GroupBy(i => i);
            foreach (var grp in arr6)
            {
                Console.WriteLine($"Type: {grp.Key}, occurance {grp.Count()}, multiplication of both={grp.Key * grp.Count()}");
            }
            /*Aufgabe 7: Gebe die Städte aus, welche mit einem bestimmten Buchstaben beginnen, 
            sowie mit einem weiteren Buchstaben Enden. Gestalte es variabel. 
            String[] cities = { “ROME”,”LONDON”,”NAIROBI”,”CALIFORNIA,””ZURICH”,”NEW DELHI”,”AMSTERDAM”,”ABUDHABI”,”PARIS} */
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABUDHABI", "PARIS" };
            Console.WriteLine("Mit welchem Buchstaben sollen die Städte beginnen?");
            string Start = (Console.ReadLine()).ToUpper();
            Console.WriteLine("Mit welchem Buchstaben sollen die Städte enden?");
            string Ende = (Console.ReadLine()).ToUpper();
            var Ausgabe1 = cities.Where(a => a.StartsWith(Start)).Select(a => a).ToList();
            var Ausgabe2 = Ausgabe1.Where(a => a.EndsWith(Ende)).Select(a => a).ToList();
            foreach (string z in Ausgabe2)
            {
                Console.WriteLine($"{z}");
            }
            /*Aufgabe 8: Lasse den Nutzer eine Zahl eingeben, wie viele Einträge er hinzufügen möchte.
            Frage anschließend nach den jeweiligen Werten, bis die Anzahl der Listelemente erreicht ist.  
            Frage Anschließend nach einer Zahl und gebe nur die Elemente der Liste aus, welche größer als die Eingabe ist. */
            Console.WriteLine("Wie viele Einträge soll deine Liste haben?");
            int Einträge = Convert.ToInt32(Console.ReadLine());
            List<int> Zahlen1 = new List<int>(Einträge);
            for(int Zahl =0;Zahl<Einträge; Zahl++)
            {
                Console.WriteLine("Welche Zahl soll als nächstes zur Liste hinzugefügt werden?");
                Zahlen1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Bitte gib eine zahl ein.");
            int Vergleichszahl = Convert.ToInt32(Console.ReadLine());
            var Ausgabe3 = Zahlen1.Where(a => a>Vergleichszahl).Select(a => a).ToList();
            foreach (int z in Ausgabe3)
            {
                Console.WriteLine($"{z}");
            }
        }
    }
}



