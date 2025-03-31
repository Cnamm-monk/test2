using QuanLiMuonTra;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        string name = "admin";
        string password = "admin";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTenDangNhap.Text != name)
                errorProvider1.SetError(txtTenDangNhap, "Ten dang nhap khong chinh xac");
            if (txtMatKhau.Text != password)
                errorProvider1.SetError(txtMatKhau, "Mat khau khong chinh xac!");
            if(txtMatKhau.Text==password && txtTenDangNhap.Text == name)
            {
                txtMatKhau.Text = txtTenDangNhap.Text = "";
                Form form = new frmHeThong();
                form.Show();
               
            }
        }
    }
}
