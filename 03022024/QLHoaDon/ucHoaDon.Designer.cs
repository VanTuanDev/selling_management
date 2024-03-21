﻿namespace _03022024.QLHoaDon
{
    partial class ucHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgDSHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnXacNhanThanhToan = new System.Windows.Forms.Button();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHoaDon)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dgDSHoaDon);
            this.pnlBottom.Location = new System.Drawing.Point(3, 86);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1054, 543);
            this.pnlBottom.TabIndex = 0;
            // 
            // dgDSHoaDon
            // 
            this.dgDSHoaDon.AllowUserToAddRows = false;
            this.dgDSHoaDon.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3});
            this.dgDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDSHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgDSHoaDon.Name = "dgDSHoaDon";
            this.dgDSHoaDon.ReadOnly = true;
            this.dgDSHoaDon.RowHeadersVisible = false;
            this.dgDSHoaDon.RowHeadersWidth = 51;
            this.dgDSHoaDon.RowTemplate.Height = 24;
            this.dgDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDSHoaDon.Size = new System.Drawing.Size(1054, 543);
            this.dgDSHoaDon.TabIndex = 0;
            this.dgDSHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSHoaDon_CellClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnXemChiTiet);
            this.pnlTop.Controls.Add(this.btnXacNhanThanhToan);
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1054, 77);
            this.pnlTop.TabIndex = 1;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemChiTiet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXemChiTiet.Location = new System.Drawing.Point(796, 10);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(233, 56);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXacNhanThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanThanhToan.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanThanhToan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(460, 10);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(315, 56);
            this.btnXacNhanThanhToan.TabIndex = 1;
            this.btnXacNhanThanhToan.Text = "Xác nhận hóa đơn";
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnCapNhatTrangThaiHoaDon_Click);
            // 
            // cl1
            // 
            this.cl1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl1.DataPropertyName = "MaHoaDon";
            this.cl1.HeaderText = "Mã hóa đơn";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl2
            // 
            this.cl2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl2.DataPropertyName = "TenKhachHang";
            this.cl2.HeaderText = "Tên khách hàng";
            this.cl2.MinimumWidth = 6;
            this.cl2.Name = "cl2";
            this.cl2.ReadOnly = true;
            this.cl2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl3
            // 
            this.cl3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl3.DataPropertyName = "TinhTrang";
            this.cl3.HeaderText = "Tình trạng";
            this.cl3.MinimumWidth = 6;
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            this.cl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1060, 632);
            this.MinimumSize = new System.Drawing.Size(1060, 632);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(1060, 632);
            this.Load += new System.EventHandler(this.ucHoaDon_Load);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHoaDon)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgDSHoaDon;
        private System.Windows.Forms.Button btnXacNhanThanhToan;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
    }
}
