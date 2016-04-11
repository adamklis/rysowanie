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
        private double _miazszosc;
        private double _wspolczynnikFiltracji;
        private double _glebokoscStropu;
        private double _glebokoscSpagu;
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

        public Warstwa(Brush grafika, string nazwa, double miazszosc, double wspolczynnikFiltracji, double glebokoscStropu, double glebokoscSpagu)
        {
            _grafika = grafika;
            _nazwa = nazwa;
            _miazszosc= miazszosc;
            _wspolczynnikFiltracji= wspolczynnikFiltracji;
            _glebokoscStropu= glebokoscStropu;
            _glebokoscSpagu= glebokoscSpagu;
        }
        
    }
}
