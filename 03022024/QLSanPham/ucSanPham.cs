using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using BLL;
using System.Collections.Generic;
using DAL.Entity;

namespace _03022024.QLSanPham
{
    public partial class ucSanPham : UserControl
    {
        private DataTable dataDSSanPham = null;
        private SanPhamManager manager = null;
        SanPhamEntity sanPham = new SanPhamEntity();

        public ucSanPham()
        {
            manager = new SanPhamManager();
            dataDSSanPham = new DataTable();

            InitializeComponent();
            dgSanPham.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgSanPham.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgSanPham.DefaultCellStyle.SelectionForeColor = Color.White;

            dgSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgSanPham.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSanPham.AllowUserToResizeRows = false;
            dgSanPham.AllowUserToResizeColumns = false;
        }
        private void Reset()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            cbbDonViTinh.Text = "";
            cbbTenDanhMuc.Text = "";
            txtDonGia.Text = "";
        }
        private void HienThiDanhSachSanPham()
        {
            string error = string.Empty;
            dataDSSanPham = manager.HienThiDanhSachSanPham();
            if (dataDSSanPham != null)
            {
                dgSanPham.DataSource = dataDSSanPham;
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        private void ucSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            List<string> categoryNames = manager.LayTenDanhMuc();
            List<string> unitNames = manager.LayTenDVT();

            cbbTenDanhMuc.Items.AddRange(categoryNames.ToArray());
            cbbDonViTinh.Items.AddRange(unitNames.ToArray());
        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgSanPham.Rows[e.RowIndex];

                string column1Value = selectedRow.Cells["cl1"].Value.ToString();
                string column2Value = selectedRow.Cells["cl2"].Value.ToString();
                string column3Value = selectedRow.Cells["cl3"].Value.ToString();
                string column4Value = selectedRow.Cells["cl4"].Value.ToString();
                decimal column5Value = Convert.ToDecimal(selectedRow.Cells["cl5"].Value);

                txtMaSanPham.Text = column1Value;
                txtTenSanPham.Text = column2Value;
                cbbDonViTinh.Text = column3Value;
                cbbTenDanhMuc.Text = column4Value;
                txtDonGia.Text = column5Value.ToString("#,##0.##");
            }
        }
        private void KiemTraKyTu(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtTenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtTenDanhMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtDonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            KiemTraKyTu(e);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null && e.Value is decimal)
            {
                e.Value = ((decimal)e.Value).ToString("#,##0.##");
                e.FormattingApplied = true;
            }
        }

        private void Them()
        {
            FormThemSanPham formThemSanPham = new FormThemSanPham();
            formThemSanPham.ShowDialog();
            HienThiDanhSachSanPham();
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
            if (!string.IsNullOrEmpty(txtMaSanPham.Text) || !string.IsNullOrEmpty(txtTenSanPham.Text) || !string.IsNullOrEmpty(cbbDonViTinh.Text) || !string.IsNullOrEmpty(cbbTenDanhMuc.Text) || !string.IsNullOrEmpty(txtDonGia.Text))
            {
                sanPham.MaSanPham = txtMaSanPham.Text;
                sanPham.TenSanPham = txtTenSanPham.Text;
                sanPham.MaDVT = cbbDonViTinh.Text;
                sanPham.MaDanhMuc = cbbTenDanhMuc.Text;
                sanPham.DonGia = decimal.Parse(txtDonGia.Text);
                try
                {
                    manager.SuaSanPham(sanPham);
                    MessageBox.Show("Sản phẩm đã được cập nhật thành công.");
                    HienThiDanhSachSanPham();
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
        private void Xoa()
        {
            if (!string.IsNullOrEmpty(txtTenSanPham.Text) && !string.IsNullOrEmpty(txtMaSanPham.Text) && !string.IsNullOrEmpty(txtDonGia.Text))
            {
                if (dgSanPham.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgSanPham.SelectedRows[0];

                    sanPham.MaSanPham = row.Cells["cl1"].Value.ToString();

                    string error = string.Empty;
                    if (manager.XoaSanPham(sanPham))
                    {
                        MessageBox.Show("Đã xóa sản phẩm thành công.");
                        HienThiDanhSachSanPham();
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
