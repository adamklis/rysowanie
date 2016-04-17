using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanie
{
    public class WarstwaDb
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public double Miazszosc { get; set; }
        public double WspFiltracji { get; set; }
        public int KolorA { get; set; }
        public int KolorR { get; set; }
        public int KolorG { get; set; }
        public int KolorB { get; set; }
        public Image Image { get; set; }

    }
}
