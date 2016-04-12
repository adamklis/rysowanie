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

   
        public void RysujWarstwe(Warstwa warstwa,double glebokosc)
        {
            _g.FillRectangle(warstwa.Grafika, 100, (int)(warstwa.GlebokoscStropu /glebokosc * _obrazek.Height), 300, (int)(warstwa.GlebokoscSpagu / glebokosc * _obrazek.Height));
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
