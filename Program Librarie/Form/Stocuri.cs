using Program_Librarie.DB;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Program_Librarie
{
    public partial class Stocuri : Form
    {
        public Stocuri()
        {
            InitializeComponent();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
            if (cmbTipProdus.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                var selectedTipProdus = (dynamic)cmbTipProdus.SelectedItem;
                filter += $"IdTipProdus = {selectedTipProdus.IdTipProdus}";
            }
            if (cmbProdus.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                var selectedProdus = (dynamic)cmbProdus.SelectedItem;
                filter += $"Produs = {selectedProdus.Id}";
            }
            if (tbMinim.Value > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"Cantitate >= {tbMinim.Value}";
            }
            if (tbMaxim.Value > 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"Cantitate <= {tbMaxim.Value}";
            }

            dynamic ds = dataGridView1.DataSource;
            ds.Filter = filter;
            dataGridView1.Refresh();
        }

        private void cmbTipProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (LabDataContext lb = new LabDataContext())
            {
                cmbProdus.Items.Clear();
                cmbProdus.ValueMember = "Id";
                cmbProdus.DisplayMember = "Nume";

                var selectedTipProdus = (dynamic)cmbTipProdus.SelectedItem;
                switch ((int)selectedTipProdus.IdTipProdus)
                {
                    //Carte
                    case 1:
                        cmbProdus.Items.AddRange(lb.carte.Select(x => new { Id = x.IdCarte, Nume = x.Titlu }).ToArray<object>());
                        break;
                    //Birotica
                    case 2:
                        cmbProdus.Items.AddRange(lb.birotica.Select(x => new { Id = x.IdBirotica, Nume = x.Denumire }).ToArray<object>());
                        break;
                    default:
                        break;
                }
                cmbProdus.Items.Insert(0, new { Id = -1, Nume = "Toate produsele" });
                cmbProdus.SelectedIndex = 0;
            }
        }

        private void Stocuri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarieDataSet.produs' table. You can move, or remove it, as needed.
            this.produsTableAdapter.Fill(this.librarieDataSet.produs);
            // TODO: This line of code loads data into the 'librarieDataSet.cartedetaliu' table. You can move, or remove it, as needed.
            using (LabDataContext lb = new LabDataContext())
            {
                cmbTipProdus.Items.Clear();
                cmbTipProdus.ValueMember = "IdTipProdus";
                cmbTipProdus.DisplayMember = "TipProdus1";
                cmbTipProdus.Items.AddRange(lb.tipprodus.Select(x => new { x.TipProdus1, x.IdTipProdus }).ToArray<object>());
                cmbTipProdus.Items.Insert(0, new { IdTipProdus = -1, TipProdus1 = "Toate produsele" });
                cmbTipProdus.SelectedIndex = 0;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbTipProdus.SelectedIndex = 0;
            cmbProdus.SelectedIndex = 0;
            tbMinim.Value = 0;
            tbMaxim.Value = 0;
            dynamic ds = dataGridView1.DataSource;
            ds.Filter = string.Empty;
            dataGridView1.Refresh();
        }
    }
}
