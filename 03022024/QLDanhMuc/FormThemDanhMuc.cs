using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace _03022024
{
    public partial class FormThemDanhMuc : Form
    {
        private DanhMucManager manager = null;
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
            string maDanhMuc = txtMaDanhMuc.Text;
            string tenDanhMuc = txtTenDanhMuc.Text;

            if (!string.IsNullOrEmpty(maDanhMuc) && !string.IsNullOrEmpty(tenDanhMuc))
            {
                manager.ThemDanhMuc(maDanhMuc, tenDanhMuc);
                MessageBox.Show("Thêm danh mục thành công!");
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
