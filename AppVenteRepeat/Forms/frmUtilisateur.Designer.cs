namespace AppVenteRepeat.Forms
{
    partial class frmUtilisateur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbbProfil = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnBlockDeblock = new System.Windows.Forms.Button();
            this.dgViewUtilisateur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profil";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(46, 94);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(319, 28);
            this.txtIdentifiant.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(46, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 28);
            this.txtEmail.TabIndex = 5;
            // 
            // cbbProfil
            // 
            this.cbbProfil.FormattingEnabled = true;
            this.cbbProfil.Location = new System.Drawing.Point(46, 346);
            this.cbbProfil.Name = "cbbProfil";
            this.cbbProfil.Size = new System.Drawing.Size(319, 30);
            this.cbbProfil.TabIndex = 6;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(46, 414);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(319, 30);
            this.btnCreer.TabIndex = 7;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // btnBlockDeblock
            // 
            this.btnBlockDeblock.Location = new System.Drawing.Point(46, 482);
            this.btnBlockDeblock.Name = "btnBlockDeblock";
            this.btnBlockDeblock.Size = new System.Drawing.Size(319, 30);
            this.btnBlockDeblock.TabIndex = 8;
            this.btnBlockDeblock.Text = "Bloquer/Debloquer";
            this.btnBlockDeblock.UseVisualStyleBackColor = true;
            // 
            // dgViewUtilisateur
            // 
            this.dgViewUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewUtilisateur.Location = new System.Drawing.Point(401, 77);
            this.dgViewUtilisateur.Name = "dgViewUtilisateur";
            this.dgViewUtilisateur.RowHeadersWidth = 51;
            this.dgViewUtilisateur.RowTemplate.Height = 24;
            this.dgViewUtilisateur.Size = new System.Drawing.Size(531, 436);
            this.dgViewUtilisateur.TabIndex = 9;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.ControlBox = false;
            this.Controls.Add(this.dgViewUtilisateur);
            this.Controls.Add(this.btnBlockDeblock);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.cbbProfil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUtilisateur";
            this.Text = "Enregistrer Utilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbbProfil;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnBlockDeblock;
        private System.Windows.Forms.DataGridView dgViewUtilisateur;
    }
}