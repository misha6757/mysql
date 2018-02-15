using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Program.frm5 = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = Opt.a1;
            label29.Text = Opt.a2;
            label6.Text = Opt.a3;
            label8.Text = Opt.a4;
            label10.Text = Opt.a5;
            label12.Text = Opt.a6;
            label14.Text = Opt.a7;
            label16.Text = Opt.a8;
            label19.Text = Opt.a9;
            label21.Text = Opt.a10;
            label23.Text = Opt.a11;
            label25.Text = Opt.a12;
            label27.Text = Opt.a13;
            label4.Text = Opt.a14;
            label31.Text = (Int32.Parse(label27.Text) * Int32.Parse(label29.Text)).ToString();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frm1.Show();
        }
    }
}
