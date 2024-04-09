using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace _03022024.QLBanHang
{
    public partial class FormChonKhachHang : Form
    {
        public KhachHang SelectedKhachHang { get; set; } = null;
        private KhachHangManager manager = null;
        private DataTable dataDSKhachHang = null;

        public FormChonKhachHang()
        {
            dataDSKhachHang = new DataTable();
            manager = new KhachHangManager();
            InitializeComponent();
            dgLuaChonKhachHang.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgLuaChonKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgLuaChonKhachHang.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgLuaChonKhachHang.DefaultCellStyle.SelectionForeColor = Color.White;

            dgLuaChonKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgLuaChonKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgLuaChonKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgLuaChonKhachHang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLuaChonKhachHang.AllowUserToResizeColumns = false;
            dgLuaChonKhachHang.AllowUserToResizeRows = false;
        }
        private void HienThiDanhSachKhachHang()
        {
            string error = string.Empty;
            dataDSKhachHang = manager.HienThiDanhSachKhachHang();
            if (dataDSKhachHang != null)
            {
                dgLuaChonKhachHang.DataSource = dataDSKhachHang;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void FormChonKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void dgLuaChonKhachHang_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string maKhachHang = selectedRow.Cells["cl1"].Value.ToString();
                string tenKhachHang = selectedRow.Cells["cl2"].Value.ToString();

                SelectedKhachHang = new KhachHang
                {
                    MaKhachHang = maKhachHang,
                    TenKhachHang = tenKhachHang
                };

                this.Close();
            }
        }
    }
}
