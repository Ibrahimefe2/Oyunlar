namespace ZiplayanKus
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEngel2 = new System.Windows.Forms.PictureBox();
            this.pbEngel1 = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(20, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 17);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label1";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZiplayanKus.Properties.Resources.zemin;
            this.pictureBox1.Location = new System.Drawing.Point(1, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbEngel2
            // 
            this.pbEngel2.Image = global::ZiplayanKus.Properties.Resources.boru2;
            this.pbEngel2.Location = new System.Drawing.Point(444, 235);
            this.pbEngel2.Name = "pbEngel2";
            this.pbEngel2.Size = new System.Drawing.Size(66, 217);
            this.pbEngel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEngel2.TabIndex = 2;
            this.pbEngel2.TabStop = false;
            this.pbEngel2.Click += new System.EventHandler(this.pbEngel2_Click);
            // 
            // pbEngel1
            // 
            this.pbEngel1.Image = global::ZiplayanKus.Properties.Resources.boru1;
            this.pbEngel1.Location = new System.Drawing.Point(444, 1);
            this.pbEngel1.Name = "pbEngel1";
            this.pbEngel1.Size = new System.Drawing.Size(66, 150);
            this.pbEngel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEngel1.TabIndex = 1;
            this.pbEngel1.TabStop = false;
            this.pbEngel1.Click += new System.EventHandler(this.pbEngel1_Click);
            // 
            // pbBird
            // 
            this.pbBird.Image = global::ZiplayanKus.Properties.Resources.kus2;
            this.pbBird.Location = new System.Drawing.Point(12, 190);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(58, 43);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            this.pbBird.Click += new System.EventHandler(this.pbBird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbEngel2);
            this.Controls.Add(this.pbEngel1);
            this.Controls.Add(this.pbBird);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbEngel1;
        private System.Windows.Forms.PictureBox pbEngel2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}