using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HinhTron
    {
        private ToaDo _Tam;

        private double _banKinh ;
        internal ToaDo Tam
        {
            get { return _Tam; }
            set { _Tam = value; }
        }

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }
        public HinhTron()
        {

        }
        public HinhTron(ToaDo Tam, double BanKinh)
        {
            this._Tam = Tam;
            this._banKinh = BanKinh;
        }
        public double tinhChuVi()
        {
            return 2*BanKinh*3.14;
        }
        public double tinhDienTich()
        {
            return BanKinh * BanKinh * 3.14;
        }
    }
}
