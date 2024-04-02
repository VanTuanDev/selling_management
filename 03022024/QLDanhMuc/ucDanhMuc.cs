using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace _03022024.QLDanhMuc
{
    public partial class ucDanhMuc : UserControl
    {
        private DataTable dataDSDanhMuc = null;
        private DanhMucManager manager = null;
        public ucDanhMuc()
        {
            InitializeComponent();
            manager = new DanhMucManager();
            dataDSDanhMuc = new DataTable();
            dgDanhMuc.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgDanhMuc.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgDanhMuc.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgDanhMuc.DefaultCellStyle.SelectionForeColor = Color.White;

            dgDanhMuc.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgDanhMuc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgDanhMuc.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgDanhMuc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgDanhMuc.AllowUserToResizeColumns = false;
            dgDanhMuc.AllowUserToResizeRows = false;
        }
        private void Reset()
        {
            txtMaDanhMuc.Text = "";
            txtTenDanhMuc.Text = "";
        }
        private void HienThiDanhSachDanhMuc()
        {
            string error = string.Empty;
            dataDSDanhMuc = manager.HienThiDanhSachDanhMuc();
            if (dataDSDanhMuc != null)
            {
                dgDanhMuc.DataSource = dataDSDanhMuc;
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        private void ucDanhMuc_Load(object sender, System.EventArgs e)
        {
            HienThiDanhSachDanhMuc();
        }

        private void dgDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDanhMuc.Rows[e.RowIndex];

                string column1Value = selectedRow.Cells["cl1"].Value.ToString();
                string column2Value = selectedRow.Cells["cl2"].Value.ToString();

                txtMaDanhMuc.Text = column1Value;
                txtTenDanhMuc.Text = column2Value;
            }
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
        private void Them()
        {
            FormThemDanhMuc formThemDanhMuc = new FormThemDanhMuc();
            formThemDanhMuc.ShowDialog();
            HienThiDanhSachDanhMuc();
        }
        private void btnThem_Click(object sender, System.EventArgs e)
        {
            Them();
        }
        private void ptbThem_Click(object sender, EventArgs e)
        {
            Them();
        }
        private void Sua()
        {
            string maDanhMuc = txtMaDanhMuc.Text;
            string tenDanhMuc = txtTenDanhMuc.Text;

            try
            {
                manager.CapNhatDanhMuc(maDanhMuc, tenDanhMuc);
                MessageBox.Show("Đã cập nhật thông tin khách hàng thành công.");
                HienThiDanhSachDanhMuc();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, System.EventArgs e)
        {
            Sua();
        }
        private void ptbSua_Click(object sender, EventArgs e)
        {
            Sua();
        }
        private void Xoa()
        {
            string maDanhMuc = txtMaDanhMuc.Text;

            try
            {
                manager.XoaDanhMuc(maDanhMuc);
                MessageBox.Show("Danh mục đã được xóa thành công.");
                HienThiDanhSachDanhMuc();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            Xoa();
        }
        private void ptbXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }
    }
}
