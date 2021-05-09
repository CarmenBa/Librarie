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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login m = new Login();
            m.Show();
        }

        private void btnAdaugaProduse_Click(object sender, EventArgs e)
        {
            Produse m = new Produse();
            m.Show();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AdaugaClient m = new AdaugaClient();
            m.Show();
        }

        private void btnEditFurnizor_Click(object sender, EventArgs e)
        {
            Furnizor m = new Furnizor();
            m.Show();
        }

        private void btnEditAutor_Click(object sender, EventArgs e)
        {
            Autori m = new Autori();
            m.Show();
        }

        private void btnEditEdituri_Click(object sender, EventArgs e)
        {
            Edituri m = new Edituri();
            m.Show();
        }

        private void btnEditDomenii_Click(object sender, EventArgs e)
        {
            Domenii m = new Domenii();
            m.Show();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            Oferta m = new Oferta();
            m.Show();
        }

        private void btnAchizitii_Click(object sender, EventArgs e)
        {
            Achizitii m = new Achizitii();
            m.Show();
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            Plati m = new Plati();
            m.Show();
        }

        private void btnRaportVanzari_Click(object sender, EventArgs e)
        {
            Vanzari m = new Vanzari();
            m.Show();
        }

        private void btnRaportStocuri_Click(object sender, EventArgs e)
        {
            Stocuri m = new Stocuri();
            m.Show();
        }

        private void btnRaportSoldFurnizori_Click(object sender, EventArgs e)
        {
            SoldFurnizori m = new SoldFurnizori();
            m.Show();
        }

        private void btnRaportFacturi_Click(object sender, EventArgs e)
        {
            FacturiPlata m = new FacturiPlata();
            m.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
