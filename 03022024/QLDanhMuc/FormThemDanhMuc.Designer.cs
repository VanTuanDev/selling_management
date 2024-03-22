namespace _03022024
{
    partial class FormThemDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemDanhMuc));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            this.ptbXacNhan = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(97, 27);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(437, 57);
            this.lblHeader.TabIndex = 28;
            this.lblHeader.Text = "THÊM DANH MỤC";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(280, 170);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(354, 35);
            this.txtTenDanhMuc.TabIndex = 37;
            this.txtTenDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDanhMuc_KeyPress);
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(280, 115);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(354, 35);
            this.txtMaDanhMuc.TabIndex = 36;
            this.txtMaDanhMuc.Tag = "";
            this.txtMaDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDanhMuc_KeyPress);
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDanhMuc.Location = new System.Drawing.Point(25, 170);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(176, 28);
            this.lblTenDanhMuc.TabIndex = 39;
            this.lblTenDanhMuc.Text = "Tên danh mục";
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDanhMuc.Location = new System.Drawing.Point(25, 115);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(168, 28);
            this.lblMaDanhMuc.TabIndex = 38;
            this.lblMaDanhMuc.Text = "Mã danh mục";
            // 
            // ptbThoat
            // 
            this.ptbThoat.BackColor = System.Drawing.Color.DarkOrange;
            this.ptbThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbThoat.Image = global::_03022024.Properties.Resources.logout;
            this.ptbThoat.Location = new System.Drawing.Point(397, 246);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(32, 32);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThoat.TabIndex = 43;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // ptbXacNhan
            // 
            this.ptbXacNhan.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbXacNhan.Image = global::_03022024.Properties.Resources.submit;
            this.ptbXacNhan.Location = new System.Drawing.Point(124, 246);
            this.ptbXacNhan.Name = "ptbXacNhan";
            this.ptbXacNhan.Size = new System.Drawing.Size(32, 32);
            this.ptbXacNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXacNhan.TabIndex = 42;
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
            this.btnThoat.Location = new System.Drawing.Point(392, 241);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 42);
            this.btnThoat.TabIndex = 41;
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
            this.btnXacNhan.Location = new System.Drawing.Point(119, 241);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(198, 42);
            this.btnXacNhan.TabIndex = 40;
            this.btnXacNhan.Text = "    Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(682, 312);
            this.Controls.Add(this.ptbThoat);
            this.Controls.Add(this.ptbXacNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.lblTenDanhMuc);
            this.Controls.Add(this.lblMaDanhMuc);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 359);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 359);
            this.Name = "FormThemDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm danh mục";
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXacNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Label lblTenDanhMuc;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.PictureBox ptbThoat;
        private System.Windows.Forms.PictureBox ptbXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
    }
}