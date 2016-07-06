using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milcom
{
    public partial class frmGlavnaAdmin : Form
    {
        public frmGlavnaAdmin()
        {
            InitializeComponent();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            frmKorisnici forma = new frmKorisnici();
            forma.ShowDialog();
        }

        private void btnCertifikati_Click(object sender, EventArgs e)
        {
            frmCertifikati forma = new frmCertifikati();
            forma.ShowDialog();
        }

        private void btnTestovi_Click(object sender, EventArgs e)
        {
            frmTestovi forma = new frmTestovi();
            forma.ShowDialog();
        }

        private void btnRezultati_Click(object sender, EventArgs e)
        {
            frmRezultati forma = new frmRezultati();
            forma.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGlavnaAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milcomDataSet.tip_polaganja' table. You can move, or remove it, as needed.
            this.tip_polaganjaTableAdapter.Fill(this.milcomDataSet.tip_polaganja);

        }
    }
}
