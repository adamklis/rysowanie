using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowanie
{
    class Rysunek
    {
        private int _dlugoscZwierciadla = 20;
        private int _interwalSkali = 50;
        private int _przesuniecieY = 25;
        private int _przeuniecieX = 100;
        private int _szerokoscProfilu = 150;
        private int _przeuniecieOsi = 60;
        private int _przeuniecieLiczbOsi = 10;
        private int _rozmiarCzcionki = 13;
        private Bitmap _obrazek;
        private Graphics _g;
        
        public Bitmap Obrazek
        {
            get
            {
                return _obrazek;
            }
        }

        public int PrzesuniecieY
        {
            get
            {
                return _przesuniecieY;
            }

            set
            {
                _przesuniecieY = value;
            }
        }
        public int PrzeuniecieX
        {
            get
            {
                return _przeuniecieX;
            }

            set
            {
                _przeuniecieX = value;
            }
        }
        public int PrzeuniecieOsi
        {
            get
            {
                return _przeuniecieOsi;
            }

            set
            {
                _przeuniecieOsi = value;
            }
        }
        public int PrzeuniecieLiczbOsi
        {
            get
            {
                return _przeuniecieLiczbOsi;
            }

            set
            {
                _przeuniecieLiczbOsi = value;
            }
        }
        public int RozmiarCzcionki
        {
            get
            {
                return _rozmiarCzcionki;
            }

            set
            {
                _rozmiarCzcionki = value;
            }
        }
        public int InterwalSkali
        {
            get
            {
                return _interwalSkali;
            }

            set
            {
                _interwalSkali = value;
            }
        }
        public int SzerokoscProfilu
        {
            get
            {
                return _szerokoscProfilu;
            }

            set
            {
                _szerokoscProfilu = value;
            }
        }

        public int DlugoscZwierciadla
        {
            get
            {
                return _dlugoscZwierciadla;
            }

            set
            {
                _dlugoscZwierciadla = value;
            }
        }

        public Rysunek (int x,int y)
        {
            _obrazek = new Bitmap(x, y);
            _g = Graphics.FromImage(Obrazek);
        }


        public void RysujWarstwe(Warstwa warstwa, double glebokosc)
        {
            Font czcionka = new Font(FontFamily.GenericMonospace, RozmiarCzcionki);
            StringFormat format = new StringFormat();
            SolidBrush pedzel = new SolidBrush(warstwa.Kolor);
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            //RectangleF prostokat = new RectangleF(
            //    (int)(PrzeuniecieX * _obrazek.Width),
            //    (int)(warstwa.GlebokoscStropu / (glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY,
            //    (int)(_obrazek.Width - (PrzeuniecieX * _obrazek.Width) * 2),
            //    (int)(warstwa.Miazszosc / (glebokosc) * (_obrazek.Height - PrzesuniecieY * 2))+1
            //    );

            RectangleF prostokat = new RectangleF(
                (int)(PrzeuniecieX),
                (int)(warstwa.GlebokoscStropu / (glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY,
                (int)(SzerokoscProfilu),
                (int)(warstwa.Miazszosc / (glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + 1
                );

            _g.FillRectangle(pedzel, prostokat);
            _g.DrawString(warstwa.Nazwa, czcionka, Brushes.Black, prostokat);
            _g.DrawString(warstwa.WspolczynnikFiltracji+"[m/d]", czcionka, Brushes.Black, prostokat,format);
        }       
        public void RysujProfil(Profil profil)
        {
            _g.Clear(Color.White);
            foreach (Warstwa warstwa in profil.Warstwy)
            {
                RysujWarstwe(warstwa, profil.Glebokosc);
            }

            RysujSkale(profil, InterwalSkali);
            RysujZwierciadloUstalone(profil);
            RysujZwierciadloNawiercone(profil);
        }


        public void RysujSkale(Profil studnia, double interwal)
        {

            double skala=interwal;
            double text = 0;
            Font czcionka = new Font(FontFamily.GenericMonospace, RozmiarCzcionki);
            interwal = (interwal / (studnia.Glebokosc) * (_obrazek.Height - PrzesuniecieY * 2));

            _g.DrawLine(Pens.Black, PrzeuniecieOsi, PrzesuniecieY, PrzeuniecieOsi, _obrazek.Height-PrzesuniecieY);    //pionowa linia
            for (double i = PrzesuniecieY; i < _obrazek.Height -PrzesuniecieY; i=i+interwal)
            {
                _g.DrawLine(Pens.Black, PrzeuniecieOsi-5, (int)i, PrzeuniecieOsi + 5, (int)i);    //poziome linie
                _g.DrawString(text.ToString(), czcionka,Brushes.Black, PrzeuniecieLiczbOsi, (float)i-RozmiarCzcionki/2);   //TEKST
                text += skala;
            }
        }
        public void RysujZwierciadloUstalone(Profil profil)
        {
            if (profil.ZwierciadloUstalone != -1)
            {
                int y = (int)(profil.ZwierciadloUstalone / (profil.Glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY;
                _g.DrawLine(Pens.Black, PrzeuniecieX-DlugoscZwierciadla, y, PrzeuniecieX + SzerokoscProfilu+ DlugoscZwierciadla, y);
                //_g.DrawPolygon
            }
        }

        public void RysujZwierciadloNawiercone(Profil profil)
        {
            if (profil.ZwierciadloNawiercone != -1)
            {
                int y = (int)(profil.ZwierciadloNawiercone / (profil.Glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY;
                _g.DrawLine(Pens.Black, PrzeuniecieX - DlugoscZwierciadla, y, PrzeuniecieX + SzerokoscProfilu + DlugoscZwierciadla, y);
            }
        }


    }
}
