using System;
using System.Threading;

namespace Aquariumproject
{
    class Program
    {
        static void Main(string[] args)
        {

            universal_fish fish1 = new universal_fish();
            swordfish swordfish = new swordfish();
            Aquarium fischtank = new Aquarium();
            Console.WriteLine("Insert height of the aquarium.");
            var values = Console.ReadLine();
            int number;
            bool success;
            for (int Index3 = 0; Index3 < 1; Index3++)
            {
                success = Int32.TryParse(values, out number);
                if (success)
                {
                    fischtank.height = Convert.ToInt32(values);
                }
                else
                {
                    Console.WriteLine("Insert height of the aquarium.");
                    values = Console.ReadLine();
                    Index3 -= 1;
                }
            }
            Console.WriteLine("Insert broad of the aquarium.");
            var values2 = Console.ReadLine();
            success = Int32.TryParse(values2, out number);
            while (success == false)
            {
                Console.WriteLine("Insert broad of the aquarium.");
                values2 = Console.ReadLine();
                success = Int32.TryParse(values2, out number);
            }
            dinosour Riesenkroko = new dinosour();
            fischtank.broad = Convert.ToInt32(values2);
            string Bedingung = "unendlich";
            fischtank.filltheaquarium();
            fischtank.fillinfishes();
            fischtank.eatingfishes();
            fischtank.output();
            Thread.Sleep(500);
            Console.Clear();
            fischtank.filltheaquarium();
            fischtank.movefishes();
            fischtank.eatingfishes();
            fischtank.output();
            Thread.Sleep(500);
            //fischtank.fillindinosour(Riesenkroko);
            while (Bedingung == "unendlich")
            {
                Console.Clear();
                fischtank.filltheaquarium();
                /*fischtank.movedinosour(Riesenkroko);*/
                fischtank.movefishes();
                fischtank.eatingfishes();
                fischtank.output();
                Thread.Sleep(500);
            }
        }
    }
}
