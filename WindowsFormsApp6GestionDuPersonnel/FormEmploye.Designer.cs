namespace WindowsFormsApp6GestionDuPersonnel
{
    partial class fmEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNouveauEmploye = new System.Windows.Forms.Button();
            this.btModifierEmploye = new System.Windows.Forms.Button();
            this.btEnregistrerEmploye = new System.Windows.Forms.Button();
            this.btSupprimerEmploye = new System.Windows.Forms.Button();
            this.lbNssEmploye = new System.Windows.Forms.Label();
            this.lbNomEmploye = new System.Windows.Forms.Label();
            this.lbPrenomEmploye = new System.Windows.Forms.Label();
            this.lbSalaireEmploye = new System.Windows.Forms.Label();
            this.lbQalifEmploye = new System.Windows.Forms.Label();
            this.lbServiceEmploye = new System.Windows.Forms.Label();
            this.tbNssEmploye = new System.Windows.Forms.TextBox();
            this.tbNomEmploye = new System.Windows.Forms.TextBox();
            this.tbPrenomEmploye = new System.Windows.Forms.TextBox();
            this.tbSalaireEmploye = new System.Windows.Forms.TextBox();
            this.tbQualifEmploye = new System.Windows.Forms.TextBox();
            this.listViewEmploye = new System.Windows.Forms.ListView();
            this.chNssEmploye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNomEmploye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrenomEmploye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSalaireEmploye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQalificationEmploye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceEmploye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbServiceEmploye = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btNouveauEmploye
            // 
            this.btNouveauEmploye.Location = new System.Drawing.Point(669, 29);
            this.btNouveauEmploye.Name = "btNouveauEmploye";
            this.btNouveauEmploye.Size = new System.Drawing.Size(100, 36);
            this.btNouveauEmploye.TabIndex = 0;
            this.btNouveauEmploye.Text = "Nouveau";
            this.btNouveauEmploye.UseVisualStyleBackColor = true;
            this.btNouveauEmploye.Click += new System.EventHandler(this.btNouveauEmploye_Click);
            // 
            // btModifierEmploye
            // 
            this.btModifierEmploye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btModifierEmploye.Location = new System.Drawing.Point(669, 93);
            this.btModifierEmploye.Name = "btModifierEmploye";
            this.btModifierEmploye.Size = new System.Drawing.Size(100, 38);
            this.btModifierEmploye.TabIndex = 1;
            this.btModifierEmploye.Text = "Modifier";
            this.btModifierEmploye.UseVisualStyleBackColor = true;
            this.btModifierEmploye.Click += new System.EventHandler(this.btModifierEmploye_Click);
            // 
            // btEnregistrerEmploye
            // 
            this.btEnregistrerEmploye.Location = new System.Drawing.Point(669, 159);
            this.btEnregistrerEmploye.Name = "btEnregistrerEmploye";
            this.btEnregistrerEmploye.Size = new System.Drawing.Size(100, 38);
            this.btEnregistrerEmploye.TabIndex = 2;
            this.btEnregistrerEmploye.Text = "Enregistrer";
            this.btEnregistrerEmploye.UseVisualStyleBackColor = true;
            this.btEnregistrerEmploye.Click += new System.EventHandler(this.btEnregistrerEmploye_Click);
            // 
            // btSupprimerEmploye
            // 
            this.btSupprimerEmploye.Location = new System.Drawing.Point(669, 233);
            this.btSupprimerEmploye.Name = "btSupprimerEmploye";
            this.btSupprimerEmploye.Size = new System.Drawing.Size(100, 42);
            this.btSupprimerEmploye.TabIndex = 3;
            this.btSupprimerEmploye.Text = "Supprimer";
            this.btSupprimerEmploye.UseVisualStyleBackColor = true;
            this.btSupprimerEmploye.Click += new System.EventHandler(this.btSupprimerEmploye_Click);
            // 
            // lbNssEmploye
            // 
            this.lbNssEmploye.AutoSize = true;
            this.lbNssEmploye.Location = new System.Drawing.Point(33, 29);
            this.lbNssEmploye.Name = "lbNssEmploye";
            this.lbNssEmploye.Size = new System.Drawing.Size(35, 13);
            this.lbNssEmploye.TabIndex = 4;
            this.lbNssEmploye.Text = "NSS :";
            // 
            // lbNomEmploye
            // 
            this.lbNomEmploye.AutoSize = true;
            this.lbNomEmploye.Location = new System.Drawing.Point(33, 68);
            this.lbNomEmploye.Name = "lbNomEmploye";
            this.lbNomEmploye.Size = new System.Drawing.Size(35, 13);
            this.lbNomEmploye.TabIndex = 5;
            this.lbNomEmploye.Text = "Nom :";
            // 
            // lbPrenomEmploye
            // 
            this.lbPrenomEmploye.AutoSize = true;
            this.lbPrenomEmploye.Location = new System.Drawing.Point(33, 118);
            this.lbPrenomEmploye.Name = "lbPrenomEmploye";
            this.lbPrenomEmploye.Size = new System.Drawing.Size(49, 13);
            this.lbPrenomEmploye.TabIndex = 6;
            this.lbPrenomEmploye.Text = "Prénom :";
            // 
            // lbSalaireEmploye
            // 
            this.lbSalaireEmploye.AutoSize = true;
            this.lbSalaireEmploye.Location = new System.Drawing.Point(33, 172);
            this.lbSalaireEmploye.Name = "lbSalaireEmploye";
            this.lbSalaireEmploye.Size = new System.Drawing.Size(45, 13);
            this.lbSalaireEmploye.TabIndex = 7;
            this.lbSalaireEmploye.Text = "Salaire :";
            // 
            // lbQalifEmploye
            // 
            this.lbQalifEmploye.AutoSize = true;
            this.lbQalifEmploye.Location = new System.Drawing.Point(33, 213);
            this.lbQalifEmploye.Name = "lbQalifEmploye";
            this.lbQalifEmploye.Size = new System.Drawing.Size(71, 13);
            this.lbQalifEmploye.TabIndex = 8;
            this.lbQalifEmploye.Text = "Qualification :";
            this.lbQalifEmploye.Click += new System.EventHandler(this.lbQalifEmploye_Click);
            // 
            // lbServiceEmploye
            // 
            this.lbServiceEmploye.AutoSize = true;
            this.lbServiceEmploye.Location = new System.Drawing.Point(33, 262);
            this.lbServiceEmploye.Name = "lbServiceEmploye";
            this.lbServiceEmploye.Size = new System.Drawing.Size(49, 13);
            this.lbServiceEmploye.TabIndex = 9;
            this.lbServiceEmploye.Text = "Service :";
            // 
            // tbNssEmploye
            // 
            this.tbNssEmploye.Location = new System.Drawing.Point(131, 29);
            this.tbNssEmploye.Name = "tbNssEmploye";
            this.tbNssEmploye.Size = new System.Drawing.Size(175, 20);
            this.tbNssEmploye.TabIndex = 10;
            // 
            // tbNomEmploye
            // 
            this.tbNomEmploye.Location = new System.Drawing.Point(131, 68);
            this.tbNomEmploye.Name = "tbNomEmploye";
            this.tbNomEmploye.Size = new System.Drawing.Size(285, 20);
            this.tbNomEmploye.TabIndex = 11;
            // 
            // tbPrenomEmploye
            // 
            this.tbPrenomEmploye.Location = new System.Drawing.Point(131, 111);
            this.tbPrenomEmploye.Name = "tbPrenomEmploye";
            this.tbPrenomEmploye.Size = new System.Drawing.Size(285, 20);
            this.tbPrenomEmploye.TabIndex = 12;
            // 
            // tbSalaireEmploye
            // 
            this.tbSalaireEmploye.Location = new System.Drawing.Point(131, 169);
            this.tbSalaireEmploye.Name = "tbSalaireEmploye";
            this.tbSalaireEmploye.Size = new System.Drawing.Size(100, 20);
            this.tbSalaireEmploye.TabIndex = 13;
            // 
            // tbQualifEmploye
            // 
            this.tbQualifEmploye.Location = new System.Drawing.Point(131, 210);
            this.tbQualifEmploye.Name = "tbQualifEmploye";
            this.tbQualifEmploye.Size = new System.Drawing.Size(70, 20);
            this.tbQualifEmploye.TabIndex = 14;
            // 
            // listViewEmploye
            // 
            this.listViewEmploye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNssEmploye,
            this.chNomEmploye,
            this.chPrenomEmploye,
            this.chSalaireEmploye,
            this.chQalificationEmploye,
            this.chServiceEmploye});
            this.listViewEmploye.FullRowSelect = true;
            this.listViewEmploye.GridLines = true;
            this.listViewEmploye.HideSelection = false;
            this.listViewEmploye.Location = new System.Drawing.Point(36, 308);
            this.listViewEmploye.Name = "listViewEmploye";
            this.listViewEmploye.Size = new System.Drawing.Size(677, 130);
            this.listViewEmploye.TabIndex = 16;
            this.listViewEmploye.UseCompatibleStateImageBehavior = false;
            this.listViewEmploye.View = System.Windows.Forms.View.Details;
            this.listViewEmploye.Click += new System.EventHandler(this.listViewEmploye_Click);
            // 
            // chNssEmploye
            // 
            this.chNssEmploye.Text = "NSS";
            this.chNssEmploye.Width = 119;
            // 
            // chNomEmploye
            // 
            this.chNomEmploye.Text = "Nom";
            this.chNomEmploye.Width = 106;
            // 
            // chPrenomEmploye
            // 
            this.chPrenomEmploye.Text = "Prenom";
            this.chPrenomEmploye.Width = 119;
            // 
            // chSalaireEmploye
            // 
            this.chSalaireEmploye.Text = "Salaire";
            this.chSalaireEmploye.Width = 96;
            // 
            // chQalificationEmploye
            // 
            this.chQalificationEmploye.Text = "Qalification";
            this.chQalificationEmploye.Width = 117;
            // 
            // chServiceEmploye
            // 
            this.chServiceEmploye.Text = "Service";
            this.chServiceEmploye.Width = 160;
            // 
            // cbServiceEmploye
            // 
            this.cbServiceEmploye.FormattingEnabled = true;
            this.cbServiceEmploye.Location = new System.Drawing.Point(131, 262);
            this.cbServiceEmploye.Name = "cbServiceEmploye";
            this.cbServiceEmploye.Size = new System.Drawing.Size(121, 21);
            this.cbServiceEmploye.TabIndex = 17;
            // 
            // fmEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbServiceEmploye);
            this.Controls.Add(this.listViewEmploye);
            this.Controls.Add(this.tbQualifEmploye);
            this.Controls.Add(this.tbSalaireEmploye);
            this.Controls.Add(this.tbPrenomEmploye);
            this.Controls.Add(this.tbNomEmploye);
            this.Controls.Add(this.tbNssEmploye);
            this.Controls.Add(this.lbServiceEmploye);
            this.Controls.Add(this.lbQalifEmploye);
            this.Controls.Add(this.lbSalaireEmploye);
            this.Controls.Add(this.lbPrenomEmploye);
            this.Controls.Add(this.lbNomEmploye);
            this.Controls.Add(this.lbNssEmploye);
            this.Controls.Add(this.btSupprimerEmploye);
            this.Controls.Add(this.btEnregistrerEmploye);
            this.Controls.Add(this.btModifierEmploye);
            this.Controls.Add(this.btNouveauEmploye);
            this.Name = "fmEmploye";
            this.Text = "Employe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmEmploye_FormClosed);
            this.Load += new System.EventHandler(this.FmEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNouveauEmploye;
        private System.Windows.Forms.Button btModifierEmploye;
        private System.Windows.Forms.Button btEnregistrerEmploye;
        private System.Windows.Forms.Button btSupprimerEmploye;
        private System.Windows.Forms.Label lbNssEmploye;
        private System.Windows.Forms.Label lbNomEmploye;
        private System.Windows.Forms.Label lbPrenomEmploye;
        private System.Windows.Forms.Label lbSalaireEmploye;
        private System.Windows.Forms.Label lbQalifEmploye;
        private System.Windows.Forms.Label lbServiceEmploye;
        private System.Windows.Forms.TextBox tbNssEmploye;
        private System.Windows.Forms.TextBox tbNomEmploye;
        private System.Windows.Forms.TextBox tbPrenomEmploye;
        private System.Windows.Forms.TextBox tbSalaireEmploye;
        private System.Windows.Forms.TextBox tbQualifEmploye;
        private System.Windows.Forms.ListView listViewEmploye;
        private System.Windows.Forms.ComboBox cbServiceEmploye;
        private System.Windows.Forms.ColumnHeader chNssEmploye;
        private System.Windows.Forms.ColumnHeader chNomEmploye;
        private System.Windows.Forms.ColumnHeader chPrenomEmploye;
        private System.Windows.Forms.ColumnHeader chSalaireEmploye;
        private System.Windows.Forms.ColumnHeader chQalificationEmploye;
        private System.Windows.Forms.ColumnHeader chServiceEmploye;
    }
}