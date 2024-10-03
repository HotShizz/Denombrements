using System;

namespace Denombrements
{
    class Program
    {

        /// <summary>
        /// Overload pour quand il n y a plusieurs lignes de messages d'explication à publier 
        /// </summary>
        /// <param name="msgOuverture">msg pour expliquer  l'utilisateur ce que l'application cherche comme information</param>
        /// <param name="msgErreur">message à affichier lors d'une erreur de saisie</param>
        /// <returns>integer</returns>
        static int CaptureEntreeInt(string[] msgOuverture, string msgErreur)
        {
            int entreUtilisateur;
            do
            {
                for (int n = 0; n < msgOuverture.Length; ++n)
                {
                    Console.WriteLine(msgOuverture[n]);
                }
                try
                {
                    entreUtilisateur = int.Parse(Console.ReadLine());
                    return entreUtilisateur;
                }
                catch
                {
                    Console.WriteLine(msgErreur);
                    Console.WriteLine();
                }
            } while (true);
        }

        /// <summary>
        /// Overload pour quand il n y a qu'une seule ligne de message d'explication à publier 
        /// </summary>
        /// <param name="msgOuverture">msg pour expliquer  l'utilisateur ce que l'application cherche comme information</param>
        /// <param name="msgErreur">message à affichier lors d'une erreur de saisie</param>
        /// <returns>integer</returns>
        static int CaptureEntreeInt(string msgOuverture, string msgErreur)
        {
            int entreUtilisateur;
            do
            {
                Console.WriteLine(msgOuverture);
                try
                {
                    entreUtilisateur = int.Parse(Console.ReadLine());
                    return entreUtilisateur;
                }
                catch
                {
                    Console.WriteLine(msgErreur);
                    Console.WriteLine();
                }
            } while (true);
        }

        /// <summary>
        /// loop utilises lors des equations. overload pour quand besoin de plusieurs valeurs
        /// </summary>
        /// <param name="valeur1">valeur choissit par l'utilisateur</param>
        /// <param name="valeur2">2eme valeur choissit par l'utilisateur</param>
        /// <returns>resultat de calculation</returns>
        static long LoopMultiplication(int valeur1, int valeur2)
        {
            long resultat = 1;
            for (int n = valeur1 - valeur2 + 1; n <= valeur1; n++)
            {
                resultat *= n;
            }
            return resultat;
        }

        /// <summary>
        /// loop utilises lors des equations. overload pour quand besoin d'un seul valeur
        /// </summary>
        /// <param name="valeur">valeur choissit par l'utilisateur;</param>
        /// <returns>resultat de calculation</returns>
        static long LoopMultiplication(int valeur)
        {
            long resultat = 1;
            for (int n = 1; n <= valeur; n++)
            {
                resultat *= n;
            }
            return resultat;
        }

        /// <summary>
        /// Logiciel permettant la calcul de permutation arrangement, combinaison des valeur saisit par l'utilisateur
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choixUtilisateur = 4;
            string[] listeDesChoix = { "Permutation ...................... 1", "Arrangement ...................... 2", "Combinaison ...................... 3", "Quitter .......................... 0", "Choix :                            " };
            string msgErreurChoix = "Erreur de saisie. Merci de choisir un element dans la liste";
            string elementsAGerer = "nombre total d'éléments à gérer =";
            string sousEnsemble = "nombre d'éléments dans le sous ensemble = ";
            string msgErreurInt = "Erreur de saisie. Merci de saisir un nombre réel entier";
            int valeurIntUtilisateur1;
            int valeurIntUtilisateur2;
            long resultat;
            long resultat2;
            while (choixUtilisateur != 0)
            {
                choixUtilisateur = CaptureEntreeInt(listeDesChoix, msgErreurChoix);
                switch (choixUtilisateur)
                {
                    case 1: 
                        //Code pour un permutation
                        valeurIntUtilisateur1 = CaptureEntreeInt(elementsAGerer, msgErreurInt);
                        resultat = LoopMultiplication(valeurIntUtilisateur1);
                        Console.WriteLine(valeurIntUtilisateur1 + "! = " + resultat);
                        break;
                    case 2: 
                        //Code pour un arrangement
                        valeurIntUtilisateur1 = CaptureEntreeInt(elementsAGerer, msgErreurInt);
                        valeurIntUtilisateur2 = CaptureEntreeInt(sousEnsemble, msgErreurInt);
                        resultat = LoopMultiplication(valeurIntUtilisateur1, valeurIntUtilisateur2);
                        Console.WriteLine("A(" + valeurIntUtilisateur1 + "/" + valeurIntUtilisateur2 + " = " + resultat + ")");
                        break;
                    case 3: 
                        // Code pour un combinaison
                        valeurIntUtilisateur1 = CaptureEntreeInt(elementsAGerer, msgErreurInt);
                        valeurIntUtilisateur2 = CaptureEntreeInt(sousEnsemble, msgErreurInt);
                        resultat = LoopMultiplication(valeurIntUtilisateur1, valeurIntUtilisateur2);
                        resultat2 = LoopMultiplication(valeurIntUtilisateur2);
                        Console.WriteLine("C(" + valeurIntUtilisateur1 + "/" + valeurIntUtilisateur2 + ") = " + (resultat / resultat2) + ")");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(msgErreurChoix);
                        break;
                }
            }
            Environment.Exit(0);
        }
    }
}
