namespace _03022024
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpDangNhap = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.ptbMatKhau = new System.Windows.Forms.PictureBox();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            this.ptbTenDangNhap = new System.Windows.Forms.PictureBox();
            this.ptbTatMoKyTu = new System.Windows.Forms.PictureBox();
            this.ptbDangNhap = new System.Windows.Forms.PictureBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.ptbLogoBHX = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tlpDangNhap.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTatMoKyTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangNhap)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoBHX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(73, 186);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(238, 36);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau.Location = new System.Drawing.Point(325, 278);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(246, 40);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(73, 278);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(155, 36);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenDangNhap.Location = new System.Drawing.Point(325, 186);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(246, 40);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDangNhap.Location = new System.Drawing.Point(82, 363);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(222, 63);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "     Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(50, 43);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(535, 97);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ĐĂNG NHẬP";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(333, 363);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(187, 63);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.tlpDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 453);
            this.panel1.TabIndex = 5;
            // 
            // tlpDangNhap
            // 
            this.tlpDangNhap.ColumnCount = 2;
            this.tlpDangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpDangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDangNhap.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpDangNhap.Controls.Add(this.pnlRight, 1, 0);
            this.tlpDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDangNhap.Location = new System.Drawing.Point(0, 0);
            this.tlpDangNhap.Name = "tlpDangNhap";
            this.tlpDangNhap.RowCount = 1;
            this.tlpDangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDangNhap.Size = new System.Drawing.Size(1034, 453);
            this.tlpDangNhap.TabIndex = 20;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlLeft.Controls.Add(this.lblHeader);
            this.pnlLeft.Controls.Add(this.ptbMatKhau);
            this.pnlLeft.Controls.Add(this.ptbThoat);
            this.pnlLeft.Controls.Add(this.ptbTenDangNhap);
            this.pnlLeft.Controls.Add(this.btnThoat);
            this.pnlLeft.Controls.Add(this.ptbTatMoKyTu);
            this.pnlLeft.Controls.Add(this.ptbDangNhap);
            this.pnlLeft.Controls.Add(this.btnDangNhap);
            this.pnlLeft.Controls.Add(this.txtTenDangNhap);
            this.pnlLeft.Controls.Add(this.lblPassword);
            this.pnlLeft.Controls.Add(this.lblUsername);
            this.pnlLeft.Controls.Add(this.txtMatKhau);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(614, 447);
            this.pnlLeft.TabIndex = 0;
            // 
            // ptbMatKhau
            // 
            this.ptbMatKhau.Image = global::_03022024.Properties.Resources.password_login;
            this.ptbMatKhau.Location = new System.Drawing.Point(18, 263);
            this.ptbMatKhau.Name = "ptbMatKhau";
            this.ptbMatKhau.Size = new System.Drawing.Size(51, 50);
            this.ptbMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMatKhau.TabIndex = 17;
            this.ptbMatKhau.TabStop = false;
            // 
            // ptbThoat
            // 
            this.ptbThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.ptbThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbThoat.Image = global::_03022024.Properties.Resources.logout;
            this.ptbThoat.Location = new System.Drawing.Point(340, 374);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(39, 45);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThoat.TabIndex = 19;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // ptbTenDangNhap
            // 
            this.ptbTenDangNhap.Image = global::_03022024.Properties.Resources.username_login;
            this.ptbTenDangNhap.Location = new System.Drawing.Point(18, 176);
            this.ptbTenDangNhap.Name = "ptbTenDangNhap";
            this.ptbTenDangNhap.Size = new System.Drawing.Size(51, 50);
            this.ptbTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTenDangNhap.TabIndex = 16;
            this.ptbTenDangNhap.TabStop = false;
            // 
            // ptbTatMoKyTu
            // 
            this.ptbTatMoKyTu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbTatMoKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbTatMoKyTu.Image = global::_03022024.Properties.Resources.on;
            this.ptbTatMoKyTu.Location = new System.Drawing.Point(539, 280);
            this.ptbTatMoKyTu.Name = "ptbTatMoKyTu";
            this.ptbTatMoKyTu.Size = new System.Drawing.Size(29, 29);
            this.ptbTatMoKyTu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTatMoKyTu.TabIndex = 15;
            this.ptbTatMoKyTu.TabStop = false;
            this.ptbTatMoKyTu.Click += new System.EventHandler(this.ptbTatMoKyTu_Click);
            // 
            // ptbDangNhap
            // 
            this.ptbDangNhap.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbDangNhap.Image = global::_03022024.Properties.Resources.login;
            this.ptbDangNhap.Location = new System.Drawing.Point(90, 372);
            this.ptbDangNhap.Name = "ptbDangNhap";
            this.ptbDangNhap.Size = new System.Drawing.Size(39, 45);
            this.ptbDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDangNhap.TabIndex = 18;
            this.ptbDangNhap.TabStop = false;
            this.ptbDangNhap.Click += new System.EventHandler(this.ptbDangNhap_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.ptbLogoBHX);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(623, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(408, 447);
            this.pnlRight.TabIndex = 1;
            // 
            // ptbLogoBHX
            // 
            this.ptbLogoBHX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogoBHX.Image = global::_03022024.Properties.Resources.logo_bachhoaxanh;
            this.ptbLogoBHX.Location = new System.Drawing.Point(0, 0);
            this.ptbLogoBHX.Name = "ptbLogoBHX";
            this.ptbLogoBHX.Size = new System.Drawing.Size(408, 447);
            this.ptbLogoBHX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogoBHX.TabIndex = 0;
            this.ptbLogoBHX.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 453);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1052, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1052, 500);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tlpDangNhap.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTatMoKyTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDangNhap)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoBHX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbTatMoKyTu;
        private System.Windows.Forms.PictureBox ptbTenDangNhap;
        private System.Windows.Forms.PictureBox ptbMatKhau;
        private System.Windows.Forms.PictureBox ptbDangNhap;
        private System.Windows.Forms.PictureBox ptbThoat;
        private System.Windows.Forms.TableLayoutPanel tlpDangNhap;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox ptbLogoBHX;
    }
}