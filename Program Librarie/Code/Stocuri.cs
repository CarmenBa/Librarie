using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Librarie.Code
{
    class Stocuri
    {
        public DataRow[] rows;

        public Stocuri(string tip, int min, int max)
        {
             rows = MySQL.GetQuery("SELECT P.IdProdus, P.Cantitate, P.descriere, " +
                "IF(B.Denumire IS NULL, 'Carte', 'Birotica') as Tip, COALESCE(B.denumire, C.titlu) " +
                "AS Denumireprodus from produs P LEFT JOIN carte C ON P.idprodus = C.idcarte LEFT JOIN birotica " +
                "B ON P.idprodus = B.idbirotica");
       
            rows = rows.Where(p => int.Parse(p[1].ToString()) <= max && int.Parse(p[1].ToString()) >= min).ToArray();
       
            if (tip != "Carte" && tip != "Birotica")
                return;

            rows = rows.Where(p => p[3].ToString() == tip).ToArray();
        }
    }
}
