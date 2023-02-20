namespace btlWinform
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFil = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgtProduct = new System.Windows.Forms.DataGridView();
            this.grbProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSale = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodePro = new System.Windows.Forms.TextBox();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelOne = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.dgtProduct2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgtBill = new System.Windows.Forms.DataGridView();
            this.grbBill = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpBill = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.btnStatisPro = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbStatisCode = new System.Windows.Forms.ComboBox();
            this.btnStatisCode = new System.Windows.Forms.Button();
            this.btnStatisDate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbStatis = new System.Windows.Forms.ComboBox();
            this.dtpStatis = new System.Windows.Forms.DateTimePicker();
            this.btnStatisBrand = new System.Windows.Forms.Button();
            this.btnStatis = new System.Windows.Forms.Button();
            this.grbStatis = new System.Windows.Forms.GroupBox();
            this.txtStaticBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtTotalStatis = new System.Windows.Forms.TextBox();
            this.lblStatisTotal = new System.Windows.Forms.Label();
            this.dgtStatis = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtProduct)).BeginInit();
            this.grbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtProduct2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtBill)).BeginInit();
            this.grbBill.SuspendLayout();
            this.tabStat.SuspendLayout();
            this.grbStatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtStatis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabProduct);
            this.tabMain.Controls.Add(this.tabBill);
            this.tabMain.Controls.Add(this.tabStat);
            this.tabMain.Location = new System.Drawing.Point(5, 2);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1302, 725);
            this.tabMain.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnLoad);
            this.tabProduct.Controls.Add(this.btnFil);
            this.tabProduct.Controls.Add(this.btnDel);
            this.tabProduct.Controls.Add(this.btnEdit);
            this.tabProduct.Controls.Add(this.btnAdd);
            this.tabProduct.Controls.Add(this.groupBox2);
            this.tabProduct.Controls.Add(this.grbProduct);
            this.tabProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabProduct.Location = new System.Drawing.Point(4, 29);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProduct.Size = new System.Drawing.Size(1294, 692);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Quản lý sản phẩm";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(184, 636);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 42);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFil
            // 
            this.btnFil.Location = new System.Drawing.Point(919, 636);
            this.btnFil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFil.Name = "btnFil";
            this.btnFil.Size = new System.Drawing.Size(222, 42);
            this.btnFil.TabIndex = 17;
            this.btnFil.Text = "Lọc theo thương hiệu";
            this.btnFil.UseVisualStyleBackColor = true;
            this.btnFil.Click += new System.EventHandler(this.btnFil_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(736, 636);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(117, 42);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(553, 636);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 42);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 636);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 42);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgtProduct);
            this.groupBox2.Location = new System.Drawing.Point(32, 302);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1225, 318);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý sản phẩm";
            // 
            // dgtProduct
            // 
            this.dgtProduct.AllowUserToAddRows = false;
            this.dgtProduct.AllowUserToDeleteRows = false;
            this.dgtProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgtProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtProduct.Location = new System.Drawing.Point(27, 27);
            this.dgtProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgtProduct.MultiSelect = false;
            this.dgtProduct.Name = "dgtProduct";
            this.dgtProduct.ReadOnly = true;
            this.dgtProduct.RowHeadersWidth = 51;
            this.dgtProduct.RowTemplate.Height = 24;
            this.dgtProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtProduct.Size = new System.Drawing.Size(1176, 282);
            this.dgtProduct.TabIndex = 0;
            this.dgtProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtProduct_CellClick);
            this.dgtProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtProduct_CellContentClick);
            // 
            // grbProduct
            // 
            this.grbProduct.Controls.Add(this.label1);
            this.grbProduct.Controls.Add(this.nudSale);
            this.grbProduct.Controls.Add(this.label2);
            this.grbProduct.Controls.Add(this.nudCount);
            this.grbProduct.Controls.Add(this.label3);
            this.grbProduct.Controls.Add(this.cbbBrand);
            this.grbProduct.Controls.Add(this.label4);
            this.grbProduct.Controls.Add(this.txtPrice);
            this.grbProduct.Controls.Add(this.label5);
            this.grbProduct.Controls.Add(this.txtNamePro);
            this.grbProduct.Controls.Add(this.label6);
            this.grbProduct.Controls.Add(this.txtCodePro);
            this.grbProduct.Location = new System.Drawing.Point(32, 27);
            this.grbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbProduct.Name = "grbProduct";
            this.grbProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbProduct.Size = new System.Drawing.Size(1225, 245);
            this.grbProduct.TabIndex = 12;
            this.grbProduct.TabStop = false;
            this.grbProduct.Text = "Thông tin sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Mã sản phẩm(7 ký tự)";
            // 
            // nudSale
            // 
            this.nudSale.Location = new System.Drawing.Point(916, 182);
            this.nudSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSale.Name = "nudSale";
            this.nudSale.Size = new System.Drawing.Size(150, 27);
            this.nudSale.TabIndex = 6;
            this.nudSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(916, 114);
            this.nudCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(150, 27);
            this.nudCount.TabIndex = 5;
            this.nudCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán(VND)";
            // 
            // cbbBrand
            // 
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(916, 42);
            this.cbbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbBrand.MaxLength = 10;
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(171, 28);
            this.cbbBrand.TabIndex = 4;
            this.cbbBrand.Tag = "Thương Hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thương hiệu";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(280, 186);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 27);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Tag = "Giá bán";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng hàng";
            // 
            // txtNamePro
            // 
            this.txtNamePro.Location = new System.Drawing.Point(280, 95);
            this.txtNamePro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamePro.MaxLength = 70;
            this.txtNamePro.Multiline = true;
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(359, 46);
            this.txtNamePro.TabIndex = 2;
            this.txtNamePro.Tag = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giảm giá(%)";
            // 
            // txtCodePro
            // 
            this.txtCodePro.Location = new System.Drawing.Point(280, 46);
            this.txtCodePro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodePro.MaxLength = 7;
            this.txtCodePro.Name = "txtCodePro";
            this.txtCodePro.Size = new System.Drawing.Size(169, 27);
            this.txtCodePro.TabIndex = 1;
            this.txtCodePro.Tag = "Mã sản phẩm";
            this.txtCodePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePro_KeyPress);
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.btnClearBill);
            this.tabBill.Controls.Add(this.btnSaveBill);
            this.tabBill.Controls.Add(this.btnDelAll);
            this.tabBill.Controls.Add(this.btnDelOne);
            this.tabBill.Controls.Add(this.btnAddBill);
            this.tabBill.Controls.Add(this.dgtProduct2);
            this.tabBill.Controls.Add(this.groupBox4);
            this.tabBill.Controls.Add(this.grbBill);
            this.tabBill.Location = new System.Drawing.Point(4, 29);
            this.tabBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBill.Size = new System.Drawing.Size(1294, 692);
            this.tabBill.TabIndex = 1;
            this.tabBill.Text = "Tạo hóa đơn";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // btnClearBill
            // 
            this.btnClearBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearBill.Enabled = false;
            this.btnClearBill.Location = new System.Drawing.Point(1095, 553);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(173, 43);
            this.btnClearBill.TabIndex = 7;
            this.btnClearBill.Text = "Xóa hết đơn";
            this.btnClearBill.UseVisualStyleBackColor = false;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.Color.Cyan;
            this.btnSaveBill.ForeColor = System.Drawing.Color.Black;
            this.btnSaveBill.Location = new System.Drawing.Point(772, 479);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(173, 43);
            this.btnSaveBill.TabIndex = 6;
            this.btnSaveBill.Text = "Lưu Hóa Đơn";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelAll.Enabled = false;
            this.btnDelAll.Location = new System.Drawing.Point(1095, 479);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(173, 43);
            this.btnDelAll.TabIndex = 5;
            this.btnDelAll.Text = "Xóa hết số lượng";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDelOne
            // 
            this.btnDelOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelOne.Enabled = false;
            this.btnDelOne.Location = new System.Drawing.Point(1095, 405);
            this.btnDelOne.Name = "btnDelOne";
            this.btnDelOne.Size = new System.Drawing.Size(173, 43);
            this.btnDelOne.TabIndex = 4;
            this.btnDelOne.Text = "Xóa một sản phẩm";
            this.btnDelOne.UseVisualStyleBackColor = false;
            this.btnDelOne.Click += new System.EventHandler(this.btnDelOne_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBill.Location = new System.Drawing.Point(772, 405);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(317, 43);
            this.btnAddBill.TabIndex = 3;
            this.btnAddBill.Text = "Thêm sản phẩm vào Hóa Đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // dgtProduct2
            // 
            this.dgtProduct2.AllowUserToAddRows = false;
            this.dgtProduct2.AllowUserToDeleteRows = false;
            this.dgtProduct2.BackgroundColor = System.Drawing.Color.White;
            this.dgtProduct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtProduct2.Location = new System.Drawing.Point(26, 319);
            this.dgtProduct2.MultiSelect = false;
            this.dgtProduct2.Name = "dgtProduct2";
            this.dgtProduct2.ReadOnly = true;
            this.dgtProduct2.RowHeadersWidth = 51;
            this.dgtProduct2.RowTemplate.Height = 24;
            this.dgtProduct2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtProduct2.Size = new System.Drawing.Size(726, 356);
            this.dgtProduct2.TabIndex = 2;
            this.dgtProduct2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtProduct2_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgtBill);
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(772, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 360);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm đặt mua";
            // 
            // dgtBill
            // 
            this.dgtBill.AllowUserToAddRows = false;
            this.dgtBill.AllowUserToDeleteRows = false;
            this.dgtBill.BackgroundColor = System.Drawing.Color.White;
            this.dgtBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtBill.Location = new System.Drawing.Point(15, 36);
            this.dgtBill.MultiSelect = false;
            this.dgtBill.Name = "dgtBill";
            this.dgtBill.ReadOnly = true;
            this.dgtBill.RowHeadersWidth = 51;
            this.dgtBill.RowTemplate.Height = 24;
            this.dgtBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtBill.Size = new System.Drawing.Size(466, 307);
            this.dgtBill.TabIndex = 0;
            this.dgtBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtBill_CellClick);
            // 
            // grbBill
            // 
            this.grbBill.Controls.Add(this.txtTotal);
            this.grbBill.Controls.Add(this.label10);
            this.grbBill.Controls.Add(this.dtpBill);
            this.grbBill.Controls.Add(this.label9);
            this.grbBill.Controls.Add(this.txtPhone);
            this.grbBill.Controls.Add(this.label8);
            this.grbBill.Controls.Add(this.txtNameCus);
            this.grbBill.Controls.Add(this.label7);
            this.grbBill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbBill.Location = new System.Drawing.Point(26, 24);
            this.grbBill.Name = "grbBill";
            this.grbBill.Size = new System.Drawing.Size(726, 262);
            this.grbBill.TabIndex = 0;
            this.grbBill.TabStop = false;
            this.grbBill.Text = "Thông tin đơn hàng";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.Location = new System.Drawing.Point(196, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 27);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Thành tiền(VND)";
            // 
            // dtpBill
            // 
            this.dtpBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBill.Location = new System.Drawing.Point(196, 142);
            this.dtpBill.Name = "dtpBill";
            this.dtpBill.Size = new System.Drawing.Size(200, 27);
            this.dtpBill.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày mua";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(196, 84);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 27);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Tag = "Số điện thoại";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "SĐT";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(196, 36);
            this.txtNameCus.MaxLength = 50;
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(254, 27);
            this.txtNameCus.TabIndex = 1;
            this.txtNameCus.Tag = "Tên khách hàng";
            this.txtNameCus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameCus_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên KH";
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.btnStatisPro);
            this.tabStat.Controls.Add(this.label13);
            this.tabStat.Controls.Add(this.cbbStatisCode);
            this.tabStat.Controls.Add(this.btnStatisCode);
            this.tabStat.Controls.Add(this.btnStatisDate);
            this.tabStat.Controls.Add(this.label12);
            this.tabStat.Controls.Add(this.label11);
            this.tabStat.Controls.Add(this.cbbStatis);
            this.tabStat.Controls.Add(this.dtpStatis);
            this.tabStat.Controls.Add(this.btnStatisBrand);
            this.tabStat.Controls.Add(this.btnStatis);
            this.tabStat.Controls.Add(this.grbStatis);
            this.tabStat.Location = new System.Drawing.Point(4, 29);
            this.tabStat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStat.Name = "tabStat";
            this.tabStat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStat.Size = new System.Drawing.Size(1294, 692);
            this.tabStat.TabIndex = 2;
            this.tabStat.Text = "Thống kê doanh thu";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // btnStatisPro
            // 
            this.btnStatisPro.Location = new System.Drawing.Point(341, 575);
            this.btnStatisPro.Name = "btnStatisPro";
            this.btnStatisPro.Size = new System.Drawing.Size(264, 47);
            this.btnStatisPro.TabIndex = 12;
            this.btnStatisPro.Text = "Thống kê sản phẩm";
            this.btnStatisPro.UseVisualStyleBackColor = true;
            this.btnStatisPro.Click += new System.EventHandler(this.btnStatisPro_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 635);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Chọn mã Hóa Đơn";
            // 
            // cbbStatisCode
            // 
            this.cbbStatisCode.FormattingEnabled = true;
            this.cbbStatisCode.Location = new System.Drawing.Point(341, 658);
            this.cbbStatisCode.Name = "cbbStatisCode";
            this.cbbStatisCode.Size = new System.Drawing.Size(157, 28);
            this.cbbStatisCode.TabIndex = 10;
            // 
            // btnStatisCode
            // 
            this.btnStatisCode.Location = new System.Drawing.Point(34, 639);
            this.btnStatisCode.Name = "btnStatisCode";
            this.btnStatisCode.Size = new System.Drawing.Size(264, 47);
            this.btnStatisCode.TabIndex = 9;
            this.btnStatisCode.Text = "Thống kê theo từng Hóa Đơn";
            this.btnStatisCode.UseVisualStyleBackColor = true;
            this.btnStatisCode.Click += new System.EventHandler(this.btnStatisCode_Click);
            // 
            // btnStatisDate
            // 
            this.btnStatisDate.Location = new System.Drawing.Point(652, 639);
            this.btnStatisDate.Name = "btnStatisDate";
            this.btnStatisDate.Size = new System.Drawing.Size(278, 47);
            this.btnStatisDate.TabIndex = 8;
            this.btnStatisDate.Text = "Thông kê theo ngày";
            this.btnStatisDate.UseVisualStyleBackColor = true;
            this.btnStatisDate.Click += new System.EventHandler(this.btnStatisDate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1033, 635);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Chọn ngày bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1010, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = " Chọn loại sản phẩm ";
            // 
            // cbbStatis
            // 
            this.cbbStatis.FormattingEnabled = true;
            this.cbbStatis.Location = new System.Drawing.Point(982, 594);
            this.cbbStatis.Name = "cbbStatis";
            this.cbbStatis.Size = new System.Drawing.Size(228, 28);
            this.cbbStatis.TabIndex = 5;
            // 
            // dtpStatis
            // 
            this.dtpStatis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatis.Location = new System.Drawing.Point(982, 659);
            this.dtpStatis.Name = "dtpStatis";
            this.dtpStatis.Size = new System.Drawing.Size(228, 27);
            this.dtpStatis.TabIndex = 4;
            // 
            // btnStatisBrand
            // 
            this.btnStatisBrand.Location = new System.Drawing.Point(652, 575);
            this.btnStatisBrand.Name = "btnStatisBrand";
            this.btnStatisBrand.Size = new System.Drawing.Size(278, 47);
            this.btnStatisBrand.TabIndex = 3;
            this.btnStatisBrand.Text = "Thống kê theo Hãng";
            this.btnStatisBrand.UseVisualStyleBackColor = true;
            this.btnStatisBrand.Click += new System.EventHandler(this.btnStatisBrand_Click);
            // 
            // btnStatis
            // 
            this.btnStatis.Location = new System.Drawing.Point(35, 575);
            this.btnStatis.Name = "btnStatis";
            this.btnStatis.Size = new System.Drawing.Size(264, 47);
            this.btnStatis.TabIndex = 2;
            this.btnStatis.Text = "Thống kê toàn bộ Hóa Đơn";
            this.btnStatis.UseVisualStyleBackColor = true;
            this.btnStatis.Click += new System.EventHandler(this.btnStatis_Click);
            // 
            // grbStatis
            // 
            this.grbStatis.BackColor = System.Drawing.Color.Transparent;
            this.grbStatis.Controls.Add(this.txtStaticBrand);
            this.grbStatis.Controls.Add(this.lblBrand);
            this.grbStatis.Controls.Add(this.txtTotalStatis);
            this.grbStatis.Controls.Add(this.lblStatisTotal);
            this.grbStatis.Controls.Add(this.dgtStatis);
            this.grbStatis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbStatis.Location = new System.Drawing.Point(34, 32);
            this.grbStatis.Name = "grbStatis";
            this.grbStatis.Size = new System.Drawing.Size(1223, 507);
            this.grbStatis.TabIndex = 1;
            this.grbStatis.TabStop = false;
            this.grbStatis.Text = "Thông tin thông kê";
            // 
            // txtStaticBrand
            // 
            this.txtStaticBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStaticBrand.Location = new System.Drawing.Point(817, 454);
            this.txtStaticBrand.Name = "txtStaticBrand";
            this.txtStaticBrand.ReadOnly = true;
            this.txtStaticBrand.Size = new System.Drawing.Size(79, 27);
            this.txtStaticBrand.TabIndex = 4;
            this.txtStaticBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStaticBrand.Visible = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(576, 457);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 20);
            this.lblBrand.TabIndex = 3;
            // 
            // txtTotalStatis
            // 
            this.txtTotalStatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalStatis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalStatis.Location = new System.Drawing.Point(250, 454);
            this.txtTotalStatis.Multiline = true;
            this.txtTotalStatis.Name = "txtTotalStatis";
            this.txtTotalStatis.ReadOnly = true;
            this.txtTotalStatis.Size = new System.Drawing.Size(228, 27);
            this.txtTotalStatis.TabIndex = 2;
            this.txtTotalStatis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStatisTotal
            // 
            this.lblStatisTotal.AutoSize = true;
            this.lblStatisTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatisTotal.Location = new System.Drawing.Point(19, 457);
            this.lblStatisTotal.Name = "lblStatisTotal";
            this.lblStatisTotal.Size = new System.Drawing.Size(172, 20);
            this.lblStatisTotal.TabIndex = 1;
            this.lblStatisTotal.Text = "Tổng doanh thu(VND)";
            // 
            // dgtStatis
            // 
            this.dgtStatis.AllowUserToAddRows = false;
            this.dgtStatis.AllowUserToDeleteRows = false;
            this.dgtStatis.BackgroundColor = System.Drawing.Color.White;
            this.dgtStatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtStatis.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgtStatis.Location = new System.Drawing.Point(19, 35);
            this.dgtStatis.MultiSelect = false;
            this.dgtStatis.Name = "dgtStatis";
            this.dgtStatis.ReadOnly = true;
            this.dgtStatis.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgtStatis.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtStatis.RowTemplate.Height = 24;
            this.dgtStatis.Size = new System.Drawing.Size(1182, 394);
            this.dgtStatis.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1149, 736);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 42);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1310, 789);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng máy tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtProduct)).EndInit();
            this.grbProduct.ResumeLayout(false);
            this.grbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtProduct2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtBill)).EndInit();
            this.grbBill.ResumeLayout(false);
            this.grbBill.PerformLayout();
            this.tabStat.ResumeLayout(false);
            this.tabStat.PerformLayout();
            this.grbStatis.ResumeLayout(false);
            this.grbStatis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtStatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.TextBox txtCodePro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgtProduct;
        private System.Windows.Forms.GroupBox grbProduct;
        private System.Windows.Forms.NumericUpDown nudSale;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgtProduct2;
        private System.Windows.Forms.GroupBox grbBill;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgtBill;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelOne;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbStatis;
        private System.Windows.Forms.DateTimePicker dtpStatis;
        private System.Windows.Forms.Button btnStatisBrand;
        private System.Windows.Forms.Button btnStatis;
        private System.Windows.Forms.GroupBox grbStatis;
        private System.Windows.Forms.DataGridView dgtStatis;
        private System.Windows.Forms.TextBox txtTotalStatis;
        private System.Windows.Forms.Label lblStatisTotal;
        private System.Windows.Forms.Button btnStatisDate;
        private System.Windows.Forms.TextBox txtStaticBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbStatisCode;
        private System.Windows.Forms.Button btnStatisCode;
        private System.Windows.Forms.Button btnStatisPro;
    }
}

