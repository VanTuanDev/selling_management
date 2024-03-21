using BLL;
using System;
using System.Windows.Forms;

namespace _03022024
{
    public partial class FormThemSanPham : Form
    {
        private SanPhamManager manager = null;
        public FormThemSanPham()
        {
            InitializeComponent();
            manager = new SanPhamManager();
        }

        private void txtTenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void KiemTraKyTu(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtMaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }      

        private void txtMaDonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtMaDanhMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void XacNhan()
        {
            string maSanPham = txtMaSanPham.Text;
            string tenSanPham = txtTenSanPham.Text;
            string maDonViTinh = txtMaDonViTinh.Text;
            string maDanhMuc = txtMaDanhMuc.Text;
            string donGia = txtDonGia.Text;

            if (string.IsNullOrEmpty(maSanPham) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(maDonViTinh) || string.IsNullOrEmpty(maDanhMuc) || string.IsNullOrEmpty(donGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                manager.ThemSanPham(maSanPham, tenSanPham, maDonViTinh, maDanhMuc, donGia);
                MessageBox.Show("Thêm sản phẩm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnXacNhan_Click(object sender, System.EventArgs e)
        {
            XacNhan();
        }

        private void ptbXacNhan_Click(object sender, System.EventArgs e)
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
        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            Thoat();
        }

        private void ptbThoat_Click(object sender, System.EventArgs e)
        {
            Thoat();
        }
    }
}
