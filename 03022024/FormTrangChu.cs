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

            if (pnlPhai.Controls.Contains(ucQLTK) == false)
            {
                ucQLTK = new ucTaiKhoan();
                ucQLTK.Dock = DockStyle.Fill;
                pnlPhai.Controls.Add(ucQLTK);
                ucQLTK.BringToFront();
                pnlPhai.Controls.Remove(ucQLBH);
                pnlPhai.Controls.Remove(ucQLDM);
                pnlPhai.Controls.Remove(ucQLSP);
                pnlPhai.Controls.Remove(ucQLHD);
                pnlPhai.Controls.Remove(ucQLKH);
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

            if (pnlPhai.Controls.Contains(ucQLKH) == false)
            {
                ucQLKH = new ucKhachHang();
                ucQLKH.Dock = DockStyle.Fill;
                pnlPhai.Controls.Add(ucQLKH);
                ucQLKH.BringToFront();
                pnlPhai.Controls.Remove(ucQLBH);
                pnlPhai.Controls.Remove(ucQLDM);
                pnlPhai.Controls.Remove(ucQLSP);
                pnlPhai.Controls.Remove(ucQLHD);
                pnlPhai.Controls.Remove(ucQLTK);
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

            if (pnlPhai.Controls.Contains(ucQLSP) == false)
            {
                ucQLSP = new ucSanPham();
                ucQLSP.Dock = DockStyle.Fill;
                pnlPhai.Controls.Add(ucQLSP);
                ucQLSP.BringToFront(); 
                pnlPhai.Controls.Remove(ucQLBH);
                pnlPhai.Controls.Remove(ucQLDM);
                pnlPhai.Controls.Remove(ucQLTK);
                pnlPhai.Controls.Remove(ucQLHD);
                pnlPhai.Controls.Remove(ucQLKH);
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

            if (pnlPhai.Controls.Contains(ucQLDM) == false)
            {
                ucQLDM = new ucDanhMuc();
                ucQLDM.Dock = DockStyle.Fill;
                pnlPhai.Controls.Add(ucQLDM);
                ucQLDM.BringToFront();
                pnlPhai.Controls.Remove(ucQLBH);
                pnlPhai.Controls.Remove(ucQLTK);
                pnlPhai.Controls.Remove(ucQLSP);
                pnlPhai.Controls.Remove(ucQLHD);
                pnlPhai.Controls.Remove(ucQLKH);
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

            if (pnlPhai.Controls.Contains(ucQLBH) == false)
            {
                ucQLBH = new ucBanHang();
                ucQLBH.Dock = DockStyle.Fill;
                pnlPhai.Controls.Add(ucQLBH);
                pnlPhai.Controls.Remove(ucQLTK);
                pnlPhai.Controls.Remove(ucQLDM);
                pnlPhai.Controls.Remove(ucQLSP);
                pnlPhai.Controls.Remove(ucQLHD);
                pnlPhai.Controls.Remove(ucQLKH);
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

            if (pnlPhai.Controls.Contains(ucQLHD) == false)
            {
                ucQLHD = new ucHoaDon();
                ucQLHD.Dock = DockStyle.Fill;
                pnlPhai.Controls.Add(ucQLHD);
                ucQLHD.BringToFront();
                pnlPhai.Controls.Remove(ucQLBH);
                pnlPhai.Controls.Remove(ucQLDM);
                pnlPhai.Controls.Remove(ucQLSP);
                pnlPhai.Controls.Remove(ucQLTK);
                pnlPhai.Controls.Remove(ucQLKH);
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

            if (pnlPhai.Controls.Contains(ucQLTK))
            {
                pnlPhai.Controls.Remove(ucQLTK);
            }

            if (pnlPhai.Controls.Contains(ucQLKH))
            {
                pnlPhai.Controls.Remove(ucQLKH);
            }

            if (pnlPhai.Controls.Contains(ucQLSP))
            {
                pnlPhai.Controls.Remove(ucQLSP);
            }
            if (pnlPhai.Controls.Contains(ucQLDM))
            {
                pnlPhai.Controls.Remove(ucQLDM);
            }
            if (pnlPhai.Controls.Contains(ucQLBH))
            {
                pnlPhai.Controls.Remove(ucQLBH);
            }
            if (pnlPhai.Controls.Contains(ucQLHD))
            {
                pnlPhai.Controls.Remove(ucQLHD);
            }
        }             
    }
}
