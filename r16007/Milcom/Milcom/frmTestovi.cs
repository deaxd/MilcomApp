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
    public partial class frmTestovi : Form
    {
        public frmTestovi()
        {
            InitializeComponent();
        }

        private void btnEngleski_Click(object sender, EventArgs e)
        {
            frmPitanja forma = new frmPitanja(1);
            forma.ShowDialog();
            forma.Focus();
        }

        private void btnNjemacki_Click(object sender, EventArgs e)
        {
            frmPitanja forma = new frmPitanja(2);
            forma.ShowDialog();
            forma.Focus();
        }

        private void btnInformatika_Click(object sender, EventArgs e)
        {
            frmPitanja forma = new frmPitanja(3);
            forma.ShowDialog();
            forma.Focus();
        }
    }
}
