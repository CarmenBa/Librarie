using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Librarie.Code
{
    class EdituriDetails
    {
        public int Id { get; set; }
        public string Nume { get; set; }

    }

    class Edituri

    {
        private DataRow[] rows;
        private int currentIndex;

        public DomeniiDetails details;


        public void Update(ListBox listBox)
        {
            currentIndex = listBox.SelectedIndex;

            rows = MySQL.GetQuery(string.Format("select IdEditura, Nume from editura"));

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
            rows = MySQL.GetQuery(string.Format("select IdEditura, Nume from editura"));

            for (currentIndex = 0; currentIndex <= rows.Length - 1; currentIndex++)
            {
                listBox.Items.Add(rows[currentIndex][1].ToString());
            }
        }


        public void Insert(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("insert into editura(Nume) values('{0}')", Nume));
        }

        public void UpdateIndex(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("update editura set Nume ='{0}' where IdEditura='{1}' ", Nume, details.Id));
        }

        public void Delete()
        {
            MySQL.ExecuteQuery(string.Format("delete from editura where IdEditura='{0}'", details.Id));

            MessageBox.Show($"Editura { details.Nume } a fost stearsă");
        }

    }
}
