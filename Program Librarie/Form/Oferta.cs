using Program_Librarie.Code;
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
    public partial class Oferta : Form
    {
        
        public Oferta()
        {
            InitializeComponent();
        }

        private void paginăPrincipalăToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Code.Oferta oferta = new Code.Oferta();
        Code.Furnizori furnizor = new Code.Furnizori();

        private void UpdateGrid()
        {
            if (cbOferta.SelectedItem == null)
            {
                grid.DataSource = null;
                return;
            }
            Code.Oferta.GetDetails(cbOferta.SelectedItem.ToString(), txtSerie, txtNumar, dtpDate);
            oferta.Update(furnizor.details.Id, cbOferta.SelectedItem.ToString());
            grid.DataSource = oferta.rows.CopyToDataTable();
        }

        private void Oferta_Load(object sender, EventArgs e)
        { 
            furnizor.Populare(cbDenumire);

            cbDenumire.SelectedIndex = 0;
            cbOferta.SelectedIndex = 0;
            
        }

        private void cbDenumire_SelectedIndexChanged(object sender, EventArgs e)
        {
            furnizor.Update(cbDenumire);

            Code.Oferta.Get(furnizor.details.Id, cbOferta);
            txtCUI.Text = furnizor.details.CUI;

            cbOferta_SelectedIndexChanged(sender, e);
        }

        private void cbOferta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            UpdateGrid();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Salvează";
            cbDenumire.Text = "";
            cbOferta.Text = "";
            txtCUI.Text = "";
            txtNumar.Text = "";
            txtSerie.Text = "";
            ((DataTable)grid.DataSource).Rows.Clear();

        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            btnModifica.Text = "Modifică";
        }
    }
}
