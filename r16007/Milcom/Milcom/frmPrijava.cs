using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milcom
{
    public partial class frmPrijava : Form
    {
        private string korIme;
        private string lozinka;

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            korIme = txtKorIme.Text;
            lozinka = txtLozinka.Text;

            prijavaBindingSource.DataSource = prijavaTableAdapter.GetDataByUsername(korIme, lozinka);

            if (prijavaBindingSource.IsBindingSuspended)
            {
                MessageBox.Show("Krivo korisničko ime i/ili lozinka.");
            }

            if (!prijavaBindingSource.IsBindingSuspended)
            {
                korisnik1BindingSource.DataSource = korisnik1TableAdapter.GetData(korIme, lozinka);

                if (!korisnik1BindingSource.IsBindingSuspended)
                {
                    frmGlavnaUser forma = new frmGlavnaUser(korIme);
                    this.Hide();
                    //this.Owner = forma;
                    forma.ShowDialog();
                    this.Show();

                    txtKorIme.Clear();
                    txtLozinka.Clear();
                }
                if (korisnik1BindingSource.IsBindingSuspended)
                {
                    frmGlavnaAdmin forma = new frmGlavnaAdmin();
                    this.Hide();
                    //this.Owner = forma;
                    forma.ShowDialog();
                    this.Show();

                    txtKorIme.Clear();
                    txtLozinka.Clear();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
