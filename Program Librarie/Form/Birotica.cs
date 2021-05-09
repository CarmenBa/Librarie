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
    public partial class Birotica : Form
    {
        Code.Birotica birotica;

        private void UpdateFields()
        {
            cmbDenumire.Text = birotica.details.Denumire;
            txtDescriere.Text = birotica.details.Descriere;
            txtPret.Text = birotica.details.Pret;
            txtCantitate.Text = birotica.details.Cantitate;
        }

        public Birotica()
        {
            InitializeComponent();
        }

        private void Birotica_Load(object sender, EventArgs e)
        {
            birotica = new Code.Birotica();

            UpdateFields();

            birotica.Populare(cmbDenumire);

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (btnModifica.Text == "Salvează")
            {
                BiroticaDetails details = new BiroticaDetails();
                details.Id = birotica.GetLastProduct()+1;
                details.Cantitate = txtCantitate.Text;
                details.Denumire = cmbDenumire.Text;
                details.Descriere = txtDescriere.Text;
                details.Pret = txtPret.Text;

                birotica.Insert(details);
                MessageBox.Show("A fost adaugat");
                birotica.Populare(cmbDenumire);

                btnModifica.Text = "Modifică";
            }

            if (btnModifica.Text == "Modifică")
            {
                if(cmbDenumire.Text == birotica.details.Denumire 
                    && txtDescriere.Text == birotica.details.Descriere 
                    && txtPret.Text == birotica.details.Pret
                    && txtCantitate.Text == birotica.details.Cantitate)
                {
                    MessageBox.Show("Nu ati introdus modificari");
                }
                else
                {
                    birotica.details.Denumire = cmbDenumire.Text;
                    birotica.details.Descriere= txtDescriere.Text;
                    birotica.details.Pret= txtPret.Text;
                    birotica.details.Cantitate= txtCantitate.Text;

                    birotica.UpdateIndex();
                    UpdateFields();
                    birotica.Populare(cmbDenumire);
                    MessageBox.Show("Modificarea a fost efectuată");
                }
            }
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Salvează";
            cmbDenumire.Text = "";
            txtDescriere.Text = "";
            txtPret.Text = "";
            txtCantitate.Text = "";
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Modifică";
            UpdateFields();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            birotica.Delete();
            this.UpdateFields();
            birotica.Populare(cmbDenumire);
            MessageBox.Show("A fost sters");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            birotica.Next();

            UpdateFields();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            birotica.Back();

            UpdateFields();
        }

        private void cmbDenumire_SelectedIndexChanged(object sender, EventArgs e)
        {
            birotica = new Code.Birotica();

            birotica.Selected(cmbDenumire);
            UpdateFields();
        }
    }
}
