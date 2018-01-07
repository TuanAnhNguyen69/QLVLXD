namespace QLVLXD.GUI.TrangChu
{
    partial class Login2
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
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.pic_Waiting = new System.Windows.Forms.PictureBox();
            this.pic_Background = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.BackColor = System.Drawing.Color.White;
            this.tb_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenDangNhap.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenDangNhap.Location = new System.Drawing.Point(228, 27);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(266, 40);
            this.tb_TenDangNhap.TabIndex = 0;
            this.tb_TenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_TenDangNhap_KeyDown);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(228, 73);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(266, 40);
            this.tb_Password.TabIndex = 0;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            // 
            // pic_Waiting
            // 
            this.pic_Waiting.Image = global::QLVLXD.Properties.Resources.giphy;
            this.pic_Waiting.Location = new System.Drawing.Point(177, 0);
            this.pic_Waiting.Name = "pic_Waiting";
            this.pic_Waiting.Size = new System.Drawing.Size(177, 171);
            this.pic_Waiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Waiting.TabIndex = 2;
            this.pic_Waiting.TabStop = false;
            // 
            // pic_Background
            // 
            this.pic_Background.BackColor = System.Drawing.Color.Transparent;
            this.pic_Background.BackgroundImage = global::QLVLXD.Properties.Resources.giphy2;
            this.pic_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Background.Location = new System.Drawing.Point(0, 0);
            this.pic_Background.Name = "pic_Background";
            this.pic_Background.Size = new System.Drawing.Size(532, 175);
            this.pic_Background.TabIndex = 3;
            this.pic_Background.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu: ";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Location = new System.Drawing.Point(163, 148);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_dangNhap.TabIndex = 6;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.Click += new System.EventHandler(this.lb_DangNhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(288, 148);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.lb_Thoat_Click);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::QLVLXD.Properties.Resources.giphy2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(532, 175);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_Waiting);
            this.Controls.Add(this.pic_Background);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_TenDangNhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login2";
            this.Shown += new System.EventHandler(this.Login2_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_TenDangNhap;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.PictureBox pic_Waiting;
        private System.Windows.Forms.PictureBox pic_Background;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_dangNhap;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
    }
}