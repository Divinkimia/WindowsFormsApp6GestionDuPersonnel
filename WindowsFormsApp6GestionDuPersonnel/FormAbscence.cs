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
    public partial class FmAbscenece : Form
    {
        bool flagQuitter = true;
        public FmAbscenece()
        {
            InitializeComponent();
        }

        private void FmAbscenece_FormClosed(object sender, FormClosedEventArgs e)
        {  
            flagQuitter = false;
            FmAbscenece fmm = new FmAbscenece();
            fmm.Show();
        }
    }
    
}
