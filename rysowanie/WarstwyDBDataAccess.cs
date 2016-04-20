using System;
using System.Collections.Generic;
using System.Linq;

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

        public static bool InsertData(WarstwaDb warstwaDb)
        {
            bool areDataInserted = true;
            try
            {
                WarstwyDBEntities warstwyDbEntities = new WarstwyDBEntities();
                Warstwy warstwa = new Warstwy
                {
                    Nazwa = warstwaDb.Nazwa,
                    Miazszosc = warstwaDb.Miazszosc,
                    WspFiltracji = warstwaDb.WspFiltracji,
                    Kolor_A = warstwaDb.KolorA,
                    Kolor_R = warstwaDb.KolorR,
                    Kolor_G = warstwaDb.KolorG,
                    Kolor_B = warstwaDb.KolorB,
                    Image = null
                };
                warstwyDbEntities.Warstwy.Add(warstwa);
                
                warstwyDbEntities.SaveChanges();
               
                

            }
            catch (Exception exception)
            {
                areDataInserted = false;
            }

            return areDataInserted;
        }

        public static bool EditData(WarstwaDb warstwaDb)
        {
            bool areDataInserted = true;
            try
            {
                WarstwyDBEntities warstwyDbEntities = new WarstwyDBEntities();

                Warstwy warstwa = warstwyDbEntities.Warstwy.FirstOrDefault(t => t.Id == warstwaDb.Id);
                if (warstwa != null)
                {
                    warstwa.Nazwa = warstwaDb.Nazwa;
                    warstwa.Miazszosc = warstwaDb.Miazszosc;
                    warstwa.WspFiltracji = warstwaDb.WspFiltracji;
                    warstwa.Kolor_A = warstwaDb.KolorA;
                    warstwa.Kolor_R = warstwaDb.KolorR;
                    warstwa.Kolor_G = warstwaDb.KolorG;
                    warstwa.Kolor_B = warstwaDb.KolorB;
                    warstwa.Image = null;
                    warstwyDbEntities.SaveChanges();
                }
            }
            catch(Exception exception)
            {
                areDataInserted = false;
            }

            return areDataInserted;
        }

    }
}
