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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Program.frm4 = this;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frm1.Show();
        }
    }
}
