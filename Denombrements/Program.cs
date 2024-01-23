/**
 * Titre: Denombrements
 * Description: Programme qui permet le calcul de denombrements
 * Auteur: Ethan Ménagé
 * Date de création: 23-01-2024
 * Date de dernière modification: 23-01-2024
 */
using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Calclul du produit de plusieurs entiers successifs (de valeurDepart à valeurArrivee)
        /// </summary>
        /// <param name="valeurDepart">valeur de départ du calcul</param>
        /// <param name="valeurArrivee">valeur d'arrivée du calcul</param>
        /// <returns>résultat du produit ou 0 si dépassement</returns>
        static long ProduitEntier(int valeurDepart, int valeurArrivee)
        {
            long resultat = 1;
            for (int k = valeurDepart; k <= valeurArrivee; k++)
            {
                resultat *= k;
            }
            return resultat;
        }

        /// <summary>
        /// Menu permettant de choisir (à plusieurs reprise) plusieurs programme de calcul:
        /// permutation, arrangement et combinaison
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string choiseValue = "1";
            while (choiseValue != "0")
            {
                // Demande à l'utilsateur le choix du programme
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choiseValue = Console.ReadLine();
                // Vérification du choix de l'utilisateur
                if (choiseValue == "1" || choiseValue == "2" || choiseValue == "3")
                {
                    try
                    {
                        Console.Write("Nombre total d'éléments à gérer: ");
                        int numberElements = int.Parse(Console.ReadLine());
                        // Calcul de la permutation
                        if (choiseValue == "1")
                        {
                            Console.WriteLine(numberElements + "! = " + ProduitEntier(1, numberElements));
                        }
                        else
                        {
                            Console.Write("Nombre d'éléments dans le sous-ensemble: ");
                            int numberSousEnsemble = int.Parse(Console.ReadLine());
                            long resultat = ProduitEntier(numberElements - numberSousEnsemble + 1, numberElements);
                            // Calcul de l'arrangement
                            if (choiseValue == "2")
                            {
                                Console.WriteLine("A(" + numberElements + "/" + numberSousEnsemble + ") = " + resultat);
                            }
                            // Calcul de la combinaison
                            else if (choiseValue == "3")
                            {
                                long resultatSecondary = resultat / ProduitEntier(1, numberSousEnsemble);
                                Console.WriteLine("C(" + numberElements + "/" + numberSousEnsemble + ") = " + resultatSecondary);
                            }
                        }
                    } 
                    catch
                    {
                        Console.WriteLine("Impossible de faire le calcul !");
                    }
                }
            }
        }
    }
}
