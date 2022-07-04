using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormLoad01");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("종료하였습니다.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( MessageBox.Show("종료하시겠습니까?","종료",
                MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
        }
    }
}
