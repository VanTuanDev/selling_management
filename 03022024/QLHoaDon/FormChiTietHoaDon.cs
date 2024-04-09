using BLL;
using DAL.Entity;
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
            dgChiTietHoaDon.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgChiTietHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgChiTietHoaDon.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgChiTietHoaDon.DefaultCellStyle.SelectionForeColor = Color.White;

            dgChiTietHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgChiTietHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgChiTietHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgChiTietHoaDon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgChiTietHoaDon.AllowUserToResizeRows = false;
            dgChiTietHoaDon.AllowUserToResizeColumns = false;
        }
        public int MaHoaDon { get; set; }

        private void HienThiDanhSachChiTietHoaDon()
        {
            CTHDEntity chiTietHoaDon = new CTHDEntity();
            chiTietHoaDon.MaHoaDon = MaHoaDon;

            DataTable dt = HDmanager.LayChiTietHoaDon(chiTietHoaDon);
            if (dt != null)
            {
                dgChiTietHoaDon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn");
            }
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            int maHoaDon = MaHoaDon;

            HoaDonEntity hoaDon = new HoaDonEntity();
            hoaDon.MaHoaDon = maHoaDon;

            DataTable dt = HDmanager.LayThongTinHoaDon(hoaDon);

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
            if (e.ColumnIndex == 2 && e.Value != null && e.Value is decimal)
            {
                e.Value = ((decimal)e.Value).ToString("#,##0.##");
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 4 && e.Value != null && e.Value is decimal)
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
                        total += Convert.ToDecimal(row.Cells[4].Value);
                    }
                }
            }

            lblTongTienND.Text = total.ToString("#,##0.##") + " VND";
        }
    }
}
