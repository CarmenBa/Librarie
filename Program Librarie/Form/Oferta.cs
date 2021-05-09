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
    public partial class Oferta : Form
    {
        private int IdOfertaSelected;
        private int IdProdusSelected;

        public Oferta()
        {
            InitializeComponent();
        }

        private void Oferta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.linieoferta' table. You can move, or remove it, as needed.
            this.linieofertaTableAdapter.Fill(this.librarieDataSet.linieoferta);
            // TODO: This line of code loads data into the 'librarieDataSet.oferta' table. You can move, or remove it, as needed.
            this.ofertaTableAdapter.Fill(this.librarieDataSet.oferta);
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

        private void dgvOferta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvOferta.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (ofertaRow)interimar.Row;
                IdOfertaSelected = rowDetaliu.IdOferta;
                cmbFurnizor.SelectedValue = rowDetaliu.IdFurnizor;
                cmbFurnizor.Text = rowDetaliu.Furnizor;
                dtDataExpirare.Value = rowDetaliu.DataExpirare;
            }
            dynamic ds = dgvLinieOferta.DataSource;
            ds.Filter = $"IdOferta = {IdOfertaSelected}";
            dgvLinieOferta.Refresh();
        }

        private void dgvLinieOferta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvLinieOferta.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (linieofertaRow)interimar.Row;
                IdProdusSelected = rowDetaliu.IdProdus;
                cmbTipProdus.SelectedValue = rowDetaliu.IdTipProdus;
                cmbTipProdus.Text = rowDetaliu.TipProdus;
                cmbProdus.SelectedValue = rowDetaliu.IdProdus;
                cmbProdus.Text = rowDetaliu.NumeProdus;
                tbPret.Value = (decimal)rowDetaliu.PretFurnizor;
                tbCantitate.Value = rowDetaliu.CantitateOferta;
            }
        }

        private void btnOfertaAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditOfertaItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newOferta = new oferta()
                {
                    IdFurnizor = currentEdit.Furnizor,
                    DataExpirare = currentEdit.DataExpirare
                };
                lb.oferta.Add(newOferta);
                lb.SaveChanges();
                UpdateOfertaGrid("Adauga");
            }
        }
        private void btnOfertaModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditOfertaItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var oferta = lb.oferta.FirstOrDefault(x => x.IdOferta == currentEdit.Id);
                oferta.DataExpirare = currentEdit.DataExpirare;
                oferta.IdFurnizor = currentEdit.Furnizor;

                lb.SaveChanges();
                UpdateOfertaGrid("Modifica");
            }
        }
        private void btnOfertaStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditOfertaItem();
            DialogResult dialogResult = MessageBox.Show("ATENTIE!\r\nEsti sigur ca vrei sa stergi aceasta oferta?\r\nVei sterge si toate detaliile pe produse la oferta!", "Sterge Oferta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (LabDataContext lb = new LabDataContext())
                {
                    var liniiOferta = lb.linieoferta.Where(x => x.IdOferta == currentEdit.Id).ToList();
                    lb.linieoferta.RemoveRange(liniiOferta);
                    lb.SaveChanges();
                    var oferta = lb.oferta.FirstOrDefault(x => x.IdOferta == currentEdit.Id);
                    lb.oferta.Remove(oferta);
                    lb.SaveChanges();

                    UpdateOfertaGrid("Sterge");
                }
            }
        }
        private class EditOfertaItem
        {
            public int Id { get; set; }
            public int Furnizor { get; set; }
            public DateTime DataExpirare { get; set; }
        }

        private EditOfertaItem GetEditOfertaItem()
        {
            var selectedFurnizor = (dynamic)cmbFurnizor.SelectedItem;
            var newEdit = new EditOfertaItem()
            {
                Id = IdOfertaSelected,
                Furnizor = (int)selectedFurnizor.IdFurnizor,
                DataExpirare = dtDataExpirare.Value,
            };
            return newEdit;
        }

        private void UpdateOfertaGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Oferta si detalii sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Oferta adaugata.");
                    break;
                case "Modifica":
                    MessageBox.Show("Oferta modificata.");
                    break;
                default:
                    break;
            }
            this.ofertaTableAdapter.Fill(this.librarieDataSet.oferta);
            this.linieofertaTableAdapter.Fill(this.librarieDataSet.linieoferta);
            dynamic ds = dgvLinieOferta.DataSource;
            ds.Filter = $"IdOferta = {IdOfertaSelected}";
            dgvLinieOferta.Refresh();
        }


        private class EditLinieOfertaItem
        {
            public int IdOferta { get; set; }
            public int IdProdus { get; set; }
            public double PretFurnizor { get; set; }
            public int Cantitate { get; set; }
        }

        private EditLinieOfertaItem GetEditLinieOfertaItem()
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
            var newEdit = new EditLinieOfertaItem()
            {
                IdOferta = IdOfertaSelected,
                IdProdus = IdProdus,
                PretFurnizor = (double)tbPret.Value,
                Cantitate = (int)tbCantitate.Value
            };
            return newEdit;
        }

        private void UpdateLinieOfertaGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Linie oferta stearsa.");
                    break;
                case "Adauga":
                    MessageBox.Show("Linie oferta adaugata.");
                    break;
                case "Modifica":
                    MessageBox.Show("Linie oferta modificata.");
                    break;
                default:
                    break;
            }
            this.linieofertaTableAdapter.Fill(this.librarieDataSet.linieoferta);
            dynamic ds = dgvLinieOferta.DataSource;
            ds.Filter = $"IdOferta = {IdOfertaSelected}";
            dgvLinieOferta.Refresh();
        }

        private void btnProdusAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditLinieOfertaItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var newLinieOferta = new linieoferta()
                {
                    IdOferta = currentEdit.IdOferta,
                    IdProdus = currentEdit.IdProdus,
                    PretFurnizor = currentEdit.PretFurnizor,
                    Cantitate = currentEdit.Cantitate
                };
                lb.linieoferta.Add(newLinieOferta);
                lb.SaveChanges();
                UpdateLinieOfertaGrid("Adauga");
            }
        }

        private void btnProdusModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditLinieOfertaItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var linieoferta = lb.linieoferta.FirstOrDefault(x => x.IdOferta == currentEdit.IdOferta && x.IdProdus == currentEdit.IdProdus);
                linieoferta.IdProdus = currentEdit.IdProdus;
                linieoferta.PretFurnizor = currentEdit.PretFurnizor;
                linieoferta.Cantitate = currentEdit.Cantitate;

                lb.SaveChanges();
                UpdateLinieOfertaGrid("Modifica");
            }
        }

        private void btnProdusStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditLinieOfertaItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var linieoferta = lb.linieoferta.FirstOrDefault(x => x.IdOferta == currentEdit.IdOferta && x.IdProdus == currentEdit.IdProdus);
                lb.linieoferta.Remove(linieoferta);
                lb.SaveChanges();
                UpdateOfertaGrid("Sterge");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            IdOfertaSelected = -1;
            IdProdusSelected = -1;
            dynamic ds = dgvLinieOferta.DataSource;
            ds.Filter = string.Empty;
            dgvLinieOferta.Refresh();
        }
    }
}
