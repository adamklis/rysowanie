namespace rysowanie
{
    public static class ProfilWalidacja
    {
        public static bool NazwaWalidacja(string nazwa, out string nazwaValid)
        {
            bool isValid = false;
            nazwaValid = string.Empty;
            if (!string.IsNullOrEmpty(nazwa))
            {
                nazwaValid = nazwa;
                isValid = true;
            }

            return isValid;
        }

        public static bool MiazszoscWalidacja(string miazszoscString, out double miazszoscDouble)
        {
            bool isValid = false;
            double miazszosc;
            miazszoscDouble = 0;
            if (double.TryParse(miazszoscString, out miazszosc))
            {
                if (miazszosc >= 0.1 && miazszosc <= 300)
                {
                    isValid = true;
                    miazszoscDouble = miazszosc;
                }
            }
            return isValid;

        }


        public static bool MiazszoscWalidacja(string miazszoscString, out float miazszoscFloat)
        {
            bool isValid = false;
            float miazszosc;
            miazszoscFloat = 0;
            if (float.TryParse(miazszoscString, out miazszosc))
            {
                if (miazszosc >= 0.1 && miazszosc <= 300)
                {
                    isValid = true;
                    miazszoscFloat = miazszosc;
                }
            }
            return isValid;

        }

        public static bool WspFiltracjiWalidacja(string wspFiltracjiString, out double wspFiltracjiDouble)
        {
            bool isValid = false;
            double wspFiltracji;
            wspFiltracjiDouble = 0;
            if (double.TryParse(wspFiltracjiString, out wspFiltracji))
            {
                if (wspFiltracji >= 0.0000001 && wspFiltracji <= 400)
                {
                    isValid = true;
                    wspFiltracjiDouble = wspFiltracji;
                }
            }
            return isValid;

        }

        public static bool WspFiltracjiWalidacja(string wspFiltracjiString, out float wspFiltracjiFloat)
        {
            bool isValid = false;
            float wspFiltracji;
            wspFiltracjiFloat = 0;
            if (float.TryParse(wspFiltracjiString, out wspFiltracji))
            {
                if (wspFiltracji >= 0.00000001 && wspFiltracji <= 400)
                {
                    isValid = true;
                    wspFiltracjiFloat = wspFiltracji;
                }
            }
            return isValid;

        }


        public static bool ZwierciadloWalidacja(string glebokoscZwierciadlaString, out double glebokoscZwierciadlaDouble)
        {
            bool isValid = false;
            double glebokoscZwierciadla;
            glebokoscZwierciadlaDouble = 0;
            if (double.TryParse(glebokoscZwierciadlaString, out glebokoscZwierciadla))
            {
                if (glebokoscZwierciadla >= 0.1 && glebokoscZwierciadla <= 200)
                {
                    isValid = true;
                    glebokoscZwierciadlaDouble = glebokoscZwierciadla;
                }
            }
            return isValid;
        }

        public static bool PolozenieZwierciadlaWalidacja(Profil profil, double glebokoscZwierciadla)
        {
            return !(profil.Glebokosc <= glebokoscZwierciadla);
        }

        public static bool PolozenieZwierciadelWzgledemSiebieWalidacja(double zwierciadloNawiercone, double zwierciadloUstalone)
        {
            return zwierciadloNawiercone > zwierciadloUstalone;
        }
        

    }
}
