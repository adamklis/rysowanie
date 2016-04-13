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
        private const int _przesuniecieY = 25;
        private const double _przeuniecieX = 0.2;
        private Bitmap _obrazek;
        private Graphics _g;
        
        public Bitmap Obrazek
        {
            get
            {
                return _obrazek;
            }
        }

        public Rysunek (int x,int y)
        {
            _obrazek = new Bitmap(x, y);
            _g = Graphics.FromImage(Obrazek);
        }


        public void RysujWarstwe(Warstwa warstwa, double glebokosc)
        {
            _g.FillRectangle(warstwa.Grafika, (int)(_przeuniecieX * _obrazek.Width), (int)(warstwa.GlebokoscStropu / (glebokosc) * (_obrazek.Height- _przesuniecieY*2))+ _przesuniecieY, (int)(_obrazek.Width- (_przeuniecieX * _obrazek.Width)*2), (int)(warstwa.Miazszosc / (glebokosc) * (_obrazek.Height- _przesuniecieY*2)));
        }       
        public void RysujProfil(Profil studnia)
        {

            foreach (Warstwa warstwa in studnia.Warstwy)
            {
                RysujWarstwe(warstwa, studnia.Glebokosc);
            }

        }


        public void RysujSkale()
        {
            _g.DrawLine(Pens.Black, 50, 0, 50, _obrazek.Height);
        }


    }
}
