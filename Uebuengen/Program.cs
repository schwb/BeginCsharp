using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void Sum(List<int> Eingesetzt)
        {
                int summe = 0;
                for (int Index =0; Index < Eingesetzt.Count; Index++)
                {
                    summe += Index;
                }
                Console.WriteLine(summe);
        }
            static void Sum(int Eingesetzt,int Eingesetzt1)
            {
                int summe = Eingesetzt + Eingesetzt;
                Console.WriteLine(summe);
            }
            //void gibt nichts zurück. Hier werden durch console.writeline inhslte ausgegeben.
            static string Kontatiniert(string eingesetzt, string eingesetzt1)
            {
                return(string.Join(';', eingesetzt, eingesetzt1));
            }
            //um Inhalte zurückzugeben sird statt void der Datentyp geschrieben und die Ausgabe in der Methode durch return festgelegt.        
    }
}



