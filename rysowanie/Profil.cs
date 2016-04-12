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

        public void NowaWarstwa(Warstwa warstwa, double miazszosc)
        {
            double glebokoscStropu = _glebokosc;
            double glebokoscSpagu = glebokoscStropu + miazszosc;
            Warstwy.Add(new Warstwa(warstwa.Grafika, warstwa.Nazwa, warstwa.WspolczynnikFiltracji, glebokoscStropu, glebokoscSpagu, miazszosc));
            _glebokosc += miazszosc;
            
        }

        public void NowaWarstwa(Warstwa warstwa, double glebokoscStropu, double glebokoscSpagu)
        {
            double miazszosc = glebokoscSpagu - glebokoscStropu;
            Warstwy.Add(new Warstwa(warstwa.Grafika,warstwa.Nazwa,warstwa.WspolczynnikFiltracji,glebokoscStropu, glebokoscSpagu,miazszosc));
            _glebokosc += miazszosc;
        }
        


        public void UsunWarstwe(int indeks)
        {
            _glebokosc -= _warstwy[indeks].GlebokoscSpagu - _warstwy[indeks].GlebokoscSpagu;
            Warstwy.RemoveAt(indeks);
            
        }

    }

}
