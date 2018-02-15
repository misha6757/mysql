using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PROGA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.frm1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.skladDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.skladDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Deal". При необходимости она может быть перемещена или удалена.
            this.dealTableAdapter.Fill(this.skladDataSet.Deal);
            button1.Enabled = false;
            

        }

        private void заполнениеСправочниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Program.frm1.Hide();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string n = dataGridView1[0, e.RowIndex].Value.ToString();
            string n = dataGridView1[0,e.RowIndex].Value.ToString();
            SqlConnection DB = new SqlConnection("Server=192.168.0.247\\MSSQL_KAB43;" + "Initial Catalog=Sklad;"  + "User ID=pk-4-14-user1;" + "Password=pk-4-14-user1;" );
            DB.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE((([Client_ID])= " + n + "))", DB);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            string n1 = dataGridView1[4, e.RowIndex].Value.ToString();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Goods WHERE((([Goods_ID])= " + n1 + "))", DB);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView3.DataSource = ds1.Tables[0];
            DB.Close();
            Opt.a1 = dataGridView1[0, e.RowIndex].Value.ToString();
            Opt.a2 = dataGridView1[1, e.RowIndex].Value.ToString();
            Opt.a3 = dataGridView2[1, 0].Value.ToString();
            Opt.a4 = dataGridView2[2, 0].Value.ToString();
            Opt.a5 = dataGridView2[3, 0].Value.ToString();
            Opt.a6 = dataGridView2[4, 0].Value.ToString();
            Opt.a7 = dataGridView2[5, 0].Value.ToString();
            Opt.a8 = dataGridView2[6, 0].Value.ToString();
            Opt.a9 = dataGridView3[1, 0].Value.ToString();
            Opt.a10 = dataGridView3[2, 0].Value.ToString();
            Opt.a11 = dataGridView3[3, 0].Value.ToString();
            Opt.a12 = dataGridView3[6, 0].Value.ToString();
            Opt.a13 = dataGridView3[4, 0].Value.ToString();
            Opt.a14 = dataGridView1[2, e.RowIndex].Value.ToString();
            button1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Program.frm1.Hide();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            Program.frm1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form5 frm5 = new Form5();
           frm5.Show();
           Program.frm1.Hide();
        }
    }
}
