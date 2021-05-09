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
    public partial class Furnizor : Form
    {
        Furnizori furnizor;
        public Furnizor()
        {
            InitializeComponent();
        }

        private void Update()
        {
            

            cbDenumire.Text = furnizor.details.Nume;
            txtCUI.Text = furnizor.details.CUI;
            txtSold.Text = furnizor.details.Sold.ToString();
            txtEmail.Text = furnizor.details.Email;

        }

        private void Furnizor_Load(object sender, EventArgs e)
        {
            furnizor = new Furnizori();
            furnizor.Populare(cbDenumire);

            cbDenumire.SelectedIndex = 0;

            //cbDenumire.Text = furnizor.details.Nume;
           // txtCUI.Text = furnizor.details.CUI;
            //txtSold = double.Parse(furnizor.details.Sold.ToString());
            //txtEmail = furnizor.details.Email;
        }

        private void cbDenumire_SelectedIndexChanged(object sender, EventArgs e)
        {
            furnizor.Update(cbDenumire);

            Update();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            furnizor.Next(cbDenumire);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            furnizor.Back(cbDenumire);

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {

            furnizor.Delete();
            furnizor.Populare(cbDenumire);
            cbDenumire.SelectedIndex = 0;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Salvează";
            cbDenumire.Text = "";
            txtCUI.Text = "";
            txtEmail.Text = "";
            txtSold.Text = "";
         
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (btnModifica.Text == "Salvează")
            {
                FurnizoriDetails details = new FurnizoriDetails();
                details.Nume = cbDenumire.Text;
                details.Email = txtEmail.Text;
                details.Sold = Convert.ToDouble(txtSold.Text);
                details.CUI = txtCUI.Text;

                furnizor.Insert(details);
                furnizor.Populare(cbDenumire);
                MessageBox.Show("A fost adaugat");

                btnModifica.Text = "Modifică";
            }

            if (btnModifica.Text == "Modifică")
            {
              
                    furnizor.details.Nume = cbDenumire.Text;
                furnizor.details.Sold = Convert.ToDouble(txtSold.Text);
                furnizor.details.Email = txtEmail.Text;
                furnizor.details.CUI = txtCUI.Text;

                    furnizor.Update();
                furnizor.Populare(cbDenumire);
                MessageBox.Show("Modificarea a fost efectuată");
               
            }
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
