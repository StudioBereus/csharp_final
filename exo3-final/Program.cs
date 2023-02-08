using System;

namespace exo3_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer le rayon de la sphère ainsi que l'angle de celui-ci, separes d'un espace");
            string[] ans = Console.ReadLine().Split(' ');
            if (double.TryParse(ans[0], out double rayon ) && double.TryParse(ans[1], out double angle)){
                double aire = (Math.PI * Math.Pow(rayon, 2) * angle) / 360;
                Console.WriteLine("L'aire du secteur est de : " + aire);
            }
        }
    }
}
