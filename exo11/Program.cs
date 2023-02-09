using System;

namespace exo11
{
    class Program
    {

        static void Main(string[] args)
        {
            string rep = "";
            bool textRestart = false, reading = false, jonc = false;


            Console.WriteLine("Merci de répondre aux questions par par O ou N. Tapez restart pour recommencer a tout moment. \nFera-t-il beau demain?");
            rep = Console.ReadLine();
            if (rep == "O")
            {
                Console.WriteLine("Je n'ai pas utilise ma bicyclette depuis quelques mois, est ce qu'elle fonctionne ?");
                rep = Console.ReadLine();
                if (rep == "O")
                {
                    jonc = true;
                }
                else if (rep == "N")
                {
                    Console.WriteLine("Alors je dois aller chez le garagiste pour le faire réparer. \n La reparation est-elle immédiate ?");
                    rep = Console.ReadLine();
                    if (rep == "O")
                    {
                        jonc = true;
                    }
                    else if (rep == "N")
                    {
                        Console.WriteLine("Alors j'irais a pied ceuillir des joncs");
                    }
                    else
                    {
                        textRestart = true;
                    }
                }
                else
                {
                    textRestart = true;
                }
            }
            else if (rep == "N")
            {
                Console.WriteLine("Alors je consacrerais ma journee a la lecture. J'aimerais lire le tome 1 de game of thrones, l'ai-je dans ma bibliotheque ?");
                rep = Console.ReadLine();
                if (rep == "O")
                {
                    reading = true;
                }
                else if (rep == "N")
                {
                    Console.WriteLine("Alors je dois aller l'emprunter a la bibliotheque. Est-il disponible ?");
                    rep = Console.ReadLine();
                    if (rep == "O")
                    {
                        reading = true;
                    }
                    else if (rep == "N")
                    {
                        Console.WriteLine("Alors j'emprunterais un roman policier.");
                        reading = true;
                    }
                    else
                    {
                        textRestart = true;
                    }

                }
                else
                {
                    textRestart = true;
                }
            }
            else { textRestart = true; }

            if (textRestart) { Console.WriteLine("Mauvaise entree ! Tapez restart pour recommencer"); }
            if (reading) { Console.WriteLine("J'ai mon livre qui me convient, je m'installe sur le fauteil"); }

            if (jonc) { Console.WriteLine("Je vais ceuillir des joncs au bord de l'etang"); }
        }
    }
}
