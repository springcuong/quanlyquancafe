using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe
{
    public class Ban
    {
        public string MaBan { get; set; }
        public string TenBan { get; set; }

        public Ban()
        {
            MaBan = "A1";
            TenBan = "Bàn A1";
        }
        public Ban(string MaBan1, string TenBan1)
        {
            this.MaBan = MaBan1;
            this.TenBan = TenBan1;
        }
    }
}
