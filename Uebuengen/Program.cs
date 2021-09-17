using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein.");
            string Zahl3 = Console.ReadLine();
            int Zahl1 = Convert.ToInt32(Zahl3.Replace("-",""));
            Console.WriteLine("Bitte gib eine Zahl ein.");
            string Zahl4 = Console.ReadLine();
            int Zahl2 = Convert.ToInt32(Zahl4.Replace("-",""));
            int G = 0;
            int K = 0;
            if (Zahl1>=Zahl2)
            {
                G = Zahl1;
                K = Zahl2;
            }
            else
            {
                G = Zahl2;
                K = Zahl1;
            }
            int u = G + 1;
            int[] Z = new int[u];
            int i = 0;
            for (int Index=u; i==0;Index--)
            {
                if (Zahl1==0 && Zahl2==0)
                {
                    Console.WriteLine("Der größte gemeinsame Teiler ist Unendlich.");
                    i = 1;
                }
                else if (Zahl1%Index==0 && Zahl2%Index==0)
                {
                    Console.WriteLine($"Der größte gemeinsame Teiler ist {Index}.");
                    i = 1;
                }
            }
        }
    }
}



