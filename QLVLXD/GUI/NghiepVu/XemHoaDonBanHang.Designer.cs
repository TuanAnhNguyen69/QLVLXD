namespace QLVLXD.GUI.NghiepVu
{
    partial class XemHoaDonBanHang
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.cTHoaDonBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet16 = new QLVLXD.QLVLXDDataSet16();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCTHDBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHDBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongDeBanSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienKMKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTHoaDonBanHangTableAdapter = new QLVLXD.QLVLXDDataSet16TableAdapters.CTHoaDonBanHangTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_HinhThucKM = new System.Windows.Forms.Label();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TrangThai = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongTienKMKH = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongTienKhuyenMai = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongTienVatLieu = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoVatLieu = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongTien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.lb_LoaiKH = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_NgayLap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaHDBH = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenKH = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_NgayGiao = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_TenThongKe = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_XoaHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBanHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.DataSource = this.cTHoaDonBanHangBindingSource;
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Location = new System.Drawing.Point(14, 343);
            this.grid.MainView = this.gridView1;
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1307, 246);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cTHoaDonBanHangBindingSource
            // 
            this.cTHoaDonBanHangBindingSource.DataMember = "CTHoaDonBanHang";
            this.cTHoaDonBanHangBindingSource.DataSource = this.qLVLXDDataSet16;
            // 
            // qLVLXDDataSet16
            // 
            this.qLVLXDDataSet16.DataSetName = "QLVLXDDataSet16";
            this.qLVLXDDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCTHDBH,
            this.colMaHDBH,
            this.colTenVL,
            this.colSoLuongMua,
            this.colDonViTinh,
            this.colLive,
            this.colTinhTrangVL,
            this.colTenNCC,
            this.colSoLuongKM,
            this.colTongSL,
            this.colGiaLe,
            this.colGiaSi,
            this.colSoLuongDeBanSi,
            this.colTienKM,
            this.colTienKMKH,
            this.colTongTien,
            this.colGhiChu});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaCTHDBH
            // 
            this.colMaCTHDBH.FieldName = "MaCTHDBH";
            this.colMaCTHDBH.Name = "colMaCTHDBH";
            // 
            // colMaHDBH
            // 
            this.colMaHDBH.FieldName = "MaHDBH";
            this.colMaHDBH.Name = "colMaHDBH";
            // 
            // colTenVL
            // 
            this.colTenVL.Caption = "Tên Vật Liệu";
            this.colTenVL.FieldName = "TenVL";
            this.colTenVL.Name = "colTenVL";
            this.colTenVL.Visible = true;
            this.colTenVL.VisibleIndex = 0;
            this.colTenVL.Width = 78;
            // 
            // colSoLuongMua
            // 
            this.colSoLuongMua.Caption = "SL Mua";
            this.colSoLuongMua.FieldName = "SoLuongMua";
            this.colSoLuongMua.Name = "colSoLuongMua";
            this.colSoLuongMua.Visible = true;
            this.colSoLuongMua.VisibleIndex = 3;
            this.colSoLuongMua.Width = 78;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "ĐVT";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 2;
            this.colDonViTinh.Width = 78;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // colTinhTrangVL
            // 
            this.colTinhTrangVL.Caption = "Tình Trạng";
            this.colTinhTrangVL.FieldName = "TinhTrangVL";
            this.colTinhTrangVL.Name = "colTinhTrangVL";
            this.colTinhTrangVL.Visible = true;
            this.colTinhTrangVL.VisibleIndex = 9;
            this.colTinhTrangVL.Width = 78;
            // 
            // colTenNCC
            // 
            this.colTenNCC.Caption = "NCC";
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 1;
            this.colTenNCC.Width = 78;
            // 
            // colSoLuongKM
            // 
            this.colSoLuongKM.Caption = "SL KM";
            this.colSoLuongKM.FieldName = "SoLuongKM";
            this.colSoLuongKM.Name = "colSoLuongKM";
            this.colSoLuongKM.Visible = true;
            this.colSoLuongKM.VisibleIndex = 4;
            this.colSoLuongKM.Width = 78;
            // 
            // colTongSL
            // 
            this.colTongSL.Caption = "Tổng SL";
            this.colTongSL.FieldName = "TongSL";
            this.colTongSL.Name = "colTongSL";
            this.colTongSL.Visible = true;
            this.colTongSL.VisibleIndex = 5;
            this.colTongSL.Width = 78;
            // 
            // colGiaLe
            // 
            this.colGiaLe.Caption = "Giá Lẻ";
            this.colGiaLe.FieldName = "GiaLe";
            this.colGiaLe.Name = "colGiaLe";
            this.colGiaLe.Visible = true;
            this.colGiaLe.VisibleIndex = 6;
            this.colGiaLe.Width = 78;
            // 
            // colGiaSi
            // 
            this.colGiaSi.Caption = "Giá Sỉ";
            this.colGiaSi.FieldName = "GiaSi";
            this.colGiaSi.Name = "colGiaSi";
            this.colGiaSi.Visible = true;
            this.colGiaSi.VisibleIndex = 7;
            this.colGiaSi.Width = 78;
            // 
            // colSoLuongDeBanSi
            // 
            this.colSoLuongDeBanSi.Caption = "SL Bán Sỉ";
            this.colSoLuongDeBanSi.FieldName = "SoLuongDeBanSi";
            this.colSoLuongDeBanSi.Name = "colSoLuongDeBanSi";
            this.colSoLuongDeBanSi.Visible = true;
            this.colSoLuongDeBanSi.VisibleIndex = 8;
            this.colSoLuongDeBanSi.Width = 89;
            // 
            // colTienKM
            // 
            this.colTienKM.Caption = "Tiền KM";
            this.colTienKM.FieldName = "TienKM";
            this.colTienKM.Name = "colTienKM";
            this.colTienKM.Visible = true;
            this.colTienKM.VisibleIndex = 11;
            this.colTienKM.Width = 72;
            // 
            // colTienKMKH
            // 
            this.colTienKMKH.Caption = "Tiền VL";
            this.colTienKMKH.FieldName = "TienKMKH";
            this.colTienKMKH.Name = "colTienKMKH";
            this.colTienKMKH.Visible = true;
            this.colTienKMKH.VisibleIndex = 10;
            this.colTienKMKH.Width = 72;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 12;
            this.colTongTien.Width = 78;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 13;
            this.colGhiChu.Width = 89;
            // 
            // cTHoaDonBanHangTableAdapter
            // 
            this.cTHoaDonBanHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_HinhThucKM);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.labelControl24);
            this.groupBox2.Controls.Add(this.lb_TrangThai);
            this.groupBox2.Controls.Add(this.labelControl22);
            this.groupBox2.Controls.Add(this.lb_TongTienKMKH);
            this.groupBox2.Controls.Add(this.labelControl18);
            this.groupBox2.Controls.Add(this.lb_TongTienKhuyenMai);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.lb_TongTienVatLieu);
            this.groupBox2.Controls.Add(this.lb_SoVatLieu);
            this.groupBox2.Controls.Add(this.lb_TongTien);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Controls.Add(this.labelControl20);
            this.groupBox2.Controls.Add(this.lb_LoaiKH);
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.lb_NgayLap);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl16);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.lb_MaHDBH);
            this.groupBox2.Controls.Add(this.lb_TenKH);
            this.groupBox2.Controls.Add(this.lb_TenNV);
            this.groupBox2.Controls.Add(this.lb_NgayGiao);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1017, 321);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hóa Đơn";
            // 
            // lb_HinhThucKM
            // 
            this.lb_HinhThucKM.AutoSize = true;
            this.lb_HinhThucKM.BackColor = System.Drawing.Color.Transparent;
            this.lb_HinhThucKM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HinhThucKM.ForeColor = System.Drawing.Color.Black;
            this.lb_HinhThucKM.Location = new System.Drawing.Point(517, 197);
            this.lb_HinhThucKM.Name = "lb_HinhThucKM";
            this.lb_HinhThucKM.Size = new System.Drawing.Size(407, 18);
            this.lb_HinhThucKM.TabIndex = 132;
            this.lb_HinhThucKM.Text = "(Dữ liệu QAZWX EDCRFV TGBYHN UJMIKOLP TGBYH)";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl11.Location = new System.Drawing.Point(351, 194);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(160, 21);
            this.labelControl11.TabIndex = 120;
            this.labelControl11.Text = "Hình thức khuyến mãi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(744, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl24.Location = new System.Drawing.Point(351, 156);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(175, 21);
            this.labelControl24.TabIndex = 120;
            this.labelControl24.Text = "Khuyến mãi khách hàng";
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThai.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TrangThai.Location = new System.Drawing.Point(520, 279);
            this.lb_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(77, 21);
            this.lb_TrangThai.TabIndex = 124;
            this.lb_TrangThai.Text = "(Dữ liệu)";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl22.Location = new System.Drawing.Point(351, 117);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(159, 21);
            this.labelControl22.TabIndex = 121;
            this.labelControl22.Text = "Tổng tiền khuyến mãi";
            // 
            // lb_TongTienKMKH
            // 
            this.lb_TongTienKMKH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTienKMKH.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TongTienKMKH.Location = new System.Drawing.Point(520, 156);
            this.lb_TongTienKMKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TongTienKMKH.Name = "lb_TongTienKMKH";
            this.lb_TongTienKMKH.Size = new System.Drawing.Size(77, 21);
            this.lb_TongTienKMKH.TabIndex = 124;
            this.lb_TongTienKMKH.Text = "(Dữ liệu)";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl18.Location = new System.Drawing.Point(351, 76);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(129, 21);
            this.labelControl18.TabIndex = 122;
            this.labelControl18.Text = "Tổng tiền vật liệu";
            // 
            // lb_TongTienKhuyenMai
            // 
            this.lb_TongTienKhuyenMai.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTienKhuyenMai.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TongTienKhuyenMai.Location = new System.Drawing.Point(520, 117);
            this.lb_TongTienKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TongTienKhuyenMai.Name = "lb_TongTienKhuyenMai";
            this.lb_TongTienKhuyenMai.Size = new System.Drawing.Size(77, 21);
            this.lb_TongTienKhuyenMai.TabIndex = 125;
            this.lb_TongTienKhuyenMai.Text = "(Dữ liệu)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Location = new System.Drawing.Point(351, 235);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 24);
            this.labelControl7.TabIndex = 123;
            this.labelControl7.Text = "Tổng tiền:";
            // 
            // lb_TongTienVatLieu
            // 
            this.lb_TongTienVatLieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTienVatLieu.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TongTienVatLieu.Location = new System.Drawing.Point(520, 75);
            this.lb_TongTienVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TongTienVatLieu.Name = "lb_TongTienVatLieu";
            this.lb_TongTienVatLieu.Size = new System.Drawing.Size(77, 21);
            this.lb_TongTienVatLieu.TabIndex = 126;
            this.lb_TongTienVatLieu.Text = "(Dữ liệu)";
            // 
            // lb_SoVatLieu
            // 
            this.lb_SoVatLieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoVatLieu.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_SoVatLieu.Location = new System.Drawing.Point(520, 42);
            this.lb_SoVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_SoVatLieu.Name = "lb_SoVatLieu";
            this.lb_SoVatLieu.Size = new System.Drawing.Size(106, 21);
            this.lb_SoVatLieu.TabIndex = 129;
            this.lb_SoVatLieu.Text = "(Số vật liệu)";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_TongTien.Location = new System.Drawing.Point(520, 234);
            this.lb_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(113, 24);
            this.lb_TongTien.TabIndex = 127;
            this.lb_TongTien.Text = "(Tổng tiền)";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl8.Location = new System.Drawing.Point(351, 42);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(83, 21);
            this.labelControl8.TabIndex = 128;
            this.labelControl8.Text = "Số vật liệu:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl9.Location = new System.Drawing.Point(351, 279);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(76, 21);
            this.labelControl9.TabIndex = 130;
            this.labelControl9.Text = "Trạng thái";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl20.Location = new System.Drawing.Point(33, 239);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(119, 21);
            this.labelControl20.TabIndex = 114;
            this.labelControl20.Text = "Loại khách hàng";
            // 
            // lb_LoaiKH
            // 
            this.lb_LoaiKH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiKH.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_LoaiKH.Location = new System.Drawing.Point(153, 236);
            this.lb_LoaiKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_LoaiKH.Name = "lb_LoaiKH";
            this.lb_LoaiKH.Size = new System.Drawing.Size(183, 24);
            this.lb_LoaiKH.TabIndex = 116;
            this.lb_LoaiKH.Text = "(Loại khách hàng)";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl12.Location = new System.Drawing.Point(33, 194);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(119, 19);
            this.labelControl12.TabIndex = 115;
            this.labelControl12.Text = "Tên khách hàng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Location = new System.Drawing.Point(33, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 19);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // lb_NgayLap
            // 
            this.lb_NgayLap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayLap.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_NgayLap.Location = new System.Drawing.Point(153, 76);
            this.lb_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_NgayLap.Name = "lb_NgayLap";
            this.lb_NgayLap.Size = new System.Drawing.Size(90, 24);
            this.lb_NgayLap.TabIndex = 91;
            this.lb_NgayLap.Text = "(Dữ liệu)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Location = new System.Drawing.Point(33, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 21);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Ngày lập";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl16.Location = new System.Drawing.Point(33, 116);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(73, 19);
            this.labelControl16.TabIndex = 74;
            this.labelControl16.Text = "Ngày Giao";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Location = new System.Drawing.Point(33, 155);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 19);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "Tên nhân viên";
            // 
            // lb_MaHDBH
            // 
            this.lb_MaHDBH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHDBH.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_MaHDBH.Location = new System.Drawing.Point(153, 38);
            this.lb_MaHDBH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_MaHDBH.Name = "lb_MaHDBH";
            this.lb_MaHDBH.Size = new System.Drawing.Size(90, 24);
            this.lb_MaHDBH.TabIndex = 85;
            this.lb_MaHDBH.Text = "(Dữ liệu)";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKH.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lb_TenKH.Location = new System.Drawing.Point(153, 191);
            this.lb_TenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(90, 24);
            this.lb_TenKH.TabIndex = 91;
            this.lb_TenKH.Text = "(Dữ liệu)";
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNV.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TenNV.Location = new System.Drawing.Point(153, 155);
            this.lb_TenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(90, 24);
            this.lb_TenNV.TabIndex = 91;
            this.lb_TenNV.Text = "(Dữ liệu)";
            // 
            // lb_NgayGiao
            // 
            this.lb_NgayGiao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayGiao.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_NgayGiao.Location = new System.Drawing.Point(153, 117);
            this.lb_NgayGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_NgayGiao.Name = "lb_NgayGiao";
            this.lb_NgayGiao.Size = new System.Drawing.Size(90, 24);
            this.lb_NgayGiao.TabIndex = 91;
            this.lb_NgayGiao.Text = "(Dữ liệu)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_TenThongKe);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.btn_XoaHoaDon);
            this.groupBox1.Controls.Add(this.btn_In);
            this.groupBox1.Controls.Add(this.btn_XuatFile);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(1038, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(282, 320);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // tb_TenThongKe
            // 
            this.tb_TenThongKe.Location = new System.Drawing.Point(28, 68);
            this.tb_TenThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TenThongKe.Name = "tb_TenThongKe";
            this.tb_TenThongKe.Size = new System.Drawing.Size(229, 24);
            this.tb_TenThongKe.TabIndex = 95;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(188, 46);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 94;
            this.labelControl3.Text = "Tên hóa đơn";
            // 
            // btn_XoaHoaDon
            // 
            this.btn_XoaHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHoaDon.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaHoaDon.Appearance.Options.UseFont = true;
            this.btn_XoaHoaDon.Appearance.Options.UseForeColor = true;
            this.btn_XoaHoaDon.Image = global::QLVLXD.Properties.Resources.Delete_icon___Copy;
            this.btn_XoaHoaDon.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_XoaHoaDon.Location = new System.Drawing.Point(28, 150);
            this.btn_XoaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaHoaDon.Name = "btn_XoaHoaDon";
            this.btn_XoaHoaDon.Size = new System.Drawing.Size(230, 154);
            this.btn_XoaHoaDon.TabIndex = 0;
            this.btn_XoaHoaDon.Text = "Xóa hóa đơn\r\nvà thoát";
            this.btn_XoaHoaDon.Click += new System.EventHandler(this.btn_XoaHoaDon_Click);
            // 
            // btn_In
            // 
            this.btn_In.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.Appearance.Options.UseFont = true;
            this.btn_In.Location = new System.Drawing.Point(188, 101);
            this.btn_In.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(70, 42);
            this.btn_In.TabIndex = 0;
            this.btn_In.Text = "In";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatFile.Appearance.Options.UseFont = true;
            this.btn_XuatFile.Location = new System.Drawing.Point(28, 101);
            this.btn_XuatFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(153, 42);
            this.btn_XuatFile.TabIndex = 0;
            this.btn_XuatFile.Text = "Xuất ra File";
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // XemHoaDonBanHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XemHoaDonBanHang";
            this.Text = "XemHoaDonBanHang";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XemHoaDonBanHang_FormClosed);
            this.Load += new System.EventHandler(this.XemHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBanHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVLXDDataSet16 qLVLXDDataSet16;
        private System.Windows.Forms.BindingSource cTHoaDonBanHangBindingSource;
        private QLVLXDDataSet16TableAdapters.CTHoaDonBanHangTableAdapter cTHoaDonBanHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCTHDBH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDBH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVL;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongMua;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangVL;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongKM;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSL;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaLe;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaSi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongDeBanSi;
        private DevExpress.XtraGrid.Columns.GridColumn colTienKM;
        private DevExpress.XtraGrid.Columns.GridColumn colTienKMKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl lb_LoaiKH;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_NgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_MaHDBH;
        private DevExpress.XtraEditors.LabelControl lb_TenKH;
        private DevExpress.XtraEditors.LabelControl lb_TenNV;
        private DevExpress.XtraEditors.LabelControl lb_NgayGiao;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl lb_TongTienKMKH;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl lb_TongTienKhuyenMai;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lb_TongTienVatLieu;
        private DevExpress.XtraEditors.LabelControl lb_SoVatLieu;
        private DevExpress.XtraEditors.LabelControl lb_TongTien;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_XoaHoaDon;
        private DevExpress.XtraEditors.SimpleButton btn_In;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private DevExpress.XtraEditors.LabelControl lb_TrangThai;
        private System.Windows.Forms.TextBox tb_TenThongKe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_HinhThucKM;
    }
}