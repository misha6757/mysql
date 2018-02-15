namespace PROGA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заполнениеСправочниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dealIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new PROGA.SkladDataSet();
            this.dealTableAdapter = new PROGA.SkladDataSetTableAdapters.DealTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new PROGA.SkladDataSetTableAdapters.ClientTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainderGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new PROGA.SkladDataSetTableAdapters.GoodsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнениеСправочниковToolStripMenuItem,
            this.отчётToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заполнениеСправочниковToolStripMenuItem
            // 
            this.заполнениеСправочниковToolStripMenuItem.Name = "заполнениеСправочниковToolStripMenuItem";
            this.заполнениеСправочниковToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.заполнениеСправочниковToolStripMenuItem.Text = "Заполнение справочников";
            this.заполнениеСправочниковToolStripMenuItem.Click += new System.EventHandler(this.заполнениеСправочниковToolStripMenuItem_Click);
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            this.отчётToolStripMenuItem.Click += new System.EventHandler(this.отчётToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dealIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.datDataGridViewTextBoxColumn,
            this.Goods_ID,
            this.Client_ID});
            this.dataGridView1.DataSource = this.dealBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dealIDDataGridViewTextBoxColumn
            // 
            this.dealIDDataGridViewTextBoxColumn.DataPropertyName = "Deal_ID";
            this.dealIDDataGridViewTextBoxColumn.HeaderText = "Код сделки";
            this.dealIDDataGridViewTextBoxColumn.Name = "dealIDDataGridViewTextBoxColumn";
            this.dealIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // datDataGridViewTextBoxColumn
            // 
            this.datDataGridViewTextBoxColumn.DataPropertyName = "Dat";
            this.datDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datDataGridViewTextBoxColumn.Name = "datDataGridViewTextBoxColumn";
            // 
            // Goods_ID
            // 
            this.Goods_ID.DataPropertyName = "Goods_ID";
            this.Goods_ID.HeaderText = "Goods_ID";
            this.Goods_ID.Name = "Goods_ID";
            this.Goods_ID.Visible = false;
            // 
            // Client_ID
            // 
            this.Client_ID.DataPropertyName = "Client_ID";
            this.Client_ID.HeaderText = "Client_ID";
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.Visible = false;
            // 
            // dealBindingSource
            // 
            this.dealBindingSource.DataMember = "Deal";
            this.dealBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dealTableAdapter
            // 
            this.dealTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Family,
            this.Name,
            this.Last_name,
            this.Company,
            this.City_Client,
            this.Telephone,
            this.clientIDDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.cityClientDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(393, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(754, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "Фамилия";
            this.Family.Name = "Family";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Last_name
            // 
            this.Last_name.DataPropertyName = "Last_name";
            this.Last_name.HeaderText = "Отчество";
            this.Last_name.Name = "Last_name";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Фирма";
            this.Company.Name = "Company";
            // 
            // City_Client
            // 
            this.City_Client.DataPropertyName = "City_Client";
            this.City_Client.HeaderText = "Город клиента";
            this.City_Client.Name = "City_Client";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Телефон";
            this.Telephone.Name = "Telephone";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // cityClientDataGridViewTextBoxColumn
            // 
            this.cityClientDataGridViewTextBoxColumn.DataPropertyName = "City_Client";
            this.cityClientDataGridViewTextBoxColumn.HeaderText = "City_Client";
            this.cityClientDataGridViewTextBoxColumn.Name = "cityClientDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.skladDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.nameGoodsDataGridViewTextBoxColumn,
            this.typeGoodsDataGridViewTextBoxColumn,
            this.sortGoodsDataGridViewTextBoxColumn,
            this.priceGoodsDataGridViewTextBoxColumn,
            this.remainderGoodsDataGridViewTextBoxColumn,
            this.cityGoodsDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.goodsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(393, 284);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(754, 150);
            this.dataGridView3.TabIndex = 3;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "Goods_ID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameGoodsDataGridViewTextBoxColumn
            // 
            this.nameGoodsDataGridViewTextBoxColumn.DataPropertyName = "Name_Goods";
            this.nameGoodsDataGridViewTextBoxColumn.HeaderText = "Название товара";
            this.nameGoodsDataGridViewTextBoxColumn.Name = "nameGoodsDataGridViewTextBoxColumn";
            // 
            // typeGoodsDataGridViewTextBoxColumn
            // 
            this.typeGoodsDataGridViewTextBoxColumn.DataPropertyName = "Type_Goods";
            this.typeGoodsDataGridViewTextBoxColumn.HeaderText = "Тип товара";
            this.typeGoodsDataGridViewTextBoxColumn.Name = "typeGoodsDataGridViewTextBoxColumn";
            // 
            // sortGoodsDataGridViewTextBoxColumn
            // 
            this.sortGoodsDataGridViewTextBoxColumn.DataPropertyName = "Sort_Goods";
            this.sortGoodsDataGridViewTextBoxColumn.HeaderText = "Сорт товара";
            this.sortGoodsDataGridViewTextBoxColumn.Name = "sortGoodsDataGridViewTextBoxColumn";
            // 
            // priceGoodsDataGridViewTextBoxColumn
            // 
            this.priceGoodsDataGridViewTextBoxColumn.DataPropertyName = "Price_Goods";
            this.priceGoodsDataGridViewTextBoxColumn.HeaderText = "Цена товара";
            this.priceGoodsDataGridViewTextBoxColumn.Name = "priceGoodsDataGridViewTextBoxColumn";
            // 
            // remainderGoodsDataGridViewTextBoxColumn
            // 
            this.remainderGoodsDataGridViewTextBoxColumn.DataPropertyName = "Remainder_Goods";
            this.remainderGoodsDataGridViewTextBoxColumn.HeaderText = "Остаток товара";
            this.remainderGoodsDataGridViewTextBoxColumn.Name = "remainderGoodsDataGridViewTextBoxColumn";
            // 
            // cityGoodsDataGridViewTextBoxColumn
            // 
            this.cityGoodsDataGridViewTextBoxColumn.DataPropertyName = "City_Goods";
            this.cityGoodsDataGridViewTextBoxColumn.HeaderText = "Город товара";
            this.cityGoodsDataGridViewTextBoxColumn.Name = "cityGoodsDataGridViewTextBoxColumn";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.skladDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 141);
            this.button1.TabIndex = 4;
            this.button1.Text = "Договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
          //  this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заполнениеСправочниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource dealBindingSource;
        private SkladDataSetTableAdapters.DealTableAdapter dealTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SkladDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private SkladDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainderGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
    }
}

