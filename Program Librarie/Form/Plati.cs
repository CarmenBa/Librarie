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
    public partial class Plati : Form
    {
        public Plati()
        {
            InitializeComponent();
        }

        private void Plati_Load(object sender, EventArgs e)
        {
            textBox1.Text = "RO1421486rt";
            textBox2.Text = "605";
            textBox5.Text = "360";
            textBox6.Text = "245";
            textBox7.Text = "VX";
            textBox8.Text = "1026";
            comboBox2.Text = "Pixar S.A.";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
