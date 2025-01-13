namespace Hangman
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
            this.lblKelime = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(40, 70);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(0, 26);
            this.lblKelime.TabIndex = 0;
            this.lblKelime.Click += new System.EventHandler(this.lblKelime_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahmin.Location = new System.Drawing.Point(45, 215);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 34);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.TextChanged += new System.EventHandler(this.txtTahmin_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Location = new System.Drawing.Point(240, 215);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 34);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources.adam;
            this.pictureBox1.Location = new System.Drawing.Point(435, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHak.Location = new System.Drawing.Point(430, 276);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(133, 26);
            this.lblKalanHak.TabIndex = 4;
            this.lblKalanHak.Text = "Kalan Hak:";
            this.lblKalanHak.Click += new System.EventHandler(this.lblKalanHak_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(40, 365);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 26);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblKelime);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblDurum;
    }
}

