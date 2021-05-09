using System.Windows.Forms;

namespace Program_Librarie.Code
{
    public static class Extensions
    {
        public static int GetNumber(this TextBox tb, int def)
        {
            int output = 0;

            if (int.TryParse(tb.Text, out output))
                return output;
            return def;
        }
    }
}
