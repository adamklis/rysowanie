﻿namespace rysowanie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studniaPictureBox = new System.Windows.Forms.PictureBox();
            this.lvProfil = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miazszosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WspFiltracji = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Spag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbWarstwa = new System.Windows.Forms.GroupBox();
            this.btnEdytujUstawienia = new System.Windows.Forms.Button();
            this.btnZapiszUstawienia = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnKolor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWspFitracji = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMiazszosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNazwa = new System.Windows.Forms.ComboBox();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.btnUsunZwUstalone = new System.Windows.Forms.Button();
            this.btnDodajZwUstalone = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            this.btnRysuj = new System.Windows.Forms.Button();
            this.btnDodajZwNawiercone = new System.Windows.Forms.Button();
            this.btnUsunZwNawiercone = new System.Windows.Forms.Button();
            this.tbUstalone = new System.Windows.Forms.TextBox();
            this.tbNawiercone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSredni = new System.Windows.Forms.GroupBox();
            this.btnWspFil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSredniWspFiltracji = new System.Windows.Forms.TextBox();
            this.btnWlasciwosciProfilu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studniaPictureBox)).BeginInit();
            this.gbWarstwa.SuspendLayout();
            this.gbProfil.SuspendLayout();
            this.gbSredni.SuspendLayout();
            this.SuspendLayout();
            // 
            // studniaPictureBox
            // 
            this.studniaPictureBox.BackColor = System.Drawing.Color.White;
            this.studniaPictureBox.Location = new System.Drawing.Point(647, 349);
            this.studniaPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.studniaPictureBox.Name = "studniaPictureBox";
            this.studniaPictureBox.Size = new System.Drawing.Size(333, 455);
            this.studniaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studniaPictureBox.TabIndex = 0;
            this.studniaPictureBox.TabStop = false;
            // 
            // lvProfil
            // 
            this.lvProfil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nazwa,
            this.Miazszosc,
            this.WspFiltracji,
            this.Strop,
            this.Spag});
            this.lvProfil.FullRowSelect = true;
            this.lvProfil.GridLines = true;
            this.lvProfil.HideSelection = false;
            this.lvProfil.Location = new System.Drawing.Point(12, 522);
            this.lvProfil.Name = "lvProfil";
            this.lvProfil.Size = new System.Drawing.Size(630, 282);
            this.lvProfil.TabIndex = 1;
            this.lvProfil.UseCompatibleStateImageBehavior = false;
            this.lvProfil.View = System.Windows.Forms.View.Details;
            this.lvProfil.SelectedIndexChanged += new System.EventHandler(this.lvProfil_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 38;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 130;
            // 
            // Miazszosc
            // 
            this.Miazszosc.Text = "Miąższość";
            this.Miazszosc.Width = 85;
            // 
            // WspFiltracji
            // 
            this.WspFiltracji.Text = "Współczynnik filtracji";
            this.WspFiltracji.Width = 134;
            // 
            // Strop
            // 
            this.Strop.Text = "Głębokość stropu";
            this.Strop.Width = 115;
            // 
            // Spag
            // 
            this.Spag.Text = "Głębokość spągu";
            this.Spag.Width = 122;
            // 
            // gbWarstwa
            // 
            this.gbWarstwa.Controls.Add(this.btnEdytujUstawienia);
            this.gbWarstwa.Controls.Add(this.btnZapiszUstawienia);
            this.gbWarstwa.Controls.Add(this.panelColor);
            this.gbWarstwa.Controls.Add(this.btnUsun);
            this.gbWarstwa.Controls.Add(this.btnEdytuj);
            this.gbWarstwa.Controls.Add(this.btnDodaj);
            this.gbWarstwa.Controls.Add(this.btnKolor);
            this.gbWarstwa.Controls.Add(this.label3);
            this.gbWarstwa.Controls.Add(this.tbWspFitracji);
            this.gbWarstwa.Controls.Add(this.label2);
            this.gbWarstwa.Controls.Add(this.tbMiazszosc);
            this.gbWarstwa.Controls.Add(this.label1);
            this.gbWarstwa.Controls.Add(this.cbNazwa);
            this.gbWarstwa.Location = new System.Drawing.Point(12, 32);
            this.gbWarstwa.Name = "gbWarstwa";
            this.gbWarstwa.Size = new System.Drawing.Size(300, 484);
            this.gbWarstwa.TabIndex = 2;
            this.gbWarstwa.TabStop = false;
            this.gbWarstwa.Text = "Warstwa";
            // 
            // btnEdytujUstawienia
            // 
            this.btnEdytujUstawienia.Location = new System.Drawing.Point(9, 436);
            this.btnEdytujUstawienia.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytujUstawienia.Name = "btnEdytujUstawienia";
            this.btnEdytujUstawienia.Size = new System.Drawing.Size(284, 29);
            this.btnEdytujUstawienia.TabIndex = 12;
            this.btnEdytujUstawienia.Text = "Edytuj ustawienia warstwy";
            this.btnEdytujUstawienia.UseVisualStyleBackColor = true;
            this.btnEdytujUstawienia.Click += new System.EventHandler(this.btnEdytujUstawienia_Click);
            // 
            // btnZapiszUstawienia
            // 
            this.btnZapiszUstawienia.Location = new System.Drawing.Point(9, 401);
            this.btnZapiszUstawienia.Margin = new System.Windows.Forms.Padding(2);
            this.btnZapiszUstawienia.Name = "btnZapiszUstawienia";
            this.btnZapiszUstawienia.Size = new System.Drawing.Size(285, 29);
            this.btnZapiszUstawienia.TabIndex = 11;
            this.btnZapiszUstawienia.Text = "Zapisz ustawienia warstwy";
            this.btnZapiszUstawienia.UseVisualStyleBackColor = true;
            this.btnZapiszUstawienia.Click += new System.EventHandler(this.btnZapiszUstawienia_Click);
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(9, 142);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(285, 41);
            this.panelColor.TabIndex = 10;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(9, 274);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(285, 29);
            this.btnUsun.TabIndex = 9;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(9, 241);
            this.btnEdytuj.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(285, 29);
            this.btnEdytuj.TabIndex = 8;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(9, 206);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(285, 29);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnKolor
            // 
            this.btnKolor.Location = new System.Drawing.Point(9, 107);
            this.btnKolor.Name = "btnKolor";
            this.btnKolor.Size = new System.Drawing.Size(285, 29);
            this.btnKolor.TabIndex = 6;
            this.btnKolor.Text = "Wybierz kolor";
            this.btnKolor.UseVisualStyleBackColor = true;
            this.btnKolor.Click += new System.EventHandler(this.btnKolor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Współczynnik filtracji [m/d]";
            // 
            // tbWspFitracji
            // 
            this.tbWspFitracji.Location = new System.Drawing.Point(145, 73);
            this.tbWspFitracji.Name = "tbWspFitracji";
            this.tbWspFitracji.Size = new System.Drawing.Size(149, 20);
            this.tbWspFitracji.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miąższość [m]";
            // 
            // tbMiazszosc
            // 
            this.tbMiazszosc.Location = new System.Drawing.Point(145, 47);
            this.tbMiazszosc.Name = "tbMiazszosc";
            this.tbMiazszosc.Size = new System.Drawing.Size(149, 20);
            this.tbMiazszosc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // cbNazwa
            // 
            this.cbNazwa.FormattingEnabled = true;
            this.cbNazwa.Location = new System.Drawing.Point(145, 19);
            this.cbNazwa.Name = "cbNazwa";
            this.cbNazwa.Size = new System.Drawing.Size(149, 21);
            this.cbNazwa.TabIndex = 0;
            this.cbNazwa.SelectedIndexChanged += new System.EventHandler(this.cbNazwa_SelectedIndexChanged);
            // 
            // gbProfil
            // 
            this.gbProfil.Controls.Add(this.btnUsunZwUstalone);
            this.gbProfil.Controls.Add(this.btnDodajZwUstalone);
            this.gbProfil.Controls.Add(this.btnRaport);
            this.gbProfil.Controls.Add(this.btnRysuj);
            this.gbProfil.Controls.Add(this.btnDodajZwNawiercone);
            this.gbProfil.Controls.Add(this.btnUsunZwNawiercone);
            this.gbProfil.Controls.Add(this.tbUstalone);
            this.gbProfil.Controls.Add(this.tbNawiercone);
            this.gbProfil.Controls.Add(this.label5);
            this.gbProfil.Controls.Add(this.label4);
            this.gbProfil.Location = new System.Drawing.Point(318, 32);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(324, 484);
            this.gbProfil.TabIndex = 3;
            this.gbProfil.TabStop = false;
            this.gbProfil.Text = "Profil";
            // 
            // btnUsunZwUstalone
            // 
            this.btnUsunZwUstalone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnUsunZwUstalone.Location = new System.Drawing.Point(247, 89);
            this.btnUsunZwUstalone.Name = "btnUsunZwUstalone";
            this.btnUsunZwUstalone.Size = new System.Drawing.Size(69, 21);
            this.btnUsunZwUstalone.TabIndex = 14;
            this.btnUsunZwUstalone.Text = "Usuń";
            this.btnUsunZwUstalone.UseVisualStyleBackColor = true;
            this.btnUsunZwUstalone.Click += new System.EventHandler(this.btnUsunZwUstalone_Click);
            // 
            // btnDodajZwUstalone
            // 
            this.btnDodajZwUstalone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDodajZwUstalone.Location = new System.Drawing.Point(172, 89);
            this.btnDodajZwUstalone.Name = "btnDodajZwUstalone";
            this.btnDodajZwUstalone.Size = new System.Drawing.Size(69, 21);
            this.btnDodajZwUstalone.TabIndex = 13;
            this.btnDodajZwUstalone.Text = "Dodaj";
            this.btnDodajZwUstalone.UseVisualStyleBackColor = true;
            this.btnDodajZwUstalone.Click += new System.EventHandler(this.btnDodajZwUstalone_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(20, 436);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(285, 29);
            this.btnRaport.TabIndex = 12;
            this.btnRaport.Text = "Utwórz raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            // 
            // btnRysuj
            // 
            this.btnRysuj.Location = new System.Drawing.Point(20, 401);
            this.btnRysuj.Name = "btnRysuj";
            this.btnRysuj.Size = new System.Drawing.Size(285, 29);
            this.btnRysuj.TabIndex = 11;
            this.btnRysuj.Text = "Rysuj profil";
            this.btnRysuj.UseVisualStyleBackColor = true;
            // 
            // btnDodajZwNawiercone
            // 
            this.btnDodajZwNawiercone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnDodajZwNawiercone.Location = new System.Drawing.Point(172, 34);
            this.btnDodajZwNawiercone.Name = "btnDodajZwNawiercone";
            this.btnDodajZwNawiercone.Size = new System.Drawing.Size(69, 21);
            this.btnDodajZwNawiercone.TabIndex = 7;
            this.btnDodajZwNawiercone.Text = "Dodaj";
            this.btnDodajZwNawiercone.UseVisualStyleBackColor = true;
            this.btnDodajZwNawiercone.Click += new System.EventHandler(this.btnDodajZwNawiercone_Click);
            // 
            // btnUsunZwNawiercone
            // 
            this.btnUsunZwNawiercone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnUsunZwNawiercone.Location = new System.Drawing.Point(247, 35);
            this.btnUsunZwNawiercone.Name = "btnUsunZwNawiercone";
            this.btnUsunZwNawiercone.Size = new System.Drawing.Size(69, 20);
            this.btnUsunZwNawiercone.TabIndex = 10;
            this.btnUsunZwNawiercone.Text = "Usuń";
            this.btnUsunZwNawiercone.UseVisualStyleBackColor = true;
            this.btnUsunZwNawiercone.Click += new System.EventHandler(this.btnUsunZwNawiercone_Click);
            // 
            // tbUstalone
            // 
            this.tbUstalone.Location = new System.Drawing.Point(9, 89);
            this.tbUstalone.Name = "tbUstalone";
            this.tbUstalone.Size = new System.Drawing.Size(149, 20);
            this.tbUstalone.TabIndex = 4;
            // 
            // tbNawiercone
            // 
            this.tbNawiercone.Location = new System.Drawing.Point(9, 35);
            this.tbNawiercone.Name = "tbNawiercone";
            this.tbNawiercone.Size = new System.Drawing.Size(149, 20);
            this.tbNawiercone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zwierciadło wody ustalone [m.p.p.t]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zwierciadło wody nawiercone [m.p.p.t]";
            // 
            // gbSredni
            // 
            this.gbSredni.Controls.Add(this.btnWspFil);
            this.gbSredni.Controls.Add(this.label6);
            this.gbSredni.Controls.Add(this.tbSredniWspFiltracji);
            this.gbSredni.Location = new System.Drawing.Point(649, 32);
            this.gbSredni.Name = "gbSredni";
            this.gbSredni.Size = new System.Drawing.Size(330, 153);
            this.gbSredni.TabIndex = 4;
            this.gbSredni.TabStop = false;
            this.gbSredni.Text = "Średni współczynnik filtracji";
            // 
            // btnWspFil
            // 
            this.btnWspFil.Location = new System.Drawing.Point(27, 107);
            this.btnWspFil.Name = "btnWspFil";
            this.btnWspFil.Size = new System.Drawing.Size(285, 29);
            this.btnWspFil.TabIndex = 8;
            this.btnWspFil.Text = "Oblicz";
            this.btnWspFil.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "[m/d]";
            // 
            // tbSredniWspFiltracji
            // 
            this.tbSredniWspFiltracji.Location = new System.Drawing.Point(6, 35);
            this.tbSredniWspFiltracji.Name = "tbSredniWspFiltracji";
            this.tbSredniWspFiltracji.Size = new System.Drawing.Size(149, 20);
            this.tbSredniWspFiltracji.TabIndex = 5;
            // 
            // btnWlasciwosciProfilu
            // 
            this.btnWlasciwosciProfilu.Location = new System.Drawing.Point(676, 316);
            this.btnWlasciwosciProfilu.Margin = new System.Windows.Forms.Padding(2);
            this.btnWlasciwosciProfilu.Name = "btnWlasciwosciProfilu";
            this.btnWlasciwosciProfilu.Size = new System.Drawing.Size(285, 29);
            this.btnWlasciwosciProfilu.TabIndex = 13;
            this.btnWlasciwosciProfilu.Text = "Właściwości";
            this.btnWlasciwosciProfilu.UseVisualStyleBackColor = true;
            this.btnWlasciwosciProfilu.Click += new System.EventHandler(this.btnWlasciwosciProfilu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 573);
            this.Controls.Add(this.btnWlasciwosciProfilu);
            this.Controls.Add(this.gbSredni);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbWarstwa);
            this.Controls.Add(this.lvProfil);
            this.Controls.Add(this.studniaPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Profil studni";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studniaPictureBox)).EndInit();
            this.gbWarstwa.ResumeLayout(false);
            this.gbWarstwa.PerformLayout();
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            this.gbSredni.ResumeLayout(false);
            this.gbSredni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox studniaPictureBox;
        private System.Windows.Forms.ListView lvProfil;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Miazszosc;
        private System.Windows.Forms.ColumnHeader WspFiltracji;
        private System.Windows.Forms.ColumnHeader Strop;
        private System.Windows.Forms.ColumnHeader Spag;
        private System.Windows.Forms.GroupBox gbWarstwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWspFitracji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiazszosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNazwa;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnKolor;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Button btnRysuj;
        private System.Windows.Forms.Button btnUsunZwNawiercone;
        private System.Windows.Forms.Button btnDodajZwNawiercone;
        private System.Windows.Forms.TextBox tbUstalone;
        private System.Windows.Forms.TextBox tbNawiercone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSredni;
        private System.Windows.Forms.Button btnWspFil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSredniWspFiltracji;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnEdytujUstawienia;
        private System.Windows.Forms.Button btnZapiszUstawienia;
        private System.Windows.Forms.Button btnWlasciwosciProfilu;
        private System.Windows.Forms.Button btnDodajZwUstalone;
        private System.Windows.Forms.Button btnUsunZwUstalone;
    }
}

