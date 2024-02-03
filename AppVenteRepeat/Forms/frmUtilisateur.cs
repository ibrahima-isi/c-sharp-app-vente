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

namespace AppVenteRepeat.Forms
{
    public partial class frmUtilisateur : Form
    {
        bdVenteEntities1 db = new bdVenteEntities1();

        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            dgViewUtilisateur.DataSource = db.Utilisateurs.ToList();

            var profils = db.Profils.ToList();
            profils.Insert(0, new Profil { codeProfil = "", nomProfil = "Select" });  // Add the text directly
            cbbProfil.DataSource = profils;
            cbbProfil.ValueMember = "codeProfil";
            cbbProfil.DisplayMember = "nomProfil";

            cbbProfil.SelectedIndex = 0;
        }
    }
}
