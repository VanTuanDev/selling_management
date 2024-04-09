using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace _03022024.QLHoaDon
{
    public partial class ucHoaDon : UserControl
    {
        private DataTable dataDSHoaDon = null;
        private HoaDonManager HDmanager = null;
        public ucHoaDon()
        {
            dataDSHoaDon = new DataTable();
            HDmanager = new HoaDonManager();
            InitializeComponent();
            dgDSHoaDon.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgDSHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgDSHoaDon.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgDSHoaDon.DefaultCellStyle.SelectionForeColor = Color.White;

            dgDSHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgDSHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgDSHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgDSHoaDon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgDSHoaDon.AllowUserToResizeRows = false;
            dgDSHoaDon.AllowUserToResizeColumns = false;
        }

        public void HienThiDSHoaDon()
        {
            string error = string.Empty;
            dataDSHoaDon = HDmanager.HienThiDSHoaDon();
            if (dataDSHoaDon != null)
            {
                dgDSHoaDon.DataSource = dataDSHoaDon;
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        public void Reset()
        {
            maHoaDonDuocChon = -1;
        }
        private void ucHoaDon_Load(object sender, System.EventArgs e)
        {
            HienThiDSHoaDon();
        }
        private int maHoaDonDuocChon = -1;
        private void dgDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDSHoaDon.Rows[e.RowIndex];
                int maHoaDon = Convert.ToInt32(selectedRow.Cells["cl1"].Value);

                maHoaDonDuocChon = maHoaDon;
            }
        }
        private void XacNhan()
        {
            if (maHoaDonDuocChon != -1)
            {
                try
                {
                    HDmanager.CapNhatTrangThaiHoaDon(maHoaDonDuocChon, "Đã thanh toán");
                    MessageBox.Show("Cập nhật trạng thái hóa đơn thành công");
                    HienThiDSHoaDon();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật trạng thái hóa đơn: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để cập nhật trạng thái");
            }
        }
        private void btnCapNhatTrangThaiHoaDon_Click(object sender, EventArgs e)
        {
            XacNhan();
        }
        private void ptbXacNhan_Click(object sender, EventArgs e)
        {
            XacNhan();
        }
        private void XemChiTiet ()
        {
            if (maHoaDonDuocChon != -1)
            {
                FormChiTietHoaDon formChiTietHoaDon = new FormChiTietHoaDon();

                formChiTietHoaDon.MaHoaDon = maHoaDonDuocChon;

                formChiTietHoaDon.ShowDialog();

                HienThiDSHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết");
            }
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }  

        private void ptbXemChiTiet_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }
    }
}
