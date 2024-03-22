namespace _03022024
{
    partial class FormThemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemSanPham));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.lblMaDonViTinh = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            this.ptbXacNhan = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(123, 24);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(428, 57);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "THÊM SẢN PHẨM";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(292, 272);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(354, 35);
            this.txtMaDanhMuc.TabIndex = 30;
            this.txtMaDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDanhMuc_KeyPress);
            // 
            // txtMaDonViTinh
            // 
            this.txtMaDonViTinh.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDonViTinh.Location = new System.Drawing.Point(292, 217);
            this.txtMaDonViTinh.Name = "txtMaDonViTinh";
            this.txtMaDonViTinh.Size = new System.Drawing.Size(354, 35);
            this.txtMaDonViTinh.TabIndex = 29;
            this.txtMaDonViTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDonViTinh_KeyPress);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSanPham.Location = new System.Drawing.Point(292, 162);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(354, 35);
            this.txtTenSanPham.TabIndex = 28;
            this.txtTenSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSanPham_KeyPress);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(292, 107);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(354, 35);
            this.txtMaSanPham.TabIndex = 27;
            this.txtMaSanPham.Tag = "";
            this.txtMaSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSanPham_KeyPress);
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDanhMuc.Location = new System.Drawing.Point(25, 272);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(168, 28);
            this.lblMaDanhMuc.TabIndex = 34;
            this.lblMaDanhMuc.Text = "Mã danh mục";
            // 
            // lblMaDonViTinh
            // 
            this.lblMaDonViTinh.AutoSize = true;
            this.lblMaDonViTinh.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDonViTinh.Location = new System.Drawing.Point(25, 217);
            this.lblMaDonViTinh.Name = "lblMaDonViTinh";
            this.lblMaDonViTinh.Size = new System.Drawing.Size(178, 28);
            this.lblMaDonViTinh.TabIndex = 33;
            this.lblMaDonViTinh.Text = "Mã đơn vị tính";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSanPham.Location = new System.Drawing.Point(25, 162);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(175, 28);
            this.lblTenSanPham.TabIndex = 32;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSanPham.Location = new System.Drawing.Point(25, 107);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(167, 28);
            this.lblMaSanPham.TabIndex = 31;
            this.lblMaSanPham.Text = "Mã sản phẩm";
            // 
            // ptbThoat
            // 
            this.ptbThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.ptbThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbThoat.Image = global::_03022024.Properties.Resources.logout;
            this.ptbThoat.Location = new System.Drawing.Point(397, 394);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(32, 32);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThoat.TabIndex = 42;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // ptbXacNhan
            // 
            this.ptbXacNhan.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbXacNhan.Image = global::_03022024.Properties.Resources.submit;
            this.ptbXacNhan.Location = new System.Drawing.Point(123, 394);
            this.ptbXacNhan.Name = "ptbXacNhan";
            this.ptbXacNhan.Size = new System.Drawing.Size(32, 32);
            this.ptbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXacNhan.TabIndex = 41;
            this.ptbXacNhan.TabStop = false;
            this.ptbXacNhan.Click += new System.EventHandler(this.ptbXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(391, 389);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 42);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXacNhan.Location = new System.Drawing.Point(118, 389);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(198, 42);
            this.btnXacNhan.TabIndex = 39;
            this.btnXacNhan.Text = "    Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.Location = new System.Drawing.Point(292, 327);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(354, 35);
            this.txtDonGia.TabIndex = 43;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonGia.Location = new System.Drawing.Point(25, 327);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(101, 28);
            this.lblDonGia.TabIndex = 44;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // FormThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.ptbThoat);
            this.Controls.Add(this.ptbXacNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.txtMaDonViTinh);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lblMaDanhMuc);
            this.Controls.Add(this.lblMaDonViTinh);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.TextBox txtMaDonViTinh;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.Label lblMaDonViTinh;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.PictureBox ptbThoat;
        private System.Windows.Forms.PictureBox ptbXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
    }
}