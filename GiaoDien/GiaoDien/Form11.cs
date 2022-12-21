using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f=new Form12();
            f.Show();

        }

        private void quảnLíDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f=new Form13();
            f.Show();
        }

        private void quảnLíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form14 f=new Form14();
            f.Show();
        }

        private void quảnLíThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f=new Form15();
            f.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
