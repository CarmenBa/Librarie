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
    public partial class Plati : Form
    {
        private int IdPlataSelected;
        private int IdAchizitieSelected;

        public Plati()
        {
            InitializeComponent();
        }

        private void Plati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.plata' table. You can move, or remove it, as needed.
            this.plataTableAdapter.Fill(this.librarieDataSet.plata);
            // TODO: This line of code loads data into the 'librarieDataSet.achizitie' table. You can move, or remove it, as needed.
            this.achizitieTableAdapter.Fill(this.librarieDataSet.achizitie);
            using (LabDataContext lb = new LabDataContext())
            {
                cmbFurnizor.Items.Clear();
                cmbFurnizor.ValueMember = "IdFurnizor";
                cmbFurnizor.DisplayMember = "Nume";
                cmbFurnizor.Items.AddRange(lb.furnizor.Select(x => new { x.Nume, x.IdFurnizor }).ToArray<object>());
            }
        }

        private void dgvAchizitii_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvAchizitii.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (achizitieRow)interimar.Row;
                IdAchizitieSelected = rowDetaliu.IdAchizitie;
            }
            dynamic ds = dgvPlati.DataSource;
            ds.Filter = $"IdAchizitie = {IdAchizitieSelected}";
            dgvPlati.Refresh();
        }

        private void dgvPlati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvPlati.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (plataRow)interimar.Row;
                IdPlataSelected = rowDetaliu.IdPlata;
                cmbFurnizor.SelectedValue = rowDetaliu.IdFurnizor;
                cmbFurnizor.Text = rowDetaliu.Furnizor;
                tbSuma.Value = (decimal)rowDetaliu.Suma;
                dtData.Value = rowDetaliu.Data;
                tbSerie.Text = rowDetaliu.SerieDocument;
                tbNrDoc.Value = rowDetaliu.NrDocument;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IdAchizitieSelected = -1;
            IdPlataSelected = -1;
            dynamic ds = dgvPlati.DataSource;
            ds.Filter = string.Empty;
            dgvPlati.Refresh();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newPlata = new plata()
                {
                    Data = currentEdit.Data,
                    IdAchizitie = IdAchizitieSelected,
                    IdFurnizor = currentEdit.Furnizor,
                    SerieDocument = currentEdit.SerieDocument,
                    NrDocument = currentEdit.NrDocument,
                    Suma = currentEdit.Suma
                };
                lb.plata.Add(newPlata);
                lb.SaveChanges();
                UpdateGrid("Adauga");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var plata = lb.plata.FirstOrDefault(x => x.IdPlata == currentEdit.Id);

                plata.Data = currentEdit.Data;
                plata.IdFurnizor = currentEdit.Furnizor;
                plata.SerieDocument = currentEdit.SerieDocument;
                plata.NrDocument = currentEdit.NrDocument;
                plata.Suma = currentEdit.Suma;

                lb.SaveChanges();
                UpdateGrid("Modifica");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            DialogResult dialogResult = MessageBox.Show("ATENTIE!\r\nEsti sigur ca vrei sa stergi aceasta plata?", "Sterge Plata", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (LabDataContext lb = new LabDataContext())
                {
                    var plata = lb.plata.FirstOrDefault(x => x.IdPlata == currentEdit.Id);
                    lb.plata.Remove(plata);
                    lb.SaveChanges();
                    UpdateGrid("Sterge");
                }
            }
        }

        private class EditItem
        {
            public int Id { get; set; }
            public int Furnizor { get; set; }
            public double Suma { get; set; }
            public DateTime Data { get; set; }
            public string SerieDocument { get; set; }
            public int NrDocument { get; set; }
        }

        private EditItem GetEditItem()
        {
            var selectedFurnizor = (dynamic)cmbFurnizor.SelectedItem;
            var newEdit = new EditItem()
            {
                Id = IdPlataSelected,
                Furnizor = (int)selectedFurnizor.IdFurnizor,
                Suma = (double)tbSuma.Value,
                Data = dtData.Value,
                SerieDocument = tbSerie.Text,
                NrDocument = (int)tbNrDoc.Value
            };
            return newEdit;
        }

        private void UpdateGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Plata sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Plata adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Plata modificat.");
                    break;
                default:
                    break;
            }
            this.plataTableAdapter.Fill(this.librarieDataSet.plata);
            dynamic ds = dgvPlati.DataSource;
            ds.Filter = $"IdAchizitie = {IdAchizitieSelected}";
            dgvPlati.Refresh();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
