using Program_Librarie.Code;
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
    public partial class Stocuri : Form
    {
        public Stocuri()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            RaportStocuri m = new RaportStocuri(rb1.Checked ? "Carte" : rb2.Checked ? "Birotica" : "All",
                tbMin.GetNumber(int.MinValue),
                tbMax.GetNumber(int.MaxValue)     
                );
            m.Show();
        }
    }
}
