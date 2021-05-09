using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Librarie
{
    public partial class Vanzari : Form
    {
        public Vanzari()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            RaportVanzari m = new RaportVanzari();
            m.Show();
        }
    }
}
