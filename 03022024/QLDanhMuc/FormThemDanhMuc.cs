using System;
using System.Windows.Forms;
using _03022024.QLBanHang;
using BLL;
using DAL.Entity;

namespace _03022024
{
    public partial class FormThemDanhMuc : Form
    {
        private DanhMucManager manager = null;
        DanhMucEntity danhMuc = new DanhMucEntity();

        public FormThemDanhMuc()
        {
            InitializeComponent();
            manager = new DanhMucManager();
        }

        private void txtMaDanhMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenDanhMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void XacNhan()
        {
            danhMuc.MaDanhMuc = txtMaDanhMuc.Text;
            danhMuc.TenDanhMuc = txtTenDanhMuc.Text;

            if (!string.IsNullOrEmpty(txtMaDanhMuc.Text) && !string.IsNullOrEmpty(txtTenDanhMuc.Text))
            {
                string errorMessage;
                try
                {
                    manager.ThemDanhMuc(danhMuc, out errorMessage);
                    MessageBox.Show(errorMessage);
                    if (errorMessage.StartsWith("Danh mục đã được thêm thành công"))
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
    }
}
