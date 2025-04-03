using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GestionDuPersonnel
{
    public partial class fmEmploye : Form
    {
        public fmEmploye()
        {
            InitializeComponent();
        }

        /*
        private void fmEmploye_Load(object sender, EventArgs e)
        {
            DataLoad();
            InitialisationContoles();
        }
        */

        private void FmEmploye_Load(object sender, EventArgs e)
        {
            DataLoad();
            InitialisationContoles();
        }


        private void DataLoad()
        {
            listViewEmploye.Items.Clear(); // Permet d'effacer les itemes avant la recharge de recharger les données

            try
            {
                string sql = $"SELECT * FROM employe ORDER BY emp_nss";

                // pour la création d'1 objet command
                SqlCommand cmd = new SqlCommand();

                // Permet d'etablir la connexion de ma commande
                cmd.Connection = Program.connexionBdd;

                // pour saisir la requet sql voulu
                cmd.CommandText = sql;

                // Me permet d'executer et de stocker mes resultat 
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employe unEmploye = new Employe(reader);

                        string[] row = new string[] { unEmploye.GetEmpNss(), unEmploye.GetEmpNom(), unEmploye.GetEmpPrenom(), unEmploye.GetEmpSalaire().ToString() };
                        var lvItems = new ListViewItem(row);

                        listViewEmploye.Items.Add(lvItems);
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données. \n" + exception.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FmEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmService fms = new fmService(); // Création d'une instance à l'affichage
            fms.Show(); // affichage du nouveau formulaire 
            Application.Exit(); //Sortir du programme
        }

        private void lbQalifEmploye_Click(object sender, EventArgs e)
        {

        }



        private void AfficherListeServices(string idService)
        {
            try
            {
                string sql = "SELECT * from Service ORDER BY sce_code";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.connexionBdd;
                command.CommandText = sql;

                int indexItem = 0;
                cbServiceEmploye.Items.Clear();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Service unService = new Service(reader);
                        cbServiceEmploye.Items.Add(new { Text = unService.GetSceDes(), Value = unService.GetSceCode() });

                        if (unService.GetSceCode() == idService)
                        {
                            indexItem = (cbServiceEmploye.Items.Count - 1);
                        }

                        cbServiceEmploye.SelectedIndex = indexItem;

                        cbServiceEmploye.DisplayMember = "Text";
                        cbServiceEmploye.ValueMember = "Value";
                    }
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données. \n" + exception.Message, "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitialisationContoles()
        {
            //Pour le Verrouillage des controles (Button , TexBox et RadioButton)
            tbNssEmploye.ReadOnly = true;
            tbNssEmploye.Clear();

            tbNomEmploye.ReadOnly = true;
            tbNomEmploye.Clear();

            tbPrenomEmploye.ReadOnly = true;
            tbPrenomEmploye.Clear();

            tbSalaireEmploye.ReadOnly = true;
            tbSalaireEmploye.Clear();



            cbServiceEmploye.Enabled = false;


            btModifierEmploye.Enabled = false;
            btEnregistrerEmploye.Enabled = false;
            btSupprimerEmploye.Enabled = false;

            //Prement l'activation du bouton  "Nouveau"
            btNouveauEmploye.Enabled = true;
        }


        private void listViewEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btNouveauEmploye_Click(object sender, EventArgs e)
        {
            btNouveauEmploye.Enabled = true;
            btEnregistrerEmploye.Enabled = true;
            btSupprimerEmploye.Enabled = true;




            tbNssEmploye.ReadOnly = false; // pour faire passer en écriture ( il parmet maintenant de saisir ) ref not de  

            tbNomEmploye.ReadOnly = false; // pour faire passer en écriture(il parmet maintenant de saisir) ref not de  
            tbNomEmploye.ForeColor = Color.Black;


            tbPrenomEmploye.ReadOnly = false; // pour faire passer en écriture ( il parmet maintenant de saisir ) ref not de  
            tbPrenomEmploye.ForeColor = Color.Black;

            tbSalaireEmploye.ReadOnly = false; // pour faire passer en écriture ( il parmet maintenant de saisir ) ref not de  
            tbSalaireEmploye.ForeColor = Color.Black;





            // Pour effacer directement une fois que j'ai ajouter 
            tbNssEmploye.Text = "";
            tbNomEmploye.Text = "";
            tbPrenomEmploye.Text = "";
            btSupprimerEmploye.Text = "";


        }

        private void listViewEmploye_Click(object sender, EventArgs e)
        {
            tbNssEmploye.ReadOnly = true;
            tbNssEmploye.ForeColor = Color.Black;
            tbNssEmploye.Clear();

            tbNomEmploye.ReadOnly = true;
            tbNomEmploye.ForeColor = Color.Black;
            tbNomEmploye.Clear();

            tbPrenomEmploye.ReadOnly = true;
            tbPrenomEmploye.ForeColor = Color.Black;
            tbPrenomEmploye.Clear();

            tbSalaireEmploye.ReadOnly = true;
            tbSalaireEmploye.ForeColor = Color.Black;
            tbSalaireEmploye.Clear();

            cbServiceEmploye.Enabled = false;

            btNouveauEmploye.Enabled = true;
            btModifierEmploye.Enabled = true;
            btEnregistrerEmploye.Enabled = false;
            btSupprimerEmploye.Enabled = true;


            if (listViewEmploye.SelectedItems.Count != 0)
            {
                string emp_nss = listViewEmploye.SelectedItems[0].SubItems[0].Text;

                try
                {
                    string sql = $"SELECT * FROM Employe WHERE emp_nss = '{emp_nss}'";
                    Employe unEmploye = null;

                    // Pour la création de l'objet Command 
                    SqlCommand cmd = new SqlCommand();

                    // Pour établir la connexion à la commande 
                    cmd.Connection = Program.connexionBdd;

                    // Pour la saisi de la requette sql voulue 
                    cmd.CommandText = sql;

                    // Pour excuter le tout et stocker le resultat dans le reader
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            unEmploye = new Employe(reader);
                            tbNssEmploye.Text = unEmploye.GetEmpNss();
                            tbNomEmploye.Text = unEmploye.GetEmpNom();
                            tbPrenomEmploye.Text = unEmploye.GetEmpPrenom();

                            tbSalaireEmploye.Text = unEmploye.GetEmpSalaire().ToString();


                        }
                    }
                    reader.Close();

                    AfficherListeServices(unEmploye.GetEmpSce());


                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur d'accès à la base de données. \n" + exception.Message, "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void listViewEmploye_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btModifierEmploye_Click(object sender, EventArgs e)
        {
        }

        private void btEnregistrerEmploye_Click(object sender, EventArgs e)
        {
        }

        private void btSupprimerEmploye_Click(object sender, EventArgs e)
        {
        }

    }
}
