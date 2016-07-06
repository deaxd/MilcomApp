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
    public partial class frmKorisnici : Form
    {
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void PrikaziKorisnike() 
        {
            //frmKorisniciBindingSource.DataSource = 
            this.korisniciTableAdapter.FillByKorisnici(this.milcomDataSet.korisnici);
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milcomDataSet.korisnici' table. You can move, or remove it, as needed.
            //this.korisniciTableAdapter.FillByKorisnici(this.milcomDataSet.korisnici);
            PrikaziKorisnike();
        }

        private void txtPretrazi_KeyUp(object sender, KeyEventArgs e)
        {
            korisniciBindingSource.Filter = "username = 'value'";

            string searchValue = txtPretrazi.Text;

            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            korisniciBindingSource.Filter = string.Format("{0} = '{1}'", "username", searchValue);
            PrikaziKorisnike();
            //frmKorisniciBindingSource.Filter = null;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmKorisniciDetalji forma = new frmKorisniciDetalji();
            forma.ShowDialog();
            forma.Focus();

            PrikaziKorisnike();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            korisnik selektiraniKorisnik = korisniciBindingSource.Current as korisnik;

            if (selektiraniKorisnik != null)
            {
                frmKorisniciDetalji forma = new frmKorisniciDetalji(selektiraniKorisnik);
                forma.ShowDialog();
                PrikaziKorisnike();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {

        }

    }
}
