namespace AppVenteRepeat
{
    partial class frmProduit
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
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.Label();
            this.txtQteCritic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQteMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.txtRCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(521, 57);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.RowHeadersWidth = 51;
            this.dgProduit.RowTemplate.Height = 24;
            this.dgProduit.Size = new System.Drawing.Size(880, 726);
            this.dgProduit.TabIndex = 0;
            this.dgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduit_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 67);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(244, 28);
            this.txtCode.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 158);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(244, 28);
            this.txtNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(12, 244);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(244, 28);
            this.txtPrix.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix";
            // 
            // txtCategorie
            // 
            this.txtCategorie.AutoSize = true;
            this.txtCategorie.Location = new System.Drawing.Point(8, 483);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(88, 22);
            this.txtCategorie.TabIndex = 11;
            this.txtCategorie.Text = "Categorie";
            // 
            // txtQteCritic
            // 
            this.txtQteCritic.Location = new System.Drawing.Point(12, 440);
            this.txtQteCritic.Name = "txtQteCritic";
            this.txtQteCritic.Size = new System.Drawing.Size(244, 28);
            this.txtQteCritic.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantite Critique";
            // 
            // txtQteMin
            // 
            this.txtQteMin.Location = new System.Drawing.Point(12, 349);
            this.txtQteMin.Name = "txtQteMin";
            this.txtQteMin.Size = new System.Drawing.Size(244, 28);
            this.txtQteMin.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantite Minim";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(346, 526);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 38);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(346, 57);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(100, 38);
            this.btnSelectionner.TabIndex = 8;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(346, 158);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 38);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(346, 244);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 38);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(12, 534);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(244, 30);
            this.cbbCategorie.TabIndex = 6;
            // 
            // txtRCode
            // 
            this.txtRCode.Location = new System.Drawing.Point(576, 21);
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.Size = new System.Drawing.Size(164, 28);
            this.txtRCode.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Code";
            // 
            // txtRNom
            // 
            this.txtRNom.Location = new System.Drawing.Point(896, 21);
            this.txtRNom.Name = "txtRNom";
            this.txtRNom.Size = new System.Drawing.Size(176, 28);
            this.txtRNom.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(843, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nom";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(1252, 17);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(132, 36);
            this.btnRechercher.TabIndex = 16;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 827);
            this.ControlBox = false;
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtQteCritic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQteMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProduit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduit";
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCategorie;
        private System.Windows.Forms.TextBox txtQteCritic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQteMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.TextBox txtRCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRechercher;
    }
}