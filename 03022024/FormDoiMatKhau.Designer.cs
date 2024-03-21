namespace _03022024
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ptbMKC = new System.Windows.Forms.PictureBox();
            this.ptbMKM = new System.Windows.Forms.PictureBox();
            this.ptbMKXN = new System.Windows.Forms.PictureBox();
            this.ptbXacNhan = new System.Windows.Forms.PictureBox();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(105, 11);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(492, 72);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "ĐỔI MẬT KHẨU";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(25, 100);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(184, 28);
            this.lblTenDangNhap.TabIndex = 10;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauCu.Location = new System.Drawing.Point(25, 155);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(156, 28);
            this.lblMatKhauCu.TabIndex = 11;
            this.lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(25, 210);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(172, 28);
            this.lblMatKhauMoi.TabIndex = 12;
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(25, 265);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(238, 28);
            this.lblXacNhanMatKhau.TabIndex = 13;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(280, 100);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(354, 35);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Tag = "";
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(280, 155);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(354, 35);
            this.txtMatKhauCu.TabIndex = 2;
            this.txtMatKhauCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauCu_KeyPress);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(280, 210);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(354, 35);
            this.txtMatKhauMoi.TabIndex = 3;
            this.txtMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi_KeyPress);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(280, 265);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(354, 35);
            this.txtXacNhanMatKhau.TabIndex = 4;
            this.txtXacNhanMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXacNhanMatKhau_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXacNhan.Location = new System.Drawing.Point(163, 335);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(198, 50);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "    Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(436, 335);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 50);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ptbMKC
            // 
            this.ptbMKC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbMKC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKC.Image = ((System.Drawing.Image)(resources.GetObject("ptbMKC.Image")));
            this.ptbMKC.Location = new System.Drawing.Point(599, 156);
            this.ptbMKC.Name = "ptbMKC";
            this.ptbMKC.Size = new System.Drawing.Size(25, 25);
            this.ptbMKC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMKC.TabIndex = 14;
            this.ptbMKC.TabStop = false;
            this.ptbMKC.Click += new System.EventHandler(this.ptb1_Click);
            // 
            // ptbMKM
            // 
            this.ptbMKM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbMKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKM.Image = ((System.Drawing.Image)(resources.GetObject("ptbMKM.Image")));
            this.ptbMKM.Location = new System.Drawing.Point(599, 211);
            this.ptbMKM.Name = "ptbMKM";
            this.ptbMKM.Size = new System.Drawing.Size(25, 25);
            this.ptbMKM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMKM.TabIndex = 15;
            this.ptbMKM.TabStop = false;
            this.ptbMKM.Click += new System.EventHandler(this.ptb2_Click);
            // 
            // ptbMKXN
            // 
            this.ptbMKXN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbMKXN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKXN.Image = ((System.Drawing.Image)(resources.GetObject("ptbMKXN.Image")));
            this.ptbMKXN.Location = new System.Drawing.Point(599, 266);
            this.ptbMKXN.Name = "ptbMKXN";
            this.ptbMKXN.Size = new System.Drawing.Size(25, 25);
            this.ptbMKXN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMKXN.TabIndex = 16;
            this.ptbMKXN.TabStop = false;
            this.ptbMKXN.Click += new System.EventHandler(this.ptb3_Click);
            // 
            // ptbXacNhan
            // 
            this.ptbXacNhan.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbXacNhan.Image = global::_03022024.Properties.Resources.submit;
            this.ptbXacNhan.Location = new System.Drawing.Point(168, 340);
            this.ptbXacNhan.Name = "ptbXacNhan";
            this.ptbXacNhan.Size = new System.Drawing.Size(40, 40);
            this.ptbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXacNhan.TabIndex = 26;
            this.ptbXacNhan.TabStop = false;
            this.ptbXacNhan.Click += new System.EventHandler(this.ptbXacNhan_Click);
            // 
            // ptbThoat
            // 
            this.ptbThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.ptbThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbThoat.Image = global::_03022024.Properties.Resources.logout1;
            this.ptbThoat.Location = new System.Drawing.Point(441, 340);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(40, 40);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThoat.TabIndex = 27;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(682, 412);
            this.Controls.Add(this.ptbThoat);
            this.Controls.Add(this.ptbXacNhan);
            this.Controls.Add(this.ptbMKXN);
            this.Controls.Add(this.ptbMKM);
            this.Controls.Add(this.ptbMKC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 459);
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox ptbMKC;
        private System.Windows.Forms.PictureBox ptbMKM;
        private System.Windows.Forms.PictureBox ptbMKXN;
        private System.Windows.Forms.PictureBox ptbXacNhan;
        private System.Windows.Forms.PictureBox ptbThoat;
    }
}