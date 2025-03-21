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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            tb_CodeService.ReadOnly = true; //  Mise en impossibiliter de saisi uniquement la lecture dans  mon text box code service 
            tb_CodeService.ForeColor = Color.Black;
            tb_CodeService.Clear();

            tb_DesignationService.ReadOnly = true; //  Mise en impossibiliter de saisi uniquement la lecture dans  mon text box designation 
            tb_DesignationService.ForeColor = Color.Black;
            tb_DesignationService.Clear();

            tb_BudgetService.ReadOnly= true; //  Mise en impossibiliter de saisi uniquement la lecture dans on text box budget 
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
            rbTypeProductif.Enabled = true;

            tb_CodeService.ReadOnly = false; // pour faire passer en écriture ( il parmet maintenant de saisir ) ref not de  : private void listViewServices_Click
            tb_CodeService.ForeColor = Color.Black;
           

            tb_DesignationService.ReadOnly = false; // pour faire passer en écriture(il parmet maintenant de saisir) ref not de  : private void listViewServices_Click
            tb_DesignationService.ForeColor = Color.Black;
            

            tb_BudgetService.ReadOnly = false; // pour faire passer en écriture ( il parmet maintenant de saisir ) ref not de  : private void listViewServices_Click
            tb_BudgetService.ForeColor = Color.Black;
            


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


        private void btSupprimerService_Click(object sender, EventArgs e)
        {
           
                // Vérifier si un service est sélectionné
                if (listViewServices.SelectedItems.Count > 0)
                {
                    // Obtenir le code du service sélectionné
                    string codeService = listViewServices.SelectedItems[0].SubItems[0].Text;

                    // Demander une confirmation avant la suppression
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le service avec le code {codeService} ?",
                                                          "Confirmation de suppression",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Requête pour supprimer le service de la base de données
                            string sql = "DELETE FROM service WHERE sce_code = '{codeService}'";

                            // Créer la commande
                            SqlCommand cmd = new SqlCommand
                            {
                                Connection = Program.connexionBdd,
                                CommandText = sql
                            };

                            // Exécuter la requête
                            cmd.ExecuteNonQuery();

                            // Afficher un message de succès
                            MessageBox.Show("Le service a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Rafraîchir la liste des services
                            DataLoad();
                        }
                        catch (Exception exception)
                        {
                        // Gérer les erreurs de connexion ou d'exécution de la requête
                        MessageBox.Show("Erreur d'accès à la base de données. \n" + exception.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un service à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
           

        }

        private void btEnregistrerService_Click(object sender, EventArgs e)
        {
            
                // Vérifier si les champs sont remplis
                if (string.IsNullOrEmpty(tb_CodeService.Text) || string.IsNullOrEmpty(tb_DesignationService.Text) || string.IsNullOrEmpty(tb_BudgetService.Text))
                {
                    MessageBox.Show("Tous les champs (code, désignation, budget) doivent être remplis.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vérifier que le budget est un nombre valide
                if (!decimal.TryParse(tb_BudgetService.Text, out decimal budget))
                {
                    MessageBox.Show("Veuillez entrer un budget valide.", "Budget invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vérifier si le type est sélectionné
                if (!rbTypeAdministratif.Checked && !rbTypeProductif.Checked)
                {
                    MessageBox.Show("Veuillez sélectionner un type de service (administratif ou productif).", "Type non sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Déterminer le type du service sélectionné
                string typeService = rbTypeAdministratif.Checked ? "administratif" : "productif";

                try
                {
                    // Si le service existe déjà (mode modification), effectuer une mise à jour
                    string sql;
                    if (tb_CodeService.ReadOnly)  // Ce cas signifie que nous sommes en mode modification
                    {
                        sql = "UPDATE service SET sce_des = @Designation, sce_budget = @Budget, sce_type = @Type WHERE sce_code = @Code";
                    }
                    else  // Nouveau service (mode création)
                    {
                        sql = "INSERT INTO service (sce_code, sce_des, sce_budget, sce_type) VALUES (@Code, @Designation, @Budget, @Type)";
                    }

                    // Créer la commande SQL
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = Program.connexionBdd,
                        CommandText = sql
                    };

                    // Ajouter les paramètres pour éviter les injections SQL
                    cmd.Parameters.AddWithValue("@Code", tb_CodeService.Text);
                    cmd.Parameters.AddWithValue("@Designation", tb_DesignationService.Text);
                    cmd.Parameters.AddWithValue("@Budget", budget);
                    cmd.Parameters.AddWithValue("@Type", typeService);

                    // Exécuter la commande
                    cmd.ExecuteNonQuery();

                    // Message de succès
                    string message = tb_CodeService.ReadOnly ? "Service mis à jour avec succès." : "Service ajouté avec succès.";
                    MessageBox.Show(message, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Rafraîchir la liste des services
                    DataLoad();

                    // Réinitialiser les contrôles
                    InitialisationContoles();
                }
                catch (Exception ex)
                {
                    // Gérer les erreurs de connexion ou d'exécution de la requête
                    MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

    }
}
