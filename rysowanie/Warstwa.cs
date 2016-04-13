using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanie
{
    class Warstwa : Profil
    {
        private string _nazwa;
        private double _miazszosc=0;
        private double _wspolczynnikFiltracji;
        private double _glebokoscStropu=0;
        private double _glebokoscSpagu=0;
        private Brush _grafika;

        public string Nazwa{  get { return _nazwa; }  }
        public double Miazszosc { get { return _miazszosc; } }
        public double WspolczynnikFiltracji { get { return _wspolczynnikFiltracji; } }
        public double GlebokoscStropu { get { return _glebokoscStropu; } }
        public double GlebokoscSpagu { get { return _glebokoscSpagu; } }
        public Brush Grafika
        {
            get
            {
                return _grafika;
            }

            set
            {
                _grafika = value;
            }
        }

        public Warstwa(Brush grafika, string nazwa, double wspolczynnikFiltracji, double glebokoscStropu, double glebokoscSpagu, double miazszosc)
        {
            _grafika = grafika;
            _nazwa = nazwa;
            _miazszosc= (double)(glebokoscSpagu-glebokoscStropu);
            _wspolczynnikFiltracji= wspolczynnikFiltracji;
            _glebokoscStropu= glebokoscStropu;
            _glebokoscSpagu= glebokoscSpagu;
            _miazszosc = miazszosc;
        }

        public Warstwa(Brush grafika, string nazwa, double wspolczynnikFiltracji, double miazszosc)
        {
            _grafika = grafika;
            _nazwa = nazwa;
            _miazszosc = miazszosc;
            _wspolczynnikFiltracji = wspolczynnikFiltracji;
            _glebokoscStropu = 0;
            _glebokoscSpagu = 0;
        }

        public Warstwa(Brush grafika, string nazwa, double wspolczynnikFiltracji, double glebokoscStropu, double glebokoscSpagu)
        {
            _grafika = grafika;
            _nazwa = nazwa;
            _miazszosc = glebokoscSpagu - glebokoscStropu;
            _wspolczynnikFiltracji = wspolczynnikFiltracji;
            _glebokoscStropu = glebokoscStropu;
            _glebokoscSpagu = glebokoscSpagu;
            
        }

        public Warstwa(Brush grafika, string nazwa, double wspolczynnikFiltracji)
        {
            _grafika = grafika;
            _nazwa = nazwa;
            _wspolczynnikFiltracji = wspolczynnikFiltracji;
        }

    }
}
