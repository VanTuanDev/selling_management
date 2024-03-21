using System;
using System.Windows.Forms;
using BLL;

namespace _03022024
{
    public partial class FormThemKhachHang : Form
    {
        private KhachHangManager manager = null;
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
            string maKhachHang = txtMaKhachHang.Text;
            string tenKhachHang = txtTenKhachHang.Text;

            if (!string.IsNullOrEmpty(maKhachHang) && !string.IsNullOrEmpty(tenKhachHang))
            {
                manager.ThemKhachHang(maKhachHang, tenKhachHang);
                MessageBox.Show("Thêm khách hàng thành công!");
                this.Close();
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
    }
}
