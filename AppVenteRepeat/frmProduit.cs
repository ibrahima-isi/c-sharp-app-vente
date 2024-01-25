using AppVenteRepeat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppVenteRepeat
{
    public partial class frmProduit : Form
    {
        bdVenteEntities1 db = new bdVenteEntities1();


        public frmProduit()
        {
            InitializeComponent();
        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = db.Produit1.ToList();
            cbbCategorie.DataSource = db.categories.ToList();
            cbbCategorie.ValueMember = "codeCategorie";
            cbbCategorie.DisplayMember = "libelleCategorie";
        }

        private void dgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetForm()
        {
            txtCode.Text = string.Empty;
            txtNom.Text = string.Empty; 
            txtPrix.Text = string.Empty;
            txtQteCritic.Text = string.Empty;
            txtQteMin.Text = string.Empty;
            dgProduit.DataSource = db.Produit1.ToList();
            cbbCategorie.DataSource = db.categories.ToList();
            cbbCategorie.ValueMember = "codeCategorie";
            cbbCategorie.DisplayMember = "libelleCategorie";
            txtCode.Focus();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit1 p = new Produit1
            {
                codeProduit = txtCode.Text,
                nomProduit = txtNom.Text,
                prixUnitaire = float.Parse(txtPrix.Text),
                qteMin = int.Parse(txtQteMin.Text),
                qteCri = int.Parse(txtQteCritic.Text)
            };
            p.codeCategorie = cbbCategorie.SelectedValue.ToString();
            db.Produit1.Add(p);
            db.SaveChanges();
            resetForm();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtNom.Text  = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtPrix.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtQteMin.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQteCritic.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            cbbCategorie.SelectedValue = dgProduit.CurrentRow.Cells[6].Value;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produit1.Find(id);
            if (p != null)
            {
                p.codeProduit = txtCode.Text;
                p.nomProduit = txtNom.Text;
                p.prixUnitaire = float.Parse(txtPrix.Text);
                p.qteMin = int.Parse(txtQteMin.Text);
                p.qteCri = int.Parse(txtQteCritic.Text);
                p.codeCategorie = cbbCategorie.SelectedValue.ToString();
                db.SaveChanges();
                resetForm();
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produit1.Find(id);
            if (p != null)
            {
                //p.codeProduit = txtCode.Text;
                //p.nomProduit = txtNom.Text;
                //p.prixUnitaire = float.Parse(txtPrix.Text);
                //p.qteMin = int.Parse(txtQteMin.Text);
                //p.qteCri = int.Parse(txtQteCritic.Text);
                //p.codeProduit = cbbCategorie.SelectedValue.ToString();
                db.Produit1.Remove(p);
                resetForm();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var listeProduits = db.Produit1.ToList();
            if (!String.IsNullOrEmpty(txtRCode.Text))
            {
                listeProduits = listeProduits.Where(a => a.codeProduit.ToUpper().Contains(txtRCode.Text.ToUpper())).ToList();
            }
            if (!String.IsNullOrEmpty(txtRNom.Text))
            {
                listeProduits = listeProduits.Where(a => a.nomProduit.ToUpper().Contains(txtRNom.Text.ToUpper())).ToList();
            }
            dgProduit.DataSource = listeProduits;
        }
    }
}
