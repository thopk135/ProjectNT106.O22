using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_Ca_Ngua
{
    public partial class Form1 : Form
    {
        #region Variables TCP
        private Socket client;
        byte[] buffSend = new byte[1024];
        byte[] buffReceive = new byte[1024];
        string _ma = "";
        private delegate void updateUI(string message);
        private updateUI updateUi;
        string playerName = "";
        bool inRoom = false;
        int roomNumber = 0;
        int[,] playerOfRoom = {{0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
                              {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
        string ipAddress = "127.0.0.1";
        string port = "9050";
        #endregion
        public Form1()
        {
            InitializeComponent();
            GenMap();
            SapBanCo();
            updateUi = new updateUI(update);
            CheckForIllegalCrossThreadCalls = false;
        }
        #region BanCo
        #region Variables BC
        PictureBox[] aPicture = new PictureBox[56];
        int giaTriXN_Server = 0;
        PictureBox XN = new PictureBox();
        PictureBox QC_Red = new PictureBox();
        PictureBox QC_Yellow = new PictureBox();
        PictureBox dich1 = new PictureBox();
        PictureBox dich2 = new PictureBox();
        PictureBox dich3 = new PictureBox();
        PictureBox dich4 = new PictureBox();
        PictureBox pt1 = new PictureBox(); // Chuong ngua
        PictureBox pt2 = new PictureBox(); //
        PictureBox pt3 = new PictureBox(); //
        PictureBox pt4 = new PictureBox(); //
        int luotDi = 1; // 1 cờ vàng, 2 cờ đỏ
        bool _go = true;
        QuanCo quanVang;
        QuanCo quanDo;
        bool checkXuatChuong = false;
        bool check_ra_quan = false;
        int[] Map_X = {21, 50, 79, 108, 137, 166, 195,
                        195, 195, 195, 195, 195,
                        195, 224, 253, 
                        253, 253, 253, 253, 253, 
                        253, 282, 311, 340, 369, 398, 427, 
                        427, 
                        427, 398, 369, 340, 311, 282, 253, 
                        253, 253, 253, 253, 253, 
                        253, 224, 195, 
                        195, 195, 195, 195, 195,
                        195, 166, 137, 108, 79, 50, 21, 
                        21};
        int[] Map_Y = {191, 191, 191, 191, 191, 191, 191,
                      162, 133, 104, 75, 46,
                      17, 17, 17,
                      46, 75, 104, 133, 162,
                      191, 191, 191, 191, 191, 191, 191,
                      220, 249,
                      249, 249, 249, 249, 249, 249,
                      278, 307, 336, 365, 394, 423,
                      423, 423,
                      394, 365, 336, 307, 278, 249,
                      249, 249, 249, 249, 249, 249,
                      220};
        #endregion
        PictureBox[] Room = new PictureBox[10];
        TextBox[] Infor = new TextBox[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            QC_Red.Visible = false;
            QC_Yellow.Visible = false;
            btnDoXN.Enabled = false;
            lblHienLuotDi.Visible = false;
            lblQCofU.Visible = false;
            picQCofU.Visible = false;
            btnDangKi.Visible = false;
            btnHuyDK.Visible = false;
            lblNhapLaiMK.Visible = false;
            txtNhapLaiMK.Visible = false;
            pnlDoiMatKhau.Visible = false;
            lblMKcu.Visible = false;
            lblMKmoi.Visible = false;
            lblXNMKmoi.Visible = false;
            btnXacNhanDMK.Visible = false;
            btnHuyDMK.Visible = false;
            txtMKCu.Visible = false;
            txtMKmoi.Visible = false;
            txtXNMKmoi.Visible = false;
            label2.Visible = false;
            btnOutRoom.Visible = false;
            starClient();
            timer1.Start();
        }

        

        private void GenMap()
        {
            for (int i = 0; i < Map_X.Length; i++)
            {
                PictureBox pt = new PictureBox();
                pt.Location = new System.Drawing.Point(Map_X[i], Map_Y[i]);
                pt.Name = "Button" + i + i;
                pt.Size = new Size(29, 29);
                pt.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.OCo;
                pt.Tag = string.Format("[{0}]", i);
                pt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_MouseClick);
                this.Controls.Add(pt);
                aPicture[i] = pt;
            }

            pt1.Location = new System.Drawing.Point(21, 17);
            pt1.Name = "ChuongVang";
            pt1.Size = new Size(174, 174);
            pt1.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.ChuongVang;
            this.Controls.Add(pt1);
            pt2.Location = new System.Drawing.Point(282, 17);
            pt2.Name = "ChuongDo";
            pt2.Size = new Size(174, 174);
            pt2.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.ChuongDo;
            this.Controls.Add(pt2);
            pt3.Location = new System.Drawing.Point(282, 278);
            pt3.Name = "ChuongXanh";
            pt3.Size = new Size(174, 174);
            pt3.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.ChuongXanh;
            this.Controls.Add(pt3);
            pt4.Location = new System.Drawing.Point(21, 278);
            pt4.Name = "ChuongXanhLa";
            pt4.Size = new Size(174, 174);
            pt4.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.ChuongXanhLa;
            this.Controls.Add(pt4);

            // cac o dich den
            dich1.Location = new System.Drawing.Point(224, 46);
            dich1.Name = "DichVang";
            dich1.Size = new Size(29, 174);
            dich1.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.DichVang;
            this.Controls.Add(dich1);
            dich2.Location = new System.Drawing.Point(253, 220);
            dich2.Name = "DichDo";
            dich2.Size = new Size(174, 29);
            dich2.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.DichDo;
            this.Controls.Add(dich2);
            dich3.Location = new System.Drawing.Point(224, 249);
            dich3.Name = "DichXanh";
            dich3.Size = new Size(29, 174);
            dich3.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.DichXanh;
            this.Controls.Add(dich3);
            dich4.Location = new System.Drawing.Point(50, 220);
            dich4.Name = "DichXanhLa";
            dich4.Size = new Size(174, 29);
            dich4.BackgroundImage = global::Co_Ca_Ngua.Properties.Resources.DichXanhLa;
            this.Controls.Add(dich4);

            //picture Xi Ngau
            XN.Location = new System.Drawing.Point(500, 50);
            XN.Name = "QC_Red";
            XN.BackColor = Color.White;
            XN.Size = new Size(40, 40);
            //XN.Image = global::Co_Ca_Ngua.Properties.Resources._1;
            this.Controls.Add(XN);

            btnDoXN.Enabled = false;
            genRoom();
        }

        private void genRoom()
        {
            int w = 0;
            int h = 0;
            int c = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    PictureBox pt = new PictureBox();
                    TextBox tb = new TextBox();
                    TextBox tb1 = new TextBox();
                    pt.Location = new System.Drawing.Point((i * 180) + 20 + h, (j * 80) + 40 + w);
                    pt.Name = "Button" + i + i;
                    pt.Size = new Size(180, 80);
                    pt.Image = global::Co_Ca_Ngua.Properties.Resources.Table;
                    pt.Tag = string.Format("[{0}]", c);
                    pt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureRoom_MouseClick);

                    tb.BackColor = System.Drawing.Color.White;
                    tb.Enabled = false;
                    tb.ForeColor = Color.Black;
                    tb.Font = new System.Drawing.Font("Jokerman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb.Location = new System.Drawing.Point((i * 180) + 75 + h, (j * 80) + 75 + w);
                    tb.Name = "textBox1";
                    tb.ReadOnly = true;
                    tb.Size = new System.Drawing.Size(57, 25);
                    tb.TabIndex = 0;
                    int n = c + 1;
                    tb.Text = "Room " + n.ToString();

                    tb1.BackColor = System.Drawing.Color.White;
                    tb1.Enabled = false;
                    tb1.ForeColor = Color.MediumBlue;
                    tb1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb1.Location = new System.Drawing.Point((i * 180) + 215 + h, (j * 80) + 60 + w);
                    tb1.Name = "textBox1";
                    tb1.ReadOnly = true;
                    tb1.Size = new System.Drawing.Size(25, 25);
                    tb1.TabIndex = 0;
                    tb1.Text = "0";

                    pnlRoom.Controls.Add(tb);
                    pnlRoom.Controls.Add(tb1);
                    pnlRoom.Controls.Add(pt);
                    Room[c] = pt;
                    Infor[c] = tb1;
                    c++;
                    h += 100;
                }
                h = 0;
                w += 10;
            }
        }

        private void pictureRoom_MouseClick(object sender, EventArgs e)
        {
            string str = ((PictureBox)sender).Tag.ToString();
            if (playerOfRoom[1, int.Parse(str[1].ToString())] < 2)
            {
                resetBC();
                pnlRoom.Visible = false;
                inRoom = true;
                label2.Visible = true;
                btnOutRoom.Visible = true;
                roomNumber = int.Parse(str[1].ToString());
                label2.Text = "ROOM" + (roomNumber + 1).ToString();
                lstDisplay.BackColor = Color.White;
                string s = "#_TCP_IR" + str[1].ToString();
                sendCommand(s);
            }
            else
            {
                MessageBox.Show("Phòng đã đầy");
            }
        }

        private void resetBC()
        {
            checkXuatChuong = false;
            check_ra_quan = false;
            QC_Red.Visible = false;
            QC_Yellow.Visible = false;
            btnDoXN.Enabled = false;
            lblHienLuotDi.Visible = false;
            lblQCofU.Visible = false;
            picQCofU.Visible = false;
            quanVang = new QuanCo(12, 12, false, 0);
            quanDo = new QuanCo(26, 26, false, 0);
        }

        public void bt_MouseClick(object sender, MouseEventArgs e)
        {
            string str = ((PictureBox)sender).Tag.ToString();
            int vt;
            if(str[2] == ']')
            {
                vt = int.Parse(str.Substring(1, 1).ToString());
            }
            else
            {
                vt = int.Parse(str.Substring(1, 2).ToString());
            }
            if (luotDi == 1 && vt == quanVang.ViTriHienTai && _go == true) //vt_HT_QuanVang
            {
                sendCommand("#_TCP_UB" + roomNumber.ToString() + luotDi.ToString() + quanVang.RaQuan.ToString() + quanVang.ViTriHienTai.ToString() + "_");
                DiCo(aPicture, quanVang.ViTriHienTai, luotDi, giaTriXN_Server);
            }
            if (luotDi == 2 && vt == quanDo.ViTriHienTai && _go == true) //vt_HT_QuanDo
            {
                sendCommand("#_TCP_UB" + roomNumber.ToString() + luotDi.ToString() + quanDo.RaQuan.ToString() + quanDo.ViTriHienTai.ToString() + "_");
                DiCo(aPicture, quanDo.ViTriHienTai, luotDi, giaTriXN_Server);
            }
        }

        private void btnDoXN_Click(object sender, EventArgs e)
        {
            sendCommand("#_TCP_DO" + luotDi.ToString() + roomNumber.ToString());
            _go = true;
            timer2.Start();
        }
        private void getImageXN(int gt)
        {
            switch (gt)
            {
                case 1: XN.Image = global::Co_Ca_Ngua.Properties.Resources._1; ; break;
                case 2: XN.Image = global::Co_Ca_Ngua.Properties.Resources._2; ; break;
                case 3: XN.Image = global::Co_Ca_Ngua.Properties.Resources._3; ; break;
                case 4: XN.Image = global::Co_Ca_Ngua.Properties.Resources._4; ; break;
                case 5: XN.Image = global::Co_Ca_Ngua.Properties.Resources._5; ; break;
                case 6: XN.Image = global::Co_Ca_Ngua.Properties.Resources._6; ; break;
            }
        }
        private void LuotDi(int ld)
        {
            switch (ld)
            {
                case 1: picLuotDi.Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                    quanVang.DiCo = true;
                    break;
                case 2: picLuotDi.Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                    quanDo.DiCo = true;
                    break;
            }

        }

        private void SapBanCo()
        {
            // quan co trong chuong do
            QC_Red.Location = new System.Drawing.Point(140, 8);
            QC_Red.Name = "QC_Red";
            QC_Red.BackColor = Color.White;
            QC_Red.Size = new Size(25, 25);
            QC_Red.Image = global::Co_Ca_Ngua.Properties.Resources.DO;
            QC_Red.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Xuat_Chuong_Do);
            pt2.Controls.Add(QC_Red);

            // quan co trong chuong vang
            QC_Yellow.Location = new System.Drawing.Point(8, 8);
            QC_Yellow.Name = "QC_Yellow";
            QC_Yellow.BackColor = Color.White;
            QC_Yellow.Size = new Size(25, 25);
            QC_Yellow.Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
            QC_Yellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Xuat_Chuong_Vang);
            pt1.Controls.Add(QC_Yellow);
        }
        private void Xuat_Chuong_Vang(object sender, EventArgs e)
        {
            if (check_ra_quan == true && luotDi == 1 && checkXuatChuong == true)
            {
                QC_Yellow.Visible = false;
                aPicture[quanVang.ViTriXuatPhat].Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                check_ra_quan = false;
                quanVang.DiCo = false;
                sendCommand("#_TCP_UB" + roomNumber.ToString() + luotDi.ToString() + quanVang.RaQuan.ToString() + quanVang.ViTriHienTai.ToString() + "_");
                quanVang.RaQuan = 1;
            }
        }

        private void Xuat_Chuong_Do(object sender, EventArgs e)
        {
            if (check_ra_quan == true && luotDi == 2 && checkXuatChuong == true)
            {
                QC_Red.Visible = false;
                aPicture[quanDo.ViTriXuatPhat].Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                check_ra_quan = false;
                quanDo.DiCo = false;
                sendCommand("#_TCP_UB" + roomNumber.ToString() + luotDi.ToString() + quanDo.RaQuan.ToString() + quanDo.ViTriHienTai.ToString() + "_");
                quanDo.RaQuan = 1;
            }
        }
        
        private void DiCo(PictureBox[] pt, int vt_HT, int ld, int gtXN)
        {
            if (!VeDich(vt_HT, ld))
            {
                if (ld == 1)
                {
                    if ((vt_HT > quanVang.ViTriXuatPhat) && (vt_HT - gtXN < quanVang.ViTriXuatPhat + 1))
                    { }
                    else
                    {
                        if (quanVang.DiCo == true)
                        {
                            for (int i = 1; i <= gtXN; i++)
                            {
                                    if (vt_HT != quanDo.ViTriHienTai)
                                    {
                                        pt[vt_HT].Image = null;
                                    }
                                    vt_HT--;
                                    if (vt_HT < 0)
                                    {
                                        vt_HT = 55;
                                    }
                                    if (vt_HT != quanDo.ViTriHienTai)
                                    {
                                        pt[vt_HT].Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                                    }
                                    if (i == gtXN)
                                    {
                                        quanVang.ViTriHienTai = vt_HT;
                                        if (vt_HT == quanDo.ViTriHienTai)
                                        {
                                            checkXuatChuong = false;
                                            quanDo.RaQuan = 0;
                                            pt[vt_HT].Image = null;
                                            QC_Red.Visible = true;
                                            quanDo.ViTriHienTai = quanDo.ViTriXuatPhat;
                                            pt[vt_HT].Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                                        }
                                    }
                            }
                            quanVang.DiCo = false;
                        }
                    }
                }
                else
                {
                    if ((vt_HT > quanDo.ViTriXuatPhat) && (vt_HT - gtXN < quanDo.ViTriXuatPhat + 1))
                    { }
                    else
                    {
                        if (quanDo.DiCo == true)
                        {
                            for (int i = 1; i <= gtXN; i++)
                            {
                                    if (vt_HT != quanVang.ViTriHienTai)
                                    {
                                        pt[vt_HT].Image = null;
                                    }
                                    vt_HT--;
                                    if (vt_HT < 0)
                                    {
                                        vt_HT = 55;
                                    }
                                    if (vt_HT != quanVang.ViTriHienTai)
                                    {
                                        pt[vt_HT].Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                                    }
                                    if (i == gtXN)
                                    {
                                        quanDo.ViTriHienTai = vt_HT;
                                        if (vt_HT == quanVang.ViTriHienTai)
                                        {
                                            checkXuatChuong = false;
                                            quanVang.RaQuan = 0;
                                            pt[vt_HT].Image = null;
                                            QC_Yellow.Visible = true;
                                            quanVang.ViTriHienTai = quanVang.ViTriXuatPhat;
                                            pt[vt_HT].Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                                        }
                                    }
                            }
                            quanDo.DiCo = false;
                        }
                    }
                }
            }
            else
            {
                if (ld == 1)
                {
                    pt[vt_HT].Image = null;
                    QC_Yellow.Visible = true;
                    QC_Yellow.Location = new System.Drawing.Point(0, 145);
                    QC_Yellow.Size = new Size(29, 29);
                    dich1.Controls.Add(QC_Yellow);
                    MessageBox.Show("Ban da thang");
                }
                else
                {
                    pt[vt_HT].Image = null;
                    QC_Red.Visible = true;
                    QC_Red.Location = new System.Drawing.Point(0, 0);
                    QC_Red.Size = new Size(29, 29);
                    dich2.Controls.Add(QC_Red);
                    MessageBox.Show("Ban da thang");
                }
            }
        }

        private void updateBanCo(PictureBox[] pt,int ld, int vt_HT, int xc)
        {
            if (ld == 1)
            {
                if(xc == 0)
                {
                    QC_Yellow.Visible = false;
                    aPicture[quanVang.ViTriXuatPhat].Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                    pt[vt_HT].Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                }            }
            else
            {
                if (xc == 0)
                {
                    QC_Red.Visible = false;
                    aPicture[quanDo.ViTriXuatPhat].Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                    pt[vt_HT].Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                }
            }
        }

        private bool VeDich(int vt_HT, int ld)
        {
            if (ld == 1)
            {
                if (vt_HT == quanVang.ViTriXuatPhat + 1 && giaTriXN_Server == 6)
                {
                    sendCommand("#_TCP_VD" + ld.ToString());
                    return true;
                }
            }
            else
            {
                if (vt_HT == quanDo.ViTriXuatPhat + 1 && giaTriXN_Server == 6)
                {
                    sendCommand("#_TCP_VD" + ld.ToString());
                    return true;
                }
            }
            return false;
        }
        #endregion

        

        #region TCP Client
        private void update(string msg)
        {
            lstDisplay.Items.Add(msg);
            lstDisplay.TopIndex = lstDisplay.Items.Count - 1;
        }

        private void starClient()
        {
            EndPoint ipep = new IPEndPoint(IPAddress.Parse(ipAddress.ToString()), Convert.ToInt32(port.ToString()));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            updateUi("Đã kết nối...");
            //// thực hiện việc kết nối và gọi beginConnect
            client.BeginConnect(ipep, new AsyncCallback(beginConnect), client); // ipep của thiết bị cần kết nối tới
            // đăng ký beginConnect khi có kết nối hoàn tất. truyển client đến EndConnect

        }
        private void beginConnect(IAsyncResult ar)
        {
            try
            {
                client.EndConnect(ar);  // lấy socket của nơi gửi
                //updateUi("Kết nối thành công tới Server: " + client.RemoteEndPoint.ToString());
                string welcome = "Hello Server";
                buffSend = new byte[1024];
                buffSend = Encoding.UTF8.GetBytes(welcome);
                // đắng ký việc gửi dữ liệu
                client.BeginSend(buffSend, 0, buffSend.Length, SocketFlags.None, new AsyncCallback(sendData), client);  // sendData được gọi khi phương thức BeginSend thực hiện thành công.
                // nhận  dữ liệu
                buffReceive = new byte[1024];
                client.BeginReceive(buffReceive, 0, buffReceive.Length, SocketFlags.None, new AsyncCallback(beginReceive), client);
            }
            catch (SocketException)
            {
                //updateUi("Kết nối tới Server không thành công.");
                MessageBox.Show("Kết nối đến Server không thành công");
            }
        }

        private void sendData(IAsyncResult ai)
        {
            client.EndSend(ai);
        }

        private void sendData(string data)
        {
            buffSend = new byte[1024];
            buffSend = Encoding.UTF8.GetBytes(data);
            client.BeginSend(buffSend, 0, buffSend.Length, SocketFlags.None, new AsyncCallback(sendData), client);
            //updateUi("_Client: " + txtSend.Text);
        }

        private void sendCommand(string data)
        {
            buffSend = new byte[1024];
            buffSend = Encoding.UTF8.GetBytes(data);
            client.BeginSend(buffSend, 0, buffSend.Length, SocketFlags.None, new AsyncCallback(sendData), client);
        }

        // nhận dữ liệu
        private void beginReceive(IAsyncResult iar)
        {
            try
            {
                Socket s = (Socket)iar.AsyncState;
                int bytesReceive = 0;
                bytesReceive = client.EndReceive(iar);
                string receive = Encoding.UTF8.GetString(buffReceive, 0, bytesReceive);
                if (receive[0] == '+')
                {
                    _ma = receive.Substring(1);
                }
                if (receive.Substring(0, 10) == "#_TCP_DNTC")
                {
                    playerName = txtTenDangNhap.Text;
                    pnlDangNhap.Visible = false;
                    lblMatKhau.Visible = false;
                    lblTenDangNhap.Visible = false;
                    btnDangNhap.Visible = false;
                    btnHuy.Visible = false;
                    txtMatKhau.Visible = false;
                    txtTenDangNhap.Visible = false;
                    lblDangKi.Visible = false;
                    txtSend.Focus();
                }
                if (receive.Length >= 9 && receive.Substring(0, 10) == "#_TCP_DNTB")
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
                if (receive.Length >= 9 && receive.Substring(0, 10) == "#_TCP_DNTT")
                {
                    MessageBox.Show("Tài khoản đang được sử dụng");
                }
                if (receive.Length >= 9 && receive.Substring(0, 10) == "#_TCP_DKTB")
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
                if (receive.Length >= 10 && receive.Substring(0, 10) == "#_TCP_DKTC")
                {
                    btnDangKi.Visible = false;
                    btnHuyDK.Visible = false;
                    lblNhapLaiMK.Visible = false;
                    txtNhapLaiMK.Visible = false;
                    MessageBox.Show("Đăng kí thành công");
                }
                if (receive.Length >= 11 && receive.Substring(0, 11) == "#_TCP_DMKTC")
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                if (receive.Length >= 8 && receive.Substring(0, 10) == "#_TCP_FULL")
                {
                    MessageBox.Show("Phòng đã đầy");
                }
                if (receive.Length >= 8 && receive.Substring(0, 8) == "#_TCP_UD")
                {
                    playerOfRoom[1, int.Parse(receive[8].ToString())] = int.Parse(receive[9].ToString());
                    Infor[int.Parse(receive[8].ToString())].Text = receive[9].ToString();
                }
                if (receive.Length >= 8 && receive.Substring(0, 8) == "#_TCP_UF")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        playerOfRoom[1, i] = int.Parse(receive[i + 8].ToString());
                        Infor[i].Text = receive[i + 8].ToString();
                    }
                }

                receiveCmdPlay(receive, s);

                if (receive.Length >= 9 && receive.Substring(0, 9) == "#_Chat_00")
                {
                    updateUi(receive.Substring(9));
                }
                //updateUi("Server: " + receive);
                s.BeginReceive(buffReceive, 0, buffReceive.Length, SocketFlags.None, new AsyncCallback(beginReceive), s);
            }
            catch { }
        }

        private void receiveCmdPlay(string str, Socket sk)
        {
            if (str.Length >= 8 && str.Substring(0, 8) == "#_TCP_LD")
            {
                QC_Red.Visible = true;
                QC_Yellow.Visible = true;
                lblQCofU.Visible = true;
                picQCofU.Visible = true;
                luotDi = int.Parse(str[8].ToString());
                switch (luotDi)
                {
                    case 1: picQCofU.Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                        btnDoXN.Enabled = true;
                        lblHienLuotDi.Visible = true;
                        break;
                    case 2: picQCofU.Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                        break;
                }
                LuotDi(1);
            }
            if (str.Length >= 8 && str.Substring(0, 8) == "#_TCP_VA")
            {
                giaTriXN_Server = int.Parse(str[9].ToString());
                getImageXN(giaTriXN_Server);
                if (giaTriXN_Server == 1 || giaTriXN_Server == 6)
                {
                    check_ra_quan = true;
                }
                else
                {
                    check_ra_quan = false;
                }
                
                int vl = int.Parse(str[8].ToString());
                if (giaTriXN_Server > 1 && giaTriXN_Server < 6)
                {
                    vl = doiLuotDi(int.Parse(str[8].ToString()));
                }
                switch (vl)
                {
                    case 1:
                        picLuotDi.Image = global::Co_Ca_Ngua.Properties.Resources.VANG;
                            quanVang.DiCo = true;
                        break;
                    case 2:
                        picLuotDi.Image = global::Co_Ca_Ngua.Properties.Resources.DO;
                            quanDo.DiCo = true;
                        break;
                }
                if(luotDi == int.Parse(str[8].ToString()))
                {
                    checkXuatChuong = true;
                    btnDoXN.Enabled = true;
                    lblHienLuotDi.Visible = true;
                }
                else
                {
                    btnDoXN.Enabled = false;
                    lblHienLuotDi.Visible = false;
                }
            }

            if (str.Length >= 8 && str.Substring(0, 8) == "#_TCP_UB")
            {
                string _str = "";
                for (int i = 11; i < str.Length; i++)
                {
                    _str += str[i];
                }
                if (int.Parse(str[10].ToString()) == 0)
                {
                    quanVang.DiCo = false;
                    quanDo.DiCo = false;
                }
                updateBanCo(aPicture, int.Parse(str[9].ToString()), int.Parse(_str), int.Parse(str[10].ToString()));
                if (int.Parse(str[10].ToString()) == 1 && quanVang.DiCo == false && quanDo.DiCo == false)
                {
                    
                }
                else
                {
                    DiCo(aPicture, int.Parse(_str), int.Parse(str[9].ToString()), giaTriXN_Server);
                }
            }

            if (str.Length >= 8 && str.Substring(0, 8) == "#_TCP_KQ")
            {
                MessageBox.Show("Người chơi " + str.Substring(8) + " đã chiến thắng !!!!!!");
                btnDoXN.Enabled = false;
            }
        }

        private int doiLuotDi(int ld)
        {
            if(ld == 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == txtNhapLaiMK.Text)
            {
                buffSend = new byte[1024];
                string str = "#_TCP_DK" + txtTenDangNhap.Text + " " + txtMatKhau.Text;
                buffSend = Encoding.UTF8.GetBytes(str);
                client.BeginSend(buffSend, 0, buffSend.Length, SocketFlags.None, new AsyncCallback(sendData), client);
                //MessageBox.Show(txtTenDangNhap.Text + " " + txtMatKhau.Text);
            }
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            btnDangKi.Visible = false;
            btnHuyDK.Visible = false;
            lblNhapLaiMK.Visible = false;
            txtNhapLaiMK.Visible = false;
        }

        private void lblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDangKi.Visible = true;
            btnHuyDK.Visible = true;
            lblNhapLaiMK.Visible = true;
            txtNhapLaiMK.Visible = true;
        }
        string tenDangNhap = "";
        string matKhau = "";
        string matKhauMoi = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            buffSend = new byte[1024];
            string str = "#_TCP_DN" + txtTenDangNhap.Text + " " + txtMatKhau.Text;
            tenDangNhap = txtTenDangNhap.Text;
            matKhau = txtMatKhau.Text;
            buffSend = Encoding.UTF8.GetBytes(str);
            client.BeginSend(buffSend, 0, buffSend.Length, SocketFlags.None, new AsyncCallback(sendData), client);
            //MessageBox.Show(txtTenDangNhap.Text + " " + txtMatKhau.Text);
            //MessageBox.Show(tenDangNhap + " " + matKhau);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            buffSend = new byte[1024];
            string str = "";
            if(inRoom == false)
            {
                str = "#_Chat_00" + txtSend.Text;
            }
            else
            {
                str = "#_Chat_1" + roomNumber.ToString() + txtSend.Text;
            }
            buffSend = Encoding.UTF8.GetBytes(str);
            client.BeginSend(buffSend, 0, buffSend.Length, SocketFlags.None, new AsyncCallback(sendData), client);
            //updateUi("_Client: " + txtSend.Text);
            txtSend.Text = "";
        }

        #endregion

        private void lklDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDangNhap.Visible = true;
            pnlDoiMatKhau.Visible = true;
            lblMKcu.Visible = true;
            lblMKmoi.Visible = true;
            lblXNMKmoi.Visible = true;
            btnXacNhanDMK.Visible = true;
            btnHuyDMK.Visible = true;
            txtMKCu.Visible = true;
            txtMKmoi.Visible = true;
            txtXNMKmoi.Visible = true;
        }

        private void btnXacNhanDMK_Click(object sender, EventArgs e)
        {
            if(txtMKCu.Text == "" || txtMKmoi.Text == "" || txtXNMKmoi.Text == "")
            {
                MessageBox.Show("Các trường dữ liệu không được để trống");
            }
            else
            {
                if(txtMKCu.Text != matKhau)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                }
                else
                {
                    if(txtMKmoi.Text != txtXNMKmoi.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không đúng");
                    }
                    else
                    {
                        sendCommand("#_TCP_DMK" + txtMKmoi.Text);
                    }
                }
            }
            pnlDangNhap.Visible = false;
            pnlDoiMatKhau.Visible = false;
            lblMKcu.Visible = false;
            lblMKmoi.Visible = false;
            lblXNMKmoi.Visible = false;
            btnXacNhanDMK.Visible = false;
            btnHuyDMK.Visible = false;
            txtMKCu.Visible = false;
            txtMKmoi.Visible = false;
            txtXNMKmoi.Visible = false;
        }

        private void btnHuyDMK_Click(object sender, EventArgs e)
        {
            pnlDoiMatKhau.Visible = false;
            lblMKcu.Visible = false;
            lblMKmoi.Visible = false;
            lblXNMKmoi.Visible = false;
            btnXacNhanDMK.Visible = false;
            btnHuyDMK.Visible = false;
            txtMKCu.Visible = false;
            txtMKmoi.Visible = false;
            txtXNMKmoi.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!isConnected(client))
            {
                MessageBox.Show("Mất kết nối đến server");
                timer1.Stop();
            }
        }

        public bool isConnected(Socket s)
        {
            try
            {
                return !(s.Poll(10, SelectMode.SelectRead) && s.Available == 0);
            }
            catch (SocketException)
            {
                return false;
            }
        }

        private void btnOutRoom_Click(object sender, EventArgs e)
        {
            pnlRoom.Visible = true;
            inRoom = false;
            label2.Visible = false;
            btnOutRoom.Visible = false;
            lstDisplay.BackColor = System.Drawing.SystemColors.Info;
            string s = "#_TCP_OR" + roomNumber.ToString();
            sendCommand(s);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _go = false;
            timer2.Stop();
        }
    }
}
