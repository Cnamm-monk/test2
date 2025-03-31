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
namespace QuanLiMuonTra
{
    public partial class frmHeThong : Form
    {
        string str = @"Data Source=NEMMM\SQLEXPRESS;Initial Catalog=QLSach;Integrated Security=True;Encrypt=False";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from QLDocGia";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        void loaddata1()
        {
            //command = connection.CreateCommand();
            command.CommandText = "select * from QLMuon";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView2.DataSource = table1;
        }
        void loaddata2()
        {
            //command = connection.CreateCommand();
            command.CommandText = "select * from QLTra";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dataGridView3.DataSource = table2;
        }

        public frmHeThong()
        {
            InitializeComponent();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            // TODO: Xử lý khi click vào tabPage2 (nếu cần)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // TODO: Xử lý khi click vào label1 (nếu cần)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // TODO: Xử lý khi click vào label2 (nếu cần)
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loaddata1();
            loaddata2();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtManageMDG.Text = "";
            txtManageName.Text = "";
            cBSex.Text = "";
            dtpBirth.Text = "1/1/1990";
            txtManageAddress.Text = "";
            txtManageSDT.Text = "";
            textBox5.Text = "";
        }

        private void btnBorrowShow_Click(object sender, EventArgs e)
        {
      

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGiveShow_Click(object sender, EventArgs e)
        {

        }

        private void txtManageMDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update QLDocGia set HoVaTen = N'" + txtManageName.Text + "',GioiTinh = N'" + cBSex.Text + "',NgaySinh = '" + dtpBirth.Text + "',DiaChi = N'" + txtManageAddress.Text + "',SoDienThoai = '" + txtManageSDT.Text + "',CCCD = '" + textBox5.Text + "' where MaDocGia = '" + txtManageMDG.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into QLDocGia values('" + txtManageMDG.Text + "',N'" + txtManageName.Text + "',N'" + cBSex.Text + "','" + dtpBirth.Text + "',N'" + txtManageAddress.Text + "','" + txtManageSDT.Text + "','" + textBox5.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtManageMDG.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtManageName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cBSex.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtpBirth.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtManageAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtManageSDT.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from QLDocGia where MaDocGia = '" + txtManageMDG.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtManageSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchQuery = "SELECT * FROM QLDocGia WHERE MaDocGia = @MaDocGia";
            DataTable searchTable = new DataTable();

            using (SqlCommand searchCommand = new SqlCommand(searchQuery, connection))
            {
                searchCommand.Parameters.AddWithValue("@MaDocGia", txtManageSearch.Text);
                SqlDataAdapter searchAdapter = new SqlDataAdapter(searchCommand);
                searchAdapter.Fill(searchTable);
            }

            if (searchTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = searchTable;
            }
            else
            {
                MessageBox.Show("Không tìm thấy độc giả với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
