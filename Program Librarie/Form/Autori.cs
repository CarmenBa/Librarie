using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Program_Librarie.DB;
using static Program_Librarie.LibrarieDataSet;

namespace Program_Librarie
{
    public partial class Autori : Form
    {
        private int IdSelected;

        public Autori()
        {
            InitializeComponent();
        }


        private void Autori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.librarieDataSet.autor);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (autorRow)interimar.Row;
                IdSelected = rowDetaliu.IdAutor;
                tbNume.Text = rowDetaliu.Nume;
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                if (!lb.autor.Any(x => x.Nume.Equals(currentEdit.Nume, StringComparison.OrdinalIgnoreCase)))
                {
                    var newAutor = new autor()
                    {
                        Nume = currentEdit.Nume,
                    };
                    lb.autor.Add(newAutor);
                    lb.SaveChanges();
                    UpdateGrid("Adauga");
                }
                else
                {
                    MessageBox.Show("Exista deja autor cu acest nume.");
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var currentEdit = GetEditItem();
            using (LabDataContext lb = new LabDataContext())
            {
                var autor = lb.autor.FirstOrDefault(x => x.IdAutor == currentEdit.Id);
                autor.Nume = currentEdit.Nume;
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
                    var autor = lb.autor.FirstOrDefault(x => x.IdAutor == currentEdit.Id);
                    lb.autor.Remove(autor);
                    lb.SaveChanges();
                    UpdateGrid("Sterge");
                }
                else
                {
                    MessageBox.Show("Exista carti care folosesc acest autor. Nu puteti sterge autorul.\r\nVa rugam sa schimbati autorii.");
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
                    MessageBox.Show("Autor sters.");
                    break;
                case "Adauga":
                    MessageBox.Show("Autor adaugat.");
                    break;
                case "Modifica":
                    MessageBox.Show("Autor salvat.");
                    break;
                default:
                    break;
            }
            this.autorTableAdapter.Fill(this.librarieDataSet.autor);
        }
    }
}
