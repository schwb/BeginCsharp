using System;
using System.Collections.Generic;
using System.IO;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Aquarium = new string[30, 30];
            for (int i = 0; i < Aquarium.GetLength(0);i++)
            {
                for(int j = 0; j<Aquarium.GetLength(1);j++)
                {
                    if (j == 0 || j == Aquarium.GetLength(0) - 1)
                    {
                        Console.Write("|");
                    }
                    else if (i == Aquarium.GetLength(0)-1)
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write("~");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}


