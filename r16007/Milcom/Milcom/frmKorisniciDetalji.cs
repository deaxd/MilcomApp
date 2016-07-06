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
    public partial class frmKorisniciDetalji : Form
    {
        private korisnik korisnikZaIzmjenu;

        public frmKorisniciDetalji()
        {
            InitializeComponent();
        }

        public frmKorisniciDetalji(korisnik korisnik)
        {
            InitializeComponent();
            this.korisnikZaIzmjenu = korisnik;
        }
        
        private void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milcomDataSet.tip_korisnik' table. You can move, or remove it, as needed.
            this.tip_korisnikTableAdapter.Fill(this.milcomDataSet.tip_korisnik);

            txtOIB.ReadOnly = true;
            txtIme.ReadOnly = true;
            txtPrezime.ReadOnly = true;
            dtpDatum.Enabled = false;
            txtAdresa.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            if (cbTip.Text == "admin")
            {
                using (var db = new MilcomEntities())
                {
                    korisnik noviKorisnik = new korisnik
                    {
                        username = txtUsername.Text,
                        password = txtPassword.Text,
                        tip_korisnik_id = 1,
                        polaznik_oib = null
                    };
                    db.korisnik.Add(noviKorisnik);
                    db.SaveChanges();
                }
                this.Close();
            }
            if (cbTip.Text == "moderator")
            {
                using (var db = new MilcomEntities())
                {
                    korisnik noviKorisnik = new korisnik
                    {
                        username = txtUsername.Text,
                        password = txtPassword.Text,
                        tip_korisnik_id = 2,
                        polaznik_oib = null
                    };
                    db.korisnik.Add(noviKorisnik);
                    db.SaveChanges();
                }
                this.Close();
            }
            if (cbTip.Text == "polaznik")
            {
                using (var db = new MilcomEntities())
                {
                    polaznik noviPolaznik = new polaznik
                    {
                        oib = int.Parse(txtOIB.Text.ToString()),
                        ime = txtIme.Text,
                        prezime = txtPrezime.Text,
                        datum_rodjenja = dtpDatum.Value.Date,
                        adresa = txtAdresa.Text,
                        telefon = txtTelefon.Text,
                        email = txtEmail.Text
                    };
                    db.polaznik.Add(noviPolaznik);

                    korisnik noviKorisnik = new korisnik
                    {
                        username = txtUsername.Text,
                        password = txtPassword.Text,
                        tip_korisnik_id = 3,
                        polaznik_oib = int.Parse(txtOIB.Text.ToString())
                    };
                    db.korisnik.Add(noviKorisnik);

                    db.SaveChanges();
                }
                this.Close();
            }
            
        }

        private void cbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTip.Text == "admin" || cbTip.Text == "moderator")
            {
                txtOIB.ReadOnly = true;
                txtIme.ReadOnly = true;
                txtPrezime.ReadOnly = true;
                dtpDatum.Enabled = false;
                txtAdresa.ReadOnly = true;
                txtTelefon.ReadOnly = true;
                txtEmail.ReadOnly = true;
            }
            if (cbTip.Text == "polaznik")
            {
                txtOIB.ReadOnly = false;
                txtIme.ReadOnly = false;
                txtPrezime.ReadOnly = false;
                dtpDatum.Enabled = true;
                txtAdresa.ReadOnly = false;
                txtTelefon.ReadOnly = false;
                txtEmail.ReadOnly = false;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
