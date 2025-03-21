using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GestionDuPersonnel
{
    public partial class FmMenu : Form
    { 
        bool flagQuitter = true;
        public FmMenu()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void picBoxMenu_Click(object sender, EventArgs e)
        {

        }

        private void btMenuServices_Click(object sender, EventArgs e)
        {
            flagQuitter = false;

            fmService fms = new fmService(); // Création d'une instance à l'affichage
            fms.Show(); // affichage du nouveau formulaire 
            Close(); // fermeture du formulaire en cours (menu) 
        }

        private void FmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flagQuitter == true) // Quiter l'application 
            {
                Program.connexionBdd.Close(); // Fermeture de connecion à la base de données (bdb)
                Application.Exit(); //Sortir du programme
            }

            
        }

        private void btMenuEmploiyes_Click(object sender, EventArgs e)
        {

        }
    }
}
