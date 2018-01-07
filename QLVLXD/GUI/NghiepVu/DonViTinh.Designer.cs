namespace QLVLXD.GUI.NghiepVu
{
    partial class DonViTinh
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
            this.btn_XoaDVT = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemDVT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.tb_DonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_DVT = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.quanLyDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTienTeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhTrangVatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DonViTinh.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDonViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienTeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangVatLieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaDVT
            // 
            this.btn_XoaDVT.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDVT.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaDVT.Appearance.Options.UseFont = true;
            this.btn_XoaDVT.Appearance.Options.UseForeColor = true;
            this.btn_XoaDVT.Location = new System.Drawing.Point(715, 390);
            this.btn_XoaDVT.Name = "btn_XoaDVT";
            this.btn_XoaDVT.Size = new System.Drawing.Size(32, 23);
            this.btn_XoaDVT.TabIndex = 88;
            this.btn_XoaDVT.Text = "-";
            this.btn_XoaDVT.Click += new System.EventHandler(this.btn_XoaDVT_Click);
            // 
            // btn_ThemDVT
            // 
            this.btn_ThemDVT.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDVT.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn_ThemDVT.Appearance.Options.UseFont = true;
            this.btn_ThemDVT.Appearance.Options.UseForeColor = true;
            this.btn_ThemDVT.Location = new System.Drawing.Point(677, 390);
            this.btn_ThemDVT.Name = "btn_ThemDVT";
            this.btn_ThemDVT.Size = new System.Drawing.Size(32, 23);
            this.btn_ThemDVT.TabIndex = 86;
            this.btn_ThemDVT.Text = "+";
            this.btn_ThemDVT.Click += new System.EventHandler(this.btn_ThemDVT_Click);
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(380, 396);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(75, 13);
            this.labelControl18.TabIndex = 79;
            this.labelControl18.Text = "Tên Đơn Vị Tính";
            // 
            // tb_DonViTinh
            // 
            this.tb_DonViTinh.Location = new System.Drawing.Point(472, 393);
            this.tb_DonViTinh.Name = "tb_DonViTinh";
            this.tb_DonViTinh.Size = new System.Drawing.Size(196, 20);
            this.tb_DonViTinh.TabIndex = 76;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_DVT);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btn_XoaDVT);
            this.groupBox2.Controls.Add(this.tb_DonViTinh);
            this.groupBox2.Controls.Add(this.btn_ThemDVT);
            this.groupBox2.Controls.Add(this.labelControl18);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 467);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Đơn Vị Tính";
            // 
            // grid_DVT
            // 
            this.grid_DVT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_DVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.DVT});
            this.grid_DVT.Location = new System.Drawing.Point(6, 101);
            this.grid_DVT.Name = "grid_DVT";
            this.grid_DVT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DVT.Size = new System.Drawing.Size(1108, 283);
            this.grid_DVT.TabIndex = 90;
            this.grid_DVT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DVT_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLVLXD.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(501, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // quanLyDonViTinhBindingSource
            // 
            this.quanLyDonViTinhBindingSource.DataMember = "QuanLyDonViTinh";
            // 
            // quanLyTienTeBindingSource
            // 
            this.quanLyTienTeBindingSource.DataMember = "QuanLyTienTe";
            // 
            // tinhTrangVatLieuBindingSource
            // 
            this.tinhTrangVatLieuBindingSource.DataMember = "TinhTrangVatLieu";
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaDV.HeaderText = "Mã đơn vị tính";
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 80;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // DonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 491);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonViTinh";
            this.Text = "TienTeDonViTinhLoaiVatLieu";
            ((System.ComponentModel.ISupportInitialize)(this.tb_DonViTinh.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDonViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienTeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangVatLieuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_XoaDVT;
        private DevExpress.XtraEditors.SimpleButton btn_ThemDVT;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit tb_DonViTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource quanLyTienTeBindingSource;
        private System.Windows.Forms.BindingSource quanLyDonViTinhBindingSource;
        private System.Windows.Forms.BindingSource tinhTrangVatLieuBindingSource;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView grid_DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
    }
}