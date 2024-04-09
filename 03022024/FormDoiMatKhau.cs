using System;
using System.Windows.Forms;
using BLL;
using DAL.Entity;

namespace _03022024
{
    public partial class FormDoiMatKhau : Form
    {
        private TaiKhoanManager manager = null;
        TaiKhoanEntity taiKhoan = new TaiKhoanEntity();

        public FormDoiMatKhau()
        {
            InitializeComponent();
            manager = new TaiKhoanManager();
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

        private void XacNhan()
        {
            taiKhoan.TenDangNhap = txtTenDangNhap.Text;
            taiKhoan.MatKhau = txtMatKhauCu.Text;
            taiKhoan.MatKhauMoi = txtMatKhauMoi.Text;
            taiKhoan.MatKhauXacNhan = txtXacNhanMatKhau.Text;
            if (!string.IsNullOrEmpty(txtTenDangNhap.Text) || !string.IsNullOrEmpty(txtMatKhauCu.Text) || !string.IsNullOrEmpty(txtMatKhauMoi.Text) || !string.IsNullOrEmpty(txtXacNhanMatKhau.Text))
            {
                string result = manager.ThayDoiMatKhau(taiKhoan);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
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

        private void ptb1_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.PasswordChar == '*')
            {
                txtMatKhauCu.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
            }
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '*')
            {
                txtMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*';
            }
        }

        private void ptb3_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.PasswordChar == '*')
            {
                txtMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txtXacNhanMatKhau.PasswordChar = '*';
            }
        }

        private void KiemTraKyTu(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtXacNhanMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void FormDoiMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ptbXacNhan_Click(sender, e);
            }
        }
    }
}
