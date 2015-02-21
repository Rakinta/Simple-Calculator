using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphique1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]   
        static void Main()
        {

            // Auteur Antonin 'Rakinta' DESFONTAINES
            // Distribution non autorisée sans l'accord explicite de l'auteur.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("DEBUG : Calculatrice");
            Application.Run(new Form1());

        }
    }
}
