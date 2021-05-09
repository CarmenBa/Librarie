using Program_Librarie.DB;
using System.Linq;
using System.Windows.Forms;

namespace Program_Librarie.Code
{
    class Login
    {
        public static string Utilizator { get; set; }
        public static int GradSecuritate { get; set; }

        public static bool Connect(string id, string password)
        {
            return true;
            using (LabDataContext lb = new LabDataContext())
            {
                var utilizator = lb.utilizator.FirstOrDefault(x => x.IdUtilizator.Equals(id) && x.Parola.Equals(password));
                if (utilizator != null)
                {
                    Utilizator = utilizator.IdUtilizator;
                    GradSecuritate = utilizator.GradSecuritate;
                    return true;
                }
                else
                {
                    MessageBox.Show("Utilizatorul sau parola nu sunt introduse corect");
                    return false;
                }
            }
        }
    }
}
