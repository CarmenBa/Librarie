using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Librarie.Code
{

    class DomeniiDetails
    {
        public int Id { get; set; }
        public string Nume { get; set; }

    }

    class Domenii

    {
        private DataRow[] rows;
        private int currentIndex;

        public DomeniiDetails details;


        public void Update(ListBox listBox)
        {
            currentIndex = listBox.SelectedIndex;

            rows = MySQL.GetQuery(string.Format("select IdDomeniu, Domeniu from domeniu"));

            if (rows.Length >= currentIndex)
            {
                details = new DomeniiDetails();
                details.Id = int.Parse(rows[currentIndex][0].ToString());
                details.Nume = rows[currentIndex][1].ToString();
            }
            else
            {
                MessageBox.Show(" Acest rand nu exista");
            }
        }

        public void Populare(ListBox listBox)
        {
            rows = MySQL.GetQuery(string.Format("select IdDomeniu, Domeniu from domeniu"));

            for (currentIndex = 0; currentIndex <= rows.Length - 1; currentIndex++)
            {
                listBox.Items.Add(rows[currentIndex][1].ToString());
            }
        }


        public void Insert(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("insert into domeniu(Domeniu) values('{0}')", Nume));
        }

        public void UpdateIndex(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("update domeniu set Domeniu ='{0}' where IdDomeniu='{1}' ", Nume, details.Id));
        }

        public void Delete()
        {
            MySQL.ExecuteQuery(string.Format("delete from domeniu where IdDomeniu='{0}'", details.Id));

            MessageBox.Show($"Domeniul { details.Nume } a fost sters");
        }

    }
}

