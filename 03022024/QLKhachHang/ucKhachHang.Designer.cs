namespace _03022024.QLKhachHang
{
    partial class ucKhachHang
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
            System.Windows.Forms.Label lblTenKhachHang;
            System.Windows.Forms.Label lblMaKhachHang;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgKhachHang = new System.Windows.Forms.DataGridView();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbXoa = new System.Windows.Forms.PictureBox();
            this.ptbSua = new System.Windows.Forms.PictureBox();
            this.ptbThem = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            lblTenKhachHang = new System.Windows.Forms.Label();
            lblMaKhachHang = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblTenKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTenKhachHang.Location = new System.Drawing.Point(32, 150);
            lblTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new System.Drawing.Size(171, 24);
            lblTenKhachHang.TabIndex = 5;
            lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.AutoSize = true;
            lblMaKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblMaKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMaKhachHang.Location = new System.Drawing.Point(32, 95);
            lblMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new System.Drawing.Size(164, 24);
            lblMaKhachHang.TabIndex = 8;
            lblMaKhachHang.Text = "Mã khách hàng";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.dgKhachHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 333);
            this.panel3.TabIndex = 2;
            // 
            // dgKhachHang
            // 
            this.dgKhachHang.AllowUserToAddRows = false;
            this.dgKhachHang.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3});
            this.dgKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgKhachHang.Name = "dgKhachHang";
            this.dgKhachHang.ReadOnly = true;
            this.dgKhachHang.RowHeadersVisible = false;
            this.dgKhachHang.RowHeadersWidth = 51;
            this.dgKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKhachHang.Size = new System.Drawing.Size(1061, 333);
            this.dgKhachHang.TabIndex = 0;
            this.dgKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhachHang_CellClick);
            // 
            // cl1
            // 
            this.cl1.DataPropertyName = "MaKhachHang";
            this.cl1.HeaderText = "Mã khách hàng";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl1.Width = 280;
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
            this.cl3.DataPropertyName = "TrangThai";
            this.cl3.HeaderText = "Trạng thái";
            this.cl3.MinimumWidth = 6;
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            this.cl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl3.Visible = false;
            this.cl3.Width = 280;
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
            this.ptbXoa.TabIndex = 12;
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
            this.ptbSua.TabIndex = 11;
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
            this.ptbThem.TabIndex = 10;
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
            this.btnXoa.TabIndex = 5;
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
            this.btnSua.TabIndex = 4;
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
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.txtTenKhachHang);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.txtMaKhachHang);
            this.panel1.Controls.Add(lblTenKhachHang);
            this.panel1.Controls.Add(lblMaKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 238);
            this.panel1.TabIndex = 0;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(237, 150);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(489, 32);
            this.txtTenKhachHang.TabIndex = 2;
            this.txtTenKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhachHang_KeyPress);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeader.Location = new System.Drawing.Point(188, 18);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(634, 57);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(237, 95);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(489, 32);
            this.txtMaKhachHang.TabIndex = 1;
            this.txtMaKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhachHang_KeyPress);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1069, 649);
            this.MinimumSize = new System.Drawing.Size(1069, 649);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1069, 649);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).EndInit();
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
        private System.Windows.Forms.DataGridView dgKhachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.PictureBox ptbXoa;
        private System.Windows.Forms.PictureBox ptbSua;
        private System.Windows.Forms.PictureBox ptbThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
    }
}
