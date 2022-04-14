namespace QuanLyQuanCaFe
{
    partial class QuanLySanPham
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
            this.dtvQuanLySanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.nupSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.nupGiaSP = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnNhapExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvQuanLySanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiaSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvQuanLySanPham
            // 
            this.dtvQuanLySanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvQuanLySanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column10,
            this.Column3});
            this.dtvQuanLySanPham.Location = new System.Drawing.Point(468, 0);
            this.dtvQuanLySanPham.Name = "dtvQuanLySanPham";
            this.dtvQuanLySanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvQuanLySanPham.Size = new System.Drawing.Size(965, 573);
            this.dtvQuanLySanPham.TabIndex = 0;
            this.dtvQuanLySanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvQuanLySanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 152.2843F;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 89.54315F;
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 89.54315F;
            this.Column5.HeaderText = "Loại sản phẩm";
            this.Column5.Name = "Column5";
            this.Column5.Width = 207;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 89.54315F;
            this.Column4.HeaderText = "Đơn vị trính";
            this.Column4.Name = "Column4";
            this.Column4.Width = 207;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 89.54315F;
            this.Column10.HeaderText = "Số lượng";
            this.Column10.Name = "Column10";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 89.54315F;
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            this.Column3.Width = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giá sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(106, 70);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(310, 20);
            this.txtTenSP.TabIndex = 2;
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "Ly",
            "Chai",
            "Gói",
            "Khác"});
            this.cboDonViTinh.Location = new System.Drawing.Point(106, 128);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(310, 21);
            this.cboDonViTinh.TabIndex = 3;
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Items.AddRange(new object[] {
            "Cà phê",
            "Nước giải khát",
            "Trà",
            "Thuốc",
            "Khác"});
            this.cbLoaiSanPham.Location = new System.Drawing.Point(105, 19);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(311, 21);
            this.cbLoaiSanPham.TabIndex = 3;
            this.cbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSanPham_SelectedIndexChanged);
            // 
            // nupSoLuongSP
            // 
            this.nupSoLuongSP.Location = new System.Drawing.Point(106, 186);
            this.nupSoLuongSP.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nupSoLuongSP.Name = "nupSoLuongSP";
            this.nupSoLuongSP.Size = new System.Drawing.Size(310, 20);
            this.nupSoLuongSP.TabIndex = 4;
            this.nupSoLuongSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupGiaSP
            // 
            this.nupGiaSP.Location = new System.Drawing.Point(106, 241);
            this.nupGiaSP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupGiaSP.Name = "nupGiaSP";
            this.nupGiaSP.Size = new System.Drawing.Size(310, 20);
            this.nupGiaSP.TabIndex = 5;
            this.nupGiaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupGiaSP.ThousandsSeparator = true;
            this.nupGiaSP.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.Yellow;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(10, 286);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(130, 31);
            this.btnThemSP.TabIndex = 6;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.Yellow;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Location = new System.Drawing.Point(318, 286);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(130, 31);
            this.btnXoaSP.TabIndex = 7;
            this.btnXoaSP.Text = "Xoá sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Location = new System.Drawing.Point(165, 286);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(130, 31);
            this.btnSuaSP.TabIndex = 8;
            this.btnSuaSP.Text = "Sửa sản phẩm";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.Yellow;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(10, 345);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(208, 31);
            this.btnXuatExcel.TabIndex = 6;
            this.btnXuatExcel.Text = "Xuất excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnNhapExcel
            // 
            this.btnNhapExcel.BackColor = System.Drawing.Color.Yellow;
            this.btnNhapExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapExcel.Location = new System.Drawing.Point(224, 345);
            this.btnNhapExcel.Name = "btnNhapExcel";
            this.btnNhapExcel.Size = new System.Drawing.Size(224, 31);
            this.btnNhapExcel.TabIndex = 6;
            this.btnNhapExcel.Text = "Nhập Excel";
            this.btnNhapExcel.UseVisualStyleBackColor = false;
            this.btnNhapExcel.Click += new System.EventHandler(this.btnNhapExcel_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnNhapExcel);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.nupGiaSP);
            this.Controls.Add(this.nupSoLuongSP);
            this.Controls.Add(this.cbLoaiSanPham);
            this.Controls.Add(this.cboDonViTinh);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvQuanLySanPham);
            this.Name = "QuanLySanPham";
            this.Size = new System.Drawing.Size(1433, 576);
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvQuanLySanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiaSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtvQuanLySanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.NumericUpDown nupSoLuongSP;
        private System.Windows.Forms.NumericUpDown nupGiaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnNhapExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
