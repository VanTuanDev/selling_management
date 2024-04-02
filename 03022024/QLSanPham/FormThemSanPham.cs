using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            DataTable categories = manager.LayDanhMuc();
            DataTable units = manager.LayDVT();

            cbbDanhMuc.DisplayMember = "TenDanhMuc";
            cbbDanhMuc.ValueMember = "MaDanhMuc";
            cbbDanhMuc.DataSource = categories;

            cbbDonViTinh.DisplayMember = "TenDVT";
            cbbDonViTinh.ValueMember = "MaDVT";
            cbbDonViTinh.DataSource = units;
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
            string maDonViTinh = cbbDonViTinh.SelectedValue.ToString();
            string maDanhMuc = cbbDanhMuc.SelectedValue.ToString();
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
