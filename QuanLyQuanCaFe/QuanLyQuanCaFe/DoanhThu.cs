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
    public partial class DoanhThu : UserControl
    {
        GoiMon gm = new GoiMon();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            dtvDoanhThu.DataSource = Form1.HD;
            TinhDoanhThu();
        }
        double tongdoanhthu = 0;      
        public void TinhDoanhThu()
        {
            foreach (DataRow dataRow in Form1.HD.Rows)
            {
                tongdoanhthu += double.Parse(dataRow["Tổng Tiền"].ToString());
            }
            txtDoanhThu.Text = tongdoanhthu.ToString();
        }
    }
}
