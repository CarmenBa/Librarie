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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
            var logged = Code.Login.Connect(txtUtilizator.Text, txtParola.Text);

            if (logged)
            {
                Principal m = new Principal();
                m.Show();
                this.Hide();
            }
        }
    }
}
