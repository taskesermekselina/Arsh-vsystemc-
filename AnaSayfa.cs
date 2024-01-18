using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form4gecis = new Form5();
            form4gecis.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form3 form4gecis = new Form3();
            form4gecis.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4gecis = new Form4();
            form4gecis.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form4gecis = new Form6();
            form4gecis.ShowDialog();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form4gecis = new Form11();
            form4gecis.ShowDialog();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 form4gecis = new Form10();
            form4gecis.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 form4gecis = new Form12();
            form4gecis.ShowDialog();
            this.Hide();
        }
    }
}
