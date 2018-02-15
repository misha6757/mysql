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
    public partial class Form3 : Form
    {
        SqlConnection DB = new SqlConnection("Server=192.168.0.247\\MSSQL_KAB43;" + "Initial Catalog=Sklad;" + "User ID=pk-4-14-user1;" + "Password=pk-4-14-user1;");

        public Form3()
        {
            InitializeComponent();
            Program.frm3 = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.skladDataSet.Client);
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.Open();
            try
            {
                string n = textBox1.Text;
                SqlDataAdapter da = new SqlDataAdapter(" " + n + " ", DB);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("OSHIBKA BRAT!");
            }
            DB.Close();
    }

        private void запрос1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client", DB);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DB.Close();
        }

        private void запрос2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Goods", DB);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DB.Close();
        }

        private void запрос3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Deal", DB);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DB.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.ShowDialog();
        }

        private void загрузкаФайлаСЗапросомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frm1.Show();
        }
    }
}
