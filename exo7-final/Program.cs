using System;

namespace exo7_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer la temperature puis son unite de mesure, separes d'une virgule (C/F)");
            string[] rep = Console.ReadLine().Split(' ');
            if(double.TryParse(rep[0], out double temp)){
                double converted;
                if (rep[1] == "C")
                {
                    converted = (temp * (9 / 5)) + 32;
                    Console.WriteLine(converted);
                }
                else if (rep[1] == "F")
                {
                    converted = (temp - 32) * 5 / 9;
                    Console.WriteLine(converted);
                }
                else
                {
                    Console.WriteLine("Mauvaise entree");
                }
            }


        }
    }
}
