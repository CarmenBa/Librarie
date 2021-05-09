using Microsoft.VisualBasic;
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
    public partial class Edituri : Form
    {
        private int IdSelected;

        public Edituri()
        {
            InitializeComponent();
        }


        private void Edituri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.editura' table. You can move, or remove it, as needed.
            this.edituraTableAdapter.Fill(this.librarieDataSet.editura);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (edituraRow)interimar.Row;
                IdSelected = rowDetaliu.IdEditura;
                tbNume.Text = rowDetaliu.Nume;
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                if (!lb.editura.Any(x => x.Nume.Equals(currentEdit.Nume, StringComparison.OrdinalIgnoreCase)))
                {
                    var newEditura = new editura()
                    {
                        Nume = currentEdit.Nume,
                    };
                    lb.editura.Add(newEditura);
                    lb.SaveChanges();
                    UpdateGrid("Adauga");
                }
                else
                {
                    MessageBox.Show("Exista deja editura cu acest nume.");
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var editura = lb.editura.FirstOrDefault(x => x.IdEditura == currentEdit.Id);
                editura.Nume = currentEdit.Nume;
                lb.SaveChanges();
                UpdateGrid("Modificat");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                if (!lb.carte.Any(x => x.IdEditura == currentEdit.Id))
                {
                    var editura = lb.editura.FirstOrDefault(x => x.IdEditura == currentEdit.Id);
                    lb.editura.Remove(editura);
                    lb.SaveChanges();
                    UpdateGrid("Sterge");
                }
                else
                {
                    MessageBox.Show("Exista carti care folosesc acest editura. Nu puteti sterge edituraul.\r\nVa rugam sa schimbati edituraii.");
                }
            }
        }

        private class EditItem
        {
            public int Id { get; set; }
            public string Nume { get; set; }
        }

        private EditItem GetEditItem()
        {
            var newEdit = new EditItem()
            {
                Id = IdSelected,
                Nume = tbNume.Text,
            };
            return newEdit;
        }

        private void UpdateGrid(string comanda)
        {
            switch (comanda)
            {
                case "Sterge":
                    MessageBox.Show("Editura sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Editura adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Editura salvat.");
                    break;
                default:
                    break;
            }
            this.edituraTableAdapter.Fill(this.librarieDataSet.editura);
        }
    }
}
