﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private Rysunek _rysunek;
        private List<WarstwaDb> _warstwaDbList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadCbNazwa();
            panelColor.BackColor = _selectedColor;
            _rysunek = new Rysunek(studniaPictureBox.Width, studniaPictureBox.Height);
            _profil = new Profil();
            _profil.NowaWarstwa(new Warstwa(Color.Red, "pierwsza", 23, 100));
            _profil.NowaWarstwa(new Warstwa(Color.Green, "druga", 23, 200));
            _profil.NowaWarstwa(new Warstwa(Color.Blue, "trzecia", 23, 100));
            _profil.NowaWarstwa(new Warstwa(Color.Yellow, "czwarta", 23, 300));
            _profil.UsunWarstwe(2);
            _profil.ZwierciadloNawiercone = 90;
            _profil.ZwierciadloUstalone = 50;
            _rysunek.RysujProfil(_profil);
            PrzeladujLv(_profil);

            studniaPictureBox.Image = _rysunek.Obrazek;

        }

        private void ReloadCbNazwa()
        {
            //cbNazwa.Items.Clear();
            //_warstwaDbList = WarstwyDbDataAccess.GetData();
            //foreach (WarstwaDb warstwaDb in _warstwaDbList)
            //{
            //    cbNazwa.Items.Add(warstwaDb.Nazwa);
            //}
        }

        private void btnKolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedColor = colorDialog.Color;
                panelColor.BackColor = _selectedColor;
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
                _rysunek.RysujProfil(_profil);
                studniaPictureBox.Image = _rysunek.Obrazek;
                DodajWarstweLv(warstwa);
            }
            else
            {
                MessageBox.Show(@"Nie wszystkie dane zostały uzupełnione poprawnie!", @"Nie można dodać warstwy",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DodajWarstweLv(Warstwa warstwa)
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
                ProfilWalidacja.NazwaWalidacja(cbNazwa.Text, out nazwa) && lvProfil.SelectedItems.Count == 1)
            {
                try
                {
                    Warstwa warstwa = new Warstwa(_selectedColor, nazwa, wspFiltracji, miazszosc);
                    warstwa.Id = Convert.ToInt32(lvProfil.SelectedItems[0].Text);
                    _profil.EdytujWarstwe(warstwa);
                    _rysunek.RysujProfil(_profil);
                    studniaPictureBox.Image = _rysunek.Obrazek;
                    EdytujWarstweLv(warstwa);
                    PrzeladujLv(_profil);
                }
                catch
                {
                    MessageBox.Show(@"Nie można edytować elementu", @"Wystąpił błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

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
                if (MessageBox.Show(@"Czy chcesz usunąć zaznaczoną warstwę?", @"Potwierdź",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    foreach (var selectedItem in lvProfil.SelectedItems)
                    {
                        try
                        {
                            _profil.UsunWarstwe(Convert.ToInt32(((ListViewItem) selectedItem).Text));
                            UsunWarstweLv();
                        }
                        catch
                        {
                            MessageBox.Show("Nie można usunąć elementu", "Wystąpił błąd", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }

                    }
                    PrzeladujLv(_profil);
                    _rysunek.RysujProfil(_profil);
                    studniaPictureBox.Image = _rysunek.Obrazek;

                }
            }
        }

        private void UsunWarstweLv()
        {
            if (lvProfil.SelectedItems.Count != 0)
            {
                foreach (var item in lvProfil.SelectedItems)
                {
                    lvProfil.Items.Remove((ListViewItem) item);
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
                Warstwa warstwa =
                    _profil.Warstwy.FirstOrDefault(t => (t.Id.ToString() == lvProfil.SelectedItems[0].Text));
                if (warstwa != null)
                {
                    cbNazwa.Text = warstwa.Nazwa;
                    tbMiazszosc.Text = warstwa.Miazszosc.ToString();
                    tbWspFitracji.Text = warstwa.WspolczynnikFiltracji.ToString();
                    _selectedColor = warstwa.Kolor;
                }

            }
        }

        private void cbNazwa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_warstwaDbList.Count > cbNazwa.SelectedIndex && cbNazwa.SelectedIndex != -1)
            {
                WarstwaDb warstwaDb = _warstwaDbList[cbNazwa.SelectedIndex];
                tbMiazszosc.Text = warstwaDb.Miazszosc.ToString();
                tbWspFitracji.Text = warstwaDb.WspFiltracji.ToString();
                _selectedColor = Color.FromArgb(warstwaDb.KolorA, warstwaDb.KolorR, warstwaDb.KolorG, warstwaDb.KolorB);
                panelColor.BackColor = _selectedColor;

            }
        }

        private void btnZapiszUstawienia_Click(object sender, EventArgs e)
        {
            //string nazwa;
            //float miazszosc;
            //float wspFiltracji;


            //if (ProfilWalidacja.MiazszoscWalidacja(tbMiazszosc.Text, out miazszosc) &&
            //    ProfilWalidacja.NazwaWalidacja(cbNazwa.Text, out nazwa) &&
            //    ProfilWalidacja.WspFiltracjiWalidacja(tbWspFitracji.Text, out wspFiltracji))
            //{
            //    if (MessageBox.Show(@"Czy chcesz zapisać obecne ustawienia warstwy?", @"Potwierdź",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        WarstwaDb warstwaDb = new WarstwaDb
            //        {
            //            Nazwa = nazwa,
            //            Miazszosc = miazszosc,
            //            WspFiltracji = wspFiltracji,
            //            KolorA = _selectedColor.A,
            //            KolorR = _selectedColor.R,
            //            KolorG = _selectedColor.G,
            //            KolorB = _selectedColor.B,
            //            Image = null
            //        };
            //        if (WarstwyDbDataAccess.InsertData(warstwaDb))
            //        {
            //            ReloadCbNazwa();
            //            MessageBox.Show(@"Pomyślnie dodano bieżące ustawienia", @"Dodano ustawienia",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show(@"Bieżące ustawienia nie zostały dodane", @"Wystąpił nieznany błąd",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }

            //    }
            //}


        }

        private void btnEdytujUstawienia_Click(object sender, EventArgs e)
        {
            //int id;
            //string nazwa;
            //float miazszosc;
            //float wspFiltracji;


            //if (ProfilWalidacja.MiazszoscWalidacja(tbMiazszosc.Text, out miazszosc) &&
            //    ProfilWalidacja.NazwaWalidacja(cbNazwa.Text, out nazwa) &&
            //    ProfilWalidacja.WspFiltracjiWalidacja(tbWspFitracji.Text, out wspFiltracji) &&
            //    cbNazwa.SelectedIndex != -1)
            //{
            //    if (MessageBox.Show(@"Czy chcesz nadpisać obecne ustawienia warstwy?", @"Potwierdź",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        id = _warstwaDbList.Find(t => t.Id == cbNazwa.SelectedIndex).Id;
            //        WarstwaDb warstwaDb = new WarstwaDb
            //        {
            //            Id = id,
            //            Nazwa = nazwa,
            //            Miazszosc = miazszosc,
            //            WspFiltracji = wspFiltracji,
            //            KolorA = _selectedColor.A,
            //            KolorR = _selectedColor.R,
            //            KolorG = _selectedColor.G,
            //            KolorB = _selectedColor.B,
            //            Image = null
            //        };
            //        if (WarstwyDbDataAccess.EditData(warstwaDb))
            //        {
            //            ReloadCbNazwa();
            //            MessageBox.Show(@"Pomyślnie zaktualizowano dane o litologii", @"Dodano ustawienia",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show(@"Dane o litologii nie zostały zaktualizowane", @"Wystąpił nieznany błąd",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }

            //    }
            //}




        }

        private void btnWlasciwosciProfilu_Click(object sender, EventArgs e)
        {
            PictureBox obrazek = studniaPictureBox;
            Button btnWlasciwosci = btnWlasciwosciProfilu;
            WlasciwosciForm form = new WlasciwosciForm(_rysunek, _profil, obrazek, btnWlasciwosci);
            form.Show();
        }

        private void btnDodajZwNawiercone_Click(object sender, EventArgs e)
        {
            double zwNawiercone;
            double zwUstalone;
            if (ProfilWalidacja.ZwierciadloWalidacja(tbNawiercone.Text, out zwNawiercone))
            {
                if (ProfilWalidacja.PolozenieZwierciadlaWalidacja(_profil, zwNawiercone))
                {
                    if (ProfilWalidacja.ZwierciadloWalidacja(_profil.ZwierciadloUstalone.ToString(), out zwUstalone))
                    {
                        if (ProfilWalidacja.PolozenieZwierciadelWzgledemSiebieWalidacja(zwNawiercone, zwUstalone))
                        {
                            _profil.ZwierciadloNawiercone = zwNawiercone;
                            _rysunek.RysujProfil(_profil);
                            studniaPictureBox.Image = _rysunek.Obrazek;
                        }
                        else
                        {
                            if (MessageBox.Show(
                                @"Zwierciadło nawiercone znajduje się poniżej zwierciadła ustalonego. Czy chcesz kontynuować?",
                                @"Błąd położenia zwierciadła", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                                DialogResult.Yes)
                            {
                                _profil.ZwierciadloNawiercone = zwNawiercone;
                                _rysunek.RysujProfil(_profil);
                                studniaPictureBox.Image = _rysunek.Obrazek;
                            }
                        }
                    }
                    else
                    {
                        _profil.ZwierciadloNawiercone = zwNawiercone;
                        _rysunek.RysujProfil(_profil);
                        studniaPictureBox.Image = _rysunek.Obrazek;
                    }
                }
                else
                {
                    MessageBox.Show(@"Zwierciadlo wody poniżej spągu profilu", @"Błąd odczytu danych",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(@"Nieprawidłowa wartość zwierciadła nawierconego", @"Błąd odczytu danych",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDodajZwUstalone_Click(object sender, EventArgs e)
        {
            double zwUstalone;
            double zwNawiercone;
            if (ProfilWalidacja.ZwierciadloWalidacja(tbUstalone.Text, out zwUstalone))
            {
                if (ProfilWalidacja.PolozenieZwierciadlaWalidacja(_profil, zwUstalone))
                {
                    if (ProfilWalidacja.ZwierciadloWalidacja(_profil.ZwierciadloNawiercone.ToString(), out zwNawiercone))
                    {
                        if (ProfilWalidacja.PolozenieZwierciadelWzgledemSiebieWalidacja(zwNawiercone, zwUstalone))
                        {
                            _profil.ZwierciadloUstalone = zwUstalone;
                            _rysunek.RysujProfil(_profil);
                            studniaPictureBox.Image = _rysunek.Obrazek;
                        }
                        else
                        {
                            if (MessageBox.Show(
                                @"Zwierciadło nawiercone znajduje się poniżej zwierciadła ustalonego. Czy chcesz kontynuować?",
                                @"Błąd położenia zwierciadła", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                                DialogResult.Yes)
                            {
                                _profil.ZwierciadloUstalone = zwUstalone;
                                _rysunek.RysujProfil(_profil);
                                studniaPictureBox.Image = _rysunek.Obrazek;
                            }
                        }
                    }
                    else
                    {
                        _profil.ZwierciadloUstalone = zwUstalone;
                        _rysunek.RysujProfil(_profil);
                        studniaPictureBox.Image = _rysunek.Obrazek;
                    }
                }
                else
                {
                    MessageBox.Show(@"Zwierciadlo wody poniżej spągu profilu", @"Błąd odczytu danych",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(@"Nieprawidłowa wartość zwierciadła ustalonego", @"Błąd odczytu danych",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUsunZwNawiercone_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(@"Czy chcesz usunąć zwierciadło nawiercone z profilu?", @"Potwierdź",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _profil.ZwierciadloNawiercone = -1;
                _rysunek.RysujProfil(_profil);
                studniaPictureBox.Image = _rysunek.Obrazek;
            }
        }

        private void btnUsunZwUstalone_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(@"Czy chcesz usunąć zwierciadło ustalone z profilu?", @"Potwierdź",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _profil.ZwierciadloUstalone = -1;
                _rysunek.RysujProfil(_profil);
                studniaPictureBox.Image = _rysunek.Obrazek;
            }
        }
    }
}

