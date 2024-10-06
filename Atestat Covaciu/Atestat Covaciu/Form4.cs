using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Covaciu
{
    public partial class Form4 : Form
    {
        float firstWidth;
        float firstHeight;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form4_SizeChanged(object sender, EventArgs e)
        {
            //cplm
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                Form1.nr++;

            if (radioButton5.Checked == true)
                Form1.nr++;

            if (radioButton9.Checked == true)
                Form1.nr++;

            if (radioButton22.Checked == true)
                Form1.nr++;

            if (radioButton18.Checked == true)
                Form1.nr++;

            if (radioButton15.Checked == true)
                Form1.nr++;

            if (radioButton34.Checked == true)
                Form1.nr++;

            if (radioButton32.Checked == true)
                Form1.nr++;

            if (radioButton27.Checked == true)
                Form1.nr++;


            Form mod = new Form5();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}