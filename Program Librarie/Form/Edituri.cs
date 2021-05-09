using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Librarie
{
    public partial class Edituri : Form
    {
        public Edituri()
        {
            InitializeComponent();
        }

        Code.Edituri edituri;

        private void Edituri_Load(object sender, EventArgs e)
        {
            edituri = new Code.Edituri();

            edituri.Populare(listBox1);
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            string nume;
            nume = Interaction.InputBox("Introduceți numele complet al editurii pe care doriți să o adăugați.", "Adăugare editura", "");

            if (nume != "")
            {
                edituri.Insert(nume);
                listBox1.Items.Clear();
                edituri.Populare(listBox1);
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string intrebare = "Introduceti numele complet al editurii pe care doriti sa o modificati. Editura selectata este " + edituri.details.Nume;
            string nume = Interaction.InputBox(intrebare, "Modificare editura", "");

            if (nume != "")
            {
                edituri.UpdateIndex(nume);
                listBox1.Items.Clear();
                edituri.Populare(listBox1);
            }

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var mb = MessageBox.Show(this, $"Sunteti sigur ca doriti sa stergeti editura { edituri.details.Nume }?", "Warning", MessageBoxButtons.YesNo);

                if (mb == DialogResult.Yes)
                {
                    edituri.Delete();
                    listBox1.Items.Clear();
                    edituri.Populare(listBox1);
                }
            }
            else
            {
                MessageBox.Show("Selecteaza o editura");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            edituri.Update(listBox1);
        }
    }
}
