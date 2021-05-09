using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Librarie.Code
{
    class OfertaDetails
    {
        public int Id { get; set; }
        public DateTime DataExpirare { get; set; }
        public string Serie { get; set; }
        public string Numar { get; set; }

    }
    class Oferta
    {
        public DataRow[] rows;

        public void Update(int id, string oferta)
        {
            rows = MySQL.GetQuery(string.Format("select P.Descriere, COALESCE(B.Denumire, C.Titlu)" +
                " as Denumire, LO.PretFurnizor, LO.Cantitate from " +
                "Produs P left join Carte C on P.IdProdus = C.IdCarte left join birotica B " +
                "on P.IdProdus = B.IdBirotica left join linieoferta LO " +
                "on P.IdProdus = LO.IdProdus left join oferta O on LO.IdOferta = O.IdOferta left join" +
                " furnizor F on O.IdFurnizor = F.IdFurnizor " +
                "where F.IdFurnizor = '{0}' and O.Denumire = '{1}'", id, oferta));

        }

        public static void Get(int id,ComboBox comboBox)
        {
            var rows = MySQL.GetQuery(string.Format("select O.Denumire" +
                " from oferta O left join furnizor F on O.IdFurnizor = F.IdFurnizor " +
                "where F.IdFurnizor = '{0}'", id));

            comboBox.Items.Clear();
            comboBox.Text = "";

            if (rows.Length < 1)
                return;

            foreach(var row in rows)
                comboBox.Items.Add(row[0]);

            comboBox.SelectedIndex = 0;
        }

        public static void GetDetails(string oferta, TextBox serie, TextBox numar, DateTimePicker data)
        {
            var row = MySQL.GetQuery(string.Format("select DataExpirare, Numar, Serie from oferta " +
                "where Denumire = '{0}'", oferta));

            serie.Text = row[0][2].ToString();
            numar.Text = row[0][1].ToString();
            data.Value = DateTime.Parse(row[0][0].ToString());
        }
    

    }
}
