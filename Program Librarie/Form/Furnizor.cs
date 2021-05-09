using Program_Librarie.Code;
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
using static Program_Librarie.LibrarieDataSet;

namespace Program_Librarie
{
    public partial class Furnizor : Form
    {
        private int IdSelected;

        public Furnizor()
        {
            InitializeComponent();
        }

        private void Furnizor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.furnizor' table. You can move, or remove it, as needed.
            this.furnizorTableAdapter.Fill(this.librarieDataSet.furnizor);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (furnizorRow)interimar.Row;
                IdSelected = rowDetaliu.IdFurnizor;
                tbNume.Text = rowDetaliu.Nume;
                tbCUI.Text = rowDetaliu.CUI;
                tbSold.Value = (decimal)rowDetaliu.Sold;
                tbEmail.Text = rowDetaliu.Email;
                tbTelefon.Text = rowDetaliu.Telefon ?? string.Empty;
            }
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newFurnizor = new furnizor()
                {
                    Nume = currentEdit.Nume,
                    CUI = currentEdit.CUI,
                    Sold = (double)currentEdit.Sold,
                    Email = currentEdit.Email,
                    Telefon = currentEdit.Telefon
                };
                lb.furnizor.Add(newFurnizor);
                lb.SaveChanges();
                UpdateGrid("Adauga");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var furnizor = lb.furnizor.FirstOrDefault(x => x.IdFurnizor == currentEdit.Id);
                furnizor.Nume = currentEdit.Nume;
                furnizor.CUI = currentEdit.CUI;
                furnizor.Sold = (double)currentEdit.Sold;
                furnizor.Email = currentEdit.Email;
                furnizor.Telefon = currentEdit.Telefon;
                lb.SaveChanges();
                UpdateGrid("Modifica");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            DialogResult dialogResult = MessageBox.Show("ATENTIE!\r\nDaca stergi acest furnizor vei sterge si toate tranzactiile legate de furnizor\r\nVrei sa continui?", "StergeFurnizor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (LabDataContext lb = new LabDataContext())
                {
                    var furnizor = lb.furnizor.FirstOrDefault(x => x.IdFurnizor == currentEdit.Id);
                    lb.furnizor.Remove(furnizor);
                    lb.SaveChanges();
                    UpdateGrid("Sterge");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                UpdateGrid("");
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
                    MessageBox.Show("Furnizor sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Furnizor adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Furnizor salvat.");
                    break;
                default:
                    break;
            }
            this.furnizorTableAdapter.Fill(this.librarieDataSet.furnizor);
        }

        private class EditItem
        {
            public int Id { get; set; }
            public string Nume { get; set; }
            public string CUI { get; set; }
            public decimal Sold { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
        }

        private EditItem GetEditItem()
        {
            var newEdit = new EditItem()
            {
                Id = IdSelected,
                Nume = tbNume.Text,
                CUI = tbCUI.Text,
                Sold = tbSold.Value,
                Email = tbEmail.Text,
                Telefon = tbTelefon.Text
            };
            return newEdit;
        }
    }
}
