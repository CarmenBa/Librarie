using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Librarie.Code
{

    class ClientDetails
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Varsta { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
    }

    class Client
    {
        private DataRow[] rows;
        private int currentIndex;

        public ClientDetails details;

        public Client() 
        {
            currentIndex = 0;

            Update();
        }
        public void Update()
        {
            rows = MySQL.GetQuery(string.Format("select * from client"));

            if (rows.Length >= currentIndex)
            {
                details = new ClientDetails();
                details.Id = int.Parse(rows[currentIndex][0].ToString());
                details.Nume = rows[currentIndex][1].ToString();
                details.Varsta = rows[currentIndex][2].ToString();
                details.Sex = rows[currentIndex][3].ToString();
                details.Email = rows[currentIndex][4].ToString();

            }
            else
            {
                MessageBox.Show("Acest rand nu exista");
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

            if (currentIndex < 0)
                currentIndex = rows.Length - 1;

            Update();
        }
        public void Insert(ClientDetails details)
        {
            int Id = GetLastProduct() + 1;
            MySQL.ExecuteQuery(string.Format("insert into client(IdClient, Nume, Varsta, Sex, Email) " +
                "values('{0}', '{1}', '{2}', '{3}', '{4}')", Id, details.Nume, details.Varsta, details.Sex, details.Email));

            this.details = details;
        }

        public void UpdateIndex()
        {
            MySQL.ExecuteQuery(string.Format("update client set Nume ='{0}', Varsta ='{1}', Sex = '{2}', Email = '{3}' where IdClient='{4}'",
                details.Nume, details.Varsta, details.Sex, details.Email, details.Id));
        }

        public int GetLastProduct()
        {
            var select = MySQL.GetQuery(string.Format("select IdClient from client ORDER BY IdClient DESC LIMIT 1"));
            return int.Parse(select[0][0].ToString());
        }

        public void Delete()
        {
            var vanzari = MySQL.GetQuery(string.Format("select IdVanzare from vanzari where IdClient='{0}'", details.Id));
            foreach(var row in vanzari)
            {
                MySQL.ExecuteQuery(string.Format("delete from linievanzare where IdVanzare='{0}'", row[0]));
            }

           
            MySQL.ExecuteQuery(string.Format("delete from vanzari where IdClient='{0}'", details.Id));
            MySQL.ExecuteQuery(string.Format("delete from client where IdClient='{0}'", details.Id));

            currentIndex = 0;
            this.Update();
        }

        public void Populare(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            rows = MySQL.GetQuery(string.Format("select * from client"));

            for (currentIndex = 0; currentIndex <= rows.Length - 1; currentIndex++)
            {
                comboBox.Items.Add(rows[currentIndex][1].ToString());
            }
        }

        public void Selected(ComboBox comboBox)
        {
            currentIndex = comboBox.SelectedIndex;
            Update();
        }


    }
}
