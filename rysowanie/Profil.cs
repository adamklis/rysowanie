using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanie
{
    class Profil
    {
        private List<Warstwa> _warstwy;
        private double _zwierciadloUstalone;
        private double _zwierciadloNawiercone;
        private double _glebokosc;

        internal List<Warstwa> Warstwy
        {
            get
            {
                return _warstwy;
            }

            set
            {
                _warstwy = value;
            }
        }
        public double ZwierciadloUstalone
        {
            get
            {
                return _zwierciadloUstalone;
            }

            set
            {
                _zwierciadloUstalone = value;
            }
        }
        public double ZwierciadloNawiercone
        {
            get
            {
                return _zwierciadloNawiercone;
            }

            set
            {
                _zwierciadloNawiercone = value;
            }
        }

        public double Glebokosc
        {
            get
            {
                return _glebokosc;
            }
        }

        public Profil()
        {
            _warstwy = new List<Warstwa>();
        }

        public void NowaWarstwa(Warstwa warstwa)
        {
            if (warstwa.GlebokoscStropu ==0 && warstwa.GlebokoscSpagu == 0)
            {
                double glebokoscStropu = _glebokosc;
                double glebokoscSpagu = glebokoscStropu + warstwa.Miazszosc;
                Warstwy.Add(new Warstwa(warstwa.Grafika, warstwa.Nazwa, warstwa.WspolczynnikFiltracji, glebokoscStropu, glebokoscSpagu, warstwa.Miazszosc));
                _glebokosc += warstwa.Miazszosc;
            }
            else
            {
                double miazszosc = (double)(warstwa.GlebokoscSpagu - warstwa.GlebokoscStropu);
                Warstwy.Add(new Warstwa(warstwa.Grafika, warstwa.Nazwa, warstwa.WspolczynnikFiltracji, warstwa.GlebokoscStropu, warstwa.GlebokoscSpagu, miazszosc));
                _glebokosc += miazszosc;
            }
          

        }
       //TODO UsunWarstwe() Do poprawienia!!
        public void UsunWarstwe(int indeks) 
        {
            _glebokosc -=(double) (_warstwy[indeks].GlebokoscSpagu - _warstwy[indeks].GlebokoscSpagu);
            Warstwy.RemoveAt(indeks);
            
        }

    }

}
