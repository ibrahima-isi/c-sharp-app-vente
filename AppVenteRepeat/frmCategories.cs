using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVenteRepeat.Model;


namespace AppVenteRepeat
{
    public partial class frmCategories : Form
    {
        bdVenteEntities1 db = new bdVenteEntities1(); 
        public frmCategories()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            dgCategorie.DataSource = db.categories.ToList();
        }

        private void resetFormCategorie()
        {
            txtCode.Text = String.Empty;
            txtLibelle.Text = String.Empty;
            dgCategorie.DataSource = db.categories.ToList();
            txtCode.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            category c = new category
            {
                codeCategorie = txtCode.Text,
                libelleCategorie = txtLibelle.Text
            };
            db.categories.Add(c);
            db.SaveChanges();
            resetFormCategorie();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
            txtLibelle.Text = dgCategorie.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            var c = db.categories.Find(id);
            if(txtCode.Text != "" && txtLibelle.Text != "")
            {
                c.codeCategorie = txtCode.Text;
                c.libelleCategorie = txtLibelle.Text;
                db.SaveChanges();
                resetFormCategorie();
            } 
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            var c = db.categories.Find(id);
            db.categories.Remove(c);  
            db.SaveChanges();
            resetFormCategorie();
        }
    }
}
