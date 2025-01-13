using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class MayinTarlasi : Form
    {
        public MayinTarlasi()
        {
            InitializeComponent();
            this.Size = new Size(650, 500);
        }

        Button[,] buttons = new Button[18, 14];
        bool[,] mines = new bool[18, 14];
        Random rnd = new Random();

        // Yeni label'lar
        Label lblOpened = new Label();
        Label lblRemaining = new Label();
        Label lblMoves = new Label();

        // Oyun istatistikleri
        int openedBlocks = 0;
        int remainingBlocks = 252; // 18 * 14 toplam buton sayısı
        int moves = 0;

        private void MayinTarlasi_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 18; x++)
            {
                for (int y = 0; y < 14; y++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(x * 30, y * 30);
                    btn.Tag = new Point(x, y);  // Tag'e Point nesnesi atanıyor
                    btn.Click += Button_Click;
                    buttons[x, y] = btn;
                    this.Controls.Add(btn);
                }
            }
            PlaceMines();

            // Label'ları ayarlama
            lblOpened.Location = new Point(540, 50);
            lblRemaining.Location = new Point(540, 100);
            lblMoves.Location = new Point(540, 150);

            lblOpened.Text = "Açılan Bloklar: 0";
            lblRemaining.Text = "Kalan Bloklar: 252";
            lblMoves.Text = "Yapılan Hamle: 0";

            this.Controls.Add(lblOpened);
            this.Controls.Add(lblRemaining);
            this.Controls.Add(lblMoves);
        }

        private void PlaceMines()
        {
            int mineCount = 0;
            while (mineCount < 40)
            {
                int x = rnd.Next(18); // 0 ile 17 arasında rastgele sayı
                int y = rnd.Next(14); // 0 ile 13 arasında rastgele sayı

                // Eğer bu konuma daha önce mayın yerleştirilmemişse
                if (!mines[x, y])
                {
                    mines[x, y] = true; // Mayın yerleştir
                    mineCount++; // Yerleştirilen mayın sayısını artır
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point position = (Point)clickedButton.Tag;  // Tag'dan Point'e dönüşüm yapılır
            int x = position.X;  // X koordinatını al
            int y = position.Y;  // Y koordinatını al

            // Eğer buton bir mayına basarsa
            if (mines[x, y])
            {
                clickedButton.Text = "💣"; // Mayını göster
                clickedButton.BackColor = Color.Red; // Arkaplanı kırmızı yap
                MessageBox.Show("Mayına bastınız! Oyun bitti.");
                RevealAllMines(); // Tüm mayınları göster
                Application.Restart(); // Oyunu yeniden başlat
            }
            else
            {
                int mineCount = CountAdjacentMines(x, y); // Çevredeki mayınları say

                // Eğer çevresinde mayın varsa
                if (mineCount > 0)
                {
                    clickedButton.Text = mineCount.ToString(); // Çevredeki mayın sayısını göster
                }
                else
                {
                    RevealSafeArea(x, y); // Eğer çevresinde hiç mayın yoksa güvenli alanı aç
                }

                clickedButton.Enabled = false; // Butonu pasifleştir

                // Hamleyi say
                moves++;
                lblMoves.Text = $"Yapılan Hamle: {moves}";

                // Açılan blokları ve kalan blokları güncelle
                remainingBlocks--;

                // UpdateOpenedBlocks metodunu çağırarak açılan blokları güncelle
                UpdateOpenedBlocks(); // Burada, açılan bloklar sayılacak ve openedBlocks güncellenmiş olacak
                lblOpened.Text = $"Açılan Bloklar: {openedBlocks}";
                lblRemaining.Text = $"Kalan Bloklar: {remainingBlocks}";
            }
        }


        private int CountAdjacentMines(int x, int y)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newX = x + i;
                    int newY = y + j;

                    // Koordinatlar geçerli mi ve mayın var mı kontrolü
                    if (newX >= 0 && newX < 18 && newY >= 0 && newY < 14 && mines[newX, newY])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void RevealAllMines()
        {
            for (int x = 0; x < 18; x++)
            {
                for (int y = 0; y < 14; y++)
                {
                    if (mines[x, y])
                    {
                        buttons[x, y].BackColor = Color.Red; // Mayınları kırmızı yap
                    }
                }
            }
        }

        private void RevealSafeArea(int x, int y)
        {
            // Koordinatların geçerli olup olmadığını kontrol et
            if (x < 0 || x >= 18 || y < 0 || y >= 14 || !buttons[x, y].Enabled)
            {
                return;
            }

            // Çevredeki mayınları say
            int mineCount = CountAdjacentMines(x, y);

            if (mineCount > 0)
            {
                buttons[x, y].Text = mineCount.ToString(); // Çevresindeki mayın sayısını yaz
                buttons[x, y].Enabled = false; // Butonu devre dışı bırak
                return;
            }

            // Eğer çevrede mayın yoksa
            buttons[x, y].Enabled = false; // Butonu devre dışı bırak
            buttons[x, y].BackColor = Color.LightGray; // Güvenli alan rengi

            // Çevredeki diğer 8 hücreyi kontrol et ve zincirleme aç
            RevealSafeArea(x - 1, y - 1); // Sol üst
            RevealSafeArea(x, y - 1);     // Üst
            RevealSafeArea(x + 1, y - 1); // Sağ üst
            RevealSafeArea(x - 1, y);     // Sol
            RevealSafeArea(x + 1, y);     // Sağ
            RevealSafeArea(x - 1, y + 1); // Sol alt
            RevealSafeArea(x, y + 1);     // Alt
            RevealSafeArea(x + 1, y + 1); // Sağ alt
        }
        private void UpdateOpenedBlocks()
        {
            // Açılan blokları sayan fonksiyon, sıfırlama yapılmaz
            int opened = 0;

            for (int x = 0; x < 18; x++)
            {
                for (int y = 0; y < 14; y++)
                {
                    if (!buttons[x, y].Enabled)  // Eğer buton devre dışıysa, açılmıştır
                    {
                        opened++;
                    }
                }
            }

            openedBlocks = opened; // Açılan blokları güncelleyerek değişkeni ata
            remainingBlocks = (18 * 14) - openedBlocks;
        }

    }
}
