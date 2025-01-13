namespace ArabaYarisi
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
            this.lblSkor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelYol = new System.Windows.Forms.Panel();
            this.pictureBoxAraba = new System.Windows.Forms.PictureBox();
            this.pictureBoxEngel2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSeri1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEngel1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSerit2 = new System.Windows.Forms.PictureBox();
            this.panelYol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeri1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerit2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(134, 53);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(53, 17);
            this.lblSkor.TabIndex = 3;
            this.lblSkor.Text = "Skor: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelYol
            // 
            this.panelYol.BackColor = System.Drawing.Color.Gray;
            this.panelYol.Controls.Add(this.pictureBoxAraba);
            this.panelYol.Controls.Add(this.pictureBoxEngel2);
            this.panelYol.Controls.Add(this.pictureBoxSeri1);
            this.panelYol.Controls.Add(this.pictureBoxEngel1);
            this.panelYol.Controls.Add(this.pictureBoxSerit2);
            this.panelYol.Location = new System.Drawing.Point(214, 0);
            this.panelYol.Name = "panelYol";
            this.panelYol.Size = new System.Drawing.Size(320, 449);
            this.panelYol.TabIndex = 4;
            // 
            // pictureBoxAraba
            // 
            this.pictureBoxAraba.Image = global::ArabaYarisi.Properties.Resources.araba;
            this.pictureBoxAraba.Location = new System.Drawing.Point(140, 379);
            this.pictureBoxAraba.Name = "pictureBoxAraba";
            this.pictureBoxAraba.Size = new System.Drawing.Size(40, 59);
            this.pictureBoxAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAraba.TabIndex = 0;
            this.pictureBoxAraba.TabStop = false;
            // 
            // pictureBoxEngel2
            // 
            this.pictureBoxEngel2.Image = global::ArabaYarisi.Properties.Resources.engell;
            this.pictureBoxEngel2.Location = new System.Drawing.Point(5, 74);
            this.pictureBoxEngel2.Name = "pictureBoxEngel2";
            this.pictureBoxEngel2.Size = new System.Drawing.Size(91, 50);
            this.pictureBoxEngel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEngel2.TabIndex = 2;
            this.pictureBoxEngel2.TabStop = false;
            // 
            // pictureBoxSeri1
            // 
            this.pictureBoxSeri1.BackColor = System.Drawing.Color.White;
            this.pictureBoxSeri1.Location = new System.Drawing.Point(100, 0);
            this.pictureBoxSeri1.Name = "pictureBoxSeri1";
            this.pictureBoxSeri1.Size = new System.Drawing.Size(10, 449);
            this.pictureBoxSeri1.TabIndex = 6;
            this.pictureBoxSeri1.TabStop = false;
            // 
            // pictureBoxEngel1
            // 
            this.pictureBoxEngel1.Image = global::ArabaYarisi.Properties.Resources.engell;
            this.pictureBoxEngel1.Location = new System.Drawing.Point(224, 74);
            this.pictureBoxEngel1.Name = "pictureBoxEngel1";
            this.pictureBoxEngel1.Size = new System.Drawing.Size(91, 50);
            this.pictureBoxEngel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEngel1.TabIndex = 1;
            this.pictureBoxEngel1.TabStop = false;
            // 
            // pictureBoxSerit2
            // 
            this.pictureBoxSerit2.BackColor = System.Drawing.Color.White;
            this.pictureBoxSerit2.Location = new System.Drawing.Point(210, 0);
            this.pictureBoxSerit2.Name = "pictureBoxSerit2";
            this.pictureBoxSerit2.Size = new System.Drawing.Size(10, 449);
            this.pictureBoxSerit2.TabIndex = 5;
            this.pictureBoxSerit2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelYol);
            this.Controls.Add(this.lblSkor);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelYol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSeri1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAraba;
        private System.Windows.Forms.PictureBox pictureBoxEngel1;
        private System.Windows.Forms.PictureBox pictureBoxEngel2;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelYol;
        private System.Windows.Forms.PictureBox pictureBoxSeri1;
        private System.Windows.Forms.PictureBox pictureBoxSerit2;
    }
}

