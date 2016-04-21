using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowanie
{
    public class Rysunek
    {
        private int _dlugoscZwierciadlaUstalonego = 33;
        private int _dlugoscZwierciadlaNawierconego = 13;
        private Color _kolorZwierciadlaUstalonego = Color.Black;
        private Color _kolorZwierciadlaNawierconego = Color.Black;
        private double _rozmiarTrojkataUstalonego = 1.0;
        private double _rozmiarTrojkataNawierconego = 1.0;
        private int _interwalSkali = 50;
        private int _przesuniecieY = 25;
        private int _przeuniecieX = 130;
        private int _szerokoscProfilu = 150;
        private int _przeuniecieOsi = 60;
        private int _przeuniecieLiczbOsi = 10;
        private int _rozmiarCzcionkiWarstwy = 13;
        private int _rozmiarCzcionkiSkali = 13;
        private Bitmap _obrazek;
        private Graphics _g;

        [Browsable(false)]
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
        public int PrzesuniecieX
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
        public int PrzesuniecieLiczbOsi
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
        public int RozmiarCzcionkiWarstwy
        {
            get
            {
                return _rozmiarCzcionkiWarstwy;
            }

            set
            {
                _rozmiarCzcionkiWarstwy = value;
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
                if (_interwalSkali>1)
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
        public int DlugoscZwierciadlaUstalonego
        {
            get
            {
                return _dlugoscZwierciadlaUstalonego;
            }

            set
            {
                _dlugoscZwierciadlaUstalonego = value;
            }
        }
        public double RozmiarTrojkataUstalonego
        {
            get
            {
                return _rozmiarTrojkataUstalonego;
            }

            set
            {
                _rozmiarTrojkataUstalonego = value;
            }
        }
        public int DlugoscZwierciadlaNawierconego
        {
            get
            {
                return _dlugoscZwierciadlaNawierconego;
            }

            set
            {
                _dlugoscZwierciadlaNawierconego = value;
            }
        }
        public double RozmiarTrojkataNawierconego
        {
            get
            {
                return _rozmiarTrojkataNawierconego;
            }

            set
            {
                _rozmiarTrojkataNawierconego = value;
            }
        }
        public Color KolorZwierciadlaUstalonego
        {
            get
            {
                return _kolorZwierciadlaUstalonego;
            }

            set
            {
                _kolorZwierciadlaUstalonego = value;
            }
        }
        public Color KolorZwierciadlaNawierconego
        {
            get
            {
                return _kolorZwierciadlaNawierconego;
            }

            set
            {
                _kolorZwierciadlaNawierconego = value;
            }
        }
        public int RozmiarCzcionkiSkali
        {
            get
            {
                return _rozmiarCzcionkiSkali;
            }

            set
            {
                _rozmiarCzcionkiSkali = value;
            }
        }

        public Rysunek (int x,int y)
        {
            _obrazek = new Bitmap(x, y);
            _g = Graphics.FromImage(Obrazek);
        }


        public void RysujWarstwe(Warstwa warstwa, double glebokosc)
        {
            Font czcionka = new Font(FontFamily.GenericMonospace, RozmiarCzcionkiWarstwy);
            StringFormat format = new StringFormat();
            SolidBrush pedzel = new SolidBrush(warstwa.Kolor);
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            
            RectangleF prostokat = new RectangleF(
                (int)(PrzesuniecieX),
                (int)(warstwa.GlebokoscStropu / (glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY,
                (int)(SzerokoscProfilu),
                (int)(warstwa.Miazszosc / (glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + 1
                );

            _g.FillRectangle(pedzel, prostokat);
            _g.DrawString(warstwa.Nazwa, czcionka, Brushes.Black, prostokat);
            _g.DrawString(warstwa.WspolczynnikFiltracji+"[m/d]", czcionka, Brushes.Black, prostokat,format);
            _g.DrawString(warstwa.Miazszosc + "[m]", czcionka, Brushes.Black, prostokat.Left-65, prostokat.Top + (prostokat.Bottom - prostokat.Top)/2-RozmiarCzcionkiWarstwy);
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
            Font czcionka = new Font(FontFamily.GenericMonospace, RozmiarCzcionkiSkali);
            interwal = (interwal / (studnia.Glebokosc) * (_obrazek.Height - PrzesuniecieY * 2));

            _g.DrawLine(Pens.Black, PrzeuniecieOsi, PrzesuniecieY, PrzeuniecieOsi, _obrazek.Height-PrzesuniecieY);    //pionowa linia
            for (double i = PrzesuniecieY; i < _obrazek.Height -PrzesuniecieY; i=i+interwal)
            {
                _g.DrawLine(Pens.Black, PrzeuniecieOsi-5, (int)i, PrzeuniecieOsi + 5, (int)i);    //poziome linie
                _g.DrawString(text.ToString(), czcionka,Brushes.Black, PrzesuniecieLiczbOsi, (float)i-RozmiarCzcionkiSkali/2);   //TEKST
                text += skala;
            }
        }
        public void RysujZwierciadloUstalone(Profil profil)
        {
            SolidBrush kolorB = new SolidBrush(KolorZwierciadlaUstalonego);
            Pen kolorP = new Pen(KolorZwierciadlaUstalonego);

            if (profil.ZwierciadloUstalone != -1)
            {
                if (profil.Glebokosc != 0)
                {
                    int y = (int)(profil.ZwierciadloUstalone / (profil.Glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY;
                    _g.DrawLine(kolorP, PrzesuniecieX - DlugoscZwierciadlaUstalonego, y, PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaUstalonego, y);
                    Point[] punkty =
                    {
                        new Point ((int)(PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaUstalonego-10*RozmiarTrojkataUstalonego), (int)(y-16*RozmiarTrojkataUstalonego)),
                        new Point ((int)(PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaUstalonego+10*RozmiarTrojkataUstalonego), (int)(y-16*RozmiarTrojkataUstalonego)),
                        new Point (PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaUstalonego, y)
                    };
                    _g.FillPolygon(kolorB, punkty);
                }
            }
        }

        public void RysujZwierciadloNawiercone(Profil profil)
        {
            Pen kolorP = new Pen(KolorZwierciadlaNawierconego);
            if (profil.ZwierciadloNawiercone != -1)
            {
                if (profil.Glebokosc != 0)
                {
                    int y = (int)(profil.ZwierciadloNawiercone / (profil.Glebokosc) * (_obrazek.Height - PrzesuniecieY * 2)) + PrzesuniecieY;
                    _g.DrawLine(kolorP, PrzesuniecieX - DlugoscZwierciadlaNawierconego, y, PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaNawierconego, y);
                    Point[] punkty =
                    {
                        new Point ((int)(PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaNawierconego-10*RozmiarTrojkataNawierconego), (int)(y-16*RozmiarTrojkataNawierconego)),
                        new Point ((int)(PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaNawierconego+10*RozmiarTrojkataNawierconego), (int)(y-16*RozmiarTrojkataNawierconego)),
                        new Point (PrzesuniecieX + SzerokoscProfilu + DlugoscZwierciadlaNawierconego, y)
                    };
                    _g.DrawPolygon(kolorP, punkty);
                }
            }
        }


    }
}
