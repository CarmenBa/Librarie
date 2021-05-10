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
    public partial class Vanzari : Form
    {
        public Vanzari()
        {
            InitializeComponent();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            this.linievanzareTableAdapter.Fill(this.librarieDataSet.linievanzare);
            if (rbPerioada.Checked)
            {
                dynamic ds = dgvVanzari.DataSource;
                ds.Filter = $"Data >= '{dtFrom.Value.ToString("dd/MM/yyyy")}' AND Data <= '{dtTo.Value.ToString("dd/MM/yyyy")}'";
                dgvVanzari.Refresh();
            }
            else
            {
                dynamic ds = dgvVanzari.DataSource;
                ds.Filter = string.Empty;
                dgvVanzari.Refresh();
            }
            var total = 0.00;
            for (var i = 0; i < dgvVanzari.Rows.Count; i++)
            {
                var row = dgvVanzari.Rows[i];
                dynamic interimar = row.DataBoundItem;
                var rowDetaliu = (linievanzareRow)interimar.Row;
                total += rowDetaliu.Pret * rowDetaliu.Cantitate;
            }
            lbActualTotal.Text = $"{total} RON";
        }

        private void Vanzari_Load(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbTot.Checked = true;
            dtFrom.Value = new DateTime(2019, 1, 1, 0, 0, 0);
            dtTo.Value = new DateTime(2020, 1, 1, 0, 0, 0);
            lbActualTotal.Text = string.Empty;
            dynamic ds = dgvVanzari.DataSource;
            ds.Filter = string.Empty;
            dgvVanzari.Refresh();
        }
    }
}
