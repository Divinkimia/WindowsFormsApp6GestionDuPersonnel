using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GestionDuPersonnel
{
    public partial class fmService : Form
    {
        public fmService()
        {
            InitializeComponent();
        }

        private void fmService_Load(object sender, EventArgs e)
        {
            DataLoad();
            InitialisationContoles();
        }

        private void DataLoad()
        {
            listViewServices.Items.Clear(); // Permet d'effacer les itemes avant la recharge de recharger les données

            try
            {
                string sql = $"SELECT * FROM service ORDER BY sce_code";

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
                        Service unService = new Service(reader);

                        string[] row = new string[] { unService.GetSceCode(), unService.GetSceDes(), unService.GetSceType(), unService.GetSceBudget().ToString()};
                        var lvItems = new ListViewItem(row);

                        listViewServices.Items.Add(lvItems);
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
            tb_CodeService.ReadOnly = true;
            tb_CodeService.Clear();
            tb_DesignationService.ReadOnly = true;
            tb_DesignationService.Clear();
            tb_BudgetService.ReadOnly = true;
            tb_BudgetService.Clear();

            rbTypeAdministratif.Enabled = false;
            rbTypeAdministratif.Checked = false;
            rbTypeProductif.Enabled = false;
            rbTypeProductif.Checked = false;

            btModifierService.Enabled = false;
            btEnregistrerService.Enabled = false;
            btSupprimerService.Enabled = false;

            //Prement l'activation du bouton  "Nouveau"
            btNouveauService.Enabled = true;
        }

        private void listViewServices_Click(object sender, EventArgs e) 
        {
            // Pour le verrouillage des controles (Button , TexBox et ComboBox)
            tb_CodeService.ReadOnly = true;
            tb_CodeService.ForeColor = Color.Black;
            tb_CodeService.Clear();

            tb_DesignationService.ReadOnly = true;
            tb_DesignationService.ForeColor = Color.Black;
            tb_DesignationService.Clear();

            tb_BudgetService.ReadOnly= true;
            tb_BudgetService.ForeColor = Color.Black;
            tb_BudgetService.Clear();

            rbTypeAdministratif.Enabled = false;
            rbTypeProductif.Enabled= false;

            btEnregistrerService.Enabled = false;

            // Pour activer les boutons ( Nouveau , Modifier, et Suprimmer ) 
            btNouveauService.Enabled = true;
            btModifierService.Enabled = true;
            btSupprimerService.Enabled = true;

        if (listViewServices.SelectedItems.Count!=0)
        {
            string codeService = listViewServices.SelectedItems[0].SubItems[0].Text;

                try
                {
                    string sql = $"SELECT * FROM service WHERE sce_code = '{codeService}'";
                    Service unService = null;

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
                            unService = new Service(reader);
                            tb_CodeService.Text = unService.GetSceCode().ToString();
                            tb_DesignationService.Text = unService.GetSceDes();

                            tb_BudgetService.Text = unService.GetSceBudget().ToString();

                            if (unService.GetSceType() == "administratif")
                            {
                                rbTypeAdministratif.Checked = true;
                            }
                            else
                            {
                                rbTypeProductif.Checked = true;
                            }
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

        }

        private void listViewServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btNouveauService_Click(object sender, EventArgs e)
        {
            btNouveauService.Enabled = true;
            btEnregistrerService.Enabled = true;
            btSupprimerService.Enabled = true;
            rbTypeAdministratif.Enabled = true;
            rbTypeProductif .Enabled = true;

            // Pour effacer directement une fois que j'ai ajouter 
            tb_CodeService.Text = ""; 
            tb_BudgetService.Text = "";
            tb_DesignationService.Text = "";
            
        }

        private void btModifierService_Click(object sender, EventArgs e)
        {
            btNouveauService.Enabled = true;
            btEnregistrerService.Enabled = true;
            btSupprimerService.Enabled = true;
            rbTypeAdministratif.Enabled = true;
            rbTypeProductif.Enabled = true;
            tb_CodeService.Enabled = true;
            tb_BudgetService.Enabled = true;
            tb_DesignationService.Enabled = true;
            rbTypeProductif.Enabled = true;
            rbTypeAdministratif.Enabled = true;
        }
    }
}
