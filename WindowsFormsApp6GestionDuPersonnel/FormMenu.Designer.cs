namespace WindowsFormsApp6GestionDuPersonnel
{
    partial class FmMenu
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
            this.btMenuServices = new System.Windows.Forms.Button();
            this.btMenuEmploiyes = new System.Windows.Forms.Button();
            this.btMenuAbscences = new System.Windows.Forms.Button();
            this.lbTitreMenu = new System.Windows.Forms.Label();
            this.picBoxMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenuServices
            // 
            this.btMenuServices.Location = new System.Drawing.Point(509, 86);
            this.btMenuServices.Name = "btMenuServices";
            this.btMenuServices.Size = new System.Drawing.Size(110, 45);
            this.btMenuServices.TabIndex = 0;
            this.btMenuServices.Text = "Services";
            this.btMenuServices.UseVisualStyleBackColor = true;
            this.btMenuServices.Click += new System.EventHandler(this.btMenuServices_Click);
            // 
            // btMenuEmploiyes
            // 
            this.btMenuEmploiyes.Location = new System.Drawing.Point(509, 157);
            this.btMenuEmploiyes.Name = "btMenuEmploiyes";
            this.btMenuEmploiyes.Size = new System.Drawing.Size(110, 46);
            this.btMenuEmploiyes.TabIndex = 1;
            this.btMenuEmploiyes.Text = "Emploiyes";
            this.btMenuEmploiyes.UseVisualStyleBackColor = true;
            this.btMenuEmploiyes.Click += new System.EventHandler(this.btMenuEmploiyes_Click);
            // 
            // btMenuAbscences
            // 
            this.btMenuAbscences.Location = new System.Drawing.Point(509, 231);
            this.btMenuAbscences.Name = "btMenuAbscences";
            this.btMenuAbscences.Size = new System.Drawing.Size(110, 36);
            this.btMenuAbscences.TabIndex = 2;
            this.btMenuAbscences.Text = "Abscences";
            this.btMenuAbscences.UseVisualStyleBackColor = true;
            this.btMenuAbscences.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbTitreMenu
            // 
            this.lbTitreMenu.AutoSize = true;
            this.lbTitreMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreMenu.Location = new System.Drawing.Point(67, 30);
            this.lbTitreMenu.Name = "lbTitreMenu";
            this.lbTitreMenu.Size = new System.Drawing.Size(354, 39);
            this.lbTitreMenu.TabIndex = 3;
            this.lbTitreMenu.Text = "Gestion du personnel ";
            // 
            // picBoxMenu
            // 
            this.picBoxMenu.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxMenu.Image = global::WindowsFormsApp6GestionDuPersonnel.Properties.Resources.rh;
            this.picBoxMenu.Location = new System.Drawing.Point(82, 101);
            this.picBoxMenu.Name = "picBoxMenu";
            this.picBoxMenu.Size = new System.Drawing.Size(339, 181);
            this.picBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMenu.TabIndex = 4;
            this.picBoxMenu.TabStop = false;
            this.picBoxMenu.Click += new System.EventHandler(this.picBoxMenu_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxMenu);
            this.Controls.Add(this.lbTitreMenu);
            this.Controls.Add(this.btMenuAbscences);
            this.Controls.Add(this.btMenuEmploiyes);
            this.Controls.Add(this.btMenuServices);
            this.Name = "FmMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenuServices;
        private System.Windows.Forms.Button btMenuEmploiyes;
        private System.Windows.Forms.Button btMenuAbscences;
        private System.Windows.Forms.Label lbTitreMenu;
        private System.Windows.Forms.PictureBox picBoxMenu;
    }
}