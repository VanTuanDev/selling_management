using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;

namespace _03022024
{
    public partial class FormDoiMatKhau : Form
    {
        private TaiKhoanManager manager = null;
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
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string matKhauXacNhan = txtXacNhanMatKhau.Text;

            string result = manager.ThayDoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi, matKhauXacNhan);
            MessageBox.Show(result + " Mời bạn đăng nhập lại!");
            if (result == "Bạn đã cập nhật mật khẩu thành công.")
            {
                Application.Restart();
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
                ptbMKC.Image = Properties.Resources.off;
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
                ptbMKC.Image = Properties.Resources.on;
            }
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '*')
            {
                txtMatKhauMoi.PasswordChar = '\0';
                ptbMKM.Image = Properties.Resources.off;
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*';
                ptbMKM.Image = Properties.Resources.on;
            }
        }

        private void ptb3_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.PasswordChar == '*')
            {
                txtMatKhauMoi.PasswordChar = '\0';
                ptbMKXN.Image = Properties.Resources.off;
            }
            else
            {
                txtXacNhanMatKhau.PasswordChar = '*';
                ptbMKXN.Image = Properties.Resources.on;
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
