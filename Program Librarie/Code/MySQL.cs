using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Program_Librarie
{
    class MySQL
    {
        public static MySqlConnection Connection { get; set; }

        public static void Create()
        {  
            try
            {
                if (Connection != null)
                {
                    MessageBox.Show("Aceasta conexiune exista deja.");
                    return;
                }
                Connection = new MySqlConnection("Server=localhost; database=aplicatie_librarie; UID=root; password=");
                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static DataRow[] GetQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, Connection);

            DataTable data = new DataTable();
            data.Load(command.ExecuteReader());

            return data.Select();
        }

        public static void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, Connection);
            command.ExecuteNonQuery();

        }
    }
}
