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
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.loaiKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.tb_TenLoaiKH = new DevExpress.XtraEditors.TextEdit();
            this.num_TriGiaHoaDonToiThieu = new System.Windows.Forms.NumericUpDown();
            this.num_PhanTramGiam = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_loaiKH = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MocTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenLoaiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanTramGiam)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_loaiKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(1049, 289);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 79);
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
            this.btn_Them.Location = new System.Drawing.Point(925, 289);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 79);
            this.btn_Them.TabIndex = 85;
            this.btn_Them.Text = "+";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(925, 378);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(218, 68);
            this.btn_Reset.TabIndex = 99;
            this.btn_Reset.Text = "Reset";
            // 
            // loaiKhachHangBindingSource
            // 
            this.loaiKhachHangBindingSource.DataMember = "LoaiKhachHang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(13, 39);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(95, 13);
            this.labelControl15.TabIndex = 80;
            this.labelControl15.Text = "Tên loại khách hàng";
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
            // num_TriGiaHoaDonToiThieu
            // 
            this.num_TriGiaHoaDonToiThieu.Location = new System.Drawing.Point(190, 84);
            this.num_TriGiaHoaDonToiThieu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_TriGiaHoaDonToiThieu.Name = "num_TriGiaHoaDonToiThieu";
            this.num_TriGiaHoaDonToiThieu.Size = new System.Drawing.Size(178, 21);
            this.num_TriGiaHoaDonToiThieu.TabIndex = 98;
            this.num_TriGiaHoaDonToiThieu.ThousandsSeparator = true;
            // 
            // num_PhanTramGiam
            // 
            this.num_PhanTramGiam.DecimalPlaces = 1;
            this.num_PhanTramGiam.Location = new System.Drawing.Point(190, 119);
            this.num_PhanTramGiam.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_PhanTramGiam.Name = "num_PhanTramGiam";
            this.num_PhanTramGiam.Size = new System.Drawing.Size(178, 21);
            this.num_PhanTramGiam.TabIndex = 98;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Phần trăm giảm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 80;
            this.labelControl2.Text = "Mốc tiêu thụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.num_PhanTramGiam);
            this.groupBox1.Controls.Add(this.num_TriGiaHoaDonToiThieu);
            this.groupBox1.Controls.Add(this.tb_TenLoaiKH);
            this.groupBox1.Controls.Add(this.labelControl15);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 157);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại khách hàng";
            // 
            // grid_loaiKH
            // 
            this.grid_loaiKH.AllowUserToAddRows = false;
            this.grid_loaiKH.AllowUserToDeleteRows = false;
            this.grid_loaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_loaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.Loai,
            this.MocTieuThu,
            this.Giam});
            this.grid_loaiKH.Location = new System.Drawing.Point(262, 12);
            this.grid_loaiKH.Name = "grid_loaiKH";
            this.grid_loaiKH.ReadOnly = true;
            this.grid_loaiKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_loaiKH.Size = new System.Drawing.Size(881, 255);
            this.grid_loaiKH.TabIndex = 104;
            this.grid_loaiKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_loaiKH_CellContentClick);
            // 
            // MaLoai
            // 
            this.MaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoai.HeaderText = "Mã loại khách hàng";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Loai.HeaderText = "Loại khách hàng";
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            // 
            // MocTieuThu
            // 
            this.MocTieuThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MocTieuThu.HeaderText = "Mốc tiêu thụ";
            this.MocTieuThu.Name = "MocTieuThu";
            this.MocTieuThu.ReadOnly = true;
            // 
            // Giam
            // 
            this.Giam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Giam.HeaderText = "Phần trăm giảm";
            this.Giam.Name = "Giam";
            this.Giam.ReadOnly = true;
            // 
            // QuyDinhKH_NCC
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 451);
            this.Controls.Add(this.grid_loaiKH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuyDinhKH_NCC";
            this.Text = "Quy Định Về Khách Hàng";
            this.Load += new System.EventHandler(this.QuyDinhKH_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenLoaiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanTramGiam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_loaiKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private System.Windows.Forms.BindingSource loaiKhachHangBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit tb_TenLoaiKH;
        private System.Windows.Forms.NumericUpDown num_TriGiaHoaDonToiThieu;
        private System.Windows.Forms.NumericUpDown num_PhanTramGiam;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_loaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MocTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giam;
    }
}