using System.Collections.Generic;

namespace rysowanie
{
    public class WarstwyDbDataAccess
    {

        public static List<WarstwaDb> GetData()
        {

            List<WarstwaDb> listaWarstw = new List<WarstwaDb>();
            try
            {
                WarstwyDBEntities warstwyDbEntities = new WarstwyDBEntities();
                foreach (var warstwa in warstwyDbEntities.Warstwy)
                {
                    if (warstwa != null)
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
                }
            }
            catch
            {
                WarstwaDb warstwaDb = new WarstwaDb
                {
                    Id = 0,
                    Nazwa = "Nie można załadować danych",
                    Miazszosc = 10,
                    WspFiltracji = 1,
                    KolorA = 0,
                    KolorR = 0,
                    KolorG = 0,
                    KolorB = 0
                };
                listaWarstw.Add(warstwaDb);
            }
            return listaWarstw;
        }

    }
}
