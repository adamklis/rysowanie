using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanie
{
    public class Warstwa : Profil
    {
        private string _nazwa;
        private double _miazszosc=0;
        private double _wspolczynnikFiltracji;
        private double _glebokoscStropu=0;
        private double _glebokoscSpagu=0;
        private Color _kolor;
        private int _id;
        private static int _warstwaCounter=0;
        
        public Color Kolor
        {
            get
            {
                return _kolor;
            }

            set
            {
                _kolor = value;
            }
        }

        public int Id { get { return _id; } set { _id = value; } }

        public string Nazwa
        {
            get
            {
                return _nazwa;
            }

            set
            {
                _nazwa = value;
            }
        }

        public double Miazszosc
        {
            get
            {
                return _miazszosc;
            }

            set
            {
                _miazszosc = value;
            }
        }

        public double WspolczynnikFiltracji
        {
            get
            {
                return _wspolczynnikFiltracji;
            }

            set
            {
                _wspolczynnikFiltracji = value;
            }
        }

        public double GlebokoscStropu
        {
            get
            {
                return _glebokoscStropu;
            }

            set
            {
                _glebokoscStropu = value;
            }
        }

        public double GlebokoscSpagu
        {
            get
            {
                return _glebokoscSpagu;
            }

            set
            {
                _glebokoscSpagu = value;
            }
        }

        public Warstwa(Color kolor, string nazwa, double wspolczynnikFiltracji, double glebokoscStropu, double glebokoscSpagu, double miazszosc)
        {
            _kolor=kolor;
            Nazwa = nazwa;
            Miazszosc= (double)(glebokoscSpagu-glebokoscStropu);
            WspolczynnikFiltracji= wspolczynnikFiltracji;
            GlebokoscStropu= glebokoscStropu;
            GlebokoscSpagu= glebokoscSpagu;
            Miazszosc = miazszosc;
            _id = _warstwaCounter;
            _warstwaCounter++;
        }

        public Warstwa(Color kolor, string nazwa, double wspolczynnikFiltracji, double miazszosc)
        {
            _kolor = kolor;
            Nazwa = nazwa;
            Miazszosc = miazszosc;
            WspolczynnikFiltracji = wspolczynnikFiltracji;
            GlebokoscStropu = 0;
            GlebokoscSpagu = 0;
            _id = _warstwaCounter;
          //  _warstwaCounter++;
        }

        public Warstwa(Color kolor, string nazwa, double wspolczynnikFiltracji, double glebokoscStropu, double glebokoscSpagu)
        {
            _kolor = kolor;
            Nazwa = nazwa;
            Miazszosc = glebokoscSpagu - glebokoscStropu;
            WspolczynnikFiltracji = wspolczynnikFiltracji;
            GlebokoscStropu = glebokoscStropu;
            GlebokoscSpagu = glebokoscSpagu;
            _id = _warstwaCounter;
          //  _warstwaCounter++;
        }

    }
}
