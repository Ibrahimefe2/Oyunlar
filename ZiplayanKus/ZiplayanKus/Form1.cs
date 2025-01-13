using System;
using System.Windows.Forms;
using System.Drawing;

namespace ZiplayanKus
{
    public partial class Form1 : Form
    {
        int gravity = 5; // Yer çekimi etkisi
        int jump = 0; // Kuşun zıplama kuvveti
        int pipeSpeed = 8; // Engel hızı
        int score = 0; // Skor
        bool gameStarted = false; // Oyunun başlama durumu

        int pipeWidth = 60; // Engel genişliği
        int spaceHeight = 120; // Engeller arası boşluk

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown); // Klavye olayı

            this.BackColor = Color.Aquamarine; // Form arka plan rengi
            pbBird.BackColor = Color.Aquamarine; // Kuş arka plan rengi

            pbEngel1.BackColor = Color.Transparent;
            pbEngel2.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializePipes(); // Engelleri başlat
            lblScore.Text = "Skorunuz: 0"; // Başlangıç skoru
            pbBird.Top = this.ClientSize.Height / 2; // Kuşu ortala
        }

        private void InitializePipes()
        {
            // Engellerin başlangıç pozisyonlarını ayarla
            Random rnd = new Random();

            int pipeHeight1 = rnd.Next(50, this.ClientSize.Height - spaceHeight);
            pbEngel1.Height = pipeHeight1;
            pbEngel1.Top = this.ClientSize.Height - pipeHeight1;
            pbEngel1.Left = 800;

            int pipeHeight2 = this.ClientSize.Height - (pipeHeight1 + spaceHeight);
            pbEngel2.Height = pipeHeight2;
            pbEngel2.Top = 0;
            pbEngel2.Left = pbEngel1.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBird.Top += gravity; // Kuşa yer çekimi uygula

            if (jump < 0)
            {
                pbBird.Top += jump; // Kuşu zıplat
                jump += gravity; // Zıplama kuvvetini azalt
            }

            pbEngel1.Left -= pipeSpeed; // Engel1 hareket ettir
            pbEngel2.Left -= pipeSpeed; // Engel2 hareket ettir

            // Engel1 yeniden pozisyonla ve skoru güncelle
            if (pbEngel1.Left < -pipeWidth)
            {
                pbEngel1.Left = 800;
                int pipeHeight1 = new Random().Next(50, this.ClientSize.Height - spaceHeight);
                pbEngel1.Height = pipeHeight1;
                pbEngel1.Top = this.ClientSize.Height - pipeHeight1;

                int pipeHeight2 = this.ClientSize.Height - (pipeHeight1 + spaceHeight);
                pbEngel2.Height = pipeHeight2;
                pbEngel2.Top = 0;
                pbEngel2.Left = pbEngel1.Left;

                score++; // Skoru artır
            }

            // Engel2 yeniden pozisyonla ve skoru güncelle
            if (pbEngel2.Left < -pipeWidth)
            {
                pbEngel2.Left = 800;
                int pipeHeight1 = new Random().Next(50, this.ClientSize.Height - spaceHeight);
                pbEngel2.Height = pipeHeight1;
                pbEngel2.Top = this.ClientSize.Height - pipeHeight1;

                int pipeHeight2 = this.ClientSize.Height - (pipeHeight1 + spaceHeight);
                pbEngel1.Height = pipeHeight2;
                pbEngel1.Top = 0;
                pbEngel1.Left = pbEngel2.Left;

                score++; // Skoru artır
            }

            lblScore.Text = "Skorunuz: " + score; // Skor göster

            // Çarpışma ve ekran dışına çıkma kontrolleri
            if (pbBird.Bounds.IntersectsWith(pbEngel1.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbEngel2.Bounds) ||
                pbBird.Top < -25 || pbBird.Bottom > this.ClientSize.Height ||
                pbBird.Bounds.IntersectsWith(pictureBox1.Bounds)) // pictureBox1 yani zemin ile çarpışma kontrolü
            {
                EndGame(); // Oyunu bitir
            }
        }

        private void EndGame()
        {
            timer1.Stop(); // Zamanlayıcıyı durdur
            lblScore.Text = "Oyun bitti! Tekrar oynamak için space'e basınız."; // Bitiş mesajı
            gameStarted = false; // Oyunu yeniden başlatabilir hale getir
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameStarted)
                {
                    timer1.Start(); // Oyunu başlat
                    gameStarted = true;
                    score = 0;
                    lblScore.Text = "Skorunuz: 0";
                    pbBird.Top = this.ClientSize.Height / 2;
                    InitializePipes();
                }
                else
                {
                    if (pbBird.Top > 0)
                    {
                        jump = -20; // Zıplama yüksekliği
                    }
                }
            }
        }

        private void pbEngel2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbEngel1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbBird_Click(object sender, EventArgs e)
        {
            
        }
    }
}
