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
    public partial class WlasciwosciForm : Form
    {
        private Rysunek _rysunek;
        private Profil _profil;
        private PictureBox _obrazek;
        private Button _wlasciwosci;
        public WlasciwosciForm(Rysunek rysunek, Profil profil,PictureBox obrazek, Button wlasciwosci)
        {
            InitializeComponent();
            _rysunek = rysunek;
            _profil = profil;
            _obrazek = obrazek;
            _wlasciwosci = wlasciwosci;

            numPrzeuniecieProfiluX.Value = _rysunek.PrzeuniecieX;
            _wlasciwosci.Enabled = false;
        }

        private void numPrzeuniecieProfiluX_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.PrzeuniecieX = (int)numPrzeuniecieProfiluX.Value;
            _rysunek.RysujProfil(_profil);
            _obrazek.Image = _rysunek.Obrazek;
            
        }

        private void WlasciwosciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _wlasciwosci.Enabled = true;
        }
    }
}
