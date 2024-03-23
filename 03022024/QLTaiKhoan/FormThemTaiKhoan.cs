using BLL;
using System;
using System.Windows.Forms;
using System.Data;

namespace _03022024
{
    public partial class FormThemTaiKhoan : Form
    {
        private TaiKhoanManager manager = null;
        private DataTable data = null;
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            manager = new TaiKhoanManager();
            data = new DataTable();
       
        }
        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dtQuyen = manager.LayDuLieuNguoiDung();
            cbbMaQuyen.DataSource = dtQuyen;
            cbbMaQuyen.DisplayMember = "TenQuyen";
            cbbMaQuyen.ValueMember = "MaQuyen";
        }
        private void ptbMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
                ptbMatKhau.Image = Properties.Resources.off;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                ptbMatKhau.Image = Properties.Resources.on;
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

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtQuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }
        private void txtTenDayDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void XacNhan()
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string tenDayDu = txtTenDayDu.Text;
            string matKhau = txtMatKhau.Text;

            string maQuyen = cbbMaQuyen.SelectedValue.ToString();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(tenDayDu) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(maQuyen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                manager.ThemTaiKhoan(tenDangNhap, tenDayDu, matKhau, maQuyen);
                MessageBox.Show("Thêm tài khoản thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
