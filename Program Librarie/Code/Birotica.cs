using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Program_Librarie.Code
{
    class BiroticaDetails
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string Pret { get; set; }
        public string Cantitate { get; set; }  
    }
    class Birotica
    {
        private DataRow[] rows;
        private int currentIndex;

        public BiroticaDetails details;
        
        public Birotica() //unde folosesc eu asta? :))
        {
            currentIndex = 0;

            Update();
        }
        public void Update()
        {
            rows = MySQL.GetQuery(string.Format("select b.IdBirotica, b.Denumire, p.Descriere, " +
                  "p.Pret, p.Cantitate from birotica b inner join produs p on b.IdBirotica=p.IdProdus"));

            if (rows.Length >= currentIndex)
            {
                details = new BiroticaDetails();
                details.Id = int.Parse(rows[currentIndex][0].ToString());
                details.Denumire = rows[currentIndex][1].ToString();
                details.Descriere = rows[currentIndex][2].ToString();
                details.Pret = rows[currentIndex][3].ToString();
                details.Cantitate = rows[currentIndex][4].ToString();
            }
            else
            {
                MessageBox.Show("Birotica - Acest rand nu exista");
            }
        }

        public void Next()
        {
            currentIndex += 1;

            if (currentIndex >= rows.Length)
                currentIndex = 0;

            Update();
        }
        public void Back()
        {
            currentIndex -= 1;

            if (currentIndex <  0)
                currentIndex = rows.Length - 1;

            Update();
        }
        public void Insert(BiroticaDetails details)
        {

            MySQL.ExecuteQuery(string.Format("insert into produs(Descriere, Pret, Cantitate) " +
                "values('{0}', '{1}', '{2}')",  details.Descriere, details.Pret, details.Cantitate));

            MySQL.ExecuteQuery(string.Format("insert into birotica(IdBirotica, Denumire) " +
                "values('{0}', '{1}')", details.Id, details.Denumire));
            this.details = details;
        }

        public void UpdateIndex()
        {
            MySQL.ExecuteQuery(string.Format("update produs set Descriere ='{0}', Pret ='{1}', Cantitate = '{2}' where IdProdus='{3}'"
                , details.Descriere, details.Pret, details.Cantitate, details.Id));

            MySQL.ExecuteQuery(string.Format("update birotica set Denumire ='{0}' where IdBirotica='{1}' ", details.Denumire, details.Id));
        }

        public int GetLastProduct()
        {
            var select = MySQL.GetQuery(string.Format("select IdProdus from produs ORDER BY IdProdus DESC LIMIT 1"));
            return int.Parse(select[0][0].ToString());
        }

        public  void Delete()
        {
            MySQL.ExecuteQuery(string.Format("delete from birotica where IdBirotica='{0}'", details.Id));
            MySQL.ExecuteQuery(string.Format("delete from produs where IdProdus='{0}'", details.Id));

            currentIndex = 0;
            this.Update();
        }

        public void Populare(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            rows = MySQL.GetQuery(string.Format("select b.IdBirotica, b.Denumire, p.Descriere, " +
                  "p.Pret, p.Cantitate from birotica b inner join produs p on b.IdBirotica=p.IdProdus"));

            for (currentIndex = 0; currentIndex <= rows.Length - 1; currentIndex++)
            {
                comboBox.Items.Add(rows[currentIndex][1].ToString());
            }
        }

        public void Selected (ComboBox comboBox)
        {
            currentIndex = comboBox.SelectedIndex;
            Update();
        }

        
    }
}
