using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using BLL;
using DAL.Entity;

namespace _03022024.QLTaiKhoan
{
    public partial class ucTaiKhoan : UserControl
    {
        private DataTable dataDSTaiKhoan = null;
        private DataTable data = null;
        private TaiKhoanManager manager = null;
        TaiKhoanEntity taiKhoan = new TaiKhoanEntity();

        public ucTaiKhoan()
        {
            InitializeComponent();
            manager = new TaiKhoanManager();
            dataDSTaiKhoan = new DataTable();
            data = new DataTable();

            dgTaiKhoan.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgTaiKhoan.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgTaiKhoan.DefaultCellStyle.SelectionForeColor = Color.White;

            dgTaiKhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgTaiKhoan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgTaiKhoan.AllowUserToResizeRows = false;
            dgTaiKhoan.AllowUserToResizeColumns = false;
        }
        private void Reset()
        {
            txtTenDayDu.Text = "";
            txtTenDangNhap.Text = "";
            cbbQuyen.Text = "";
        }
        private void HienThiDanhSachTaiKhoan()
        {
            string error = string.Empty;
            dataDSTaiKhoan = manager.HienThiDanhSachTaiKhoan();
            if (dataDSTaiKhoan != null)
            {
                dgTaiKhoan.DataSource = dataDSTaiKhoan; 
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTaiKhoan();
            DataTable dtQuyen = manager.LayDuLieuNguoiDung();
            cbbQuyen.DataSource = dtQuyen;
            cbbQuyen.DisplayMember = "TenQuyen";
            cbbQuyen.ValueMember = "MaQuyen";
            cbbQuyen.SelectedIndex = -1;
        }

        private void dgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgTaiKhoan.Rows[e.RowIndex];

                string column1Value = selectedRow.Cells["cl1"].Value.ToString();
                string column2Value = selectedRow.Cells["cl2"].Value.ToString();
                string column3Value = selectedRow.Cells["cl3"].Value.ToString();

                txtTenDayDu.Text = column1Value;
                txtTenDangNhap.Text = column2Value;
                cbbQuyen.Text = column3Value;
            }
        }       

        private void txtTenDayDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtQuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Them()
        {
            FormThemTaiKhoan formThemTaiKhoan = new FormThemTaiKhoan();
            formThemTaiKhoan.ShowDialog();
            HienThiDanhSachTaiKhoan();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
        }
        private void ptbThem_Click(object sender, EventArgs e)
        {
            Them();
        }
        private void Sua()
        {
            taiKhoan.TenDangNhap = txtTenDangNhap.Text;
            taiKhoan.TenDayDu = txtTenDayDu.Text;
            taiKhoan.MaQuyen = cbbQuyen.Text;
            if (!string.IsNullOrEmpty(txtTenDangNhap.Text) || !string.IsNullOrEmpty(txtTenDayDu.Text))
            {
                try
                {
                    manager.CapNhatTaiKhoan(taiKhoan);
                    MessageBox.Show("Đã cập nhật thông tin tài khoản thành công.");
                    HienThiDanhSachTaiKhoan();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.");
            }       
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
        }
        private void ptbSua_Click(object sender, EventArgs e)
        {
            Sua();
        }
        private void Xoa ()
        {
            if (!string.IsNullOrEmpty(txtTenDangNhap.Text) && !string.IsNullOrEmpty(txtTenDayDu.Text))
            {
                if (dgTaiKhoan.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgTaiKhoan.SelectedRows[0];

                    taiKhoan.TenDangNhap = row.Cells["cl2"].Value.ToString();

                    string error = string.Empty;
                    if (manager.XoaTaiKhoan(taiKhoan))
                    {
                        MessageBox.Show("Đã xóa tài khoản thành công.");
                        HienThiDanhSachTaiKhoan();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }
        private void ptbXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }
    }
}
