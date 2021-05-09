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
    public partial class FacturiPlata : Form
    {
        public FacturiPlata()
        {
            InitializeComponent();
        }

        private void FacturiPlata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.platadetaliu' table. You can move, or remove it, as needed.
            this.platadetaliuTableAdapter.Fill(this.librarieDataSet.platadetaliu);
            using (LabDataContext lb = new LabDataContext())
            {
                cmbFurnizor.Items.Clear();
                cmbFurnizor.Items.AddRange(lb.furnizor.Select(x => x.Nume).ToArray<object>());
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            var cauta = new
            {
                furnizor = cmbFurnizor.Text,
                valMin = tbValMin.Value,
                valMax = tbValMax.Value
            };
            string filter = string.Empty;
            if (!string.IsNullOrEmpty(cauta.furnizor))
            {
                using (LabDataContext lb = new LabDataContext())
                {
                    var idFurnizor = lb.furnizor.FirstOrDefault(x => x.Nume.Equals(cauta.furnizor, StringComparison.OrdinalIgnoreCase)).IdFurnizor;
                    filter = $"IdFurnizor = {idFurnizor}";
                }
            }
            if (!string.IsNullOrEmpty(filter))
            {
                filter += $" AND ";
            }
            filter += $"Suma >= {cauta.valMin}";
            if (cauta.valMax > 0)
            {
                filter += $" AND Suma <= {cauta.valMax}";

            }
            dynamic ds = dataGridView1.DataSource;
            ds.Filter = filter;
            dataGridView1.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFurnizor.Text = string.Empty;
            tbValMin.Value = 0;
            tbValMax.Value = 0;
            dynamic ds = dataGridView1.DataSource;
            ds.Filter = string.Empty;
            dataGridView1.Refresh();
        }
    }
}
