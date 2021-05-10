using Program_Librarie.DB;
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
            var id = txtUtilizator.Text;
            var password = txtParola.Text;
            var logged = false;
            using (LabDataContext lb = new LabDataContext())
            {
                var utilizator = lb.utilizator.FirstOrDefault(x => x.IdUtilizator.Equals(id) && x.Parola.Equals(password));
                if (utilizator != null)
                {
                    logged = true;
                }
                else
                {
                    MessageBox.Show("Utilizatorul sau parola nu sunt introduse corect");
                    logged = false;
                }
            }

            if (logged)
            {
                Principal m = new Principal();
                m.Show();
                this.Hide();
            }
        }
    }
}
