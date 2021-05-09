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
    public partial class Domenii : Form
    {
        public Domenii()
        {
            InitializeComponent();
        }

        Code.Domenii domenii;
        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Domenii_Load(object sender, EventArgs e)
        {
            domenii = new Code.Domenii();

            domenii.Populare(listBox1);
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            string nume;
            nume = Interaction.InputBox("Introduceți numele complet al domeniului pe care doriți să îl adăugați.", "Adăugare domeniu", "");

            if (nume != "")
            {
                domenii.Insert(nume);
                listBox1.Items.Clear();
                domenii.Populare(listBox1);
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string intrebare = "Introduceti numele complet al domeniului pe care doriti sa il modificati. Domeniul selectat este " + domenii.details.Nume;
            string nume = Interaction.InputBox(intrebare, "Modificare domeniu", "");

            if (nume != "")
            {
                domenii.UpdateIndex(nume);
                listBox1.Items.Clear();
                domenii.Populare(listBox1);
            }

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var mb = MessageBox.Show(this, $"Sunteti sigur ca doriti sa stergeti domeniul { domenii.details.Nume }?", "Warning", MessageBoxButtons.YesNo);

                if (mb == DialogResult.Yes)
                {
                    domenii.Delete();
                    listBox1.Items.Clear();
                    domenii.Populare(listBox1);
                }
            }
            else
            {
                MessageBox.Show("Selecteaza un domeniu");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            domenii.Update(listBox1);
        }
    }
}
