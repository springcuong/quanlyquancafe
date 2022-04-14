namespace QuanLyQuanCaFe
{
    partial class GoiMon
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPhanLoaiSPGoiMon = new System.Windows.Forms.ComboBox();
            this.dtvDanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTienHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSuaHoaDon = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.nupSoLuongSP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvHoaDon = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhMucSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.cboPhanLoaiSPGoiMon);
            this.groupBox4.Controls.Add(this.dtvDanhMucSanPham);
            this.groupBox4.Location = new System.Drawing.Point(992, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(435, 566);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sản phẩm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTimKiem);
            // 
            // cboPhanLoaiSPGoiMon
            // 
            this.cboPhanLoaiSPGoiMon.FormattingEnabled = true;
            this.cboPhanLoaiSPGoiMon.Items.AddRange(new object[] {
            "Cà phê",
            "Trà",
            "Nước giải khát",
            "Thuốc",
            "Khác"});
            this.cboPhanLoaiSPGoiMon.Location = new System.Drawing.Point(8, 19);
            this.cboPhanLoaiSPGoiMon.Name = "cboPhanLoaiSPGoiMon";
            this.cboPhanLoaiSPGoiMon.Size = new System.Drawing.Size(342, 21);
            this.cboPhanLoaiSPGoiMon.TabIndex = 2;
            // 
            // dtvDanhMucSanPham
            // 
            this.dtvDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDanhMucSanPham.Location = new System.Drawing.Point(6, 50);
            this.dtvDanhMucSanPham.Name = "dtvDanhMucSanPham";
            this.dtvDanhMucSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvDanhMucSanPham.Size = new System.Drawing.Size(423, 510);
            this.dtvDanhMucSanPham.TabIndex = 1;
            this.dtvDanhMucSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.txtTienHang);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtvHoaDon);
            this.groupBox3.Location = new System.Drawing.Point(598, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 566);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(7, 513);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(376, 34);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh toán hoá đơn";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTienHang
            // 
            this.txtTienHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienHang.Location = new System.Drawing.Point(100, 458);
            this.txtTienHang.Multiline = true;
            this.txtTienHang.Name = "txtTienHang";
            this.txtTienHang.Size = new System.Drawing.Size(281, 42);
            this.txtTienHang.TabIndex = 6;
            this.txtTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnSuaHoaDon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nupSoLuongSP, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSuaHoaDon
            // 
            this.btnSuaHoaDon.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.sửa;
            this.btnSuaHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuaHoaDon.Location = new System.Drawing.Point(96, 3);
            this.btnSuaHoaDon.Name = "btnSuaHoaDon";
            this.btnSuaHoaDon.Size = new System.Drawing.Size(87, 35);
            this.btnSuaHoaDon.TabIndex = 3;
            this.btnSuaHoaDon.UseVisualStyleBackColor = true;
            this.btnSuaHoaDon.Click += new System.EventHandler(this.btnSuaHoaDon_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.xoá1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(189, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 35);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.thêm;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 35);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnThemSPVaoHoaDon);
            // 
            // nupSoLuongSP
            // 
            this.nupSoLuongSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nupSoLuongSP.Location = new System.Drawing.Point(282, 18);
            this.nupSoLuongSP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupSoLuongSP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSoLuongSP.Name = "nupSoLuongSP";
            this.nupSoLuongSP.Size = new System.Drawing.Size(89, 20);
            this.nupSoLuongSP.TabIndex = 4;
            this.nupSoLuongSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupSoLuongSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtvHoaDon
            // 
            this.dtvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.SL,
            this.DonGia,
            this.ThanhTien});
            this.dtvHoaDon.Location = new System.Drawing.Point(7, 58);
            this.dtvHoaDon.Name = "dtvHoaDon";
            this.dtvHoaDon.Size = new System.Drawing.Size(374, 386);
            this.dtvHoaDon.TabIndex = 0;
            this.dtvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên Món";
            this.Ten.Name = "Ten";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.Width = 50;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 566);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu A";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(427, 447);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 100);
            this.button14.TabIndex = 23;
            this.button14.Text = "12";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnBan);
            // 
            // button15
            // 
            this.button15.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Location = new System.Drawing.Point(231, 447);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 100);
            this.button15.TabIndex = 21;
            this.button15.Text = "11";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnBan);
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Location = new System.Drawing.Point(47, 447);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 100);
            this.button16.TabIndex = 19;
            this.button16.Text = "10";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnBan);
            // 
            // button17
            // 
            this.button17.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(427, 313);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 100);
            this.button17.TabIndex = 17;
            this.button17.Text = "9";
            this.button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnBan);
            // 
            // button18
            // 
            this.button18.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(231, 313);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(100, 100);
            this.button18.TabIndex = 15;
            this.button18.Text = "8";
            this.button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnBan);
            // 
            // button19
            // 
            this.button19.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Location = new System.Drawing.Point(47, 313);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 100);
            this.button19.TabIndex = 13;
            this.button19.Text = "7";
            this.button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btnBan);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(427, 169);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 11;
            this.button12.Text = "6";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnBan);
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Location = new System.Drawing.Point(231, 169);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 9;
            this.button13.Text = "5";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnBan);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(47, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 7;
            this.button10.Text = "4";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnBan);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(427, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 5;
            this.button11.Text = "3";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnBan);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(231, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 3;
            this.button9.Text = "2";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnBan);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.BackgroundImage = global::QuanLyQuanCaFe.Properties.Resources.bàn;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(44, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 1;
            this.button5.Tag = "";
            this.button5.Text = "1";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnBan);
            // 
            // GoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoiMon";
            this.Size = new System.Drawing.Size(1433, 576);
            this.Load += new System.EventHandler(this.GoiMon_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhMucSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cboPhanLoaiSPGoiMon;
        public System.Windows.Forms.DataGridView dtvDanhMucSanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSuaHoaDon;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown nupSoLuongSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnThanhToan;
    }
}
