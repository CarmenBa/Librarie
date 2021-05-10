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

namespace Program_Librarie
{
    public partial class SoldFurnizori : Form
    {
        public SoldFurnizori()
        {
            InitializeComponent();
        }

        private void SoldFurnizori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.furnizor' table. You can move, or remove it, as needed.
            this.furnizorTableAdapter.Fill(this.librarieDataSet.furnizor);
            using (LabDataContext lb = new LabDataContext())
            {
                cmbFurnizor.Items.Clear();
                cmbFurnizor.ValueMember = "IdFurnizor";
                cmbFurnizor.DisplayMember = "Nume";
                cmbFurnizor.Items.AddRange(lb.furnizor.Select(x => new { x.Nume, x.IdFurnizor }).ToArray<object>());
                cmbFurnizor.Items.Insert(0, new { IdFurnizor = -1, Nume = "Toti furnizorii" });
                cmbFurnizor.SelectedIndex = 0;
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
            if (cmbFurnizor.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                var selectedFurnizor = (dynamic)cmbFurnizor.SelectedItem;
                filter += $"IdFurnizor = {selectedFurnizor.IdFurnizor}";
            }
            if (tbValMin.Value > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"Sold >= {tbValMin.Value}";
            }
            if (tbValMax.Value > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"Sold <= {tbValMax.Value}";
            }
            dynamic ds = dataGridView1.DataSource;
            ds.Filter = filter;
            dataGridView1.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbFurnizor.SelectedIndex = 0;
            tbValMin.Value = 0;
            tbValMax.Value = 0;
            dynamic ds = dataGridView1.DataSource;
            ds.Filter = string.Empty;
            dataGridView1.Refresh();
        }
    }
}
