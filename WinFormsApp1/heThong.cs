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
        string connectstring = @"Data Source=NEMMM\SQLEXPRESS;Initial Catalog=QLThueTraSach;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
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
            con = new SqlConnection(connectstring);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from QLDocGia",con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource= dt;
                con.Close();
            }
            catch(Exception ex) { 
            MessageBox.Show(ex.Message);
            }
        }
    }
}
