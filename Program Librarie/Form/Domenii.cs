using Program_Librarie.DB;
using System;
using System.Linq;
using System.Windows.Forms;
using static Program_Librarie.LibrarieDataSet;

namespace Program_Librarie
{
    public partial class Domenii : Form
    {
        private int IdSelected;

        public Domenii()
        {
            InitializeComponent();
        }

        private void Domenii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.domeniu' table. You can move, or remove it, as needed.
            this.domeniuTableAdapter.Fill(this.librarieDataSet.domeniu);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (domeniuRow)interimar.Row;
                IdSelected = rowDetaliu.IdDomeniu;
                tbNume.Text = rowDetaliu.Domeniu;
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                if (!lb.domeniu.Any(x => x.Domeniu1.Equals(currentEdit.Domeniu, StringComparison.OrdinalIgnoreCase)))
                {
                    var newDomeniu = new domeniu()
                    {
                        Domeniu1 = currentEdit.Domeniu,
                    };
                    lb.domeniu.Add(newDomeniu);
                    lb.SaveChanges();
                    UpdateGrid("Adauga");
                }
                else
                {
                    MessageBox.Show("Exista deja domeniu cu acest nume.");
                }
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var domeniu = lb.domeniu.FirstOrDefault(x => x.IdDomeniu == currentEdit.Id);
                domeniu.Domeniu1 = currentEdit.Domeniu;
                lb.SaveChanges();
                UpdateGrid("Modificat");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                if (!lb.carte.Any(x => x.IdAutor == currentEdit.Id))
                {
                    var domeniu = lb.domeniu.FirstOrDefault(x => x.IdDomeniu == currentEdit.Id);
                    lb.domeniu.Remove(domeniu);
                    lb.SaveChanges();
                    UpdateGrid("Sterge");
                }
                else
                {
                    MessageBox.Show("Exista carti care folosesc acest domeniu. Nu puteti sterge domeniul.");
                }
            }
        }

        private class EditItem
        {
            public int Id { get; set; }
            public string Domeniu { get; set; }
        }

        private EditItem GetEditItem()
        {
            var newEdit = new EditItem()
            {
                Id = IdSelected,
                Domeniu = tbNume.Text,
            };
            return newEdit;
        }

        private void UpdateGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Domeniu sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Domeniu adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Domeniu salvat.");
                    break;
                default:
                    break;
            }
            this.domeniuTableAdapter.Fill(this.librarieDataSet.domeniu);
        }
    }
}
