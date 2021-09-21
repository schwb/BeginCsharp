using System;
using System.Collections.Generic;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib den Nenner des Bruchs ein.");
            double Zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib den Zähler des Bruchs ein.");
            double Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte wähle eine Rechenmethode für den Bruch. (Negieren, Umkehren, Erweitern, Kürzen, Potenzieren, Wurzel ziehen)");
            string Rechenmethode = Console.ReadLine();
            double Ergebnis = 0;
            string Ergebnis2 = "wird nicht ausgegeben";
            switch(Rechenmethode)
            {
                case "Negieren":
                    Ergebnis = Negieren(Zahl2, Zahl1);
                    break;
                case "Umkehren":
                    Ergebnis = Umkehren(Zahl2, Zahl1);
                    break;
                case "Erweitern":
                    Console.WriteLine("Um welchen Faktor möchtest du den Bruch erweitern?");
                    double Faktor = Convert.ToDouble(Console.ReadLine());
                    Ergebnis = Erweitern(Zahl2, Zahl1, Faktor);
                    break;
                case "Kürzen":
                    string Größtergt= Ggt(Zahl2, Zahl1);
                    if (Größtergt=="Unendlich")
                    {
                        Ergebnis = 0;
                    }
                    else
                    { 
                       double faktor = Convert.ToDouble(Größtergt);
                        Zahl1 = Zahl1 / faktor;
                        Zahl2 = Zahl2 / faktor;
                        Ergebnis2 = $"Der gekürzte Bruch lautet im Nenner {Zahl2} und im Zähler {Zahl1}. Der größte gemeinsame Teiler lautet {faktor}. Das Ergebnis lautet {Zahl1 / Zahl2}.";
                    }
                    break;
                case "Potenzieren":
                    Console.WriteLine("Mit welcher Zahl möchtest du deinen Bruch potenzieren?");
                    double Exponent = Convert.ToDouble(Console.ReadLine());
                    Ergebnis= Potenzieren(Zahl1, Zahl2, Exponent);
                    break;
                case "Wurzel ziehen":
                    Ergebnis = Wurzelziehen(Zahl1, Zahl2);
                    break;
                default:
                    Console.WriteLine("Deine gewählte Methode ist in diesem Programm nicht definiert.");
                    break;
            }
            if (Ergebnis2 == "wird nicht ausgegeben")
            {
                Console.WriteLine($"Ergebnis: {Ergebnis}.");
            }
            else 
            {
                Console.WriteLine(Ergebnis2);
            }
        }
        static double Wurzelziehen(double Zahl1, double Zahl2)
        {
            Zahl1 = Zahl1 / Zahl2;
            return (Math.Sqrt(Zahl1));
        }
        static double Potenzieren(double Zahl1, double Zahl2, double Exponent)
        {
            if (Exponent>0)
            {
                Zahl1 = Zahl1 / Zahl2;
                return (Math.Pow(Zahl1,Exponent));
            }
            else if(Exponent==0)
            {
                return 1;
            }
            else
            {
                string Positiv = Convert.ToString(Exponent);
                Positiv= Positiv.Replace("-", "");
                Exponent = Convert.ToDouble(Positiv);
                Zahl1 = Zahl1 / Zahl2;
                return (Math.Pow(Zahl1, 1 / Exponent));
            }
        }
        static double Negieren(double Zahl2, double Zahl1)
        {
            Zahl1 = Zahl1 * -1;
            return (Zahl1 / Zahl2);
        }
        static double Umkehren(double Zahl2, double Zahl1)
        {
            return (Zahl2 / Zahl1);
        }
        static double Erweitern(double zahl2, double zahl1, double faktor)
        {
            zahl1 = zahl1 * faktor;
            zahl2 = zahl2 * faktor;
            return (zahl1 / zahl2);
        }
        static string Ggt(double zahl2, double zahl1)
        {
            string Ausgabe = "";
            double Zahl1 = zahl1;
            double Zahl2 = zahl2;
            string Zahl3 = Convert.ToString(Zahl1);
            Zahl1 = Convert.ToDouble(Zahl3.Replace("-", ""));
            string Zahl4 = Convert.ToString(Zahl2);
            Zahl2 = Convert.ToDouble(Zahl4.Replace("-", ""));
            double G = 0;
            double K = 0;
            if (Zahl1 >= Zahl2)
            {
                G = Zahl1;
                K = Zahl2;
            }
            else
            {
                G = Zahl2;
                K = Zahl1;
            }
            int u = Convert.ToInt32(G + 1);
            int i = 0;
            for (int Index = u; i == 0; Index--)
            {
                if (Zahl1 == 0 && Zahl2 == 0)
                {
                    Ausgabe= ("Unendlich");
                    i = 1;
                }
                else if (Zahl1 % Index == 0 && Zahl2 % Index == 0)
                {
                    Ausgabe = Convert.ToString(Index);
                    
                    i = 1;
                }
            }
            return Ausgabe;
        }
    }
}



