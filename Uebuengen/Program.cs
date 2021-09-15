using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Julian", "Ioanna", "Linus", "Bernhard", "Carmen", "Oliver", "Amelie" };
            for (int Index = 0; Index < 7; Index += 1)
            {
                if (names[Index].Contains("e"))
                {
                    Console.WriteLine(names[Index]);
                }
                else
                {

                }
            }
        }
    }
}


