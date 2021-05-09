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
    public partial class Achizitii : Form
    {
        public Achizitii()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Achizitii_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "Pixar S.A.";
            textBox1.Text = "RO1421486rt";
            textBox3.Text = "VX";
            textBox4.Text = "1026";

            //Create a New DataTable to store the Data

            DataTable People = new DataTable("People");

            //Create the Columns in the DataTable

            DataColumn c0 = new DataColumn("Produs");
            DataColumn c1 = new DataColumn("Categorie");
            DataColumn c2 = new DataColumn("PretUnitar");
            DataColumn c3 = new DataColumn("Cantitate");
            DataColumn c4 = new DataColumn("Valoare");

            //Add the Created Columns to the Datatable

            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);
            People.Columns.Add(c4);


            DataRow row, row1, row2, row3;

            row = People.NewRow();

            row["Produs"] = "Pix cu gel";
            row["Categorie"] = "Birotica";
            row["PretUnitar"] = "1.5";
            row["Cantitate"] = "100";
            row["Valoare"] = "150";

            row1 = People.NewRow();

            row1["Produs"] = "Caiet de matematica";
            row1["Categorie"] = "Birotica";
            row1["PretUnitar"] = "3.5";
            row1["Cantitate"] = "60";
            row1["Valoare"] = "210";

            row2 = People.NewRow();

            row2["Produs"] = "Carte de poezii";
            row2["Categorie"] = "Carti";
            row2["PretUnitar"] = "35";
            row2["Cantitate"] = "7";
            row2["Valoare"] = "245";

           


            //Add 3 rows to table

            People.Rows.Add(row);
            People.Rows.Add(row1);
            People.Rows.Add(row2);


            dataGridView1.DataSource = People;
            for (int i = 0; i < dataGridView1.Columns.Count; i += 4)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
