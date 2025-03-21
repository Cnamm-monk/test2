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
            btnHienThi = new Button();
            dataGridView1 = new DataGridView();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
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
            tabPage2.Controls.Add(btnHienThi);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
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
            // btnHienThi
            // 
            btnHienThi.Location = new Point(493, 172);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 18;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += button1_Click_1;
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
            // textBox6
            // 
            textBox6.Location = new Point(844, 109);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(158, 27);
            textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(560, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(560, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(186, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 8;
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
            groupBox1.Location = new Point(-4, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1092, 481);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quản lí trả sách";
            tabPage4.UseVisualStyleBackColor = true;
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
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TabPage tabPage4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lblChaoMung;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnHienThi;
    }
}