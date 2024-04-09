using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DAL.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03022024.QLBanHang
{
    public partial class ucBanHang : UserControl
    {
        private DataTable dataDSSanPham = null;
        private SanPhamManager manager = null;
        private HoaDonManager HDmanager = null;
        SanPhamEntity sanPham = new SanPhamEntity();
        HoaDonEntity hoaDon = new HoaDonEntity();
        KhachHangEntity khachHang = new KhachHangEntity();
        CTHDEntity chiTietHoaDon = new CTHDEntity();

        public ucBanHang()
        {
            dataDSSanPham = new DataTable();
            manager = new SanPhamManager();
            HDmanager = new HoaDonManager();

            InitializeComponent();
            dgDanhSachSP.DefaultCellStyle.Font = new Font("Tahoma", 8);
            dgDanhSachSP.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgDanhSachSP.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgDanhSachSP.DefaultCellStyle.SelectionForeColor = Color.White;

            dgDanhSachSP.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgDanhSachSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgDanhSachSP.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgDanhSachSP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgDanhSachSP.AllowUserToResizeRows = false;
            dgDanhSachSP.AllowUserToResizeColumns = false;

            dgDSSanPhamDuocChon.DefaultCellStyle.Font = new Font("Tahoma", 8);
            dgDSSanPhamDuocChon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgDSSanPhamDuocChon.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgDSSanPhamDuocChon.DefaultCellStyle.SelectionForeColor = Color.White;

            dgDSSanPhamDuocChon.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgDSSanPhamDuocChon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgDSSanPhamDuocChon.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgDSSanPhamDuocChon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgDSSanPhamDuocChon.AllowUserToResizeRows = false;
            dgDSSanPhamDuocChon.AllowUserToResizeColumns = false;
        }
        private void HienThiDanhSachSanPham()
        {
            string error = string.Empty;
            dataDSSanPham = manager.HienThiDanhSachSanPhamBanHang();
            if (dataDSSanPham != null)
            {
                dgDanhSachSP.DataSource = dataDSSanPham;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
        }

        private void dgDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgDanhSachSP.Rows[e.RowIndex];

                string column1Value = selectedRow.Cells["cl1"].Value.ToString();
                decimal column4Value = Convert.ToDecimal(selectedRow.Cells["cl4"].Value);

                lblTenSPNoiDung.Text = column1Value;
                lblDonGiaNoiDung.Text = column4Value.ToString("#,##0.##"); 
            }
        }
        private bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
        private void Them()
        {
            string SoLuong = txtSoLuong.Text;
            if (IsNumeric(SoLuong))
            {
                if (!string.IsNullOrEmpty(lblTenSPNoiDung.Text))
                {
                    string tenSanPham = lblTenSPNoiDung.Text;
                    int soLuong = int.Parse(txtSoLuong.Text);
                    decimal donGia = decimal.Parse(lblDonGiaNoiDung.Text);
                    decimal thanhTien = soLuong * donGia;

                    bool daTonTai = false;
                    foreach (DataGridViewRow existingRow in dgDSSanPhamDuocChon.Rows)
                    {
                        string tenSanPhamHienTai = existingRow.Cells[0].Value.ToString();
                        int soLuongHienTai = int.Parse(existingRow.Cells[1].Value.ToString());
                        decimal donGiaHienTai = decimal.Parse(existingRow.Cells[2].Value.ToString());

                        if (tenSanPham == tenSanPhamHienTai)
                        {
                            soLuongHienTai += soLuong;
                            decimal thanhTienHienTai = soLuongHienTai * donGiaHienTai;
                            existingRow.Cells[1].Value = soLuongHienTai;
                            existingRow.Cells[3].Value = thanhTienHienTai;

                            daTonTai = true;
                            break;
                        }
                    }

                    if (!daTonTai)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgDSSanPhamDuocChon);
                        row.Cells[0].Value = tenSanPham;
                        row.Cells[1].Value = soLuong;
                        row.Cells[2].Value = donGia;
                        row.Cells[3].Value = thanhTien;

                        dgDSSanPhamDuocChon.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm muốn mua.");
                }
            }
            else
            {
                MessageBox.Show("Số lượng chỉ cho phép nhập số.");
            }
                
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
            CapNhatTongTien();
        }
        private void ptbThem_Click(object sender, EventArgs e)
        {
            Them();
            CapNhatTongTien();
        }
        private void Xoa()
        {
            if (dgDSSanPhamDuocChon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgDSSanPhamDuocChon.SelectedRows[0];
                dgDSSanPhamDuocChon.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
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
        private void CapNhatTongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgDSSanPhamDuocChon.Rows)
            {
                if (!row.IsNewRow) 
                {
                    if (row.Cells[3].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells[3].Value);
                    }
                }
            }

            lblThanhTienNoiDung.Text = total.ToString("#,##0.##") + " VND";
        }
        private void dgDSSanPhamDuocChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatTongTien();
        }

        private void dgDanhSachSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null && e.Value is decimal)
            {
                e.Value = ((decimal)e.Value).ToString("#,##0.##");
                e.FormattingApplied = true;
            }
        }

        private void dgDSSanPhamDuocChon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null && e.Value is decimal)
            {
                e.Value = ((decimal)e.Value).ToString("#,##0.##");
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 2 && e.Value != null && e.Value is decimal)
            {
                e.Value = ((decimal)e.Value).ToString("#,##0.##");
                e.FormattingApplied = true;
            }
        }
        private void ThanhToan()
        {
            if(!string.IsNullOrEmpty(lblTenKHNoiDung.Text))
            {
                hoaDon.TinhTrang = "Chưa thanh toán";
                khachHang.TenKhachHang = lblTenKHNoiDung.Text;

                hoaDon.MaKhachHang = lblMaKHNoiDung.Text;
                chiTietHoaDon.MaHoaDon = HDmanager.TaoHoaDon(hoaDon);
                MessageBox.Show(chiTietHoaDon.MaHoaDon.ToString()); //
                try
                {
                    if (chiTietHoaDon.MaHoaDon != -1)
                    {
                        foreach (DataGridViewRow row in dgDSSanPhamDuocChon.Rows)
                        {
                            sanPham.TenSanPham = row.Cells["column1"].Value.ToString();
                            chiTietHoaDon.SoLuongDat = Convert.ToInt32(row.Cells["column2"].Value);
                            chiTietHoaDon.ThanhTien = Convert.ToDecimal(row.Cells["column4"].Value);

                            chiTietHoaDon.MaSanPham = HDmanager.LayMaSanPhamTuTen(sanPham);
                            MessageBox.Show(chiTietHoaDon.MaSanPham.ToString()); //
                            HDmanager.TaoChiTietHoaDon(chiTietHoaDon);
                        }
                        MessageBox.Show("Giao dịch của bạn đang được xử lý.");
                    }
                    else
                    {
                        MessageBox.Show("Tạo hóa đơn thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi khi thực hiện giao dịch: " + ex.Message);
                }
                lblMaKHNoiDung.Text = string.Empty;
                lblTenKHNoiDung.Text = string.Empty;
                lblTenSPNoiDung.Text = string.Empty;
                lblDonGiaNoiDung.Text = string.Empty;
                txtSoLuong.Text = string.Empty;

                dgDSSanPhamDuocChon.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Chưa có khách hàng.");
            }          
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }
        private void ptbThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuaChonKhachHang_Click(object sender, EventArgs e)
        {
            FormChonKhachHang chonKhachHangForm = new FormChonKhachHang();
            chonKhachHangForm.ShowDialog();

            if (chonKhachHangForm.SelectedKhachHang != null)
            {
                string maKhachHang = chonKhachHangForm.SelectedKhachHang.MaKhachHang;
                string tenKhachHang = chonKhachHangForm.SelectedKhachHang.TenKhachHang;

                lblMaKHNoiDung.Text = maKhachHang;
                lblTenKHNoiDung.Text = tenKhachHang;
            }
        }
    }
}
