namespace TicTacToeOyunu
{
    partial class frmAnaEkran
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
            this.lblSecim = new System.Windows.Forms.Label();
            this.btn3x3 = new System.Windows.Forms.Button();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn9x9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSecim
            // 
            this.lblSecim.AutoSize = true;
            this.lblSecim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecim.Location = new System.Drawing.Point(254, 136);
            this.lblSecim.Name = "lblSecim";
            this.lblSecim.Size = new System.Drawing.Size(263, 23);
            this.lblSecim.TabIndex = 0;
            this.lblSecim.Text = "Lütfen Harita Boyutunu Seçin";
            // 
            // btn3x3
            // 
            this.btn3x3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3x3.Location = new System.Drawing.Point(204, 170);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(75, 54);
            this.btn3x3.TabIndex = 1;
            this.btn3x3.Text = "3x3 Harita";
            this.btn3x3.UseVisualStyleBackColor = true;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // btn5x5
            // 
            this.btn5x5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5x5.Location = new System.Drawing.Point(353, 170);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(75, 54);
            this.btn5x5.TabIndex = 2;
            this.btn5x5.Text = "5x5 Harita";
            this.btn5x5.UseVisualStyleBackColor = true;
            this.btn5x5.Click += new System.EventHandler(this.btn5x5_Click);
            // 
            // btn9x9
            // 
            this.btn9x9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9x9.Location = new System.Drawing.Point(502, 170);
            this.btn9x9.Name = "btn9x9";
            this.btn9x9.Size = new System.Drawing.Size(75, 54);
            this.btn9x9.TabIndex = 3;
            this.btn9x9.Text = "9x9 Harita";
            this.btn9x9.UseVisualStyleBackColor = true;
            this.btn9x9.Click += new System.EventHandler(this.btn9x9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 66);
            this.label1.TabIndex = 4;
            this.label1.Text = "3x3 haritada kazanmak için 3\'lü x veya o serisi oluşturun.\r\n5x5 haritada kazanmak" +
    " için 4\'lü x veya o serisi oluşturun.\r\n9x9 haritada kazanmak için 4\'lü x veya o " +
    "serisi oluşturun.";
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn9x9);
            this.Controls.Add(this.btn5x5);
            this.Controls.Add(this.btn3x3);
            this.Controls.Add(this.lblSecim);
            this.Name = "frmAnaEkran";
            this.Text = "Harita Seçim Ekranı";
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecim;
        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btn9x9;
        private System.Windows.Forms.Label label1;
    }
}

