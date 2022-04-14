using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe
{
    public class SanPham
    {
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongSP { get; set; }
        public double GiaSP { get; set; }
        public SanPham()
        {
            TenSP = "Cà phê sữa";
            LoaiSP = "Cà phê";
            DonViTinh = "Ly";
            SoLuongSP = 1;
            GiaSP = 0;
        }
        public SanPham(string TenSP1, string LoaiSP1, string DonViTinh1, int SoLuongSP1, double GiaSP1)
        {
            this.TenSP = TenSP1;
            this.LoaiSP = LoaiSP1;
            this.DonViTinh = DonViTinh1;
            this.SoLuongSP = SoLuongSP1;
            this.GiaSP = GiaSP1;
        }
    }
}
