using System;
using System.Windows.Forms;
using BLL;
using DAL.Entity;

namespace _03022024
{
    public partial class FormDangNhap : Form
    {
        private TaiKhoanManager manager = null;
        TaiKhoanEntity taiKhoan = new TaiKhoanEntity();

        public FormDangNhap()
        {
            InitializeComponent();
            manager = new TaiKhoanManager();
        }
        private void DangNhap()
        {
            taiKhoan.TenDangNhap = txtTenDangNhap.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;

            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string role = manager.DangNhap(taiKhoan);

            if (role != null)
            {
                this.Hide();

                FormTrangChu dashboard = new FormTrangChu(role);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void ptbDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }         

        private void Thoat()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Thoat();
        }
        private void ptbThoat_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void KiemTraKyTu(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ptbTatMoKyTu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}