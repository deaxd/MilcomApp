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
    public partial class frmGlavnaUser : Form
    {
        private string korIme;
        private int OIB;
        private int pok;

        public frmGlavnaUser()
        {
            InitializeComponent();
        }

        public frmGlavnaUser(string kIme)
        {
            InitializeComponent();
            korIme = kIme;
        }

        private void frmGlavnaUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milcomDataSet.tip_polaganja' table. You can move, or remove it, as needed.
            this.tip_polaganjaTableAdapter.Fill(this.milcomDataSet.tip_polaganja);

            //dohvaćanje OIB-a
            OIB = int.Parse((this.korisnikTableAdapter1.FillByUsername(korIme)).ToString());
            //broj pokusaja
            if (this.rezultatTableAdapter1.FillByRezultati(this.milcomDataSet.rezultat, OIB) > 0)
            {
                pok = int.Parse((this.rezultatTableAdapter1.FillByPokusaj(OIB)).ToString());
            }
            else
            {
                pok = 1;
            }
        }

        private void btnPristupi_Click(object sender, EventArgs e)
        {
            //datum
            var now = DateTime.Now;
            var datum = now.Date;

            //bodovi
            Random rng = new Random();
            int bodoviRng = rng.Next(0, 100);
                        
            using (var db = new MilcomEntities())
            {
                rezultat noviRezultat = new rezultat
                {
                    datum_polaganja = datum,
                    pokusaj = pok,
                    bodovi = bodoviRng,
                    tip_polaganja_id = int.Parse(cbTip.SelectedValue.ToString()),
                    polaznik_oib = OIB
                };
                db.rezultat.Add(noviRezultat);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
