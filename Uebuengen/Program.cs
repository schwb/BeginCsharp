using System;

namespace Uebuengen
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] array = new string[] { "Julian","Ioanna","Linus","Bernhard","Carmen","Oliver","Amelie" };
            for(int index = 0; index < array.Length; index += 1)
            {
                Console.WriteLine(array[index]);
            }
        }
    }
}
