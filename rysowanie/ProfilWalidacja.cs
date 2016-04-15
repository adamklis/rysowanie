namespace rysowanie
{
    public static class ProfilWalidacja
    {
        public static bool MiazszoscWalidacja(string miazszoscString, out double miazszoscDouble)
        {
            bool isValid = false;
            double miazszosc;
            miazszoscDouble = 0;
            if (double.TryParse(miazszoscString, out miazszosc))
            {
                if (miazszosc >= 0.1 && miazszosc <= 100)
                {
                    isValid = true;
                    miazszoscDouble = miazszosc;
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
                if (wspFiltracjiDouble >= 0.0000001 && wspFiltracjiDouble <= 200)
                {
                    isValid = true;
                    wspFiltracjiDouble = wspFiltracji;
                }
            }
            return isValid;

        }

    }
}
