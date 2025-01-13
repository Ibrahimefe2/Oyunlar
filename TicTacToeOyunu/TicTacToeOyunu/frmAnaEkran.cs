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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            frm3x3 form3x3 = new frm3x3();
            form3x3.Show();                
            this.Hide();
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            frm5x5 form5x5 = new frm5x5();
            form5x5.Show();                
            this.Hide();
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            frm9x9 form9x9 = new frm9x9();
            form9x9.Show();                
            this.Hide();
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
