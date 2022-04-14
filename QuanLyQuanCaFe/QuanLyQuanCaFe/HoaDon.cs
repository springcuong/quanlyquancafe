using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe
{
    public class HoaDon
    {
        public string tensp { get; set; }
        public int soluong { get; set;}
        public double giasp { get; set; }
        public double thanhtien { get; set; }
        public double tongtien { get; set; }
        public HoaDon()
        {
            tensp = "Cà phê đen";
            soluong = 1;
            giasp = 0;
            thanhtien = 0;
            tongtien = 0;
        }
        public HoaDon(string tensp1, int soluong1, double giasp1)
        {
            this.tensp = tensp1;
            this.soluong = soluong1;
            this.giasp = giasp1;
        }
        public double TinhThanhTien()
        {
            this.thanhtien = this.soluong * this.giasp;
            return this.thanhtien;
        }
    }
}
