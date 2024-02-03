using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace AppVenteRepeat
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
        }

        // method to close a window, it will help closing a open window before opening it again
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            // foreach element of the layout children opened, we closed them
            foreach(Form f in charr)
            {
                // closing the window
                f.Close();
            }

        }
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // method for the categorie menu
        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategories c = new frmCategories
            {
                MdiParent = this
            };
            c.Show();
            c.WindowState = FormWindowState.Maximized;
            
        }
        // method for produit menu
        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit p = new frmProduit
            {
                MdiParent = this
            };
            p.Show();
            p.WindowState = FormWindowState.Maximized;

        }

        // the exit button
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // the disconnect button
        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            form1.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }
    }
}
