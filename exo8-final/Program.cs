using System;

namespace exo8_final
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeu de la fourchette avec l'objet random

            //Instantier l'objet random
            Random rng = new Random();

            //Autres variables
            int nOrdi, nUtilisateur, nbTentatives = 0, min = 0, max = 100;

            //Définir le chiffre au hasard "choisi" par l'ordi, entre 0 et 100
            nOrdi = rng.Next(0, 101);
            Console.WriteLine(nOrdi);
            do
            {
                Console.WriteLine("Veuillez entrer un nombre " + min + " et " + max);
                if (int.TryParse(Console.ReadLine(), out nUtilisateur))
                {
                    if (nUtilisateur == nOrdi)
                    {
                        Console.WriteLine("Gagne ! \nNombre de tentatives : " + nbTentatives);
                    }
                    else if (nUtilisateur > nOrdi)
                    {
                        Console.WriteLine("C'est moins !");//Redefinir la borne max
                        max = nUtilisateur;
                        nbTentatives++;
                    }
                    else if (nUtilisateur < nOrdi)
                    {
                        Console.WriteLine("C'est plus !");//Redefinir la borne minimale
                        min = nUtilisateur;
                        nbTentatives++;
                    }
                }

            } while (nUtilisateur != nOrdi);
            //Donner la consigne
            
            //Vérfier que l'entree de l'utilisateur est bien un chiffre
            
        }
    }
}
