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
    public partial class Produse : Form
    {
        private int IdSelected;
        public Produse()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Produse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.cartedetaliu' table. You can move, or remove it, as needed.
            this.cartedetaliuTableAdapter.Fill(this.librarieDataSet.cartedetaliu);
            using (LabDataContext lb = new LabDataContext())
            {
                cmbTipProdus.Items.Clear();
                cmbTipProdus.Items.AddRange(lb.tipprodus.Select(x => x.TipProdus1).ToArray<object>());
                cmbAutor.Items.Clear();
                cmbAutor.Items.AddRange(lb.autor.Select(x => x.Nume).ToArray<object>());
                cmbEditura.Items.Clear();
                cmbEditura.Items.AddRange(lb.editura.Select(x => x.Nume).ToArray<object>());
                cmbDomeniu.Items.Clear();
                cmbDomeniu.Items.AddRange(lb.domeniu.Select(x => x.Domeniu1).ToArray<object>());
            }
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pentru probleme consultati manualul de instructiuni sau contactati-ne la adresa SUPORT@gmail.com!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (cartedetaliuRow)interimar.Row;
                IdSelected = rowDetaliu.Id;
                cmbTipProdus.SelectedIndex = cmbTipProdus.Items.IndexOf(rowDetaliu.Produs);
                tbTitlu.Text = rowDetaliu.Titlu;
                tbDescriere.Text = rowDetaliu.Descriere;
                tbPret.Value = (decimal)rowDetaliu.Pret;
                tbCantitate.Value = rowDetaliu.Cantitate;
                if (rowDetaliu.Produs.Equals("Carte"))
                {
                    SetCarteFieldsVisible(true);
                    tbISBN.Text = rowDetaliu.ISBN;
                    tbAn.Value = decimal.Parse(rowDetaliu.An);
                    tbNrPagini.Value = decimal.Parse(rowDetaliu.NrPagini);
                    tbLocatie.Text = rowDetaliu.Locatie;
                    cmbAutor.SelectedIndex = cmbAutor.Items.IndexOf(rowDetaliu.Autor);
                    cmbDomeniu.SelectedIndex = cmbDomeniu.Items.IndexOf(rowDetaliu.Domeniu);
                    cmbEditura.SelectedIndex = cmbEditura.Items.IndexOf(rowDetaliu.Editura);
                }
                else
                {
                    SetCarteFieldsVisible(false);
                }
            }
        }


        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var IdTipProdus = lb.tipprodus.FirstOrDefault(x => x.TipProdus1.Equals(currentEdit.TipProdus)).IdTipProdus;
                switch (IdTipProdus)
                {
                    //Carte
                    case 1:
                        var newCarte = new carte()
                        {
                            ISBN = currentEdit.ISBN,
                            Titlu = currentEdit.Titlu,
                            Descriere = currentEdit.Descriere,
                            IdEditura = lb.editura.FirstOrDefault(x => x.Nume.Equals(currentEdit.Editura)).IdEditura,
                            An = (int)currentEdit.An,
                            NrPagini = (int)currentEdit.NrPagini,
                            Locatie = currentEdit.Locatie,
                            IdAutor = lb.autor.FirstOrDefault(x => x.Nume.Equals(currentEdit.Autor)).IdAutor,
                            IdDomeniu = lb.domeniu.FirstOrDefault(x => x.Domeniu1.Equals(currentEdit.Domeniu)).IdDomeniu,
                        };
                        var carteAdaugata = lb.carte.Add(newCarte);
                        lb.SaveChanges();
                        if (carteAdaugata.IdCarte > -1)
                        {
                            var newProdus = new produs()
                            {
                                IdTipProdus = lb.tipprodus.FirstOrDefault(x => x.TipProdus1.Equals(currentEdit.TipProdus)).IdTipProdus,
                                Pret = (double)currentEdit.Pret,
                                Cantitate = (int)currentEdit.Cantitate
                            };
                            lb.produs.Add(newProdus);
                            lb.SaveChanges();
                        }
                        break;
                    //Birotica
                    case 2:
                        var newBirotica = new birotica()
                        {
                            Denumire = currentEdit.Titlu,
                            Descriere = currentEdit.Descriere,
                        };
                        var biroticaAdaugata = lb.birotica.Add(newBirotica);
                        lb.SaveChanges();
                        if (biroticaAdaugata.IdBirotica > -1)
                        {
                            var newProdus = new produs()
                            {
                                IdTipProdus = lb.tipprodus.FirstOrDefault(x => x.TipProdus1.Equals(currentEdit.TipProdus)).IdTipProdus,
                                Pret = (double)currentEdit.Pret,
                                Cantitate = (int)currentEdit.Cantitate
                            };
                            lb.produs.Add(newProdus);
                            lb.SaveChanges();
                        }
                        break;
                }
                UpdateGrid("Adauga");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var IdTipProdus = lb.tipprodus.FirstOrDefault(x => x.TipProdus1.Equals(currentEdit.TipProdus)).IdTipProdus;
                switch (IdTipProdus)
                {
                    //Carte
                    case 1:
                        var getCarte = lb.carte.Where(x => x.IdCarte.Equals(currentEdit.Id)).FirstOrDefault();
                        getCarte.ISBN = currentEdit.ISBN;
                        getCarte.Titlu = currentEdit.Titlu;
                        getCarte.Descriere = currentEdit.Descriere;
                        getCarte.IdEditura = lb.editura.FirstOrDefault(x => x.Nume.Equals(currentEdit.Editura)).IdEditura;
                        getCarte.An = (int)currentEdit.An;
                        getCarte.NrPagini = (int)currentEdit.NrPagini;
                        getCarte.Locatie = currentEdit.Locatie;
                        getCarte.IdAutor = lb.autor.FirstOrDefault(x => x.Nume.Equals(currentEdit.Autor)).IdAutor;
                        getCarte.IdDomeniu = lb.domeniu.FirstOrDefault(x => x.Domeniu1.Equals(currentEdit.Domeniu)).IdDomeniu;
                        lb.SaveChanges();
                        var getProdusCarte = lb.produs.Where(x => x.Produs1 == getCarte.IdCarte && x.IdTipProdus == IdTipProdus).FirstOrDefault();
                        getProdusCarte.Pret = (double)currentEdit.Pret;
                        getProdusCarte.Cantitate = (int)currentEdit.Cantitate;
                        lb.SaveChanges();
                        break;
                    //Birotica
                    case 2:
                        var getBirotica = lb.birotica.Where(x => x.IdBirotica.Equals(currentEdit.Id)).FirstOrDefault();
                        getBirotica.Denumire = currentEdit.Titlu;
                        getBirotica.Descriere = currentEdit.Descriere;
                        //lb.SaveChanges();
                        var getProdusBirotica = lb.produs.Where(x => x.Produs1 == getBirotica.IdBirotica && x.IdTipProdus == IdTipProdus).FirstOrDefault();
                        getProdusBirotica.Pret = (double)currentEdit.Pret;
                        getProdusBirotica.Cantitate = (int)currentEdit.Cantitate;
                        lb.SaveChanges();
                        break;
                }
                UpdateGrid("Modifica");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var IdTipProdus = lb.tipprodus.FirstOrDefault(x => x.TipProdus1.Equals(currentEdit.TipProdus)).IdTipProdus;
                switch (IdTipProdus)
                {
                    //Carte
                    case 1:
                        var getCarte = lb.carte.Where(x => x.IdCarte.Equals(currentEdit.Id)).FirstOrDefault();
                        lb.carte.Remove(getCarte);
                        lb.SaveChanges();
                        var getProdusCarte = lb.produs.Where(x => x.Produs1 == getCarte.IdCarte && x.IdTipProdus == IdTipProdus).FirstOrDefault();
                        lb.produs.Remove(getProdusCarte);
                        lb.SaveChanges();
                        break;
                    //Birotica
                    case 2:
                        var getBirotica = lb.birotica.Where(x => x.IdBirotica.Equals(currentEdit.Id)).FirstOrDefault();
                        lb.birotica.Remove(getBirotica);
                        lb.SaveChanges();
                        var getProdusBirotica = lb.produs.Where(x => x.Produs1 == getBirotica.IdBirotica && x.IdTipProdus == IdTipProdus).FirstOrDefault();
                        lb.produs.Remove(getProdusBirotica);
                        lb.SaveChanges();
                        break;
                }
                UpdateGrid("Sterge");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region helper stuff

        private void SetCarteFieldsVisible(bool value)
        {
            lblISBN.Visible = value;
            tbISBN.Visible = value;
            lbAn.Visible = value;
            tbAn.Visible = value;
            lbNrPagini.Visible = value;
            tbNrPagini.Visible = value;
            lblLocatie.Visible = value;
            tbLocatie.Visible = value;
            lblAutor.Visible = value;
            cmbAutor.Visible = value;
            lblDomeniu.Visible = value;
            cmbDomeniu.Visible = value;
            lblEditura.Visible = value;
            cmbEditura.Visible = value;
        }

        private class EditItem
        {
            public int Id { get; set; }
            public string TipProdus { get; set; }
            public string Titlu { get; set; }
            public string Descriere { get; set; }
            public decimal Pret { get; set; }
            public decimal Cantitate { get; set; }
            public string ISBN { get; set; }
            public decimal An { get; set; }
            public decimal NrPagini { get; set; }
            public string Locatie { get; set; }
            public string Autor { get; set; }
            public string Domeniu { get; set; }
            public string Editura { get; set; }
        }

        private EditItem GetEditItem()
        {
            var newEdit = new EditItem()
            {
                Id = IdSelected,
                TipProdus = cmbTipProdus.Text,
                Titlu = tbTitlu.Text,
                Descriere = tbDescriere.Text,
                Pret = tbPret.Value,
                Cantitate = tbCantitate.Value,
                ISBN = tbISBN.Text,
                An = tbAn.Value,
                NrPagini = tbNrPagini.Value,
                Locatie = tbLocatie.Text,
                Autor = cmbAutor.Text,
                Domeniu = cmbDomeniu.Text,
                Editura = cmbEditura.Text,
            };
            return newEdit;
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
            this.cartedetaliuTableAdapter.Fill(this.librarieDataSet.cartedetaliu);
        }

        #endregion
    }
}
