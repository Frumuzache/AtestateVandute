using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Cristi
{
    public partial class Form1 : Form
    {
        public static int nr = 1;
        float firstWidth;
        float firstHeight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            float size1 = this.Size.Width / firstWidth;
            float size2 = this.Size.Height / firstHeight;

            SizeF scale = new SizeF(size1, size2);
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));
                control.Scale(scale);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
            nr = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mod = new Form2();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mod = new Form3();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form mod = new Form4();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }
    }
}
