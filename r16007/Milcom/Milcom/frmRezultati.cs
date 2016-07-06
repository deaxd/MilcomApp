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
    public partial class frmRezultati : Form
    {
        public frmRezultati()
        {
            InitializeComponent();
        }

        private void frmRezultati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milcomDataSet.polaznik' table. You can move, or remove it, as needed.
            this.polaznikTableAdapter.Fill(this.milcomDataSet.polaznik);
            // TODO: This line of code loads data into the 'milcomDataSet.tip_polaganja' table. You can move, or remove it, as needed.
            this.tip_polaganjaTableAdapter.Fill(this.milcomDataSet.tip_polaganja);
            // TODO: This line of code loads data into the 'milcomDataSet.rezultat' table. You can move, or remove it, as needed.
            this.rezultatTableAdapter.Fill(this.milcomDataSet.rezultat);

        }

        private void txtPretrazi_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnIzradi_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
