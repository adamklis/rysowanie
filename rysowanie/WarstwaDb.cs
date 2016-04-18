using System.Drawing;

namespace rysowanie
{
    public class WarstwaDb
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public float Miazszosc { get; set; }
        public float WspFiltracji { get; set; }
        public int KolorA { get; set; }
        public int KolorR { get; set; }
        public int KolorG { get; set; }
        public int KolorB { get; set; }
        public Image Image { get; set; }

    }
}
