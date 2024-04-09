namespace _03022024.QLHoaDon
{
    partial class FormChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietHoaDon));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lblTongTienND = new System.Windows.Forms.Label();
            this.lblTenKHNoiDung = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.dgChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Controls.Add(this.lblTongTienND);
            this.pnlHeader.Controls.Add(this.lblTenKHNoiDung);
            this.pnlHeader.Controls.Add(this.lblTongTien);
            this.pnlHeader.Controls.Add(this.lblTenKhachHang);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(871, 150);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHeader.Location = new System.Drawing.Point(225, 18);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(338, 40);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // lblTongTienND
            // 
            this.lblTongTienND.AutoSize = true;
            this.lblTongTienND.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTienND.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTongTienND.Location = new System.Drawing.Point(241, 106);
            this.lblTongTienND.Name = "lblTongTienND";
            this.lblTongTienND.Size = new System.Drawing.Size(0, 24);
            this.lblTongTienND.TabIndex = 3;
            // 
            // lblTenKHNoiDung
            // 
            this.lblTenKHNoiDung.AutoSize = true;
            this.lblTenKHNoiDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKHNoiDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenKHNoiDung.Location = new System.Drawing.Point(241, 70);
            this.lblTenKHNoiDung.Name = "lblTenKHNoiDung";
            this.lblTenKHNoiDung.Size = new System.Drawing.Size(0, 24);
            this.lblTenKHNoiDung.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTongTien.Location = new System.Drawing.Point(12, 106);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(118, 24);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền :";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenKhachHang.Location = new System.Drawing.Point(12, 70);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(184, 24);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng :";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlDataGridView.Controls.Add(this.lblFooter);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDataGridView.Location = new System.Drawing.Point(0, 489);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(871, 79);
            this.pnlDataGridView.TabIndex = 1;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFooter.Location = new System.Drawing.Point(96, 21);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(612, 40);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "CẢM ƠN QUÝ KHÁCH. HẸN GẶP LẠI!";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.dgChiTietHoaDon);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 150);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(871, 339);
            this.pnlFooter.TabIndex = 2;
            // 
            // dgChiTietHoaDon
            // 
            this.dgChiTietHoaDon.AllowUserToAddRows = false;
            this.dgChiTietHoaDon.AllowUserToResizeColumns = false;
            this.dgChiTietHoaDon.AllowUserToResizeRows = false;
            this.dgChiTietHoaDon.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3,
            this.cl4,
            this.cl5});
            this.dgChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgChiTietHoaDon.Name = "dgChiTietHoaDon";
            this.dgChiTietHoaDon.ReadOnly = true;
            this.dgChiTietHoaDon.RowHeadersVisible = false;
            this.dgChiTietHoaDon.RowHeadersWidth = 51;
            this.dgChiTietHoaDon.RowTemplate.Height = 24;
            this.dgChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChiTietHoaDon.Size = new System.Drawing.Size(871, 339);
            this.dgChiTietHoaDon.TabIndex = 0;
            this.dgChiTietHoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgChiTietHoaDon_CellFormatting);
            // 
            // cl1
            // 
            this.cl1.DataPropertyName = "MaHoaDon";
            this.cl1.HeaderText = "Mã HD";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl2
            // 
            this.cl2.DataPropertyName = "TenSanPham";
            this.cl2.FillWeight = 3.052572F;
            this.cl2.HeaderText = "Tên sản phẩm";
            this.cl2.MinimumWidth = 6;
            this.cl2.Name = "cl2";
            this.cl2.ReadOnly = true;
            this.cl2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl2.Width = 220;
            // 
            // cl3
            // 
            this.cl3.DataPropertyName = "DonGia";
            this.cl3.HeaderText = "Đơn giá";
            this.cl3.MinimumWidth = 6;
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            this.cl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl3.Width = 90;
            // 
            // cl4
            // 
            this.cl4.DataPropertyName = "SoLuongDat";
            this.cl4.FillWeight = 27.98191F;
            this.cl4.HeaderText = "Số lượng";
            this.cl4.MinimumWidth = 6;
            this.cl4.Name = "cl4";
            this.cl4.ReadOnly = true;
            this.cl4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl5
            // 
            this.cl5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl5.DataPropertyName = "ThanhTien";
            this.cl5.FillWeight = 268.9655F;
            this.cl5.HeaderText = "Thành tiền";
            this.cl5.MinimumWidth = 6;
            this.cl5.Name = "cl5";
            this.cl5.ReadOnly = true;
            this.cl5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(871, 568);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(889, 615);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(889, 615);
            this.Name = "FormChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            this.pnlDataGridView.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.DataGridView dgChiTietHoaDon;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblTongTienND;
        private System.Windows.Forms.Label lblTenKHNoiDung;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl5;
    }
}