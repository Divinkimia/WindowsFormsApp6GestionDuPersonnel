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
            Application.Run(new fmService());
        }
    }
}
