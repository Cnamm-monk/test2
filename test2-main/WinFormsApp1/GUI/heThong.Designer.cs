namespace QuanLiMuonTra
{
    partial class frmHeThong
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblChaoMung = new Label();
            btnThoat = new Button();
            btnDangXuat = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            btnSearch1 = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            txtManageSearch = new TextBox();
            textBox5 = new TextBox();
            txtManageSDT = new TextBox();
            txtManageAddress = new TextBox();
            cBSex = new ComboBox();
            dtpBirth = new DateTimePicker();
            txtManageName = new TextBox();
            txtManageMDG = new TextBox();
            lblTimKiem = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            grbDocGia = new GroupBox();
            bnBorrowFix = new Button();
            btnBorrowAdd = new Button();
            dtpDateBorrow = new DateTimePicker();
            txtBorrowNameS = new TextBox();
            txtBorrowMS = new TextBox();
            txtBorrowMDG = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            groupBox4 = new GroupBox();
            dataGridView3 = new DataGridView();
            groupBox3 = new GroupBox();
            btnGiveSearch = new Button();
            btnGiveShow = new Button();
            btnGiveExit = new Button();
            label15 = new Label();
            label14 = new Label();
            txtGiveMS = new TextBox();
            txtGiveMDG = new TextBox();
            txtSearch = new TextBox();
            label13 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            grbDocGia.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1100, 514);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged_1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblChaoMung);
            tabPage1.Controls.Add(btnThoat);
            tabPage1.Controls.Add(btnDangXuat);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1092, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hệ thống";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblChaoMung
            // 
            lblChaoMung.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChaoMung.ForeColor = SystemColors.ActiveCaptionText;
            lblChaoMung.Location = new Point(340, 53);
            lblChaoMung.Name = "lblChaoMung";
            lblChaoMung.RightToLeft = RightToLeft.No;
            lblChaoMung.Size = new Size(410, 58);
            lblChaoMung.TabIndex = 3;
            lblChaoMung.Text = "Phần mềm quản lý mượn trả sách";
            lblChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(736, 293);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 56);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnDangXuat.Location = new Point(282, 293);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(94, 56);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.pexels_pixabay_159711;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1086, 475);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 224, 192);
            tabPage2.Controls.Add(btnSearch1);
            tabPage2.Controls.Add(btnXoa);
            tabPage2.Controls.Add(btnSua);
            tabPage2.Controls.Add(btnThem);
            tabPage2.Controls.Add(btnShow);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(txtManageSearch);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(txtManageSDT);
            tabPage2.Controls.Add(txtManageAddress);
            tabPage2.Controls.Add(cBSex);
            tabPage2.Controls.Add(dtpBirth);
            tabPage2.Controls.Add(txtManageName);
            tabPage2.Controls.Add(txtManageMDG);
            tabPage2.Controls.Add(lblTimKiem);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1092, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lí độc giả";
            tabPage2.Click += tabPage2_Click;
            // 
            // btnSearch1
            // 
            btnSearch1.Location = new Point(874, 107);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(94, 29);
            btnSearch1.TabIndex = 22;
            btnSearch1.Text = "Tìm kiếm";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += button1_Click_2;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(831, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(685, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(537, 171);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(391, 172);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 18;
            btnShow.Text = "Khởi tạo";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 207);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1100, 271);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // txtManageSearch
            // 
            txtManageSearch.Location = new Point(844, 64);
            txtManageSearch.Name = "txtManageSearch";
            txtManageSearch.Size = new Size(158, 27);
            txtManageSearch.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(560, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 27);
            textBox5.TabIndex = 15;
            // 
            // txtManageSDT
            // 
            txtManageSDT.Location = new Point(560, 64);
            txtManageSDT.Name = "txtManageSDT";
            txtManageSDT.Size = new Size(151, 27);
            txtManageSDT.TabIndex = 14;
            // 
            // txtManageAddress
            // 
            txtManageAddress.Location = new Point(560, 19);
            txtManageAddress.Name = "txtManageAddress";
            txtManageAddress.Size = new Size(151, 27);
            txtManageAddress.TabIndex = 13;
            // 
            // cBSex
            // 
            cBSex.FormattingEnabled = true;
            cBSex.Items.AddRange(new object[] { "Nam", "Nữ" });
            cBSex.Location = new Point(186, 116);
            cBSex.Name = "cBSex";
            cBSex.Size = new Size(151, 28);
            cBSex.TabIndex = 12;
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(186, 171);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(131, 27);
            dtpBirth.TabIndex = 11;
            // 
            // txtManageName
            // 
            txtManageName.Location = new Point(186, 64);
            txtManageName.Name = "txtManageName";
            txtManageName.Size = new Size(151, 27);
            txtManageName.TabIndex = 9;
            // 
            // txtManageMDG
            // 
            txtManageMDG.Location = new Point(186, 19);
            txtManageMDG.Name = "txtManageMDG";
            txtManageMDG.Size = new Size(151, 27);
            txtManageMDG.TabIndex = 8;
            txtManageMDG.TextChanged += txtManageMDG_TextChanged;
            // 
            // lblTimKiem
            // 
            lblTimKiem.BackColor = Color.FromArgb(192, 255, 192);
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimKiem.Location = new Point(844, 22);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(158, 20);
            lblTimKiem.TabIndex = 7;
            lblTimKiem.Text = "Tìm kiếm mã độc giả:";
            lblTimKiem.Click += label8_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(434, 116);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 6;
            label7.Text = "CCCD:";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(192, 255, 192);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(434, 64);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 255, 192);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(434, 19);
            label5.Name = "label5";
            label5.Size = new Size(60, 27);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(44, 171);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh: ";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(44, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(44, 64);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(44, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 27);
            label1.TabIndex = 0;
            label1.Text = "Mã độc giả:";
            label1.Click += label1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(grbDocGia);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1092, 481);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quản lí mượn sách";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(-4, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1100, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1100, 234);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // grbDocGia
            // 
            grbDocGia.BackColor = Color.FromArgb(192, 255, 192);
            grbDocGia.Controls.Add(bnBorrowFix);
            grbDocGia.Controls.Add(button1);
            grbDocGia.Controls.Add(btnBorrowAdd);
            grbDocGia.Controls.Add(dtpDateBorrow);
            grbDocGia.Controls.Add(txtBorrowNameS);
            grbDocGia.Controls.Add(txtBorrowMS);
            grbDocGia.Controls.Add(txtBorrowMDG);
            grbDocGia.Controls.Add(label12);
            grbDocGia.Controls.Add(label11);
            grbDocGia.Controls.Add(label10);
            grbDocGia.Controls.Add(label9);
            grbDocGia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDocGia.Location = new Point(-4, 0);
            grbDocGia.Name = "grbDocGia";
            grbDocGia.Size = new Size(1100, 251);
            grbDocGia.TabIndex = 0;
            grbDocGia.TabStop = false;
            grbDocGia.Text = "Quản lý mượn sách";
            // 
            // bnBorrowFix
            // 
            bnBorrowFix.BackColor = Color.FromArgb(255, 224, 192);
            bnBorrowFix.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bnBorrowFix.Location = new Point(578, 139);
            bnBorrowFix.Name = "bnBorrowFix";
            bnBorrowFix.Size = new Size(94, 52);
            bnBorrowFix.TabIndex = 9;
            bnBorrowFix.Text = "Sửa";
            bnBorrowFix.UseVisualStyleBackColor = false;
            // 
            // btnBorrowAdd
            // 
            btnBorrowAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnBorrowAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBorrowAdd.Location = new Point(430, 139);
            btnBorrowAdd.Name = "btnBorrowAdd";
            btnBorrowAdd.Size = new Size(94, 52);
            btnBorrowAdd.TabIndex = 8;
            btnBorrowAdd.Text = "Thêm";
            btnBorrowAdd.UseVisualStyleBackColor = false;
            // 
            // dtpDateBorrow
            // 
            dtpDateBorrow.Format = DateTimePickerFormat.Custom;
            dtpDateBorrow.Location = new Point(514, 29);
            dtpDateBorrow.Name = "dtpDateBorrow";
            dtpDateBorrow.RightToLeft = RightToLeft.Yes;
            dtpDateBorrow.Size = new Size(158, 30);
            dtpDateBorrow.TabIndex = 7;
            dtpDateBorrow.Value = new DateTime(2025, 3, 27, 21, 17, 19, 0);
            // 
            // txtBorrowNameS
            // 
            txtBorrowNameS.Location = new Point(187, 132);
            txtBorrowNameS.Name = "txtBorrowNameS";
            txtBorrowNameS.Size = new Size(125, 30);
            txtBorrowNameS.TabIndex = 6;
            // 
            // txtBorrowMS
            // 
            txtBorrowMS.Location = new Point(187, 78);
            txtBorrowMS.Name = "txtBorrowMS";
            txtBorrowMS.Size = new Size(125, 30);
            txtBorrowMS.TabIndex = 5;
            // 
            // txtBorrowMDG
            // 
            txtBorrowMDG.Location = new Point(187, 28);
            txtBorrowMDG.Name = "txtBorrowMDG";
            txtBorrowMDG.Size = new Size(125, 30);
            txtBorrowMDG.TabIndex = 4;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(255, 255, 128);
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label12.Location = new Point(337, 31);
            label12.Name = "label12";
            label12.Size = new Size(124, 25);
            label12.TabIndex = 3;
            label12.Text = "Ngày Mượn";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(255, 255, 128);
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.Location = new Point(23, 139);
            label11.Name = "label11";
            label11.Size = new Size(114, 25);
            label11.TabIndex = 2;
            label11.Text = "Tên Sách";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(255, 255, 128);
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Location = new Point(23, 85);
            label10.Name = "label10";
            label10.Size = new Size(114, 25);
            label10.TabIndex = 1;
            label10.Text = "Mã Sách";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 255, 128);
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Location = new Point(23, 31);
            label9.Name = "label9";
            label9.Size = new Size(114, 25);
            label9.TabIndex = 0;
            label9.Text = "Mã Độc Giả";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox4);
            tabPage4.Controls.Add(groupBox3);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1092, 481);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quản lí trả sách";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(224, 224, 224);
            groupBox4.Controls.Add(dataGridView3);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(3, 266);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1086, 212);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(-3, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1096, 219);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 255, 192);
            groupBox3.Controls.Add(btnGiveSearch);
            groupBox3.Controls.Add(btnGiveShow);
            groupBox3.Controls.Add(btnGiveExit);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtGiveMS);
            groupBox3.Controls.Add(txtGiveMDG);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1086, 270);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quản lý trả sách";
            // 
            // btnGiveSearch
            // 
            btnGiveSearch.Location = new Point(484, 147);
            btnGiveSearch.Name = "btnGiveSearch";
            btnGiveSearch.Size = new Size(125, 30);
            btnGiveSearch.TabIndex = 9;
            btnGiveSearch.Text = "Tìm Kiếm";
            btnGiveSearch.UseVisualStyleBackColor = true;
            // 
            // btnGiveShow
            // 
            btnGiveShow.Location = new Point(550, 204);
            btnGiveShow.Name = "btnGiveShow";
            btnGiveShow.Size = new Size(98, 43);
            btnGiveShow.TabIndex = 8;
            btnGiveShow.Text = "Hiển Thị";
            btnGiveShow.UseVisualStyleBackColor = true;
            btnGiveShow.Click += btnGiveShow_Click;
            // 
            // btnGiveExit
            // 
            btnGiveExit.Location = new Point(426, 204);
            btnGiveExit.Name = "btnGiveExit";
            btnGiveExit.Size = new Size(98, 43);
            btnGiveExit.TabIndex = 7;
            btnGiveExit.Text = "Xoá";
            btnGiveExit.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label15.Location = new Point(203, 163);
            label15.Name = "label15";
            label15.Size = new Size(125, 27);
            label15.TabIndex = 6;
            label15.Text = "Mã Sách";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label14.Location = new Point(23, 163);
            label14.Name = "label14";
            label14.Size = new Size(125, 27);
            label14.TabIndex = 5;
            label14.Text = "Mã Độc Giả";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGiveMS
            // 
            txtGiveMS.Location = new Point(203, 204);
            txtGiveMS.Name = "txtGiveMS";
            txtGiveMS.Size = new Size(125, 30);
            txtGiveMS.TabIndex = 4;
            // 
            // txtGiveMDG
            // 
            txtGiveMDG.Location = new Point(23, 204);
            txtGiveMDG.Name = "txtGiveMDG";
            txtGiveMDG.Size = new Size(125, 30);
            txtGiveMDG.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(468, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 30);
            txtSearch.TabIndex = 2;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label13.Location = new Point(469, 23);
            label13.Name = "label13";
            label13.Size = new Size(150, 27);
            label13.TabIndex = 1;
            label13.Text = "Tìm Kiếm Theo";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mã Độc Giả", "Mã Sách" });
            comboBox2.Location = new Point(468, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(745, 139);
            button1.Name = "button1";
            button1.Size = new Size(94, 52);
            button1.TabIndex = 8;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 514);
            Controls.Add(tabControl1);
            Name = "frmHeThong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý mượn trả sách";
            Load += frmHeThong_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            grbDocGia.ResumeLayout(false);
            grbDocGia.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnThoat;
        private Button btnDangXuat;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTimKiem;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtManageSDT;
        private TextBox txtManageAddress;
        private ComboBox cBSex;
        private DateTimePicker dtpBirth;
        private TextBox txtManageName;
        private TextBox txtManageMDG;
        private TextBox txtManageSearch;
        private TextBox textBox5;
        private TabPage tabPage4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lblChaoMung;
        private GroupBox groupBox2;
        private GroupBox grbDocGia;
        private Button btnShow;
        private Button bnBorrowFix;
        private Button btnBorrowAdd;
        private DateTimePicker dtpDateBorrow;
        private TextBox txtBorrowNameS;
        private TextBox txtBorrowMS;
        private TextBox txtBorrowMDG;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label13;
        private ComboBox comboBox2;
        private Button btnGiveSearch;
        private Button btnGiveShow;
        private Button btnGiveExit;
        private Label label15;
        private Label label14;
        private TextBox txtGiveMS;
        private TextBox txtGiveMDG;
        private TextBox txtSearch;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnSearch1;
        private Button button1;
    }
}