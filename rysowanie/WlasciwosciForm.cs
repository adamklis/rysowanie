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

            numPrzesuniecieProfiluX.Maximum = _obrazek.Width;
            numPrzesuniecieProfiluY.Maximum = _obrazek.Height / 2;
            numSzerokoscProfilu.Maximum = _obrazek.Width;
            numDlugoscLiniiNawiercone.Maximum= _obrazek.Width/2;
            numDlugoscLiniiUstalone.Maximum = _obrazek.Width/2;
            numPrzesuniecieSkaliX.Maximum = _obrazek.Width;
            numPrzesuniecieLiczbSkaliX.Maximum = _obrazek.Width;
            numPrzesuniecieProfiluX.Value = _rysunek.PrzesuniecieX;
            numPrzesuniecieProfiluY.Value = _rysunek.PrzesuniecieY;
            numSzerokoscProfilu.Value = _rysunek.SzerokoscProfilu;
            numRozmiarCzcionkiProfilu.Value = _rysunek.RozmiarCzcionkiWarstwy;
            numPrzesuniecieSkaliX.Value = _rysunek.PrzeuniecieOsi;
            numPrzesuniecieLiczbSkaliX.Value = _rysunek.PrzesuniecieLiczbOsi;
            numInterwalSkali.Value = _rysunek.InterwalSkali;
            numRozmiarCzcionkiSkali.Value = _rysunek.RozmiarCzcionkiSkali;
            numDlugoscLiniiNawiercone.Value = _rysunek.DlugoscZwierciadlaNawierconego;
            numDlugoscLiniiUstalone.Value = _rysunek.DlugoscZwierciadlaUstalonego;
            numRozmiarTrojkataNawiercone.Value = (decimal)_rysunek.RozmiarTrojkataNawierconego;
            numRozmiarTrojkataUstalone.Value = (decimal)_rysunek.RozmiarTrojkataUstalonego;
            btnKolorUstalone.BackColor = _rysunek.KolorZwierciadlaUstalonego;
            btnKolorNawiercone.BackColor = _rysunek.KolorZwierciadlaNawierconego;
            _wlasciwosci.Enabled = false;
        }

        private void przerysuj()
        {
            _rysunek.RysujProfil(_profil);
            _obrazek.Image = _rysunek.Obrazek;
        }

        private void numPrzeuniecieProfiluX_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.PrzesuniecieX = (int)numPrzesuniecieProfiluX.Value;
            przerysuj();
            
        }

        private void WlasciwosciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _wlasciwosci.Enabled = true;
        }

        private void btnKolorUstalone_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnKolorUstalone.BackColor = colorDialog.Color;
                _rysunek.KolorZwierciadlaUstalonego = colorDialog.Color;
                przerysuj();
            }
        }

        private void btnKolorNawiercone_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnKolorNawiercone.BackColor = colorDialog.Color;
                _rysunek.KolorZwierciadlaNawierconego = colorDialog.Color;
                przerysuj();
            }
        }

        private void numPrzeuniecieProfiluY_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.PrzesuniecieY = (int)numPrzesuniecieProfiluY.Value;
            przerysuj();
        }

        private void numSzerokoscProfilu_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.SzerokoscProfilu = (int)numSzerokoscProfilu.Value;
            przerysuj();
        }

        private void numRozmiarCzcionkiProfilu_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.RozmiarCzcionkiWarstwy = (int)numRozmiarCzcionkiProfilu.Value;
            przerysuj();
        }

        private void numPrzesuniecieSkaliX_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.PrzeuniecieOsi = (int)numPrzesuniecieSkaliX.Value;
            przerysuj();
        }

        private void numPrzesuniecieLiczbSkaliX_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.PrzesuniecieLiczbOsi = (int)numPrzesuniecieLiczbSkaliX.Value;
            przerysuj();
        }

        private void numInterwalSkali_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.InterwalSkali = (int)numInterwalSkali.Value;
            przerysuj();
        }

        private void numRozmiarCzcionkiSkali_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.RozmiarCzcionkiSkali = (int)numRozmiarCzcionkiSkali.Value;
            przerysuj();
        }

        private void numDlugoscLiniiUstalone_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.DlugoscZwierciadlaUstalonego = (int)numDlugoscLiniiUstalone.Value;
            przerysuj();
        }

        private void numRozmiarTrojkataUstalone_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.RozmiarTrojkataUstalonego = (double)numRozmiarTrojkataUstalone.Value;
            przerysuj();
        }

        private void numDlugoscLiniiNawiercone_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.DlugoscZwierciadlaNawierconego = (int)numDlugoscLiniiNawiercone.Value;
            przerysuj();
        }

        private void numRozmiarTrojkataNawiercone_ValueChanged(object sender, EventArgs e)
        {
            _rysunek.RozmiarTrojkataNawierconego = (double)numRozmiarTrojkataNawiercone.Value;
            przerysuj();
        }
    }
}
