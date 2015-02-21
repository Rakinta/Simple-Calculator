using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphique1
{
    class calcul
    {

        private static char[] Tabsigne = { '+', '-', '*', '÷' }; //Tableau utilisé dans l'ensemble de la classe
        /// <summary>
        /// Supprime le dernier caractère de la chaine si il y a correspondance.
        /// </summary>
        /// <param name="chaine">Chaine de caractère qui serat vérifié.</param>
        /// <param name="derniercaractere">Vrai si vérifier uniquement le dernier caractère</param>
        /// <returns>Chaine après suppression</returns>
        /// 
        public static string VerificationChaine(string chaine)
        {
            char[] tabCaractereValide = { '+', '-', '*', '÷', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            
            for (int i = 0; i < chaine.Length; i++)
            {
                bool caractereValide = false;

                foreach (var caractere in tabCaractereValide)
                {
                    if (chaine[i] == caractere)
                    {
                        caractereValide = true;
                    }
                }

                if (!caractereValide)
                {
                    Console.WriteLine("Suppression du caractere '" + chaine[i] + "' en position " + i);
                    chaine = chaine.Remove(i, 1);
                }
            }

            return chaine;
        }
        public static string VerificationChaine(string chaine, bool derniercaractere)
        {
            char dernierCaractere = chaine[chaine.Length - 1];
            int dernierPos = chaine.Length - 1;
            char[] Tabsigne = { '+', '-', '*', '÷' };

            for (int i = 0; i < Tabsigne.Length && derniercaractere == true; i++)
            {
                if (dernierCaractere == Tabsigne[i])
                {
                    chaine = chaine.Remove(dernierPos, 1);
                }
            }
            return chaine;
        }
        static char PremierSigne(string chaine)
        {
            int signePos = 999;
            char signe = ' ';
            char[] tabSigne = { '+', '-', '*', '÷' };
            for (int i = 0; i < tabSigne.Length; i++) //Détermine la position du premier signe de la chaine pour calcul.
            {
                //Console.WriteLine(tabSigne[i] + "détecté en" + chaine.IndexOf(tabSigne[i]));
                if (chaine.IndexOf(tabSigne[i]) != -1 && tabSigne[i] < signePos)
                {
                    signePos = chaine.IndexOf(tabSigne[i]);
                    signe = chaine[signePos];
                }
            }
            return signe;
        }
        public static double Calculer(string chaine)
        {
            int signePos = 999;
            bool calculTermine = false;
            double nbr1, nbr2, resultat = 0;

            chaine = calcul.VerificationChaine(chaine); //Enlève si il y a un signe à la fin de la chaine.

            String[] tabCalc = chaine.Split(calcul.Tabsigne); //Stock la chaine dans un tableau avec comme séparateur des signes.
            if (tabCalc.Length < 2)
            {
                resultat = 0;
            }
            else
            {
                do
                {
                    tabCalc = chaine.Split(Tabsigne);

                    signePos = PremierSigne(chaine); //Recupere la position du premier signe de la chaine.
                    nbr1 = double.Parse(tabCalc[0]);
                    nbr2 = double.Parse(tabCalc[1]);
                    int positionSecondChiffre = chaine.IndexOf(nbr2.ToString());
                    switch (PremierSigne(chaine))
                    {
                        case '+':
                            resultat = nbr1 + nbr2;
                            break;
                        case '-':
                            resultat = nbr1 - nbr2;
                            break;
                        case '*':
                            resultat = nbr1 * nbr2;
                            break;
                        case '÷':
                            if (nbr2 == 0)
                            {
                                MessageBox.Show("La division par zéro est impossible !",
                                "Erreur : Division par zéro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                                return 0;
                            }
                            else
                            {
                                resultat = nbr1 / nbr2;
                            }
                            break;
                        default:
                            MessageBox.Show("Erreur: Le calcul a échoué",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            break;
                    }

                    //chaine = chaine.Substring(chaine.IndexOf(nbr2.ToString()), testchaine);
                    Console.WriteLine("chaine avant suppression" + chaine);
                    Console.WriteLine("Chiffre1: " + nbr1 + " le second nombre est " + nbr2 + "\nResultat:" + resultat);

                    if (tabCalc.Length > 2)
                    {
                        chaine = resultat.ToString() + (chaine.Substring(positionSecondChiffre + 1, tabCalc.Length - positionSecondChiffre + 3));
                        Console.WriteLine("chaine apres suppression : " + chaine);
                    }
                    else
                    {
                        calculTermine = true;
                    }
                } while (!calculTermine);
            }


            calculTermine = false;
            return resultat;
        }

    }
}
