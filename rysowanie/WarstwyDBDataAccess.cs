using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanie
{
    public class WarstwyDbDataAccess
    {

        public static List<WarstwaDb> GetData()
        {
            List<WarstwaDb> listaWarstw = new List<WarstwaDb>();
            WarstwyDBEntities warstwyDbEntities = new WarstwyDBEntities();
            foreach (var warstwa in warstwyDbEntities.Warstwy)
            {
                WarstwaDb warstwaDb = new WarstwaDb
                {
                    Id = warstwa.Id,
                    Nazwa = warstwa.Nazwa,
                    Miazszosc = warstwa.Miazszosc.Value,
                    WspFiltracji = warstwa.WspFiltracji.Value,
                    KolorA = warstwa.Kolor_A.Value,
                    KolorR = warstwa.Kolor_R.Value,
                    KolorG = warstwa.Kolor_G.Value,
                    KolorB = warstwa.Kolor_B.Value
                };
                listaWarstw.Add(warstwaDb);
            }
            return listaWarstw;
        }

    }
}
