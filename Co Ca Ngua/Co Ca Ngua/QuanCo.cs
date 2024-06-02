using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Ca_Ngua
{
    public class QuanCo
    {
        int viTriXuatPhat;

        public int ViTriXuatPhat
        {
            get { return viTriXuatPhat; }
            set { viTriXuatPhat = value; }
        }
        int viTriHienTai;

        public int ViTriHienTai
        {
            get { return viTriHienTai; }
            set { viTriHienTai = value; }
        }
        bool diCo;

        public bool DiCo
        {
            get { return diCo; }
            set { diCo = value; }
        }

        int raQuan;

        public int RaQuan
        {
            get { return raQuan; }
            set { raQuan = value; }
        }

        public QuanCo()
        {

        }

        public QuanCo(int vtxp, int vtht, bool dc, int rq)
        {
            this.viTriXuatPhat = vtxp;
            this.viTriHienTai = vtht;
            this.diCo = dc;
            this.raQuan = rq;
        }
    }
}
