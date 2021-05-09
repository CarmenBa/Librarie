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
    public partial class RaportStocuri : Form
    {
        void PopulateDG(string tip, int min, int max)
        {
            Code.Stocuri stoc = new Code.Stocuri(tip, min, max);
            dataGridView1.DataSource = stoc.rows.CopyToDataTable();
        }
        public RaportStocuri(string tip, int min, int max)
        {

            InitializeComponent();

            PopulateDG(tip, min, max);
        }

        private void RaportStocuri_Load(object sender, EventArgs e)
        {/*
            //Create a New DataTable to store the Data

            DataTable People = new DataTable("People");

            //Create the Columns in the DataTable

            DataColumn c0 = new DataColumn("Produs");
            DataColumn c1 = new DataColumn("Categorie");
            DataColumn c2 = new DataColumn("Descriere");
            DataColumn c3 = new DataColumn("Cantitate");

            //Add the Created Columns to the Datatable

            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);


            DataRow row, row1, row2, row3;

            row = People.NewRow();

            row["Produs"] = "Amintiri din copilarie";
            row["Categorie"] = "Birotica";
            row["Descriere"] = "Carte cu povestiri de I. Creanga";
            row["Cantitate"] = "15";

            row1 = People.NewRow();

            row1["Produs"] = "Culegere de matematica";
            row1["Categorie"] = "Birotica";
            row1["Descriere"] = "Culegere pentru BAC";
            row1["Cantitate"] = "6";

            row2 = People.NewRow();

            row2["Produs"] = "Carte de poezii";
            row2["Categorie"] = "Carti";
            row2["Descriere"] = "Opera lui Mihai Eminescu";
            row2["Cantitate"] = "17";

            row3 = People.NewRow();

            row3["Produs"] = "Programare C#";
            row3["Categorie"] = "Carti";
            row3["Descriere"] = "Bazele programarii in C#";
            row3["Cantitate"] = "12";


            //Add 3 rows to table

            People.Rows.Add(row);
            People.Rows.Add(row1);
            People.Rows.Add(row2);
            People.Rows.Add(row3);


            dataGridView1.DataSource = People;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }*/
        }
    }
}
