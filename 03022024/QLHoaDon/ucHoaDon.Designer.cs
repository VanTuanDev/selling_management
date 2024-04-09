namespace _03022024.QLHoaDon
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
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbXemChiTiet = new System.Windows.Forms.PictureBox();
            this.ptbXacNhan = new System.Windows.Forms.PictureBox();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnXacNhanThanhToan = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHoaDon)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXemChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dgDSHoaDon);
            this.pnlBottom.Location = new System.Drawing.Point(3, 86);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1064, 560);
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
            this.dgDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDSHoaDon.Name = "dgDSHoaDon";
            this.dgDSHoaDon.ReadOnly = true;
            this.dgDSHoaDon.RowHeadersVisible = false;
            this.dgDSHoaDon.RowHeadersWidth = 51;
            this.dgDSHoaDon.RowTemplate.Height = 24;
            this.dgDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDSHoaDon.Size = new System.Drawing.Size(1064, 560);
            this.dgDSHoaDon.TabIndex = 0;
            this.dgDSHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSHoaDon_CellClick);
            // 
            // cl1
            // 
            this.cl1.DataPropertyName = "MaHoaDon";
            this.cl1.HeaderText = "Mã hóa đơn";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl1.Width = 270;
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
            this.cl3.DataPropertyName = "TinhTrang";
            this.cl3.HeaderText = "Tình trạng";
            this.cl3.MinimumWidth = 6;
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            this.cl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl3.Width = 200;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.ptbXemChiTiet);
            this.pnlTop.Controls.Add(this.ptbXacNhan);
            this.pnlTop.Controls.Add(this.btnXemChiTiet);
            this.pnlTop.Controls.Add(this.btnXacNhanThanhToan);
            this.pnlTop.Location = new System.Drawing.Point(3, 2);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 78);
            this.pnlTop.TabIndex = 1;
            // 
            // ptbXemChiTiet
            // 
            this.ptbXemChiTiet.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbXemChiTiet.Image = global::_03022024.Properties.Resources.view_cthd;
            this.ptbXemChiTiet.Location = new System.Drawing.Point(811, 18);
            this.ptbXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbXemChiTiet.Name = "ptbXemChiTiet";
            this.ptbXemChiTiet.Size = new System.Drawing.Size(40, 39);
            this.ptbXemChiTiet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXemChiTiet.TabIndex = 3;
            this.ptbXemChiTiet.TabStop = false;
            this.ptbXemChiTiet.Click += new System.EventHandler(this.ptbXemChiTiet_Click);
            // 
            // ptbXacNhan
            // 
            this.ptbXacNhan.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbXacNhan.Image = global::_03022024.Properties.Resources.submit;
            this.ptbXacNhan.Location = new System.Drawing.Point(475, 18);
            this.ptbXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbXacNhan.Name = "ptbXacNhan";
            this.ptbXacNhan.Size = new System.Drawing.Size(40, 39);
            this.ptbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXacNhan.TabIndex = 1;
            this.ptbXacNhan.TabStop = false;
            this.ptbXacNhan.Click += new System.EventHandler(this.ptbXacNhan_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemChiTiet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXemChiTiet.Location = new System.Drawing.Point(796, 10);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(233, 57);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "     Xem chi tiết";
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
            this.btnXacNhanThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(315, 57);
            this.btnXacNhanThanhToan.TabIndex = 1;
            this.btnXacNhanThanhToan.Text = "     Xác nhận hóa đơn";
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnCapNhatTrangThaiHoaDon_Click);
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1069, 649);
            this.MinimumSize = new System.Drawing.Size(1069, 649);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(1069, 649);
            this.Load += new System.EventHandler(this.ucHoaDon_Load);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHoaDon)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbXemChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgDSHoaDon;
        private System.Windows.Forms.Button btnXacNhanThanhToan;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.PictureBox ptbXacNhan;
        private System.Windows.Forms.PictureBox ptbXemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
    }
}
