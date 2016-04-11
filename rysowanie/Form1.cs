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
            rysunek.RysujSkale();
            rysunek.RysujWarstwe(new Warstwa(Brushes.Green,"www", 12, 33, 0, 150),230);
            rysunek.RysujWarstwe(new Warstwa(Brushes.Blue,"www", 12, 33, 150, 200), 230);
            rysunek.RysujWarstwe(new Warstwa(Brushes.Red,"www", 12, 33, 200, 230), 230);
            studniaPictureBox.Image=rysunek.Obrazek;


        }

    }
}
