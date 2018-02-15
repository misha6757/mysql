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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Program.frm2 = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.skladDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.skladDataSet.Client);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.clientTableAdapter.Update(this.skladDataSet.Client);
            this.goodsTableAdapter.Update(this.skladDataSet.Goods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Update(this.skladDataSet.Client);
            this.goodsTableAdapter.Update(this.skladDataSet.Goods);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frm1.Show();
        }
    }
}
