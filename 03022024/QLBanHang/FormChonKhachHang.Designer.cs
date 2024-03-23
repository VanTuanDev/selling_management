namespace _03022024.QLBanHang
{
    partial class FormChonKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChonKhachHang));
            this.dgLuaChonKhachHang = new System.Windows.Forms.DataGridView();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLuaChonKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLuaChonKhachHang
            // 
            this.dgLuaChonKhachHang.AllowUserToAddRows = false;
            this.dgLuaChonKhachHang.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgLuaChonKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLuaChonKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2});
            this.dgLuaChonKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLuaChonKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgLuaChonKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgLuaChonKhachHang.Name = "dgLuaChonKhachHang";
            this.dgLuaChonKhachHang.RowHeadersVisible = false;
            this.dgLuaChonKhachHang.RowHeadersWidth = 51;
            this.dgLuaChonKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLuaChonKhachHang.Size = new System.Drawing.Size(760, 350);
            this.dgLuaChonKhachHang.TabIndex = 0;
            this.dgLuaChonKhachHang.DoubleClick += new System.EventHandler(this.dgLuaChonKhachHang_DoubleClick);
            // 
            // cl1
            // 
            this.cl1.DataPropertyName = "MaKhachHang";
            this.cl1.HeaderText = "Mã khách hàng";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl1.Width = 200;
            // 
            // cl2
            // 
            this.cl2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl2.DataPropertyName = "TenKhachHang";
            this.cl2.HeaderText = "Tên khách hàng";
            this.cl2.MinimumWidth = 6;
            this.cl2.Name = "cl2";
            this.cl2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormChonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.dgLuaChonKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn khách hàng";
            this.Load += new System.EventHandler(this.FormChonKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLuaChonKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLuaChonKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
    }
}