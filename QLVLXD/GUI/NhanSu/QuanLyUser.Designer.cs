namespace QLVLXD.GUI.NhanSu
{
    partial class QuanLyUser
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
            this.cbb_PhanQuyen = new System.Windows.Forms.ComboBox();
            this.btn_ResetThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_QuanlyUser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cb_TenNhanVien = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanlyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_PhanQuyen
            // 
            this.cbb_PhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PhanQuyen.FormattingEnabled = true;
            this.cbb_PhanQuyen.Location = new System.Drawing.Point(111, 130);
            this.cbb_PhanQuyen.Name = "cbb_PhanQuyen";
            this.cbb_PhanQuyen.Size = new System.Drawing.Size(443, 21);
            this.cbb_PhanQuyen.TabIndex = 29;
            // 
            // btn_ResetThongTin
            // 
            this.btn_ResetThongTin.Location = new System.Drawing.Point(235, 189);
            this.btn_ResetThongTin.Name = "btn_ResetThongTin";
            this.btn_ResetThongTin.Size = new System.Drawing.Size(92, 23);
            this.btn_ResetThongTin.TabIndex = 28;
            this.btn_ResetThongTin.Text = "Reset";
            this.btn_ResetThongTin.Click += new System.EventHandler(this.btn_ResetThongTin_Click);
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemChiTiet.Appearance.Options.UseFont = true;
            this.btn_XemChiTiet.Location = new System.Drawing.Point(808, 83);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(177, 59);
            this.btn_XemChiTiet.TabIndex = 27;
            this.btn_XemChiTiet.Text = "Xem chi tiết nhân viên";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(808, 20);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(177, 57);
            this.btn_Xoa.TabIndex = 26;
            this.btn_Xoa.Text = "Xóa tài khoản";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(808, 150);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(177, 58);
            this.btn_Them.TabIndex = 24;
            this.btn_Them.Text = "Thêm User";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Phân quyền";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(111, 57);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(443, 20);
            this.txt_TenDangNhap.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Password";
            // 
            // gridControl_QuanlyUser
            // 
            this.gridControl_QuanlyUser.Location = new System.Drawing.Point(10, 225);
            this.gridControl_QuanlyUser.MainView = this.gridView1;
            this.gridControl_QuanlyUser.Name = "gridControl_QuanlyUser";
            this.gridControl_QuanlyUser.Size = new System.Drawing.Size(978, 255);
            this.gridControl_QuanlyUser.TabIndex = 30;
            this.gridControl_QuanlyUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_QuanlyUser.MouseCaptureChanged += new System.EventHandler(this.gridControl_QuanlyUser_MouseCaptureChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colPassword,
            this.colMaNV,
            this.colPhanQuyen});
            this.gridView1.GridControl = this.gridControl_QuanlyUser;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Caption = "Tên Đăng Nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã Nhân Viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 1;
            // 
            // colPhanQuyen
            // 
            this.colPhanQuyen.Caption = "Phân Quyền";
            this.colPhanQuyen.FieldName = "PhanQuyen";
            this.colPhanQuyen.Name = "colPhanQuyen";
            this.colPhanQuyen.Visible = true;
            this.colPhanQuyen.VisibleIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.cb_TenNhanVien);
            this.groupBox1.Controls.Add(this.cbb_PhanQuyen);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(235, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 172);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(111, 92);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(443, 21);
            this.txt_Password.TabIndex = 30;
            // 
            // cb_TenNhanVien
            // 
            this.cb_TenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenNhanVien.FormattingEnabled = true;
            this.cb_TenNhanVien.Location = new System.Drawing.Point(111, 20);
            this.cb_TenNhanVien.Name = "cb_TenNhanVien";
            this.cb_TenNhanVien.Size = new System.Drawing.Size(443, 21);
            this.cb_TenNhanVien.TabIndex = 29;
            this.cb_TenNhanVien.SelectedIndexChanged += new System.EventHandler(this.cb_TenNhanVien_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Nhân Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources.customers_icon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 208);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLyUser
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl_QuanlyUser);
            this.Controls.Add(this.btn_ResetThongTin);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_XemChiTiet);
            this.Controls.Add(this.btn_Xoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyUser";
            this.Text = "QuanLyUser";
            this.Load += new System.EventHandler(this.QuanLyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanlyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_PhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btn_ResetThongTin;
        private DevExpress.XtraEditors.SimpleButton btn_XemChiTiet;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl_QuanlyUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanQuyen;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}