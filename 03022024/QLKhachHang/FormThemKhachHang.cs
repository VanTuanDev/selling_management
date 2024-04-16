using System;
using System.Windows.Forms;
using _03022024.QLSanPham;
using BLL;
using DAL.Entity;

namespace _03022024
{
    public partial class FormThemKhachHang : Form
    {
        private KhachHangManager manager = null;
        KhachHangEntity khachHang = new KhachHangEntity();

        public FormThemKhachHang()
        {
            InitializeComponent();
            manager = new KhachHangManager();
        }
        private void txtMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void XacNhan()
        {
            khachHang.MaKhachHang = txtMaKhachHang.Text;
            khachHang.TenKhachHang = txtTenKhachHang.Text;

            if (!string.IsNullOrEmpty(txtMaKhachHang.Text) && !string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                string errorMessage;
                try
                {
                    manager.ThemKhachHang(khachHang, out errorMessage);
                    MessageBox.Show(errorMessage);
                    if (errorMessage.StartsWith("Khách hàng đã được thêm thành công"))
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            XacNhan();
        }

        private void ptbXacNhan_Click(object sender, EventArgs e)
        {
            XacNhan();
        }
        private void Thoat()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void ptbThoat_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void FormThemKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(sender, e);
            }
        }

        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
