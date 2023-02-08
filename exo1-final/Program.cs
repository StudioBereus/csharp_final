using System;

namespace exo1_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer autant de chiffre que vous le souhaitez, separes d'un espace");
            string[] ans = Console.ReadLine().Split(' ');
            if (ans.Length > 2)
            {
                double sum = 0;
                for (int i = 0; i < ans.Length; i++)
                {
                    if (double.TryParse(ans[i], out double number))
                    {
                        sum += number;
                    }
                }
                double moyenne = sum / ans.Length;
                Console.WriteLine("La moyenne est de : " + moyenne);
            }
            else
            {
                Console.WriteLine("Veuillez entrer au moins deux chiffres");
            }
        }
    }
}
