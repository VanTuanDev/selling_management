using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _03022024.QLHoaDon
{
    public partial class FormChiTietHoaDon : Form
    {
        private HoaDonManager HDmanager = null;
        private DataTable dataCTHoaDon = null;

        public FormChiTietHoaDon()
        {
            dataCTHoaDon = new DataTable();
            InitializeComponent();
            HDmanager = new HoaDonManager();
            dgChiTietHoaDon.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgChiTietHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgChiTietHoaDon.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgChiTietHoaDon.DefaultCellStyle.SelectionForeColor = Color.White;

            dgChiTietHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14, FontStyle.Bold);
            dgChiTietHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgChiTietHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgChiTietHoaDon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgChiTietHoaDon.AllowUserToResizeRows = false;
            dgChiTietHoaDon.AllowUserToResizeColumns = false;
        }
        public int MaHoaDon { get; set; }

        private void HienThiDanhSachChiTietHoaDon()
        {
            DataTable dt = HDmanager.LayChiTietHoaDon(MaHoaDon);
            if (dt != null)
            {
                dgChiTietHoaDon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn");
            }
        }
        private void FormChiTietHoaDon_Load(object sender, System.EventArgs e)
        {
            int maHoaDon = MaHoaDon;

            DataTable dt = HDmanager.LayThongTinHoaDon(maHoaDon);

            if (dt.Rows.Count > 0)
            {
                lblTenKHNoiDung.Text = dt.Rows[0]["TenKhachHang"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
            }
            HienThiDanhSachChiTietHoaDon();
            CapNhatTongTien();
        }

        private void dgChiTietHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null && e.Value is decimal)
            {
                e.Value = ((decimal)e.Value).ToString("#,##0.##");
                e.FormattingApplied = true;
            }
        }
        private void CapNhatTongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgChiTietHoaDon.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[3].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells[3].Value);
                    }
                }
            }

            lblTongTienND.Text = total.ToString("#,##0.##") + " VND";
        }
    }
}
