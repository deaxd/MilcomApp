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
    public partial class frmPitanjaDetalji : Form
    {
        private int odabraniTip;
        private int odabranoPitanje;
        private bool kontrolna;

        public frmPitanjaDetalji()
        {
            InitializeComponent();
        }

        public frmPitanjaDetalji(int tipID)
        {
            InitializeComponent();
            odabraniTip = tipID;
            kontrolna = true;
        }

        public frmPitanjaDetalji(int pitanjeID, int tipID)
        {
            InitializeComponent();
            odabranoPitanje = pitanjeID;
            odabraniTip = tipID;
            kontrolna = false;
        }

        private void frmPitanjaDetalji_Load(object sender, EventArgs e)
        {
            if (!kontrolna)
            {
                txtPitanje.Text = (this.pitanjeTableAdapter.FillByPitanjeID(odabranoPitanje)).ToString();
            }
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            using (var db = new MilcomEntities())
            {
                if (kontrolna)
                {
                    pitanje novoPitanje = new pitanje
                    {
                        tekst = txtPitanje.Text,
                        tip_polaganja_id = odabraniTip
                    };
                    db.pitanje.Add(novoPitanje);
                }
                else
                {
                    this.Validate();
                    this.pitanjeBindingSource.EndEdit();
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
