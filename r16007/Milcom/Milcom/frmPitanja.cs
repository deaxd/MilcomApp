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
    public partial class frmPitanja : Form
    {
        private int odabraniTip;

        public frmPitanja()
        {
            InitializeComponent();
        }

        public frmPitanja(int tip)
        {
            InitializeComponent();
            odabraniTip = tip;
        }

        private void PrikaziPitanja()
        {
            this.pitanjeTableAdapter.FillByTip(this.milcomDataSet.pitanje, odabraniTip);
            this.odgovorTableAdapter.Fill(this.milcomDataSet.odgovor);
        }

        private void PrikaziOdgovore(int pitanjeID)
        {
            this.odgovorTableAdapter.Fill(this.milcomDataSet.odgovor);
        }

        private void frmPitanja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milcomDataSet.tip_polaganja' table. You can move, or remove it, as needed.
            this.tip_polaganjaTableAdapter.Fill(this.milcomDataSet.tip_polaganja);
            PrikaziPitanja();
        }

        //CRUD pitanja
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmPitanjaDetalji forma = new frmPitanjaDetalji(odabraniTip);
            forma.ShowDialog();
            forma.Focus();

            PrikaziPitanja();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvPitanja.RowCount > 0)
            {
                int pitanjeID = int.Parse(dgvPitanja.CurrentRow.Cells[0].Value.ToString());

                frmPitanjaDetalji forma = new frmPitanjaDetalji(pitanjeID, odabraniTip);
                forma.ShowDialog();
                forma.Focus();

                PrikaziPitanja();
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            int odabranoP = int.Parse(dgvPitanja.CurrentRow.Cells[0].Value.ToString());

            if (odabranoP != 0)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MilcomEntities())
                    {
                        if (dgvOdgovori.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dgvOdgovori.Rows)
                            {
                                dgvOdgovori.Rows.RemoveAt(dgvOdgovori.CurrentRow.Index);
                            }
                        }
                        if (dgvOdgovori.RowCount == 0)
                        {
                            dgvPitanja.Rows.Remove(dgvPitanja.CurrentRow);
                        }
                    }

                   // PrikaziPitanja();
                }
            }
        }

        //CRUD odgovori
        private void btnDodajO_Click(object sender, EventArgs e)
        {
            if (dgvPitanja.RowCount > 0)
            {
                int pitanjeID = int.Parse(dgvPitanja.CurrentRow.Cells[0].Value.ToString());

                frmOdgovoriDetalji forma = new frmOdgovoriDetalji(pitanjeID);
                forma.ShowDialog();
                forma.Focus();

                PrikaziPitanja();
            }
        }

        private void btnUrediO_Click(object sender, EventArgs e)
        {
            if (dgvOdgovori.RowCount > 0)
            {
                int pitanjeID = int.Parse(dgvPitanja.CurrentRow.Cells[0].Value.ToString());
                int odgID = int.Parse(dgvOdgovori.CurrentRow.Cells[0].Value.ToString());

                frmOdgovoriDetalji forma = new frmOdgovoriDetalji(pitanjeID, odgID);
                forma.ShowDialog();
                forma.Focus();

                PrikaziPitanja();
            }
        }

        private void btnIzbrisiO_Click(object sender, EventArgs e)
        {
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
