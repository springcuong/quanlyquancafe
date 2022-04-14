using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaFe
{
    public partial class Form1 : Form
    {
        GoiMon gm = new GoiMon();
        DoanhThu dt = new DoanhThu();
        DangNhap dn = new DangNhap();
        QuanLySanPham qlsp = new QuanLySanPham();

        public static DataTable dtb;
        public static DataTable HD;
        public static DataTable DongHD;
        public static DataTable test;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnQuanLySanPham.PerformClick();
        }
        private void btn_goimon(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(gm);
            gm.Show();
        }
        private void btn_doanhthu(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(dt);
            dt.Show();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(qlsp);
            qlsp.Show();
        }
    }
}
