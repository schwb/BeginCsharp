using System;
using System.Collections.Generic;
using System.IO;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            int Position = 0;
            Random r = new Random();
            int[,] Zahlen = new int[5, 7];
            for(int i=0;i<Zahlen.GetLength(0);i++)
            {
                for(int j=0;j<Zahlen.GetLength(1);j++)
                {
                   if(i==Zahlen.GetLength(0)-1)
                    {
                        summe = 0;
                        for(int k=0;k<Zahlen.GetLength(0)-1;k++)
                        {
                            summe += Zahlen[k, Position];
                        }
                        Zahlen[Zahlen.GetLength(0) - 1, Position]=summe;
                        Position += 1;
                        string sum = Convert.ToString(summe);
                        Console.Write($"{sum.PadRight(5,' ')}");
                    }
                    else
                    {
                        Zahlen[i,j]=r.Next(1, 99);
                        string Zahl= Convert.ToString(Zahlen[i, j]);
                        Console.Write($"{Zahl.PadRight(5, ' ')}");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}


