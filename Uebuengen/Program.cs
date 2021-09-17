using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein.");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib eine Zahl ein.");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
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
            for (int Index=u; i==0 && Index>=0 ;Index--)
            {
                }
                if (Zahl1%Index==0 && Zahl2%Index==0)
                {
                    Console.WriteLine($"Der größte gemeinsame Teiler ist{Index}.");
                    i = 1;
                }
                else
                {
                }
            }
        }
    }
}



