using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class HinhTron
    {
        private ToaDo _tam;

        internal ToaDo Tam
        {
            get { return _tam; }
            set { _tam = value; }
        }

        private double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        public HinhTron(ToaDo tam, double banKinh)
        {
            this._tam = tam;
            this._banKinh = banKinh;
        }

        public HinhTron() 
        {

        }

        public double tinhDienTich()
        {
            return BanKinh * BanKinh * 3.14;
        }

        public double tinhChuVi()
        {
            return BanKinh * 2 * 3.14;
        }

    }
}