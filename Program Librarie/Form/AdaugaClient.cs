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
using static Program_Librarie.LibrarieDataSet;

namespace Program_Librarie
{
    public partial class AdaugaClient : Form
    {
        private int IdSelected;
        public AdaugaClient()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdaugaClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.librarieDataSet.client);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (clientRow)interimar.Row;
                IdSelected = rowDetaliu.IdClient;
                tbNume.Text = rowDetaliu.Nume;
                tbVarsta.Value = rowDetaliu.Varsta;
                cmbSex.Text = rowDetaliu.Sex;
                tbEmail.Text = rowDetaliu.Email;
            }
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (btnModifica.Text == "Salvează")
            {
                ClientDetails details = new ClientDetails();
                details.Nume = cmbNume.Text;
                details.Varsta = txtVarsta.Text;
                details.Sex = cmbSex.Text;
                details.Email = tbEmail.Text;

                client.Insert(details);
                client.Populare(cmbNume);
                MessageBox.Show("A fost adaugat");

                btnModifica.Text = "Modifică";
            }

            if (btnModifica.Text == "Modifică")
            {
                if (cmbNume.Text == client.details.Nume
                    && txtVarsta.Text == client.details.Varsta
                    && cmbSex.Text == client.details.Sex
                    && tbEmail.Text == client.details.Email)
                {
                    //MessageBox.Show("Nu ati introdus modificari");
                }
                else
                {
                    client.details.Nume = cmbNume.Text;
                    client.details.Varsta = txtVarsta.Text;
                    client.details.Sex = cmbSex.Text;
                    client.details.Email = tbEmail.Text;

                    client.UpdateIndex();
                    UpdateFields();
                    client.Populare(cmbNume);
                    MessageBox.Show("Modificarea a fost efectuată");
                }
            }
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Salvează";
            cmbNume.Text = "";
            txtVarsta.Text = "";
            cmbSex.Text = "";
            tbEmail.Text = "";
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Modifică";
            UpdateFields();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            client.Delete();
            this.UpdateFields();
            client.Populare(cmbNume);
            MessageBox.Show("A fost sters");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            client.Next();

            UpdateFields();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            client.Back();

            UpdateFields();
        }

        private void cmbDenumire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNume_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNume.SelectedItem == null)
                return;

            client.Selected(cmbNume);
            UpdateFields();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librarieDataSet);

        }

        private void UpdateGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Produs sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Produs adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Produs modificat.");
                    break;
                default:
                    break;
            }
            this.clientTableAdapter.Fill(this.librarieDataSet.client);
        }

    }
}

