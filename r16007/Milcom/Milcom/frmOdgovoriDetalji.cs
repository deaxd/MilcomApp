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
    public partial class frmOdgovoriDetalji : Form
    {
        private int odabranoPitanje;
        private int odabraniOdgovor;
        private bool kontrolna;

        public frmOdgovoriDetalji()
        {
            InitializeComponent();
            kontrolna = true;
        }
        public frmOdgovoriDetalji(int pitanjeID)
        {
            InitializeComponent();
            odabranoPitanje = pitanjeID;
            kontrolna = true;
        }

        public frmOdgovoriDetalji(int pitanjeID, int odgovorID)
        {
            InitializeComponent();
            odabranoPitanje = pitanjeID;
            odabraniOdgovor = odgovorID;
            kontrolna = false;
        }

        private void frmOdgovoriDetalji_Load(object sender, EventArgs e)
        {
            if (!kontrolna)
            {
                txtOdgovor.Text = (this.odgovorTableAdapter.FillByOdgID(odabraniOdgovor)).ToString();
                cbTocno.Checked = Boolean.Parse(this.odgovorTableAdapter.FillByTocno(odabraniOdgovor).ToString());
            }            
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            using (var db = new MilcomEntities())
            {
                if (kontrolna)
                {
                    odgovor noviOdgovor = new odgovor
                    {
                        tekst = txtOdgovor.Text,
                        tocno = cbTocno.Checked,
                        pitanje_id = odabranoPitanje
                    };
                    db.odgovor.Add(noviOdgovor); 
                }
                else
                {
                    this.Validate();
                    this.odgovorBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.milcomDataSet);
                }
                db.SaveChanges();
            }

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
