namespace _03022024.QLTaiKhoan
{
    partial class ucTaiKhoan
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
            System.Windows.Forms.Label lblTenDayDu;
            System.Windows.Forms.Label lblTenDangNhap;
            System.Windows.Forms.Label lblQuyen;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbXoa = new System.Windows.Forms.PictureBox();
            this.ptbSua = new System.Windows.Forms.PictureBox();
            this.ptbThem = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtTenDayDu = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTenDayDu = new System.Windows.Forms.Label();
            lblTenDangNhap = new System.Windows.Forms.Label();
            lblQuyen = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenDayDu
            // 
            lblTenDayDu.AutoSize = true;
            lblTenDayDu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblTenDayDu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTenDayDu.Location = new System.Drawing.Point(32, 95);
            lblTenDayDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTenDayDu.Name = "lblTenDayDu";
            lblTenDayDu.Size = new System.Drawing.Size(122, 24);
            lblTenDayDu.TabIndex = 4;
            lblTenDayDu.Text = "Tên đầy đủ";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblTenDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTenDangNhap.Location = new System.Drawing.Point(32, 140);
            lblTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new System.Drawing.Size(161, 24);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblQuyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblQuyen.Location = new System.Drawing.Point(32, 185);
            lblQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new System.Drawing.Size(75, 24);
            lblQuyen.TabIndex = 7;
            lblQuyen.Text = "Quyền";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LimeGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.dgTaiKhoan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 333);
            this.panel3.TabIndex = 2;
            // 
            // dgTaiKhoan
            // 
            this.dgTaiKhoan.AllowUserToAddRows = false;
            this.dgTaiKhoan.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3,
            this.cl4});
            this.dgTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgTaiKhoan.Name = "dgTaiKhoan";
            this.dgTaiKhoan.ReadOnly = true;
            this.dgTaiKhoan.RowHeadersVisible = false;
            this.dgTaiKhoan.RowHeadersWidth = 51;
            this.dgTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTaiKhoan.Size = new System.Drawing.Size(1061, 333);
            this.dgTaiKhoan.TabIndex = 4;
            this.dgTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaiKhoan_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.ptbXoa);
            this.panel2.Controls.Add(this.ptbSua);
            this.panel2.Controls.Add(this.ptbThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(4, 250);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 54);
            this.panel2.TabIndex = 1;
            // 
            // ptbXoa
            // 
            this.ptbXoa.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbXoa.Image = global::_03022024.Properties.Resources.delete;
            this.ptbXoa.Location = new System.Drawing.Point(419, 12);
            this.ptbXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbXoa.Name = "ptbXoa";
            this.ptbXoa.Size = new System.Drawing.Size(27, 27);
            this.ptbXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXoa.TabIndex = 9;
            this.ptbXoa.TabStop = false;
            this.ptbXoa.Click += new System.EventHandler(this.ptbXoa_Click);
            // 
            // ptbSua
            // 
            this.ptbSua.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbSua.Image = global::_03022024.Properties.Resources.edit;
            this.ptbSua.Location = new System.Drawing.Point(221, 12);
            this.ptbSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbSua.Name = "ptbSua";
            this.ptbSua.Size = new System.Drawing.Size(27, 27);
            this.ptbSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSua.TabIndex = 8;
            this.ptbSua.TabStop = false;
            this.ptbSua.Click += new System.EventHandler(this.ptbSua_Click);
            // 
            // ptbThem
            // 
            this.ptbThem.BackColor = System.Drawing.Color.DarkGreen;
            this.ptbThem.Image = global::_03022024.Properties.Resources.add;
            this.ptbThem.Location = new System.Drawing.Point(19, 12);
            this.ptbThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbThem.Name = "ptbThem";
            this.ptbThem.Size = new System.Drawing.Size(27, 27);
            this.ptbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThem.TabIndex = 7;
            this.ptbThem.TabStop = false;
            this.ptbThem.Click += new System.EventHandler(this.ptbThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(405, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(184, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(205, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(184, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(5, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(184, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.cbbQuyen);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.txtTenDayDu);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Controls.Add(lblQuyen);
            this.panel1.Controls.Add(lblTenDangNhap);
            this.panel1.Controls.Add(lblTenDayDu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 238);
            this.panel1.TabIndex = 0;
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(237, 185);
            this.cbbQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(489, 32);
            this.cbbQuyen.TabIndex = 9;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(237, 140);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(489, 32);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // txtTenDayDu
            // 
            this.txtTenDayDu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDayDu.Location = new System.Drawing.Point(237, 95);
            this.txtTenDayDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDayDu.Name = "txtTenDayDu";
            this.txtTenDayDu.Size = new System.Drawing.Size(489, 32);
            this.txtTenDayDu.TabIndex = 1;
            this.txtTenDayDu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDayDu_KeyPress);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTieuDe.Location = new System.Drawing.Point(188, 18);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(584, 57);
            this.lblTieuDe.TabIndex = 8;
            this.lblTieuDe.Text = "THÔNG TIN TÀI KHOẢN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cl1
            // 
            this.cl1.DataPropertyName = "TenDayDu";
            this.cl1.HeaderText = "Tên đầy đủ";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl1.Width = 185;
            // 
            // cl2
            // 
            this.cl2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl2.DataPropertyName = "TenDangNhap";
            this.cl2.HeaderText = "Tên đăng nhập";
            this.cl2.MinimumWidth = 6;
            this.cl2.Name = "cl2";
            this.cl2.ReadOnly = true;
            this.cl2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl3
            // 
            this.cl3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl3.DataPropertyName = "TenQuyen";
            this.cl3.HeaderText = "Quyền tài khoản";
            this.cl3.MinimumWidth = 6;
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            this.cl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl4
            // 
            this.cl4.DataPropertyName = "TrangThai";
            this.cl4.HeaderText = "Trạng thái";
            this.cl4.MinimumWidth = 6;
            this.cl4.Name = "cl4";
            this.cl4.ReadOnly = true;
            this.cl4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl4.Visible = false;
            this.cl4.Width = 120;
            // 
            // ucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1069, 649);
            this.MinimumSize = new System.Drawing.Size(1069, 649);
            this.Name = "ucTaiKhoan";
            this.Size = new System.Drawing.Size(1069, 649);
            this.Load += new System.EventHandler(this.ucTaiKhoan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTenDayDu;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.PictureBox ptbThem;
        private System.Windows.Forms.PictureBox ptbSua;
        private System.Windows.Forms.PictureBox ptbXoa;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl4;
    }
}
