namespace QLVLXD.GUI.KH_NCC
{
    partial class QuyDinhKH_NCC
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
            this.components = new System.ComponentModel.Container();
            this.num_SoLanMuaToiThieu = new System.Windows.Forms.NumericUpDown();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tb_TenLoaiKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.num_PhanGiamGiamLanMuaCuoi = new System.Windows.Forms.NumericUpDown();
            this.num_TriGiaHoaDonToiThieuMoiLanMua = new System.Windows.Forms.NumericUpDown();
            this.num_TriGiaHoaDonToiThieu = new System.Windows.Forms.NumericUpDown();
            this.num_PhanTramGiam = new System.Windows.Forms.NumericUpDown();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.loaiKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet20 = new QLVLXD.QLVLXDDataSet20();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLanMuaToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTriGiaToiThieuMoiLanMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanTramGiamLanMuaCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTriGiaHoaDonToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanTramGiam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaiKhachHangTableAdapter = new QLVLXD.QLVLXDDataSet20TableAdapters.LoaiKhachHangTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_SoLanMua = new System.Windows.Forms.RadioButton();
            this.r_TriGia = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLanMuaToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenLoaiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanGiamGiamLanMuaCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieuMoiLanMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanTramGiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_SoLanMuaToiThieu
            // 
            this.num_SoLanMuaToiThieu.Location = new System.Drawing.Point(189, 94);
            this.num_SoLanMuaToiThieu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_SoLanMuaToiThieu.Name = "num_SoLanMuaToiThieu";
            this.num_SoLanMuaToiThieu.Size = new System.Drawing.Size(147, 21);
            this.num_SoLanMuaToiThieu.TabIndex = 98;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(1045, 328);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 79);
            this.btn_Xoa.TabIndex = 87;
            this.btn_Xoa.Text = "-";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(947, 328);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(92, 79);
            this.btn_Them.TabIndex = 85;
            this.btn_Them.Text = "+";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(13, 39);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(95, 13);
            this.labelControl15.TabIndex = 80;
            this.labelControl15.Text = "Tên loại khách hàng";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(13, 98);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(94, 13);
            this.labelControl10.TabIndex = 77;
            this.labelControl10.Text = "Số lần mua tối thiểu";
            // 
            // tb_TenLoaiKH
            // 
            this.tb_TenLoaiKH.Location = new System.Drawing.Point(190, 36);
            this.tb_TenLoaiKH.Name = "tb_TenLoaiKH";
            this.tb_TenLoaiKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenLoaiKH.Properties.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.tb_TenLoaiKH.Properties.Appearance.Options.UseFont = true;
            this.tb_TenLoaiKH.Properties.Appearance.Options.UseForeColor = true;
            this.tb_TenLoaiKH.Size = new System.Drawing.Size(456, 20);
            this.tb_TenLoaiKH.TabIndex = 75;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 130);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 13);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "Phần trăm giảm lần mua cuối";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(346, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 13);
            this.labelControl2.TabIndex = 80;
            this.labelControl2.Text = "Trị giá hóa đơn tối thiểu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(346, 168);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Phần trăm giảm";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(947, 417);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(180, 46);
            this.btn_Reset.TabIndex = 99;
            this.btn_Reset.Text = "Reset";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 13);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Trị giá tối thiểu mỗi lần mua";
            // 
            // num_PhanGiamGiamLanMuaCuoi
            // 
            this.num_PhanGiamGiamLanMuaCuoi.DecimalPlaces = 1;
            this.num_PhanGiamGiamLanMuaCuoi.Location = new System.Drawing.Point(189, 128);
            this.num_PhanGiamGiamLanMuaCuoi.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_PhanGiamGiamLanMuaCuoi.Name = "num_PhanGiamGiamLanMuaCuoi";
            this.num_PhanGiamGiamLanMuaCuoi.Size = new System.Drawing.Size(147, 21);
            this.num_PhanGiamGiamLanMuaCuoi.TabIndex = 98;
            // 
            // num_TriGiaHoaDonToiThieuMoiLanMua
            // 
            this.num_TriGiaHoaDonToiThieuMoiLanMua.Location = new System.Drawing.Point(189, 163);
            this.num_TriGiaHoaDonToiThieuMoiLanMua.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_TriGiaHoaDonToiThieuMoiLanMua.Name = "num_TriGiaHoaDonToiThieuMoiLanMua";
            this.num_TriGiaHoaDonToiThieuMoiLanMua.Size = new System.Drawing.Size(147, 21);
            this.num_TriGiaHoaDonToiThieuMoiLanMua.TabIndex = 98;
            this.num_TriGiaHoaDonToiThieuMoiLanMua.ThousandsSeparator = true;
            // 
            // num_TriGiaHoaDonToiThieu
            // 
            this.num_TriGiaHoaDonToiThieu.Location = new System.Drawing.Point(497, 131);
            this.num_TriGiaHoaDonToiThieu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_TriGiaHoaDonToiThieu.Name = "num_TriGiaHoaDonToiThieu";
            this.num_TriGiaHoaDonToiThieu.Size = new System.Drawing.Size(147, 21);
            this.num_TriGiaHoaDonToiThieu.TabIndex = 98;
            this.num_TriGiaHoaDonToiThieu.ThousandsSeparator = true;
            // 
            // num_PhanTramGiam
            // 
            this.num_PhanTramGiam.DecimalPlaces = 1;
            this.num_PhanTramGiam.Location = new System.Drawing.Point(497, 166);
            this.num_PhanTramGiam.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_PhanTramGiam.Name = "num_PhanTramGiam";
            this.num_PhanTramGiam.Size = new System.Drawing.Size(147, 21);
            this.num_PhanTramGiam.TabIndex = 98;
            // 
            // grid
            // 
            this.grid.DataSource = this.loaiKhachHangBindingSource;
            this.grid.Location = new System.Drawing.Point(262, 12);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1049, 265);
            this.grid.TabIndex = 101;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loaiKhachHangBindingSource
            // 
            this.loaiKhachHangBindingSource.DataMember = "LoaiKhachHang";
            this.loaiKhachHangBindingSource.DataSource = this.qLVLXDDataSet20;
            // 
            // qLVLXDDataSet20
            // 
            this.qLVLXDDataSet20.DataSetName = "QLVLXDDataSet20";
            this.qLVLXDDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiKH,
            this.colTenLoaiKH,
            this.colSoLanMuaToiThieu,
            this.colTriGiaToiThieuMoiLanMua,
            this.colPhanTramGiamLanMuaCuoi,
            this.colTriGiaHoaDonToiThieu,
            this.colPhanTramGiam,
            this.colLive});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaLoaiKH
            // 
            this.colMaLoaiKH.FieldName = "MaLoaiKH";
            this.colMaLoaiKH.Name = "colMaLoaiKH";
            // 
            // colTenLoaiKH
            // 
            this.colTenLoaiKH.Caption = "Tên Loại Khách Hàng";
            this.colTenLoaiKH.FieldName = "TenLoaiKH";
            this.colTenLoaiKH.Name = "colTenLoaiKH";
            this.colTenLoaiKH.Visible = true;
            this.colTenLoaiKH.VisibleIndex = 0;
            this.colTenLoaiKH.Width = 146;
            // 
            // colSoLanMuaToiThieu
            // 
            this.colSoLanMuaToiThieu.Caption = "Số Lần Mua Tối Thiểu";
            this.colSoLanMuaToiThieu.FieldName = "SoLanMuaToiThieu";
            this.colSoLanMuaToiThieu.Name = "colSoLanMuaToiThieu";
            this.colSoLanMuaToiThieu.Visible = true;
            this.colSoLanMuaToiThieu.VisibleIndex = 1;
            this.colSoLanMuaToiThieu.Width = 146;
            // 
            // colTriGiaToiThieuMoiLanMua
            // 
            this.colTriGiaToiThieuMoiLanMua.Caption = "Trị Giá Tối Thiểu Mỗi Lần Mua";
            this.colTriGiaToiThieuMoiLanMua.FieldName = "TriGiaToiThieuMoiLanMua";
            this.colTriGiaToiThieuMoiLanMua.Name = "colTriGiaToiThieuMoiLanMua";
            this.colTriGiaToiThieuMoiLanMua.Visible = true;
            this.colTriGiaToiThieuMoiLanMua.VisibleIndex = 2;
            this.colTriGiaToiThieuMoiLanMua.Width = 159;
            // 
            // colPhanTramGiamLanMuaCuoi
            // 
            this.colPhanTramGiamLanMuaCuoi.Caption = "Phần Trăm Giảm Lần Mua Cuối";
            this.colPhanTramGiamLanMuaCuoi.FieldName = "PhanTramGiamLanMuaCuoi";
            this.colPhanTramGiamLanMuaCuoi.Name = "colPhanTramGiamLanMuaCuoi";
            this.colPhanTramGiamLanMuaCuoi.Visible = true;
            this.colPhanTramGiamLanMuaCuoi.VisibleIndex = 3;
            this.colPhanTramGiamLanMuaCuoi.Width = 203;
            // 
            // colTriGiaHoaDonToiThieu
            // 
            this.colTriGiaHoaDonToiThieu.Caption = "Trị Giá Hóa Đơn Tối Thiểu";
            this.colTriGiaHoaDonToiThieu.FieldName = "TriGiaHoaDonToiThieu";
            this.colTriGiaHoaDonToiThieu.Name = "colTriGiaHoaDonToiThieu";
            this.colTriGiaHoaDonToiThieu.Visible = true;
            this.colTriGiaHoaDonToiThieu.VisibleIndex = 4;
            this.colTriGiaHoaDonToiThieu.Width = 130;
            // 
            // colPhanTramGiam
            // 
            this.colPhanTramGiam.Caption = "Phần Trăm Giảm";
            this.colPhanTramGiam.FieldName = "PhanTramGiam";
            this.colPhanTramGiam.Name = "colPhanTramGiam";
            this.colPhanTramGiam.Visible = true;
            this.colPhanTramGiam.VisibleIndex = 5;
            this.colPhanTramGiam.Width = 97;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // loaiKhachHangTableAdapter
            // 
            this.loaiKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_SoLanMua);
            this.groupBox1.Controls.Add(this.r_TriGia);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.num_TriGiaHoaDonToiThieuMoiLanMua);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.num_PhanGiamGiamLanMuaCuoi);
            this.groupBox1.Controls.Add(this.num_PhanTramGiam);
            this.groupBox1.Controls.Add(this.num_SoLanMuaToiThieu);
            this.groupBox1.Controls.Add(this.num_TriGiaHoaDonToiThieu);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.tb_TenLoaiKH);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl15);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 196);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại khách hàng";
            // 
            // r_SoLanMua
            // 
            this.r_SoLanMua.AutoSize = true;
            this.r_SoLanMua.Location = new System.Drawing.Point(13, 66);
            this.r_SoLanMua.Name = "r_SoLanMua";
            this.r_SoLanMua.Size = new System.Drawing.Size(190, 17);
            this.r_SoLanMua.TabIndex = 99;
            this.r_SoLanMua.TabStop = true;
            this.r_SoLanMua.Text = "Giảm giá dựa trên số lần mua";
            this.r_SoLanMua.UseVisualStyleBackColor = true;
            this.r_SoLanMua.CheckedChanged += new System.EventHandler(this.r_SoLanMua_CheckedChanged);
            // 
            // r_TriGia
            // 
            this.r_TriGia.AutoSize = true;
            this.r_TriGia.Location = new System.Drawing.Point(346, 66);
            this.r_TriGia.Name = "r_TriGia";
            this.r_TriGia.Size = new System.Drawing.Size(212, 17);
            this.r_TriGia.TabIndex = 99;
            this.r_TriGia.TabStop = true;
            this.r_TriGia.Text = "Giảm giá dựa trên Trị giá hóa đơn";
            this.r_TriGia.UseVisualStyleBackColor = true;
            this.r_TriGia.CheckedChanged += new System.EventHandler(this.r_TriGia_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources.digital_marketing;
            this.pictureBox1.Location = new System.Drawing.Point(14, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // QuyDinhKH_NCC
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuyDinhKH_NCC";
            this.Text = "Quy Định Về Khách Hàng";
            this.Load += new System.EventHandler(this.QuyDinhKH_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLanMuaToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenLoaiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanGiamGiamLanMuaCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieuMoiLanMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanTramGiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_SoLanMuaToiThieu;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit tb_TenLoaiKH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown num_PhanGiamGiamLanMuaCuoi;
        private System.Windows.Forms.NumericUpDown num_TriGiaHoaDonToiThieuMoiLanMua;
        private System.Windows.Forms.NumericUpDown num_TriGiaHoaDonToiThieu;
        private System.Windows.Forms.NumericUpDown num_PhanTramGiam;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVLXDDataSet20 qLVLXDDataSet20;
        private System.Windows.Forms.BindingSource loaiKhachHangBindingSource;
        private QLVLXDDataSet20TableAdapters.LoaiKhachHangTableAdapter loaiKhachHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLanMuaToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTriGiaToiThieuMoiLanMua;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanTramGiamLanMuaCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTriGiaHoaDonToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanTramGiam;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r_SoLanMua;
        private System.Windows.Forms.RadioButton r_TriGia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}