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
    public partial class Achizitii : Form
    {
        private int IdAchizitieSelected;
        private int IdProdusSelected;

        public Achizitii()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Achizitii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.linieachizitie' table. You can move, or remove it, as needed.
            this.linieachizitieTableAdapter.Fill(this.librarieDataSet.linieachizitie);
            // TODO: This line of code loads data into the 'librarieDataSet.achizitie' table. You can move, or remove it, as needed.
            this.achizitieTableAdapter.Fill(this.librarieDataSet.achizitie);
            using (LabDataContext lb = new LabDataContext())
            {
                cmbFurnizor.Items.Clear();
                cmbFurnizor.ValueMember = "IdFurnizor";
                cmbFurnizor.DisplayMember = "Nume";
                cmbFurnizor.Items.AddRange(lb.furnizor.Select(x => new { x.Nume, x.IdFurnizor }).ToArray<object>());
                cmbTipProdus.Items.Clear();
                cmbTipProdus.ValueMember = "IdTipProdus";
                cmbTipProdus.DisplayMember = "TipProdus1";
                cmbTipProdus.Items.AddRange(lb.tipprodus.Select(x => new { x.TipProdus1, x.IdTipProdus }).ToArray<object>());
            }

        }

        private void cmbTipProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (LabDataContext lb = new LabDataContext())
            {
                cmbProdus.Items.Clear();
                cmbProdus.ValueMember = "Id";
                cmbProdus.DisplayMember = "Nume";

                var selectedTipProdus = (dynamic)cmbTipProdus.SelectedItem;
                switch ((int)selectedTipProdus.IdTipProdus)
                {
                    //Carte
                    case 1:
                        cmbProdus.Items.AddRange(lb.carte.Select(x => new { Id = x.IdCarte, Nume = x.Titlu }).ToArray<object>());
                        break;
                    //Birotica
                    case 2:
                        cmbProdus.Items.AddRange(lb.birotica.Select(x => new { Id = x.IdBirotica, Nume = x.Denumire }).ToArray<object>());
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgvAchizitie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvAchizitie.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (achizitieRow)interimar.Row;
                IdAchizitieSelected = rowDetaliu.IdAchizitie;
                cmbFurnizor.SelectedValue = rowDetaliu.IdFurnizor;
                cmbFurnizor.Text = rowDetaliu.Furnizor;
                dtData.Value = rowDetaliu.Data;
                tbSerie.Text = rowDetaliu.SerieDocument;
                tbNrDoc.Value = (int)rowDetaliu.NrDocument;
            }
            dynamic ds = dgvLinieAchizitie.DataSource;
            ds.Filter = $"IdAchizitie = {IdAchizitieSelected}";
            dgvLinieAchizitie.Refresh();
        }

        private void btnAchizitieModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditAchizitieItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var achizitie = lb.achizitie.FirstOrDefault(x => x.IdAchizitie == currentEdit.Id);
                achizitie.Data = currentEdit.Data;
                achizitie.IdFurnizor = currentEdit.Furnizor;
                achizitie.SerieDocument = currentEdit.SerieDocument;
                achizitie.NrDocument = currentEdit.NrDocument;

                lb.SaveChanges();
                UpdateAchizitieGrid("Modifica");
            }
        }

        private void btnAchizitieAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditAchizitieItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newAchizitie = new achizitie()
                {
                    IdFurnizor = currentEdit.Furnizor,
                    Data = currentEdit.Data,
                    SerieDocument = currentEdit.SerieDocument,
                    NrDocument = currentEdit.NrDocument
                };
                lb.achizitie.Add(newAchizitie);
                lb.SaveChanges();
                UpdateAchizitieGrid("Adauga");
            }
        }

        private void btnAchizitieStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditAchizitieItem();
            DialogResult dialogResult = MessageBox.Show("ATENTIE!\r\nEsti sigur ca vrei sa stergi aceasta achizitie?\r\nVei sterge si toate detaliile pe produse la achizitie!", "Sterge achizitia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (LabDataContext lb = new LabDataContext())
                {
                    var liniiAchizitii = lb.linieachizitie.Where(x => x.IdAchizitie == currentEdit.Id).ToList();
                    lb.linieachizitie.RemoveRange(liniiAchizitii);
                    lb.SaveChanges();
                    var achizitie = lb.achizitie.FirstOrDefault(x => x.IdAchizitie == currentEdit.Id);
                    lb.achizitie.Remove(achizitie);
                    lb.SaveChanges();

                    UpdateAchizitieGrid("");
                }
            }
        }

        private class EditAchizitieItem
        {
            public int Id { get; set; }
            public int Furnizor { get; set; }
            public DateTime Data { get; set; }
            public string SerieDocument { get; set; }
            public int NrDocument { get; set; }
        }
        private EditAchizitieItem GetEditAchizitieItem()
        {
            var selectedFurnizor = (dynamic)cmbFurnizor.SelectedItem;
            var newEdit = new EditAchizitieItem()
            {
                Id = IdAchizitieSelected,
                Furnizor = (int)selectedFurnizor.IdFurnizor,
                Data = dtData.Value,
                SerieDocument = tbSerie.Text,
                NrDocument = (int)tbNrDoc.Value
            };
            return newEdit;
        }
        private void UpdateAchizitieGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Achizitie stearsa.");
                    break;
                case "Adauga":
                    MessageBox.Show("Achizitie adaugata.");
                    break;
                case "Modifica":
                    MessageBox.Show("Achizitie modificata.");
                    break;
                default:
                    MessageBox.Show("Terminat");
                    break;
            }
            this.linieachizitieTableAdapter.Fill(this.librarieDataSet.linieachizitie);
            this.achizitieTableAdapter.Fill(this.librarieDataSet.achizitie);
            dynamic ds = dgvLinieAchizitie.DataSource;
            ds.Filter = $"IdAchizitie = {IdAchizitieSelected}";
            dgvLinieAchizitie.Refresh();
        }


        private void dgvLinieAchizitie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvLinieAchizitie.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (linieachizitieRow)interimar.Row;
                IdProdusSelected = rowDetaliu.IdProdus;
                cmbTipProdus.SelectedValue = rowDetaliu.IdTipProdus;
                cmbTipProdus.Text = rowDetaliu.TipProdus;
                cmbProdus.SelectedValue = rowDetaliu.IdProdus;
                cmbProdus.Text = rowDetaliu.NumeProdus;
                tbPret.Value = (decimal)rowDetaliu.Pret;
                tbCantitate.Value = rowDetaliu.Cantitate;
            }
        }

        private void btnProdusAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditLinieAchizitieItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newLinieAchizitie = new linieachizitie()
                {
                    IdAchizitie = currentEdit.IdAchizitie,
                    IdProdus = currentEdit.IdProdus,
                    Pret = currentEdit.Pret,
                    Cantitate = currentEdit.Cantitate
                };
                lb.linieachizitie.Add(newLinieAchizitie);
                lb.SaveChanges();
                UpdateLinieAchizitieGrid("Adauga");
            }
        }

        private void btnProdusModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditLinieAchizitieItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var linieachizitie = lb.linieachizitie.FirstOrDefault(x => x.IdAchizitie == currentEdit.IdAchizitie && x.IdProdus == currentEdit.IdProdus);
                linieachizitie.IdProdus = currentEdit.IdProdus;
                linieachizitie.Pret = currentEdit.Pret;
                linieachizitie.Cantitate = currentEdit.Cantitate;

                lb.SaveChanges();
                UpdateLinieAchizitieGrid("Modifica");
            }
        }

        private void btnProdusStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditLinieAchizitieItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var linieachizitie = lb.linieachizitie.FirstOrDefault(x => x.IdAchizitie == currentEdit.IdAchizitie && x.IdProdus == currentEdit.IdProdus);
                lb.linieachizitie.Remove(linieachizitie);
                lb.SaveChanges();
                UpdateLinieAchizitieGrid("Sterge");
            }
        }


        private class EditLinieAchizitieItem
        {
            public int IdAchizitie { get; set; }
            public int IdProdus { get; set; }
            public double Pret { get; set; }
            public int Cantitate { get; set; }
        }
        private EditLinieAchizitieItem GetEditLinieAchizitieItem()
        {
            var selectedTipProdus = (dynamic)cmbTipProdus.SelectedItem;
            var selectedProdus = (dynamic)cmbProdus.SelectedItem;
            var IdProdus = -1;
            using (LabDataContext lb = new LabDataContext())
            {
                int selectedIdTipProdus = selectedTipProdus.IdTipProdus;
                int selectedIdProdus = selectedProdus.Id;
                IdProdus = lb.produs.FirstOrDefault(x => x.IdTipProdus == selectedIdTipProdus && x.Produs1 == selectedIdProdus).IdProdus;
            }
            var newEdit = new EditLinieAchizitieItem()
            {
                IdAchizitie = IdAchizitieSelected,
                IdProdus = IdProdus,
                Pret = (double)tbPret.Value,
                Cantitate = (int)tbCantitate.Value
            };
            return newEdit;
        }
        private void UpdateLinieAchizitieGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Linie achizitie stearsa.");
                    break;
                case "Adauga":
                    MessageBox.Show("Linie achizitie adaugata.");
                    break;
                case "Modifica":
                    MessageBox.Show("Linie achizitie modificata.");
                    break;
                default:
                    break;
            }
            this.linieachizitieTableAdapter.Fill(this.librarieDataSet.linieachizitie);
            dynamic ds = dgvLinieAchizitie.DataSource;
            ds.Filter = $"IdAchizitie = {IdAchizitieSelected}";
            dgvLinieAchizitie.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IdAchizitieSelected = -1;
            IdProdusSelected = -1;
            dynamic ds = dgvLinieAchizitie.DataSource;
            ds.Filter = string.Empty;
            dgvLinieAchizitie.Refresh();
        }
    }
}
