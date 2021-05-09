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

namespace Program_Librarie
{
    public partial class Autori : Form
    {
        public Autori()
        {
            InitializeComponent();
        }

        
        Code.Autori autori;

        private void Autori_Load(object sender, EventArgs e)
        {
            autori = new Code.Autori();

            autori.Populare(listBox1);
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            string nume;
            nume = Interaction.InputBox("Introduceți numele complet al autorului pe care doriți să îl adăugați.", "Adăugare autor", "");
            
            if(nume != "")
            {
                autori.Insert(nume);
                listBox1.Items.Clear();
                autori.Populare(listBox1);
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
                string intrebare = "Introduceti numele complet al autorului pe care doriti sa il modificati. Autorul selectat este " + autori.details.Nume;
                string nume = Interaction.InputBox(intrebare, "Modificare autor", "");

                if (nume != "")
                {
                    autori.UpdateIndex(nume);
                    listBox1.Items.Clear();
                    autori.Populare(listBox1);
                }
            
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
                if (listBox1.SelectedItem != null)
                {
                    var mb = MessageBox.Show(this, $"Sunteti sigur ca doriti sa stergeti autorul { autori.details.Nume }?", "Warning", MessageBoxButtons.YesNo);

                    if (mb == DialogResult.Yes)
                    {
                        autori.Delete();
                        listBox1.Items.Clear();
                        autori.Populare(listBox1);
                    }
                }
                else
                {
                    MessageBox.Show("Selecteaza un autor");
                }
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            autori.Update(listBox1);
        }

    }
}
