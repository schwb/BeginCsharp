using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            decimal second = Convert.ToDecimal(first);
            string third = Console.ReadLine();
            decimal fourth = Convert.ToDecimal(third);
            Console.WriteLine(second + fourth);
        }
    }
}
