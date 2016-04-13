using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rysunek rysunek = new Rysunek(500,700);

            Profil profil = new Profil();
            


            //profil.NowaWarstwa(new Warstwa(Brushes.Red, "pierwsza", 23, 100));
            //profil.NowaWarstwa(new Warstwa(Brushes.Green, "druga", 23, 200));
            //profil.NowaWarstwa(new Warstwa(Brushes.Blue, "trzecia", 23, 100));
            //profil.NowaWarstwa(new Warstwa(Brushes.Yellow, "czwarta", 23, 300));


            profil.NowaWarstwa(new Warstwa(Brushes.Red, "pierwsza", 23, 0, 100));
            profil.NowaWarstwa(new Warstwa(Brushes.Green, "druga", 23, 100, 300));
            profil.NowaWarstwa(new Warstwa(Brushes.Blue, "trzecia", 23, 300, 400));
            profil.NowaWarstwa(new Warstwa(Brushes.Yellow, "czwarta", 23, 400, 700));

            rysunek.RysujProfil(profil);
            //rysunek.RysujSkale();


            studniaPictureBox.Image=rysunek.Obrazek;


        }

    }
}
