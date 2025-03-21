using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GestionDuPersonnel
{
    public partial class FmEmploye : Form
    {
        public FmEmploye()
        {
            InitializeComponent();
        }

        private void FmEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmService fms = new fmService(); // Création d'une instance à l'affichage
            fms.Show(); // affichage du nouveau formulaire 
            Application.Exit(); //Sortir du programme
        }

        
    }
}
