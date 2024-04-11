using System.Data.SqlClient;

namespace QLSACH
{
    public partial class F_Login : Form
    {
        private string connectionStr = @"Data Source=DESKTOP-NN2JUAV\SQLEXPRESS;Initial Catalog=QLSACH;Integrated Security=True";
        public F_Login()
        {
            InitializeComponent();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            tbPassWord_Login.UseSystemPasswordChar = true;
        }

        private void cbReveal_pass_CheckedChanged(object sender, EventArgs e)
        {
            tbPassWord_Login.UseSystemPasswordChar = !cbReveal_pass.Checked;
        }

        private void btnDangNhap_Login_Click(object sender, EventArgs e)
        {
            int c = 0;
            if(tbUserName_Login.Text.Trim().Length > 0 && tbPassWord_Login.Text.Trim().Length > 0) 
            {
                using(SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    string count = "SELECT COUNT(*) FROM NV WHERE UserName COLLATE SQL_Latin1_General_CP1_CS_AS = @UserName AND Pass_Word COLLATE SQL_Latin1_General_CP1_CS_AS = @Pass_Word";
                    using (SqlCommand cmd = new SqlCommand(count, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", tbUserName_Login.Text.Trim());
                        cmd.Parameters.AddWithValue("@Pass_Word", tbPassWord_Login.Text.Trim());
                        c = (int)cmd.ExecuteScalar();
                        if(c > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            QLSACH qLSACH = new QLSACH();
                            qLSACH.FormClosed += QLSACH_FormClosed;
                            qLSACH.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            tbUserName_Login.Focus();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUserName_Login.Focus();
            }

        }

        private void QLSACH_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tbUserName_Login.Clear();
            tbPassWord_Login.Clear();
            cbReveal_pass.Checked = false;
            Show();
        }

        private void btnThoat_Login_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
