using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Program_Librarie.Code
{
    class FurnizoriDetails
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string CUI { get; set; }
        public double Sold { get; set; }
        public string Email { get; set; }
    }

    class Furnizori
    {
        private DataRow[] rows;
        private int currentIndex;

        public FurnizoriDetails details;


        public void Update(ComboBox comboBox)
        {
            foreach(var row in rows)
            {
              
                if(row[1] == comboBox.SelectedItem)
                {
                    details = new FurnizoriDetails();
                    details.Id = int.Parse(row[0].ToString());
                    details.Nume = row[1].ToString();
                    details.CUI = row[2].ToString();
                    details.Sold = Convert.ToDouble(row[3].ToString());
                    details.Email = row[4].ToString();
                }
            }
        }



        public void Populare(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            rows = MySQL.GetQuery(string.Format("select * from Furnizor"));

            for (currentIndex = 0; currentIndex < rows.Length; currentIndex++)
            {
                comboBox.Items.Add(rows[currentIndex][1].ToString());
            }
        }


        public void UpdateIndex(string Nume)
        {
            MySQL.ExecuteQuery(string.Format("update Furnizor set Nume ='{0}' where IdFurnizor='{1}' ", Nume, details.Id));
        }

        public void Delete()
        {
            MySQL.ExecuteQuery(string.Format("delete from plata where IdFurnizor='{0}'", details.Id));
            MySQL.ExecuteQuery(string.Format("delete from oferta where IdFurnizor='{0}'", details.Id));
            MySQL.ExecuteQuery(string.Format("delete from achizitie where IdFurnizor='{0}'", details.Id));
            MySQL.ExecuteQuery(string.Format("delete from Furnizor where IdFurnizor='{0}'", details.Id));

            MessageBox.Show($"Furnizorul { details.Nume } a fost sters");
        }
        public void Next(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex >= comboBox.Items.Count - 1)
                comboBox.SelectedIndex = 0;
            else
                comboBox.SelectedIndex++;

            Update(comboBox);
        }
        public void Back(ComboBox comboBox)
        {
            currentIndex -= 1;

            if (comboBox.SelectedIndex <= 0)
                comboBox.SelectedIndex = comboBox.Items.Count - 1;
            else
                comboBox.SelectedIndex--;

            Update(comboBox);
        }

        public void Insert(FurnizoriDetails details)
        {
            var select = MySQL.GetQuery(string.Format("select IdFurnizor from furnizor ORDER BY IdFurnizor DESC LIMIT 1"));
            int id = int.Parse(select[0][0].ToString()) + 1;

            MySQL.ExecuteQuery(string.Format("insert into Furnizor(IdFurnizor,Nume,CUI,Sold,Email) values('{0}','{1}','{2}','{3}','{4}')",id,details.Nume,details.CUI,details.Sold,details.Email));

            this.details = details;
        }

        public void Update()
        {
            MySQL.ExecuteQuery(string.Format("update furnizor set Nume ='{0}', CUI = '{1}', Sold = '{2}', Email = '{3}' WHERE IdFurnizor = '{4}'", details.Nume, details.CUI, details.Sold, details.Email, details.Id));
        }
    }
}
