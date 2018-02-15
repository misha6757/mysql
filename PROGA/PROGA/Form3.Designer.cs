namespace PROGA
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запрос1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запрос2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запрос3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузкаФайлаСЗапросомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new PROGA.SkladDataSet();
            this.clientTableAdapter = new PROGA.SkladDataSetTableAdapters.ClientTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запрос1ToolStripMenuItem,
            this.запрос2ToolStripMenuItem,
            this.запрос3ToolStripMenuItem,
            this.загрузкаФайлаСЗапросомToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // запрос1ToolStripMenuItem
            // 
            this.запрос1ToolStripMenuItem.Name = "запрос1ToolStripMenuItem";
            this.запрос1ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.запрос1ToolStripMenuItem.Text = "Запрос №1";
            this.запрос1ToolStripMenuItem.Click += new System.EventHandler(this.запрос1ToolStripMenuItem_Click);
            // 
            // запрос2ToolStripMenuItem
            // 
            this.запрос2ToolStripMenuItem.Name = "запрос2ToolStripMenuItem";
            this.запрос2ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.запрос2ToolStripMenuItem.Text = "Запрос №2";
            this.запрос2ToolStripMenuItem.Click += new System.EventHandler(this.запрос2ToolStripMenuItem_Click);
            // 
            // запрос3ToolStripMenuItem
            // 
            this.запрос3ToolStripMenuItem.Name = "запрос3ToolStripMenuItem";
            this.запрос3ToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.запрос3ToolStripMenuItem.Text = "Запрос №3";
            this.запрос3ToolStripMenuItem.Click += new System.EventHandler(this.запрос3ToolStripMenuItem_Click);
            // 
            // загрузкаФайлаСЗапросомToolStripMenuItem
            // 
            this.загрузкаФайлаСЗапросомToolStripMenuItem.Name = "загрузкаФайлаСЗапросомToolStripMenuItem";
            this.загрузкаФайлаСЗапросомToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.загрузкаФайлаСЗапросомToolStripMenuItem.Text = "Загрузка файла с запросом";
            this.загрузкаФайлаСЗапросомToolStripMenuItem.Click += new System.EventHandler(this.загрузкаФайлаСЗапросомToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Отчёт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запрос1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запрос2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запрос3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузкаФайлаСЗапросомToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SkladDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}