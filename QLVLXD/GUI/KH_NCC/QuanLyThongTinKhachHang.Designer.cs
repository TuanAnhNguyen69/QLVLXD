namespace QLVLXD
{
    partial class KhachHang
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
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_LoaiKH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ResetThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dtP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_CongNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            this.grid_khachhang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            // 
            // cbb_LoaiKH
            // 
            this.cbb_LoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiKH.FormattingEnabled = true;
            this.cbb_LoaiKH.Location = new System.Drawing.Point(386, 190);
            this.cbb_LoaiKH.Name = "cbb_LoaiKH";
            this.cbb_LoaiKH.Size = new System.Drawing.Size(157, 21);
            this.cbb_LoaiKH.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(300, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Loại KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Số điện thoại";
            // 
            // btn_ResetThongTin
            // 
            this.btn_ResetThongTin.Location = new System.Drawing.Point(765, 155);
            this.btn_ResetThongTin.Name = "btn_ResetThongTin";
            this.btn_ResetThongTin.Size = new System.Drawing.Size(160, 23);
            this.btn_ResetThongTin.TabIndex = 61;
            this.btn_ResetThongTin.Text = "Reset thông tin";
            this.btn_ResetThongTin.Click += new System.EventHandler(this.btn_ResetThongTin_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Location = new System.Drawing.Point(765, 105);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(160, 38);
            this.btn_CapNhat.TabIndex = 60;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(765, 60);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(160, 38);
            this.btn_Xoa.TabIndex = 59;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(766, 15);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(160, 38);
            this.btn_Them.TabIndex = 58;
            this.btn_Them.Text = "Thêm \r\nKhách \r\nHàng";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(386, 147);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(157, 20);
            this.txt_Email.TabIndex = 57;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(386, 104);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(157, 20);
            this.txt_CMND.TabIndex = 56;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress_1);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(387, 65);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(157, 20);
            this.txt_SDT.TabIndex = 55;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress_1);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(107, 192);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(169, 20);
            this.txt_DiaChi.TabIndex = 54;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Location = new System.Drawing.Point(107, 147);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(169, 21);
            this.cbb_GioiTinh.TabIndex = 53;
            // 
            // dtP_NgaySinh
            // 
            this.dtP_NgaySinh.Location = new System.Drawing.Point(107, 104);
            this.dtP_NgaySinh.Name = "dtP_NgaySinh";
            this.dtP_NgaySinh.Size = new System.Drawing.Size(169, 20);
            this.dtP_NgaySinh.TabIndex = 52;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(107, 64);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Properties.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.txt_TenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKH.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TenKH.Size = new System.Drawing.Size(169, 20);
            this.txt_TenKH.TabIndex = 51;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(103, 23);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(104, 16);
            this.lb_MaKH.TabIndex = 50;
            this.lb_MaKH.Text = "(Mã khách hàng)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_LoaiKH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_CongNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.cbb_GioiTinh);
            this.groupBox1.Controls.Add(this.dtP_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.lb_MaKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(210, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 214);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng";
            // 
            // lb_CongNo
            // 
            this.lb_CongNo.AutoSize = true;
            this.lb_CongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CongNo.Location = new System.Drawing.Point(384, 26);
            this.lb_CongNo.Name = "lb_CongNo";
            this.lb_CongNo.Size = new System.Drawing.Size(59, 13);
            this.lb_CongNo.TabIndex = 62;
            this.lb_CongNo.Text = "(Dữ Liệu)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(300, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Công nợ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources.user_customer;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Location = new System.Drawing.Point(766, 185);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(93, 35);
            this.btn_XuatFile.TabIndex = 93;
            this.btn_XuatFile.Text = "Xuất ra File\r";
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(865, 185);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(61, 35);
            this.btn_In.TabIndex = 92;
            this.btn_In.Text = "In\r\n";
            // 
            // grid_khachhang
            // 
            this.grid_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.CMND,
            this.Email,
            this.LoaiKH,
            this.CongNo});
            this.grid_khachhang.Location = new System.Drawing.Point(12, 231);
            this.grid_khachhang.Name = "grid_khachhang";
            this.grid_khachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_khachhang.Size = new System.Drawing.Size(914, 248);
            this.grid_khachhang.TabIndex = 65;
            this.grid_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_khachhang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = false;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên";
            this.TenKH.Name = "TenKH";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.Name = "LoaiKH";
            // 
            // CongNo
            // 
            this.CongNo.HeaderText = "Công nợ";
            this.CongNo.Name = "CongNo";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.grid_khachhang);
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ResetThongTin);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang";
            this.Text = "Quản Lý Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.VisibleChanged += new System.EventHandler(this.KhachHang_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_LoaiKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_ResetThongTin;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.DateTimePicker dtP_NgaySinh;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_CongNo;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private DevExpress.XtraEditors.SimpleButton btn_In;
        private System.Windows.Forms.DataGridView grid_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongNo;
    }
}