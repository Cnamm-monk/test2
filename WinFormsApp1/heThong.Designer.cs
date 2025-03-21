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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            tabPage4 = new TabPage();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtBorrowMDG = new TextBox();
            txtBorrowMS = new TextBox();
            txtBorrowNameS = new TextBox();
            dtpDateBorrow = new DateTimePicker();
            btnBorrowAdd = new Button();
            bnBorrowFix = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            comboBox2 = new ComboBox();
            label13 = new Label();
            txtSearch = new TextBox();
            txtGiveMDG = new TextBox();
            txtGiveMS = new TextBox();
            label14 = new Label();
            label15 = new Label();
            btnGiveExit = new Button();
            btnGiveShow = new Button();
            btnGiveSearch = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
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
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            tabPage2.Controls.Add(label8);
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
            // btnShow
            // 
            btnShow.Location = new Point(493, 172);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 18;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1100, 243);
            dataGridView1.TabIndex = 17;
            // 
            // txtManageSearch
            // 
            txtManageSearch.Location = new Point(844, 109);
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
            dtpBirth.Location = new Point(186, 171);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(250, 27);
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
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(844, 67);
            label8.Name = "label8";
            label8.Size = new Size(158, 20);
            label8.TabIndex = 7;
            label8.Text = "Tìm kiếm mã độc giả:";
            label8.Click += label8_Click;
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
            tabPage3.Controls.Add(groupBox1);
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
            groupBox2.Location = new Point(-4, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1100, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(bnBorrowFix);
            groupBox1.Controls.Add(btnBorrowAdd);
            groupBox1.Controls.Add(dtpDateBorrow);
            groupBox1.Controls.Add(txtBorrowNameS);
            groupBox1.Controls.Add(txtBorrowMS);
            groupBox1.Controls.Add(txtBorrowMDG);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(-4, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            // txtBorrowMDG
            // 
            txtBorrowMDG.Location = new Point(187, 28);
            txtBorrowMDG.Name = "txtBorrowMDG";
            txtBorrowMDG.Size = new Size(125, 27);
            txtBorrowMDG.TabIndex = 4;
            // 
            // txtBorrowMS
            // 
            txtBorrowMS.Location = new Point(187, 78);
            txtBorrowMS.Name = "txtBorrowMS";
            txtBorrowMS.Size = new Size(125, 27);
            txtBorrowMS.TabIndex = 5;
            // 
            // txtBorrowNameS
            // 
            txtBorrowNameS.Location = new Point(187, 132);
            txtBorrowNameS.Name = "txtBorrowNameS";
            txtBorrowNameS.Size = new Size(125, 27);
            txtBorrowNameS.TabIndex = 6;
            // 
            // dtpDateBorrow
            // 
            dtpDateBorrow.Location = new Point(514, 29);
            dtpDateBorrow.Name = "dtpDateBorrow";
            dtpDateBorrow.Size = new Size(250, 27);
            dtpDateBorrow.TabIndex = 7;
            // 
            // btnBorrowAdd
            // 
            btnBorrowAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnBorrowAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBorrowAdd.Location = new Point(438, 112);
            btnBorrowAdd.Name = "btnBorrowAdd";
            btnBorrowAdd.Size = new Size(94, 52);
            btnBorrowAdd.TabIndex = 8;
            btnBorrowAdd.Text = "Thêm";
            btnBorrowAdd.UseVisualStyleBackColor = false;
            // 
            // bnBorrowFix
            // 
            bnBorrowFix.BackColor = Color.FromArgb(255, 224, 192);
            bnBorrowFix.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bnBorrowFix.Location = new Point(637, 112);
            bnBorrowFix.Name = "bnBorrowFix";
            bnBorrowFix.Size = new Size(94, 52);
            bnBorrowFix.TabIndex = 9;
            bnBorrowFix.Text = "Sửa";
            bnBorrowFix.UseVisualStyleBackColor = false;
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
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1086, 288);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(224, 224, 224);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(3, 297);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1086, 181);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mã Độc Giả", "Mã Sách" });
            comboBox2.Location = new Point(468, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 0;
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
            // txtSearch
            // 
            txtSearch.Location = new Point(486, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 2;
            // 
            // txtGiveMDG
            // 
            txtGiveMDG.Location = new Point(23, 228);
            txtGiveMDG.Name = "txtGiveMDG";
            txtGiveMDG.Size = new Size(125, 27);
            txtGiveMDG.TabIndex = 3;
            // 
            // txtGiveMS
            // 
            txtGiveMS.Location = new Point(203, 228);
            txtGiveMS.Name = "txtGiveMS";
            txtGiveMS.Size = new Size(125, 27);
            txtGiveMS.TabIndex = 4;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label14.Location = new Point(23, 198);
            label14.Name = "label14";
            label14.Size = new Size(125, 27);
            label14.TabIndex = 5;
            label14.Text = "Mã Độc Giả";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label15.Location = new Point(203, 198);
            label15.Name = "label15";
            label15.Size = new Size(125, 27);
            label15.TabIndex = 6;
            label15.Text = "Mã Sách";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGiveExit
            // 
            btnGiveExit.Location = new Point(373, 214);
            btnGiveExit.Name = "btnGiveExit";
            btnGiveExit.Size = new Size(94, 43);
            btnGiveExit.TabIndex = 7;
            btnGiveExit.Text = "Xoá";
            btnGiveExit.UseVisualStyleBackColor = true;
            // 
            // btnGiveShow
            // 
            btnGiveShow.Location = new Point(486, 212);
            btnGiveShow.Name = "btnGiveShow";
            btnGiveShow.Size = new Size(94, 43);
            btnGiveShow.TabIndex = 8;
            btnGiveShow.Text = "Hiển Thị";
            btnGiveShow.UseVisualStyleBackColor = true;
            // 
            // btnGiveSearch
            // 
            btnGiveSearch.Location = new Point(503, 129);
            btnGiveSearch.Name = "btnGiveSearch";
            btnGiveSearch.Size = new Size(94, 43);
            btnGiveSearch.TabIndex = 9;
            btnGiveSearch.Text = "Tìm Kiếm";
            btnGiveSearch.UseVisualStyleBackColor = true;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
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
        private Label label8;
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
        private GroupBox groupBox1;
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
    }
}