using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie Namen ein, die mit einem Semikolon getrennt sind");
            string a = Console.ReadLine();
            string[] b = a.Split(';');
            for(int Index = 0; Index < b.Length; Index += 1 )
            {
                Console.WriteLine(b[Index]);
            }

        }
    }
}



