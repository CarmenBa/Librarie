using Program_Librarie.DB;
using System;
using System.Linq;
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
            cmbSex.Items.Clear();
            cmbSex.Items.Add("masculin");
            cmbSex.Items.Add("feminin");
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

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newClient = new client()
                {
                    Nume = currentEdit.Nume,
                    Varsta = (int)currentEdit.Varsta,
                    Sex = currentEdit.Sex,
                    Email = currentEdit.Email
                };
                lb.client.Add(newClient);
                lb.SaveChanges();
                UpdateGrid("Adauga");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var client = lb.client.FirstOrDefault(x => x.IdClient == currentEdit.Id);
                client.Nume = currentEdit.Nume;
                client.Varsta = (int)currentEdit.Varsta;
                client.Sex = currentEdit.Sex;
                client.Email = currentEdit.Email;
                lb.SaveChanges();
                UpdateGrid("Modifica");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var client = lb.client.FirstOrDefault(x => x.IdClient == currentEdit.Id);
                lb.client.Remove(client);
                lb.SaveChanges();
                UpdateGrid("Sterge");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void UpdateGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Client sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Client adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Client salvat.");
                    break;
                default:
                    break;
            }
            this.clientTableAdapter.Fill(this.librarieDataSet.client);
        }

        private class EditItem
        {
            public int Id { get; set; }
            public string Nume { get; set; }
            public decimal Varsta { get; set; }
            public string Sex { get; set; }
            public string Email { get; set; }
        }

        private EditItem GetEditItem()
        {
            var newEdit = new EditItem()
            {
                Id = IdSelected,
                Nume = tbNume.Text,
                Varsta = tbVarsta.Value,
                Sex = cmbSex.Text,
                Email = tbEmail.Text
            };
            return newEdit;
        }
    }
}

