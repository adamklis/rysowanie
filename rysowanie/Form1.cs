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

        private Color _selectedColor = Color.Goldenrod;
        private Profil _profil;
        private Rysunek rysunek;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rysunek = new Rysunek(studniaPictureBox.Width, studniaPictureBox.Height);

            _profil = new Profil();
            //_profil = profil;


            _profil.NowaWarstwa(new Warstwa(Color.Red, "pierwsza", 23, 100));
            _profil.NowaWarstwa(new Warstwa(Color.Green, "druga", 23, 200));
            _profil.NowaWarstwa(new Warstwa(Color.Blue, "trzecia", 23, 100));
            _profil.NowaWarstwa(new Warstwa(Color.Yellow, "czwarta", 23, 300));


            //profil.NowaWarstwa(new Warstwa(Color.Red, "pierwsza", 23, 0, 100));
            //profil.NowaWarstwa(new Warstwa(Color.Green, "druga", 23, 100, 300));
            //profil.NowaWarstwa(new Warstwa(Color.Blue, "trzecia", 23, 300, 400));
            //profil.NowaWarstwa(new Warstwa(Color.Yellow, "czwarta", 23, 400, 690));
            //profil.UsunWarstwe(2);

            rysunek.RysujProfil(_profil);
            PrzeladujLv(_profil);

            studniaPictureBox.Image=rysunek.Obrazek;


        }

        private void btnKolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedColor = colorDialog.Color;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string nazwa;
            double wspFiltracji;
            double miazszosc;
            if (ProfilWalidacja.MiazszoscWalidacja(tbMiazszosc.Text, out miazszosc) &&
                ProfilWalidacja.WspFiltracjiWalidacja(tbWspFitracji.Text, out wspFiltracji) &&
                ProfilWalidacja.NazwaWalidacja(cbNazwa.Text, out nazwa))
            {
                Warstwa warstwa = new Warstwa(_selectedColor, nazwa, wspFiltracji, miazszosc);
                warstwa = _profil.NowaWarstwa(warstwa);
                rysunek.RysujProfil(_profil);
                studniaPictureBox.Image = rysunek.Obrazek;
                DodajWarstweLv(warstwa);
            }
            else
            {
                MessageBox.Show(@"Nie wszystkie dane zostały uzupełnione poprawnie!", @"Nie można dodać warstwy",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
        private void DodajWarstweLv(Warstwa warstwa )
        {
            ListViewItem item = new ListViewItem(warstwa.Id.ToString());
            item.SubItems.Add(warstwa.Nazwa);
            item.SubItems.Add(warstwa.Miazszosc.ToString());
            item.SubItems.Add(warstwa.WspolczynnikFiltracji.ToString());
            item.SubItems.Add(warstwa.GlebokoscStropu.ToString());
            item.SubItems.Add(warstwa.GlebokoscSpagu.ToString());
            lvProfil.Items.Add(item);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            string nazwa;
            double miazszosc;
            double wspFiltracji;
            if (ProfilWalidacja.MiazszoscWalidacja(tbMiazszosc.Text, out miazszosc) &&
                ProfilWalidacja.WspFiltracjiWalidacja(tbWspFitracji.Text, out wspFiltracji) &&
                ProfilWalidacja.NazwaWalidacja(cbNazwa.Text, out nazwa))
            {
                Warstwa warstwa = new Warstwa(_selectedColor, nazwa, wspFiltracji, miazszosc);
                EdytujWarstweLv(warstwa);
            }
            else
            {
                MessageBox.Show(@"Nie wszystkie dane zostały uzupełnione poprawnie!", @"Nie można dodać warstwy",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EdytujWarstweLv(Warstwa warstwa)
        {
            
            if (lvProfil.SelectedItems.Count == 1)
            {
                ListViewItem item = lvProfil.SelectedItems[0];
                item.SubItems[1].Text = warstwa.Nazwa;
                item.SubItems[2].Text = warstwa.Miazszosc.ToString();
                item.SubItems[3].Text = warstwa.WspolczynnikFiltracji.ToString();
                item.SubItems[4].Text = warstwa.GlebokoscStropu.ToString();
                item.SubItems[5].Text = warstwa.GlebokoscSpagu.ToString();

            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (lvProfil.SelectedItems.Count != 0)
            {
                if (MessageBox.Show(@"Czy chcesz usunąć zaznaczoną warstwę?", @"Potwierdź", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    UsunWarstweLv();
                }
            }
        }

        private void UsunWarstweLv()
        {
            if (lvProfil.SelectedItems.Count != 0)
            {
                foreach (var item in lvProfil.SelectedItems)
                {
                    lvProfil.Items.Remove((ListViewItem)item);
                }
            }
        }

        private void PrzeladujLv(Profil profil)
        {
            lvProfil.Items.Clear();
            foreach (Warstwa warstwa in profil.Warstwy)
            {
                DodajWarstweLv(warstwa);
            }
        }

        private void lvProfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProfil.SelectedItems.Count != 0)
            {
                Warstwa warstwa = _profil.Warstwy.FirstOrDefault(t => (t.Id.ToString() == lvProfil.SelectedItems[0].Text));
                if (warstwa != null)
                {
                    cbNazwa.Text = warstwa.Nazwa;
                    tbMiazszosc.Text = warstwa.Miazszosc.ToString();
                    tbWspFitracji.Text = warstwa.WspolczynnikFiltracji.ToString();
                    _selectedColor = warstwa.Kolor;
                }

            }
        }
    }
}
