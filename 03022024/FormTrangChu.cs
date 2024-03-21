using _03022024.QLBanHang;
using _03022024.QLDanhMuc;
using _03022024.QLKhachHang;
using _03022024.QLHoaDon;
using _03022024.QLSanPham;
using _03022024.QLTaiKhoan;
using System.Windows.Forms;
using BLL;
using System;

namespace _03022024
{
    public partial class FormTrangChu : Form
    {
        private string roleName;

        public FormTrangChu(string roleName)
        {
            InitializeComponent();
            this.Text = "Trang chủ";
            this.roleName = roleName;
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            if(roleName != "Admin")
            {
                btnTaiKhoan.Visible = false;
                ptbTaiKhoan.Visible = false;
            }
        }       
        private void FormDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private ucTaiKhoan ucQLTK;
        private void QLTaiKhoan()
        {
            this.Text = "Tài khoản";

            if (panelRight.Controls.Contains(ucQLTK) == false)
            {
                ucQLTK = new ucTaiKhoan();
                ucQLTK.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ucQLTK);
                ucQLTK.BringToFront();
            }
            else
            {
                ucQLTK.BringToFront();
            }
        }
        
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            QLTaiKhoan();
        }
        private void ptbTaiKhoan_Click(object sender, EventArgs e)
        {
            QLTaiKhoan();
        }

        private ucKhachHang ucQLKH;
        private void QLKhachHang()
        {
            this.Text = "Khách hàng";

            if (panelRight.Controls.Contains(ucQLKH) == false)
            {
                ucQLKH = new ucKhachHang();
                ucQLKH.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ucQLKH);
                ucQLKH.BringToFront();
            }
            else
            {
                ucQLKH.BringToFront();
            }
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            QLKhachHang();
        }
        private void ptbKhachHang_Click(object sender, EventArgs e)
        {
            QLKhachHang();
        }

        private ucSanPham ucQLSP;
        private void QLSanPham()
        {
            this.Text = "Sản phẩm";

            if (panelRight.Controls.Contains(ucQLSP) == false)
            {
                ucQLSP = new ucSanPham();
                ucQLSP.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ucQLSP);
                ucQLSP.BringToFront();
            }
            else
            {
                ucQLSP.BringToFront();
            }
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            QLSanPham();
        }
        private void ptbSanPham_Click(object sender, EventArgs e)
        {
            QLSanPham();
        }

        private ucDanhMuc ucQLDM;
        private void QLDanhMuc()
        {
            this.Text = "Danh mục";

            if (panelRight.Controls.Contains(ucQLDM) == false)
            {
                ucQLDM = new ucDanhMuc();
                ucQLDM.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ucQLDM);
                ucQLDM.BringToFront();
            }
            else
            {
                ucQLDM.BringToFront();
            }
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            QLDanhMuc();
        }
        private void ptbDanhMuc_Click(object sender, EventArgs e)
        {
            QLDanhMuc();
        }

        private ucBanHang ucQLBH;
        private void QLBanHang()
        {
            this.Text = "Bán hàng";

            if (panelRight.Controls.Contains(ucQLBH) == false)
            {
                ucQLBH = new ucBanHang();
                ucQLBH.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ucQLBH);
                ucQLBH.BringToFront();
            }
            else
            {
                ucQLBH.BringToFront();
            }
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            QLBanHang();
        }
        private void ptbBanHang_Click(object sender, EventArgs e)
        {
            QLBanHang();
        }
        private ucHoaDon ucQLHD;
        private void QLHoaDon()
        {
            this.Text = "Hóa đơn";

            if (panelRight.Controls.Contains(ucQLHD) == false)
            {
                ucQLHD = new ucHoaDon();
                ucQLHD.Dock = DockStyle.Fill;
                panelRight.Controls.Add(ucQLHD);
                ucQLHD.BringToFront();
            }
            else
            {
                ucQLHD.BringToFront();
            }
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDon();
        }
        private void ptbHoaDon_Click(object sender, EventArgs e)
        {
            QLHoaDon();
        }
        private void DoiMatKhau()
        {
            FormDoiMatKhau formChangePassword = new FormDoiMatKhau();
            formChangePassword.Show();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }

        private void ptbDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }
        private void DangXuat()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                FormDangNhap loginForm = new FormDangNhap();
                this.Hide();
                loginForm.Show();
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }
        private void ptbDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }
        private void ptbTrangChu_Click(object sender, EventArgs e)
        {
            this.Text = "Trang chủ";

            if (panelRight.Controls.Contains(ucQLTK))
            {
                panelRight.Controls.Remove(ucQLTK);
            }

            if (panelRight.Controls.Contains(ucQLKH))
            {
                panelRight.Controls.Remove(ucQLKH);
            }

            if (panelRight.Controls.Contains(ucQLSP))
            {
                panelRight.Controls.Remove(ucQLSP);
            }
            if (panelRight.Controls.Contains(ucQLDM))
            {
                panelRight.Controls.Remove(ucQLDM);
            }
            if (panelRight.Controls.Contains(ucQLBH))
            {
                panelRight.Controls.Remove(ucQLBH);
            }
            if (panelRight.Controls.Contains(ucQLHD))
            {
                panelRight.Controls.Remove(ucQLHD);
            }
        }             
    }
}
