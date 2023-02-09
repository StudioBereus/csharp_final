using System;

namespace exo12
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbUtilisateur = 0, nbPc, victoryUt = 0, victoryPc = 0, matchNull=0, res;
            Random rng = new Random();
            Console.WriteLine("Jeu du 0-1-2");
            while (victoryPc < 10 && victoryUt < 10 || nbUtilisateur < 0)
            {
                Console.WriteLine("\nVeuillez entrer un chiffre entre 0 et 2");
                int.TryParse(Console.ReadLine(), out nbUtilisateur);
                nbPc = rng.Next(0, 3);
                
                if (nbPc > nbUtilisateur)
                {
                    Console.WriteLine(nbPc);
                    res = nbPc - nbUtilisateur;
                    if (res == 0)
                    {
                        matchNull++;
                        Console.WriteLine("Match nul ! " + victoryPc+" "+victoryUt+" "+matchNull);
                    }
                    else if (res == 1)
                    {
                        victoryUt++;
                        Console.WriteLine("Utilisateur gagne ! "+ victoryPc + " " + victoryUt + " " + matchNull);
                    }
                    else if (res == 2)
                    {
                        victoryPc++;
                        Console.WriteLine("Pc gagne ! "+ victoryPc + " " + victoryUt + " " + matchNull);
                    }
                }
                else
                {
                    Console.WriteLine(nbPc);
                    res = nbUtilisateur - nbPc;
                    if (res == 0)
                    {
                        matchNull++;
                        Console.WriteLine("Match nul ! " + victoryPc + " " + victoryUt + " " + matchNull);
                    }
                    else if (res == 1)
                    {
                        victoryPc++;
                        Console.WriteLine("Pc gagne ! " + victoryPc + " " + victoryUt + " " + matchNull);
                    }
                    else if (res == 2)
                    {
                        victoryUt++;
                        Console.WriteLine("Utilisateur gagne ! " + victoryPc + " " + victoryUt + " " + matchNull);
                    }
                }
            }
            Console.WriteLine("Victoires Utilisateur : " + victoryUt + "\n Victoires PC : " + victoryPc + "Matchs nuls : " + matchNull);
        }
    }
}
