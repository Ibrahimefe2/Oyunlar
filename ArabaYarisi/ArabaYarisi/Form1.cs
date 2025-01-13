using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        private int hareketAraligi; // Şerit genişliklerine göre hesaplanacak
        private int skor = 0; // Skoru tutar
        private int hiz = 5; // Başlangıç hızı

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Klavye olaylarını formda yakala
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hareket aralığını hesapla
            hareketAraligi = (panelYol.Width - pictureBoxAraba.Width) / 3 + 13;

            // Başlangıç skor ve timer ayarları
            lblSkor.Text = $"Skor: {skor}";
            timer1.Enabled = true; // Oyunu başlat
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // Sol yön tuşu
            {
                // Sol sınır kontrolü: Araba sola gitmek için, sol taraf sınırda olmamalı
                if (pictureBoxAraba.Left + panelYol.Width - 150> panelYol.Left )
                {
                    pictureBoxAraba.Left -= hareketAraligi; // Sola hareket et
                }
            }
            else if (e.KeyCode == Keys.Right) // Sağ yön tuşu
            {
                // Sağ sınır kontrolü: Araba sağa gitmek için, sağ taraf sınırda olmamalı
                if (pictureBoxAraba.Right < panelYol.Left)
                {
                    pictureBoxAraba.Left += hareketAraligi; // Sağa hareket et
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Engelleri hareket ettir
            pictureBoxEngel1.Top += hiz;
            pictureBoxEngel2.Top += hiz;

            // Engel yeniden başlat (yukarıdan aşağı geçerse)
            if (pictureBoxEngel1.Top > panelYol.Height)
            {
                pictureBoxEngel1.Top = -50;
                pictureBoxEngel1.Left = panelYol.Left + (new Random().Next(0, 3) * hareketAraligi - 157);
                SkoruArtir();
            }
            if (pictureBoxEngel2.Top > panelYol.Height)
            {
                pictureBoxEngel2.Top = -50;
                pictureBoxEngel2.Left = panelYol.Left + (new Random().Next(0, 3) * hareketAraligi - 240);
                SkoruArtir();
            }

            // Çarpışma kontrolü
            if (pictureBoxAraba.Bounds.IntersectsWith(pictureBoxEngel1.Bounds) ||
                pictureBoxAraba.Bounds.IntersectsWith(pictureBoxEngel2.Bounds))
            {
                OyunuBitir();
            }
        }

        private void SkoruArtir()
        {
            skor += 5;
            lblSkor.Text = $"Skor: {skor}";

            // Hızı artır
            if (hiz < 50) // Maksimum hızı sınırlayabiliriz
            {
                hiz++;
            }
        }

        private void OyunuBitir()
        {
            timer1.Enabled = false;
            MessageBox.Show($"Oyun Bitti! Toplam Skor: {skor}", "Oyun Sonu");
            Application.Exit();
        }
    }
}
