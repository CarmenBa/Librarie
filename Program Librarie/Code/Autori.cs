using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Program_Librarie.Code
{
    class AutoriDetails
    {
        public int Id { get; set; }
        public string Nume { get; set; }

    }

    class Autori
    {
        private DataRow[] rows;
        private int currentIndex;

        public AutoriDetails details;


        public void Update(ListBox listBox)
        {
            currentIndex = listBox.SelectedIndex;

            rows = MySQL.GetQuery(string.Format("select IdAutor, Nume from autor"));

            if (rows.Length >= currentIndex)
            {
                details = new AutoriDetails();
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
            rows = MySQL.GetQuery(string.Format("select IdAutor, Nume from autor"));

            for (currentIndex = 0; currentIndex <= rows.Length - 1; currentIndex++)
            {
                listBox.Items.Add(rows[currentIndex][1].ToString());
            }
        }


        public void Insert(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("insert into autor(Nume) values('{0}')", Nume));
        }

        public void UpdateIndex(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("update autor set Nume ='{0}' where IdAutor='{1}' ", Nume, details.Id));
        }

        public void Delete()
        {
            MySQL.ExecuteQuery(string.Format("delete from autor where IdAutor='{0}'", details.Id));

            MessageBox.Show($"Autorul { details.Nume } a fost sters");
        }

    }
}
