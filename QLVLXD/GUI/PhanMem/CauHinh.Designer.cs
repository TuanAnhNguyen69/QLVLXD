namespace QLVLXD.GUI.PhanMem
{
    partial class CauHinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_SoLuongToiThieu = new System.Windows.Forms.NumericUpDown();
            this.num_ThoiGianKiemTra = new System.Windows.Forms.NumericUpDown();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuongToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ThoiGianKiemTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỐ LƯỢNG VẬT LIỆU TỐI THIỂU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "THỜI GIAN KIỂM TRA CSDL ĐỊNH KỲ";
            // 
            // num_SoLuongToiThieu
            // 
            this.num_SoLuongToiThieu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_SoLuongToiThieu.ForeColor = System.Drawing.Color.Purple;
            this.num_SoLuongToiThieu.Location = new System.Drawing.Point(650, 348);
            this.num_SoLuongToiThieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_SoLuongToiThieu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_SoLuongToiThieu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SoLuongToiThieu.Name = "num_SoLuongToiThieu";
            this.num_SoLuongToiThieu.Size = new System.Drawing.Size(111, 32);
            this.num_SoLuongToiThieu.TabIndex = 1;
            this.num_SoLuongToiThieu.ThousandsSeparator = true;
            this.num_SoLuongToiThieu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_ThoiGianKiemTra
            // 
            this.num_ThoiGianKiemTra.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_ThoiGianKiemTra.ForeColor = System.Drawing.Color.Purple;
            this.num_ThoiGianKiemTra.Location = new System.Drawing.Point(650, 398);
            this.num_ThoiGianKiemTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_ThoiGianKiemTra.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_ThoiGianKiemTra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ThoiGianKiemTra.Name = "num_ThoiGianKiemTra";
            this.num_ThoiGianKiemTra.Size = new System.Drawing.Size(111, 32);
            this.num_ThoiGianKiemTra.TabIndex = 1;
            this.num_ThoiGianKiemTra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Luu
            // 
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(411, 453);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(166, 83);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources._1366377136497284388setup_svg_med;
            this.pictureBox1.Location = new System.Drawing.Point(358, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "PHÚT";
            // 
            // CauHinh
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.num_ThoiGianKiemTra);
            this.Controls.Add(this.num_SoLuongToiThieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CauHinh";
            this.Text = "V";
            this.Load += new System.EventHandler(this.CauHinh_Load);
            this.VisibleChanged += new System.EventHandler(this.CauHinh_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuongToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ThoiGianKiemTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_SoLuongToiThieu;
        private System.Windows.Forms.NumericUpDown num_ThoiGianKiemTra;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}