using System;
using System.Windows.Forms;

namespace PTTK_HT
{
    public partial class F_QuanLyCuaHangSach : Form
    {
        public F_QuanLyCuaHangSach()
        {

            InitializeComponent();
        }


        public void ShowPanel(Panel panelToShow)
        {
            panelToShow.Visible = true;
            gbCapNhat.Visible = false;
        }

        public void HidePanel(Panel panelToHide)
        {
            panelToHide.Visible = false;
            gbCapNhat.Visible=true;
        }

        private void F_QuanLyCuaHangSach_Load(object sender, EventArgs e)
        {
        }
        //Cập nhật sách
        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_CapNhatSach);
        }

        private void btnThoat_CNSACH_Click(object sender, EventArgs e)
        {
            HidePanel(panel_CapNhatSach);
        }
        //Cập nhật KH
        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_CapNhatKhachHang);
        }

        private void btnThoat_CNKH_Click(object sender, EventArgs e)
        {
            HidePanel(panel_CapNhatKhachHang);
        }
        //Cập nhật NV
        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_CapNhatNV);
        }
        private void btnThoat_CNNV_Click(object sender, EventArgs e)
        {
            HidePanel(panel_CapNhatNV);
        }

        //Cập nhật hóa đơn
        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_CapNhatHD);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            HidePanel(panel_CapNhatHD);
        }

        //Cập nhật đơn hàng
        private void btnCapNhatDonHang_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_CapNhatDonHang);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            HidePanel(panel_CapNhatDonHang);
        }
    }
}
