using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace _03022024.QLKhachHang
{
    public partial class ucKhachHang : UserControl
    {
        private DataTable dataDSKhachHang = null;
        private KhachHangManager manager = null;
        public ucKhachHang()
        {
            InitializeComponent();
            manager = new KhachHangManager();
            dataDSKhachHang = new DataTable();
            dgKhachHang.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgKhachHang.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgKhachHang.DefaultCellStyle.SelectionForeColor = Color.White;

            dgKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgKhachHang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgKhachHang.AllowUserToResizeColumns = false;
            dgKhachHang.AllowUserToResizeRows = false;
        }
        private void Reset()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
        }
        private void HienThiDanhSachKhachHang()
        {
            string error = string.Empty;
            dataDSKhachHang = manager.HienThiDanhSachKhachHang();
            if (dataDSKhachHang != null)
            {
                dgKhachHang.DataSource = dataDSKhachHang;
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgKhachHang.Rows[e.RowIndex];

                string column1Value = selectedRow.Cells["cl1"].Value.ToString();
                string column2Value = selectedRow.Cells["cl2"].Value.ToString();

                txtMaKhachHang.Text = column1Value;
                txtTenKhachHang.Text = column2Value;
            }
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
        private void Them()
        {
            FormThemKhachHang formThemKhachHang = new FormThemKhachHang();
            formThemKhachHang.ShowDialog();
            HienThiDanhSachKhachHang();
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
            string makhachhang = txtMaKhachHang.Text;
            string tenkhachhang = txtTenKhachHang.Text;

            try
            {
                manager.CapNhatKhachHang(makhachhang, tenkhachhang);
                MessageBox.Show("Đã cập nhật thông tin khách hàng thành công.");
                HienThiDanhSachKhachHang();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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
        private void Xoa()
        {
            if (dgKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgKhachHang.SelectedRows[0];

                string khachhang = row.Cells["cl1"].Value.ToString();

                string error = string.Empty;
                if (manager.XoaKhachHang(khachhang))
                {
                    
                    MessageBox.Show("Đã xóa khách hàng thành công.");
                    HienThiDanhSachKhachHang();
                    Reset();
                }
                else
                {
                    MessageBox.Show(error);
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
