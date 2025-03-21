using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GestionDuPersonnel
{
    internal static partial class Program
    {

        public static SqlConnection connexionBdd; // permet une connection globale

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            try
            {
                connexionBdd = ConnexionBdd.GetDBConnexion();
                connexionBdd.Open();
            }
            catch (Exception e) 
            {
                MessageBox.Show("Erreur de connexion à la base de données. \nDetails : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Etape fais dans la premère parti Application.Run(new fmService());


            //Ici excecution du changement de formulaire au demarrage de l'application pagessage de FmService à Fm_Menu
            FmMenu fmMenu = new FmMenu();
            fmMenu.Show();

            Application.Run();
        }
    }
}
