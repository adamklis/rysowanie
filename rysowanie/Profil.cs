using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanie
{
    public class Profil
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

        public Warstwa NowaWarstwa(Warstwa warstwa)
        {
            Warstwa nowaWarstwa;
            if (warstwa.GlebokoscStropu ==0 && warstwa.GlebokoscSpagu == 0)
            {
                double glebokoscStropu = _glebokosc;
                double glebokoscSpagu = glebokoscStropu + warstwa.Miazszosc;
                nowaWarstwa = new Warstwa(warstwa.Kolor, warstwa.Nazwa, warstwa.WspolczynnikFiltracji, glebokoscStropu, glebokoscSpagu, warstwa.Miazszosc);
                Warstwy.Add(nowaWarstwa);
                _glebokosc += warstwa.Miazszosc;
            }
            else
            {
                double miazszosc = (double)(warstwa.GlebokoscSpagu - warstwa.GlebokoscStropu);
                nowaWarstwa = new Warstwa(warstwa.Kolor, warstwa.Nazwa, warstwa.WspolczynnikFiltracji, warstwa.GlebokoscStropu, warstwa.GlebokoscSpagu, miazszosc);
                Warstwy.Add(nowaWarstwa);
                _glebokosc += miazszosc;
            }
            return nowaWarstwa;
          

        }
       
        public void UsunWarstwe(int indeks) 
        {
            Warstwy.Remove(_warstwy.FirstOrDefault(t => t.Id == indeks));
            Przelicz(); 
        }

        public void EdytujWarstwe(Warstwa warstwa)
        {
            Warstwa znalezionaWarstwa=_warstwy.FirstOrDefault(t => t.Id == warstwa.Id);
            if (znalezionaWarstwa != null)
            {
                znalezionaWarstwa = warstwa;
            }
            Przelicz();
        }

        private void Przelicz()
        {
            _glebokosc = 0;
            foreach (Warstwa warstwa in _warstwy)
            {
                warstwa.GlebokoscStropu = Glebokosc;
                warstwa.GlebokoscSpagu = warstwa.GlebokoscStropu + warstwa.Miazszosc;
                _glebokosc = warstwa.GlebokoscSpagu;
            }
        }

    }

}
