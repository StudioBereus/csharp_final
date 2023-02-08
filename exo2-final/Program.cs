using System;

namespace exo2_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer le rayon de votre sphère");
            double.TryParse(Console.ReadLine(), out double rayon);
            if (rayon > 0){
                double aire = 4 * Math.PI * Math.Pow(rayon, 2);
                double volume = (4 / 3) * Math.PI * Math.Pow(rayon, 3);
                Console.WriteLine("Aire : " + aire + "\nVolume : " + volume);
            }
            else{
                Console.WriteLine("Sphere inexistante !");
            }
        }
    }
}
