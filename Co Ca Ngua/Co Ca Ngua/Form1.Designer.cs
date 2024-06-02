namespace Co_Ca_Ngua
{
    partial class Form1
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
            this.btnDoXN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.lklDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.pnlDoiMatKhau = new System.Windows.Forms.Panel();
            this.btnHuyDMK = new System.Windows.Forms.Button();
            this.btnXacNhanDMK = new System.Windows.Forms.Button();
            this.lblXNMKmoi = new System.Windows.Forms.Label();
            this.txtXNMKmoi = new System.Windows.Forms.TextBox();
            this.lblMKmoi = new System.Windows.Forms.Label();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.lblMKcu = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMK = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.btnHuyDK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblDangKi = new System.Windows.Forms.LinkLabel();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblQCofU = new System.Windows.Forms.Label();
            this.lblHienLuotDi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutRoom = new System.Windows.Forms.Button();
            this.picQCofU = new System.Windows.Forms.PictureBox();
            this.picLuotDi = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlRoom.SuspendLayout();
            this.pnlDangNhap.SuspendLayout();
            this.pnlDoiMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQCofU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuotDi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoXN
            // 
            this.btnDoXN.Location = new System.Drawing.Point(483, 112);
            this.btnDoXN.Name = "btnDoXN";
            this.btnDoXN.Size = new System.Drawing.Size(75, 23);
            this.btnDoXN.TabIndex = 2;
            this.btnDoXN.Text = "Đổ Xí Ngầu";
            this.btnDoXN.UseVisualStyleBackColor = true;
            this.btnDoXN.Click += new System.EventHandler(this.btnDoXN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lượt Đi";
            // 
            // pnlRoom
            // 
            this.pnlRoom.BackColor = System.Drawing.Color.White;
            this.pnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoom.Controls.Add(this.lklDoiMatKhau);
            this.pnlRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoom.Location = new System.Drawing.Point(0, 0);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(825, 478);
            this.pnlRoom.TabIndex = 7;
            // 
            // lklDoiMatKhau
            // 
            this.lklDoiMatKhau.AutoSize = true;
            this.lklDoiMatKhau.Location = new System.Drawing.Point(742, 455);
            this.lklDoiMatKhau.Name = "lklDoiMatKhau";
            this.lklDoiMatKhau.Size = new System.Drawing.Size(70, 13);
            this.lklDoiMatKhau.TabIndex = 0;
            this.lklDoiMatKhau.TabStop = true;
            this.lklDoiMatKhau.Text = "Đổi mật khẩu";
            this.lklDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDoiMatKhau_LinkClicked);
            // 
            // lstDisplay
            // 
            this.lstDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(601, 90);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(212, 212);
            this.lstDisplay.TabIndex = 8;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(601, 346);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(212, 20);
            this.txtSend.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(738, 410);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.BackColor = System.Drawing.Color.Azure;
            this.pnlDangNhap.Controls.Add(this.pnlDoiMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblNhapLaiMK);
            this.pnlDangNhap.Controls.Add(this.txtNhapLaiMK);
            this.pnlDangNhap.Controls.Add(this.btnHuyDK);
            this.pnlDangNhap.Controls.Add(this.btnHuy);
            this.pnlDangNhap.Controls.Add(this.btnDangKi);
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Controls.Add(this.lblDangKi);
            this.pnlDangNhap.Controls.Add(this.lblMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblTenDangNhap);
            this.pnlDangNhap.Controls.Add(this.txtMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtTenDangNhap);
            this.pnlDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(825, 478);
            this.pnlDangNhap.TabIndex = 11;
            // 
            // pnlDoiMatKhau
            // 
            this.pnlDoiMatKhau.Controls.Add(this.btnHuyDMK);
            this.pnlDoiMatKhau.Controls.Add(this.btnXacNhanDMK);
            this.pnlDoiMatKhau.Controls.Add(this.lblXNMKmoi);
            this.pnlDoiMatKhau.Controls.Add(this.txtXNMKmoi);
            this.pnlDoiMatKhau.Controls.Add(this.lblMKmoi);
            this.pnlDoiMatKhau.Controls.Add(this.txtMKmoi);
            this.pnlDoiMatKhau.Controls.Add(this.lblMKcu);
            this.pnlDoiMatKhau.Controls.Add(this.txtMKCu);
            this.pnlDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.pnlDoiMatKhau.Name = "pnlDoiMatKhau";
            this.pnlDoiMatKhau.Size = new System.Drawing.Size(825, 478);
            this.pnlDoiMatKhau.TabIndex = 73;
            // 
            // btnHuyDMK
            // 
            this.btnHuyDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDMK.Location = new System.Drawing.Point(431, 328);
            this.btnHuyDMK.Name = "btnHuyDMK";
            this.btnHuyDMK.Size = new System.Drawing.Size(105, 36);
            this.btnHuyDMK.TabIndex = 27;
            this.btnHuyDMK.Text = "Hủy";
            this.btnHuyDMK.UseVisualStyleBackColor = true;
            this.btnHuyDMK.Click += new System.EventHandler(this.btnHuyDMK_Click);
            // 
            // btnXacNhanDMK
            // 
            this.btnXacNhanDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDMK.Location = new System.Drawing.Point(288, 328);
            this.btnXacNhanDMK.Name = "btnXacNhanDMK";
            this.btnXacNhanDMK.Size = new System.Drawing.Size(105, 36);
            this.btnXacNhanDMK.TabIndex = 26;
            this.btnXacNhanDMK.Text = "Xác nhận";
            this.btnXacNhanDMK.UseVisualStyleBackColor = true;
            this.btnXacNhanDMK.Click += new System.EventHandler(this.btnXacNhanDMK_Click);
            // 
            // lblXNMKmoi
            // 
            this.lblXNMKmoi.AutoSize = true;
            this.lblXNMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXNMKmoi.Location = new System.Drawing.Point(238, 215);
            this.lblXNMKmoi.Name = "lblXNMKmoi";
            this.lblXNMKmoi.Size = new System.Drawing.Size(176, 20);
            this.lblXNMKmoi.TabIndex = 24;
            this.lblXNMKmoi.Text = "Xác nhận mật khẩu mới";
            // 
            // txtXNMKmoi
            // 
            this.txtXNMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXNMKmoi.Location = new System.Drawing.Point(429, 212);
            this.txtXNMKmoi.Name = "txtXNMKmoi";
            this.txtXNMKmoi.PasswordChar = '*';
            this.txtXNMKmoi.Size = new System.Drawing.Size(158, 26);
            this.txtXNMKmoi.TabIndex = 23;
            // 
            // lblMKmoi
            // 
            this.lblMKmoi.AutoSize = true;
            this.lblMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKmoi.Location = new System.Drawing.Point(238, 176);
            this.lblMKmoi.Name = "lblMKmoi";
            this.lblMKmoi.Size = new System.Drawing.Size(104, 20);
            this.lblMKmoi.TabIndex = 25;
            this.lblMKmoi.Text = "Mật khẩu mới";
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.Location = new System.Drawing.Point(429, 173);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.PasswordChar = '*';
            this.txtMKmoi.Size = new System.Drawing.Size(158, 26);
            this.txtMKmoi.TabIndex = 22;
            // 
            // lblMKcu
            // 
            this.lblMKcu.AutoSize = true;
            this.lblMKcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKcu.Location = new System.Drawing.Point(238, 137);
            this.lblMKcu.Name = "lblMKcu";
            this.lblMKcu.Size = new System.Drawing.Size(96, 20);
            this.lblMKcu.TabIndex = 26;
            this.lblMKcu.Text = "Mật khẩu cũ";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(429, 134);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(158, 26);
            this.txtMKCu.TabIndex = 21;
            // 
            // lblNhapLaiMK
            // 
            this.lblNhapLaiMK.AutoSize = true;
            this.lblNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLaiMK.Location = new System.Drawing.Point(240, 228);
            this.lblNhapLaiMK.Name = "lblNhapLaiMK";
            this.lblNhapLaiMK.Size = new System.Drawing.Size(136, 20);
            this.lblNhapLaiMK.TabIndex = 70;
            this.lblNhapLaiMK.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMK.Location = new System.Drawing.Point(395, 225);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.PasswordChar = '*';
            this.txtNhapLaiMK.Size = new System.Drawing.Size(190, 26);
            this.txtNhapLaiMK.TabIndex = 64;
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDK.Location = new System.Drawing.Point(425, 266);
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.Size = new System.Drawing.Size(120, 30);
            this.btnHuyDK.TabIndex = 68;
            this.btnHuyDK.Text = "Hủy đăng kí";
            this.btnHuyDK.UseVisualStyleBackColor = true;
            this.btnHuyDK.Click += new System.EventHandler(this.btnHuyDK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(425, 266);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 30);
            this.btnHuy.TabIndex = 66;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Location = new System.Drawing.Point(280, 266);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(120, 30);
            this.btnDangKi.TabIndex = 67;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(280, 266);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(120, 30);
            this.btnDangNhap.TabIndex = 65;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblDangKi
            // 
            this.lblDangKi.AutoSize = true;
            this.lblDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKi.Location = new System.Drawing.Point(389, 328);
            this.lblDangKi.Name = "lblDangKi";
            this.lblDangKi.Size = new System.Drawing.Size(53, 16);
            this.lblDangKi.TabIndex = 69;
            this.lblDangKi.TabStop = true;
            this.lblDangKi.Text = "Đăng kí";
            this.lblDangKi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDangKi_LinkClicked);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(240, 183);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lblMatKhau.TabIndex = 71;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(240, 138);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lblTenDangNhap.TabIndex = 72;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(395, 180);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(190, 26);
            this.txtMatKhau.TabIndex = 63;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(395, 135);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(190, 26);
            this.txtTenDangNhap.TabIndex = 62;
            // 
            // lblQCofU
            // 
            this.lblQCofU.AutoSize = true;
            this.lblQCofU.Location = new System.Drawing.Point(480, 386);
            this.lblQCofU.Name = "lblQCofU";
            this.lblQCofU.Size = new System.Drawing.Size(90, 13);
            this.lblQCofU.TabIndex = 12;
            this.lblQCofU.Text = "Quân cờ của bạn";
            // 
            // lblHienLuotDi
            // 
            this.lblHienLuotDi.AutoSize = true;
            this.lblHienLuotDi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienLuotDi.Location = new System.Drawing.Point(461, 341);
            this.lblHienLuotDi.Name = "lblHienLuotDi";
            this.lblHienLuotDi.Size = new System.Drawing.Size(134, 23);
            this.lblHienLuotDi.TabIndex = 12;
            this.lblHienLuotDi.Text = "Đến lượt bạn";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(716, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // btnOutRoom
            // 
            this.btnOutRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutRoom.Image = global::Co_Ca_Ngua.Properties.Resources.outRoom;
            this.btnOutRoom.Location = new System.Drawing.Point(720, 36);
            this.btnOutRoom.Name = "btnOutRoom";
            this.btnOutRoom.Size = new System.Drawing.Size(62, 50);
            this.btnOutRoom.TabIndex = 14;
            this.btnOutRoom.UseVisualStyleBackColor = true;
            this.btnOutRoom.Click += new System.EventHandler(this.btnOutRoom_Click);
            // 
            // picQCofU
            // 
            this.picQCofU.Location = new System.Drawing.Point(511, 410);
            this.picQCofU.Name = "picQCofU";
            this.picQCofU.Size = new System.Drawing.Size(25, 25);
            this.picQCofU.TabIndex = 3;
            this.picQCofU.TabStop = false;
            // 
            // picLuotDi
            // 
            this.picLuotDi.Location = new System.Drawing.Point(511, 253);
            this.picLuotDi.Name = "picLuotDi";
            this.picLuotDi.Size = new System.Drawing.Size(25, 25);
            this.picLuotDi.TabIndex = 3;
            this.picLuotDi.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(825, 478);
            this.Controls.Add(this.btnOutRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHienLuotDi);
            this.Controls.Add(this.lblQCofU);
            this.Controls.Add(this.pnlDangNhap);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQCofU);
            this.Controls.Add(this.picLuotDi);
            this.Controls.Add(this.btnDoXN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRoom.ResumeLayout(false);
            this.pnlRoom.PerformLayout();
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.pnlDoiMatKhau.ResumeLayout(false);
            this.pnlDoiMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQCofU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuotDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoXN;
        private System.Windows.Forms.PictureBox picLuotDi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.Label lblNhapLaiMK;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Button btnHuyDK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel lblDangKi;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblQCofU;
        private System.Windows.Forms.PictureBox picQCofU;
        private System.Windows.Forms.Label lblHienLuotDi;
        private System.Windows.Forms.LinkLabel lklDoiMatKhau;
        private System.Windows.Forms.Panel pnlDoiMatKhau;
        private System.Windows.Forms.Button btnHuyDMK;
        private System.Windows.Forms.Button btnXacNhanDMK;
        private System.Windows.Forms.Label lblXNMKmoi;
        private System.Windows.Forms.TextBox txtXNMKmoi;
        private System.Windows.Forms.Label lblMKmoi;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label lblMKcu;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutRoom;
        private System.Windows.Forms.Timer timer2;
    }
}

