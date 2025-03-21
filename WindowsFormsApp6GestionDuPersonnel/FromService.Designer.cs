namespace WindowsFormsApp6GestionDuPersonnel
{
    partial class fmService
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_CodeService = new System.Windows.Forms.TextBox();
            this.tb_DesignationService = new System.Windows.Forms.TextBox();
            this.tb_BudgetService = new System.Windows.Forms.TextBox();
            this.lb_CodeService = new System.Windows.Forms.Label();
            this.lb_Designation = new System.Windows.Forms.Label();
            this.lb_TypeService = new System.Windows.Forms.Label();
            this.lb_BudgetService = new System.Windows.Forms.Label();
            this.btNouveauService = new System.Windows.Forms.Button();
            this.btModifierService = new System.Windows.Forms.Button();
            this.btEnregistrerService = new System.Windows.Forms.Button();
            this.btSupprimerService = new System.Windows.Forms.Button();
            this.rbTypeAdministratif = new System.Windows.Forms.RadioButton();
            this.rbTypeProductif = new System.Windows.Forms.RadioButton();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desigantion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tb_CodeService
            // 
            this.tb_CodeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodeService.Location = new System.Drawing.Point(174, 47);
            this.tb_CodeService.Name = "tb_CodeService";
            this.tb_CodeService.Size = new System.Drawing.Size(100, 22);
            this.tb_CodeService.TabIndex = 0;
            // 
            // tb_DesignationService
            // 
            this.tb_DesignationService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DesignationService.Location = new System.Drawing.Point(174, 95);
            this.tb_DesignationService.Name = "tb_DesignationService";
            this.tb_DesignationService.Size = new System.Drawing.Size(275, 22);
            this.tb_DesignationService.TabIndex = 1;
            // 
            // tb_BudgetService
            // 
            this.tb_BudgetService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BudgetService.Location = new System.Drawing.Point(174, 219);
            this.tb_BudgetService.Name = "tb_BudgetService";
            this.tb_BudgetService.Size = new System.Drawing.Size(100, 22);
            this.tb_BudgetService.TabIndex = 2;
            // 
            // lb_CodeService
            // 
            this.lb_CodeService.AutoSize = true;
            this.lb_CodeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CodeService.Location = new System.Drawing.Point(57, 47);
            this.lb_CodeService.Name = "lb_CodeService";
            this.lb_CodeService.Size = new System.Drawing.Size(111, 20);
            this.lb_CodeService.TabIndex = 3;
            this.lb_CodeService.Text = "Code Service :";
            // 
            // lb_Designation
            // 
            this.lb_Designation.AutoSize = true;
            this.lb_Designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Designation.Location = new System.Drawing.Point(57, 95);
            this.lb_Designation.Name = "lb_Designation";
            this.lb_Designation.Size = new System.Drawing.Size(102, 20);
            this.lb_Designation.TabIndex = 4;
            this.lb_Designation.Text = "Designation :";
            // 
            // lb_TypeService
            // 
            this.lb_TypeService.AutoSize = true;
            this.lb_TypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypeService.Location = new System.Drawing.Point(57, 139);
            this.lb_TypeService.Name = "lb_TypeService";
            this.lb_TypeService.Size = new System.Drawing.Size(51, 20);
            this.lb_TypeService.TabIndex = 5;
            this.lb_TypeService.Text = "Type :";
            // 
            // lb_BudgetService
            // 
            this.lb_BudgetService.AutoSize = true;
            this.lb_BudgetService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BudgetService.Location = new System.Drawing.Point(57, 219);
            this.lb_BudgetService.Name = "lb_BudgetService";
            this.lb_BudgetService.Size = new System.Drawing.Size(69, 20);
            this.lb_BudgetService.TabIndex = 6;
            this.lb_BudgetService.Text = "Budget :";
            // 
            // btNouveauService
            // 
            this.btNouveauService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNouveauService.Location = new System.Drawing.Point(641, 74);
            this.btNouveauService.Name = "btNouveauService";
            this.btNouveauService.Size = new System.Drawing.Size(90, 41);
            this.btNouveauService.TabIndex = 7;
            this.btNouveauService.Text = "Nouveau";
            this.btNouveauService.UseVisualStyleBackColor = true;
            // 
            // btModifierService
            // 
            this.btModifierService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifierService.Location = new System.Drawing.Point(641, 139);
            this.btModifierService.Name = "btModifierService";
            this.btModifierService.Size = new System.Drawing.Size(90, 41);
            this.btModifierService.TabIndex = 8;
            this.btModifierService.Text = "Modifier";
            this.btModifierService.UseVisualStyleBackColor = true;
            // 
            // btEnregistrerService
            // 
            this.btEnregistrerService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrerService.Location = new System.Drawing.Point(641, 199);
            this.btEnregistrerService.Name = "btEnregistrerService";
            this.btEnregistrerService.Size = new System.Drawing.Size(90, 40);
            this.btEnregistrerService.TabIndex = 9;
            this.btEnregistrerService.Text = "Enregistrer";
            this.btEnregistrerService.UseVisualStyleBackColor = true;
            // 
            // btSupprimerService
            // 
            this.btSupprimerService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerService.Location = new System.Drawing.Point(641, 263);
            this.btSupprimerService.Name = "btSupprimerService";
            this.btSupprimerService.Size = new System.Drawing.Size(90, 40);
            this.btSupprimerService.TabIndex = 10;
            this.btSupprimerService.Text = "Supprimer";
            this.btSupprimerService.UseVisualStyleBackColor = true;
            // 
            // rbTypeAdministratif
            // 
            this.rbTypeAdministratif.AutoSize = true;
            this.rbTypeAdministratif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTypeAdministratif.Location = new System.Drawing.Point(174, 139);
            this.rbTypeAdministratif.Name = "rbTypeAdministratif";
            this.rbTypeAdministratif.Size = new System.Drawing.Size(106, 22);
            this.rbTypeAdministratif.TabIndex = 11;
            this.rbTypeAdministratif.TabStop = true;
            this.rbTypeAdministratif.Text = "Administratif";
            this.rbTypeAdministratif.UseVisualStyleBackColor = true;
            // 
            // rbTypeProductif
            // 
            this.rbTypeProductif.AutoSize = true;
            this.rbTypeProductif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTypeProductif.Location = new System.Drawing.Point(174, 181);
            this.rbTypeProductif.Name = "rbTypeProductif";
            this.rbTypeProductif.Size = new System.Drawing.Size(85, 22);
            this.rbTypeProductif.TabIndex = 12;
            this.rbTypeProductif.TabStop = true;
            this.rbTypeProductif.Text = "Productif";
            this.rbTypeProductif.UseVisualStyleBackColor = true;
            // 
            // listViewServices
            // 
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Desigantion,
            this.Type,
            this.Budget});
            this.listViewServices.FullRowSelect = true;
            this.listViewServices.GridLines = true;
            this.listViewServices.HideSelection = false;
            this.listViewServices.Location = new System.Drawing.Point(24, 280);
            this.listViewServices.MultiSelect = false;
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(433, 158);
            this.listViewServices.TabIndex = 13;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            this.listViewServices.SelectedIndexChanged += new System.EventHandler(this.listViewServices_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 69;
            // 
            // Desigantion
            // 
            this.Desigantion.Text = "Desigantion";
            this.Desigantion.Width = 134;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 142;
            // 
            // Budget
            // 
            this.Budget.Text = "Budget";
            this.Budget.Width = 82;
            // 
            // fmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewServices);
            this.Controls.Add(this.rbTypeProductif);
            this.Controls.Add(this.rbTypeAdministratif);
            this.Controls.Add(this.btSupprimerService);
            this.Controls.Add(this.btEnregistrerService);
            this.Controls.Add(this.btModifierService);
            this.Controls.Add(this.btNouveauService);
            this.Controls.Add(this.lb_BudgetService);
            this.Controls.Add(this.lb_TypeService);
            this.Controls.Add(this.lb_Designation);
            this.Controls.Add(this.lb_CodeService);
            this.Controls.Add(this.tb_BudgetService);
            this.Controls.Add(this.tb_DesignationService);
            this.Controls.Add(this.tb_CodeService);
            this.Name = "fmService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.fmService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CodeService;
        private System.Windows.Forms.TextBox tb_DesignationService;
        private System.Windows.Forms.TextBox tb_BudgetService;
        private System.Windows.Forms.Label lb_CodeService;
        private System.Windows.Forms.Label lb_Designation;
        private System.Windows.Forms.Label lb_TypeService;
        private System.Windows.Forms.Label lb_BudgetService;
        private System.Windows.Forms.Button btNouveauService;
        private System.Windows.Forms.Button btModifierService;
        private System.Windows.Forms.Button btEnregistrerService;
        private System.Windows.Forms.Button btSupprimerService;
        private System.Windows.Forms.RadioButton rbTypeAdministratif;
        private System.Windows.Forms.RadioButton rbTypeProductif;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Desigantion;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Budget;
    }
}

