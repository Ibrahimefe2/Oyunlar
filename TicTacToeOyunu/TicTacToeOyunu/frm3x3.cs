using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeOyunu
{
    public partial class frm3x3 : Form
    {
        private bool isPlayerOneTurn = true; // true ise 1. oyuncu, false ise 2. oyuncu
        private int playerOneScore = 0; // 1. oyuncunun puanı
        private int playerTwoScore = 0; // 2. oyuncunun puanı
        private Button btnMenuyeDon;

        private Label lblSira; // Oyuncu sırasını gösterecek label
        private Label lblPlayerOne; // 1. oyuncu label'ı
        private Label lblPlayerTwo; // 2. oyuncu label'ı
        private Label lblScoreOne; // 1. oyuncunun puanı
        private Label lblScoreTwo; // 2. oyuncunun puanı

        public frm3x3()
        {
            InitializeComponent();
        }

        private void OyunButon_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Tıklanan butonu alıyoruz

            // Eğer buton boşsa, X işareti ekle
            if (btn != null && string.IsNullOrEmpty(btn.Text))
            {
                if (isPlayerOneTurn)
                {
                    btn.Text = "X"; // 1. oyuncu için "X" ekle
                    lblSira.Text = "Sıra 2. oyuncuda"; // 1. oyuncu oynadıktan sonra 2. oyuncuya geçildiğini yazıyoruz
                }
                else // Eğer 2. oyuncunun sırasıysa
                {
                    btn.Text = "O"; // 2. oyuncu için "O" ekle
                    lblSira.Text = "Sıra 1. oyuncuda"; // 2. oyuncu oynadıktan sonra 1. oyuncuya geçildiğini yazıyoruz
                }
                isPlayerOneTurn = !isPlayerOneTurn;
            }
            CheckForWinner();
        }

        private void frm3x3_Load(object sender, EventArgs e)
        {
            int buttonSize = 60; // Butonların boyutu
            int gridSize = 3;    // 3x3 için ızgara boyutu
            this.ClientSize = new Size(buttonSize * gridSize + 200, buttonSize * gridSize + 150); // Form boyutunu genişlettik

            // Oyuncu isimleri ve puanları gösterecek label'ları ekliyoruz
            lblPlayerOne = new Label();
            lblPlayerOne.Text = "1. Oyuncu";
            lblPlayerOne.Font = new Font("Arial", 12);
            lblPlayerOne.Location = new Point(10, 10);
            this.Controls.Add(lblPlayerOne);

            btnMenuyeDon = new Button();
            btnMenuyeDon.Text = "Menüye Dön";
            btnMenuyeDon.Size = new Size(120, 40);
            btnMenuyeDon.Location = new Point(this.ClientSize.Width - btnMenuyeDon.Width - 20, this.ClientSize.Height - btnMenuyeDon.Height - 10); // Sağ alt köşe
            btnMenuyeDon.BackColor = Color.LightBlue;
            btnMenuyeDon.Click += new EventHandler(this.btnMenuyeDon_Click);
            this.Controls.Add(btnMenuyeDon);

            lblScoreOne = new Label();
            lblScoreOne.Text = "0";
            lblScoreOne.Font = new Font("Arial", 12);
            lblScoreOne.Location = new Point(10, 30);
            this.Controls.Add(lblScoreOne);

            lblPlayerTwo = new Label();
            lblPlayerTwo.Text = "2. Oyuncu";
            lblPlayerTwo.Font = new Font("Arial", 12);
            lblPlayerTwo.Location = new Point(this.ClientSize.Width - 120, 10);
            this.Controls.Add(lblPlayerTwo);

            lblScoreTwo = new Label();
            lblScoreTwo.Text = "0";
            lblScoreTwo.Font = new Font("Arial", 12);
            lblScoreTwo.Location = new Point(this.ClientSize.Width - 120, 30);
            this.Controls.Add(lblScoreTwo);

            // Sıra bilgisini gösterecek label
            lblSira = new Label();
            lblSira.Text = "Sıra 1. oyuncuda";
            lblSira.Font = new Font("Arial", 12);
            lblSira.Location = new Point(10, buttonSize * gridSize + 65);
            lblSira.Size = new Size(buttonSize * gridSize, 30);
            this.Controls.Add(lblSira);

            // 3x3 butonları dinamik olarak oluşturuyoruz
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Button btn = new Button();
                    btn.Name = $"btn{i}{j}"; // Buton ismini konumuna göre ayarlıyoruz, örneğin "btn00"
                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Location = new Point(i * buttonSize + 80, j * buttonSize + 60);
                    btn.BackColor = Color.LightGray;
                    btn.Click += new EventHandler(this.OyunButon_Click); // Tıklama olayını ekliyoruz
                    this.Controls.Add(btn); // Butonu forma ekliyoruz
                }
            }
        }

        private void CheckForWinner()
        {
            string[,] board = new string[3, 3];
            Button btn;

            // Board'ı dolduruyoruz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btn = this.Controls[$"btn{i}{j}"] as Button;
                    board[i, j] = btn.Text;
                }
            }

            // Kazanan var mı kontrol et
            if (CheckRowCol(board) || CheckDiagonals(board))
            {
                if (!isPlayerOneTurn) // isPlayerOneTurn ters çünkü sıra değişti
                {
                    playerOneScore++; // 1. oyuncu kazandı
                    MessageBox.Show("1. Oyuncu 1 puan kazandı!");
                    lblScoreOne.Text = playerOneScore.ToString();
                }
                else
                {
                    playerTwoScore++; // 2. oyuncu kazandı
                    MessageBox.Show("2. Oyuncu 1 puan kazandı!");
                    lblScoreTwo.Text = playerTwoScore.ToString();
                }

                // Oyun bitince sıfırlıyoruz
                ResetGame();
            }
            else
            {
                // Eğer tüm butonlar dolmuşsa ve kazanan yoksa beraberlik durumu
                bool isBoardFull = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (string.IsNullOrEmpty(board[i, j]))
                        {
                            isBoardFull = false;
                            break;
                        }
                    }
                    if (!isBoardFull) break;
                }

                if (isBoardFull)
                {
                    // Eğer tüm butonlar dolmuş ve kazanan yoksa beraberlik
                    MessageBox.Show("Oyun berabere bitti!");
                    ResetGame();
                }
            }
        }


        private bool CheckRowCol(string[,] board)
        {
            // Satır ve sütun kontrolü
            for (int i = 0; i < 3; i++)
            {
                // Satır kontrolü
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && !string.IsNullOrEmpty(board[i, 0]))
                    return true;

                // Sütun kontrolü
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && !string.IsNullOrEmpty(board[0, i]))
                    return true;
            }

            return false;
        }

        private bool CheckDiagonals(string[,] board)
        {
            // Diagonal kontrolü
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && !string.IsNullOrEmpty(board[0, 0]))
                return true;

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && !string.IsNullOrEmpty(board[0, 2]))
                return true;

            return false;
        }

        private void ResetGame()
        {
            // Oyun sıfırlanıyor, butonları temizliyoruz
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn != btnMenuyeDon)
                {
                    btn.Text = ""; // Tüm butonları boşaltıyoruz
                }
            }

            // Sıra bilgisi sıfırlanıyor
            lblSira.Text = "Sıra 1. oyuncuda"; // 1. oyuncuya sırası veriyoruz

            // Sıra 1. oyuncuda olduğu için, isPlayerOneTurn'ü true yapıyoruz
            isPlayerOneTurn = true;
        }

        private void btnMenuyeDon_Click(object sender, EventArgs e)
        {
            // Menüye dön butonuna tıklandığında formu kapatıyoruz
            frmAnaEkran anaEkran = new frmAnaEkran();
            this.Hide();
            anaEkran.Show();
        }
    }
}
