using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace QLSACH
{
    public partial class QLSACH : Form
    {
        private int index = -1;
        private string connectionStr = @"Data Source=DESKTOP-NN2JUAV\SQLEXPRESS;Initial Catalog=QLSACH;Integrated Security=True";
        private DataTable dt;
        public QLSACH()
        {
            InitializeComponent();
        }

        private void QLSACH_Load(object sender, EventArgs e)
        {
            dgSach_CN.DataSource = Load_Sach();
        }
        private void tcCapNhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcCapNhat.SelectedIndex)
            {
                case 0: dgSach_CN.DataSource = Load_Sach(); break;
                case 1: dgKH_CN.DataSource = Load_KH(); break;
                case 2: dgNV_CN.DataSource = Load_NV(); break;
            }
        }
        //Cập nhât sách
        private void dgSach_CN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaSach_CN.Text = dt.Rows[index][0].ToString().Trim();
                tbTenSach_CN.Text = dt.Rows[index][1].ToString().Trim();
                tbTacGia_CN.Text = dt.Rows[index][2].ToString().Trim();
                tbNXB_CN.Text = dt.Rows[index][3].ToString().Trim();
                tbGia_CN.Text = dt.Rows[index][4].ToString().Trim();
                dtpNgayCN.Value = Convert.ToDateTime(dt.Rows[index][5]);
            }
        }
        private void Clear_Sach()
        {
            tbMaSach_CN.Clear();
            tbTenSach_CN.Clear();
            tbTacGia_CN.Clear();
            tbNXB_CN.Clear();
            tbGia_CN.Clear();
            dtpNgayCN.Value = DateTime.Today;
            tbMaSach_CN.Focus();
            index = -1;
        }
        private DataTable Load_Sach()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string fill = "SELECT MSACH AS N'Mã sách', TenSach AS N'Tên sách', TacGia AS N'Tác giả', NXB, Gia AS N'Giá',NgayCP AS N'Ngày cập nhật' FROM SACH";
                using (SqlDataAdapter da = new SqlDataAdapter(fill, conn))
                {
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }
            return dt;
        }
        private void btnThemSach_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaSach_CN.Text.Trim().Length > 0 && tbTenSach_CN.Text.Trim().Length > 0 && tbTacGia_CN.Text.Trim().Length > 0 && tbNXB_CN.Text.Trim().Length > 0
                     && double.Parse(tbGia_CN.Text.Trim()) > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionStr))
                    {
                        conn.Open();
                        string NgayCN = DateTime.Parse(dtpNgayCN.Text).ToString();
                        string insert = "INSERT INTO SACH (MSACH,TenSach,TacGia,NXB,Gia,NgayCP) VALUES(@MSACH,@TenSach,@TacGia,@NXB,@Gia,@NgayCP)";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@MSACH", tbMaSach_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@TenSach", tbTenSach_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@TacGia", tbTacGia_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@NXB", tbNXB_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gia", double.Parse(tbGia_CN.Text.Trim()));
                            cmd.Parameters.AddWithValue("@NgayCP", NgayCN);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm thành công");
                        Clear_Sach();
                        dgSach_CN.DataSource = Load_Sach();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin sách không hợp lệ! Hãy kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMaSach_CN.Focus();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Mã sách đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMaSach_CN.Focus();
                }
                else
                {
                    MessageBox.Show("Lỗi: ", ex.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGia_CN.Focus();
            }
        }

        private void btnXoaSach_CN_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string delete = "DELETE SACH WHERE MSACH = @MSACH";
                using (SqlCommand cmd = new SqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@MSACH", tbMaSach_CN.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Xóa thành công");
                Clear_Sach();
                dgSach_CN.DataSource = Load_Sach();
            }
        }

        private void btnSuaSach_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if (index >= 0)
                {
                    if (tbMaSach_CN.Text.Trim().Length > 0 && tbTenSach_CN.Text.Trim().Length > 0 && tbTacGia_CN.Text.Trim().Length > 0 && tbNXB_CN.Text.Trim().Length > 0
                        && double.Parse(tbGia_CN.Text.Trim()) > 0)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionStr))
                        {
                            conn.Open();
                            string NgayCN = DateTime.Today.ToString();
                            string update = "UPDATE SACH SET TenSach=@TenSach,TacGia=@TacGia,NXB=@NXB,Gia=@Gia,NgayCP=@NgayCP WHERE MSACH=@MSACH";
                            using (SqlCommand cmd = new SqlCommand(update, conn))
                            {
                                cmd.Parameters.AddWithValue("@MSACH", tbMaSach_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@TenSach", tbTenSach_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@TacGia", tbTacGia_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@NXB", tbNXB_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@Gia", tbGia_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@NgayCP", NgayCN);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Sửa thành công");
                            Clear_Sach();
                            dgSach_CN.DataSource = Load_Sach();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin sách không hợp lệ! Hãy kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbMaSach_CN.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một dòng để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Mã sách đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMaSach_CN.Focus();
                }
                else
                {
                    MessageBox.Show("Lỗi: ", ex.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGia_CN.Focus();
            }
        }

        private void btnResetSach_CN_Click(object sender, EventArgs e)
        {
            Clear_Sach();
        }
        //Cập nhật KH
        private void dgKH_CN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbHoTenKH_CN.Text = dt.Rows[index][0].ToString().Trim();
                tbDiaChiKH_CN.Text = dt.Rows[index][1].ToString().Trim();
                dtpNgaySinh_KH_CN.Value = Convert.ToDateTime(dt.Rows[index][2]);
                tbSDT_KH_CN.Text = dt.Rows[index][3].ToString().Trim();
            }
        }
        private DataTable Load_KH()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string fill = "SELECT HoTen AS N'Họ tên',DiaChi AS N'Địa chỉ',NgaySinh AS N'Ngày sinh', SDT AS N'Số điện thoại' FROM KH";
                using (SqlDataAdapter da = new SqlDataAdapter(fill, connectionStr))
                {
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }
            return dt;
        }
        private void Clear_KH()
        {
            tbHoTenKH_CN.Clear();
            tbDiaChiKH_CN.Clear();
            tbSDT_KH_CN.Clear();
            dtpNgaySinh_KH_CN.Value = DateTime.Today;
            tbHoTenKH_CN.Focus();
            index = -1;
        }

        private void btnThemKH_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbHoTenKH_CN.Text.Trim().Length > 0 && tbDiaChiKH_CN.Text.Trim().Length > 0 && tbSDT_KH_CN.Text.Trim().Length > 0 && (tbSDT_KH_CN.Text.Trim().Length > 0 && tbSDT_KH_CN.Text.Trim().Length <= 10))
                {
                    using (SqlConnection conn = new SqlConnection(connectionStr))
                    {
                        conn.Open();
                        string insert = "INSERT INTO KH (HoTen,DiaChi,NgaySinh,SDT) VALUES (@HoTen,@DiaChi,@NgaySinh,@SDT)";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@HoTen", tbHoTenKH_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChiKH_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh_KH_CN.Value);
                            cmd.Parameters.AddWithValue("@SDT", tbSDT_KH_CN.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm thành công!");
                    }
                    Clear_KH();
                    dgKH_CN.DataSource = Load_KH();
                }
                else
                {
                    if (tbSDT_KH_CN.Text.Trim().Length > 10 || tbSDT_KH_CN.Text.Trim().Length < 0)
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Thông tin khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: ", ex.ToString());
            }
        }

        private void btnXoaKH_CN_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    string delete = "DELETE KH WHERE SDT=@SDT";
                    using (SqlCommand cmd = new SqlCommand(delete, conn))
                    {
                        cmd.Parameters.AddWithValue("@SDT", tbSDT_KH_CN.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công!");
                }
                Clear_KH();
                dgKH_CN.DataSource = Load_KH();
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaKH_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if (index >= 0)
                {
                    if (tbHoTenKH_CN.Text.Trim().Length > 0 && tbDiaChiKH_CN.Text.Trim().Length > 0 && tbSDT_KH_CN.Text.Trim().Length > 0 && (tbSDT_KH_CN.Text.Trim().Length > 0 && tbSDT_KH_CN.Text.Trim().Length <= 10))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionStr))
                        {
                            conn.Open();
                            string update = "UPDATE KH SET HoTen=@HoTen,DiaChi=@DiaChi,NgaySinh=@NgaySinh,SDT=@SDT1 WHERE SDT=@SDT";
                            using (SqlCommand cmd = new SqlCommand(update, conn))
                            {
                                cmd.Parameters.AddWithValue("@HoTen", tbHoTenKH_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@DiaChi", tbDiaChiKH_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh_KH_CN.Value);
                                cmd.Parameters.AddWithValue("@SDT1", tbSDT_KH_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@SDT", dt.Rows[index][3].ToString());
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Sửa thành công!");
                        }
                        Clear_KH();
                        dgKH_CN.DataSource = Load_KH();
                    }
                    else
                    {
                        if (tbSDT_KH_CN.Text.Trim().Length > 10 || tbSDT_KH_CN.Text.Trim().Length < 0)
                            MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Thông tin khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một dòng để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: ", ex.ToString());
            }
        }

        private void btnResetKH_CN_Click(object sender, EventArgs e)
        {
            Clear_KH();
        }
        //Cập nhật NV
        private DataTable Load_NV()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string fill = "SELECT MaNV AS N'Mã nhân viên',UserName AS 'Username',Pass_Word AS 'Password' FROM NV";
                using (SqlDataAdapter da = new SqlDataAdapter(fill, conn))
                {
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }
            return dt;
        }
        private void Clear_NV()
        {
            tbMaNV_CN.Clear();
            tbUsername_CN.Clear();
            tbPassword_CN.Clear();
            tbMaNV_CN.Focus();
            index = -1;
        }
        private void dgNV_CN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaNV_CN.Text = dt.Rows[index][0].ToString().Trim();
                tbUsername_CN.Text = dt.Rows[index][1].ToString().Trim();
                tbPassword_CN.Text = dt.Rows[index][2].ToString().Trim();
            }
        }

        private void btnThemNV_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbMaNV_CN.Text.Trim().Length > 0 && tbUsername_CN.Text.Trim().Length > 0 && tbPassword_CN.Text.Trim().Length > 0)
                {
                    using(SqlConnection conn = new SqlConnection(connectionStr))
                    {
                        conn.Open();
                        string insert = "INSERT INTO NV (MaNV,UserName,Pass_Word) VALUES (@MaNV,@UserName,@Pass_Word)";
                        using(SqlCommand cmd = new SqlCommand(insert,conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", tbMaNV_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@UserName", tbUsername_CN.Text.Trim());
                            cmd.Parameters.AddWithValue("@Pass_Word", tbPassword_CN.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm thành công!");
                    }
                    Clear_NV();
                    dgNV_CN.DataSource = Load_NV();
                }
                else
                    MessageBox.Show("Thông tin không hợp lệ!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: ", ex.ToString());
            }
        }

        private void btnXoaNV_CN_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                using(SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    string delete = "DELETE NV WHERE MaNV=@MaNV";
                    using(SqlCommand cmd = new SqlCommand(delete,conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", tbMaNV_CN.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công!");
                }
                Clear_NV();
                dgNV_CN.DataSource = Load_NV();
            }
            else
                MessageBox.Show("Hãy chọn một dòng để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSuaNV_CN_Click(object sender, EventArgs e)
        {
            try
            {
                if(index >= 0)
                {
                    if (tbMaNV_CN.Text.Trim().Length > 0 && tbUsername_CN.Text.Trim().Length > 0 && tbPassword_CN.Text.Trim().Length > 0)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionStr))
                        {
                            conn.Open();
                            string update = "UPDATE NV SET UserName=@UserName,Pass_Word=@Pass_Word WHERE MaNV=@MaNV";
                            using (SqlCommand cmd = new SqlCommand(update, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaNV", tbMaNV_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@UserName", tbUsername_CN.Text.Trim());
                                cmd.Parameters.AddWithValue("@Pass_Word", tbPassword_CN.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Sửa thành công!");
                        }
                        Clear_NV();
                        dgNV_CN.DataSource = Load_NV();
                    }
                    else
                        MessageBox.Show("Thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Hãy chọn một dòng để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: ", ex.ToString());
            }
        }

        private void btnResetNV_CN_Click(object sender, EventArgs e)
        {
            Clear_NV();
        }
    }
}
