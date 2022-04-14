using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace QuanLyQuanCaFe
{
    public partial class GoiMon : UserControl
    {
        public List<HoaDon> DSHD = new List<HoaDon>();
        public List<QuanLySanPham> QLSP = new List<QuanLySanPham>();
        public bool[] trangthaiban = new bool[50];
        int index;
        int DemSoHoaDon=0;
        int IDHoaDon =1;
        public int DemSoDong = 0;
        int soBan=0;
        public GoiMon()
        {
            InitializeComponent();
        }
        private void btntruyen_Click(object sender, EventArgs e)
        {
            cboPhanLoaiSPGoiMon.Items.Clear();
            foreach(DataGridViewRow row in dtvDanhMucSanPham.Rows)
            {
                if(row.Cells[2].Value.ToString()!= null)
                cboPhanLoaiSPGoiMon.Items.Add(row.Cells[2].Value.ToString());                
            }
        }    
        private void GoiMon_Load(object sender, EventArgs e)
        {
            dtvDanhMucSanPham.DataSource = Form1.dtb;
            Form1.DongHD = new DataTable();
            Form1.DongHD.Columns.Add("STT");
            Form1.DongHD.Columns.Add("Mã Dòng");
            Form1.DongHD.Columns.Add("Mã Hóa Đơn");
            Form1.DongHD.Columns.Add("Tên Món");
            Form1.DongHD.Columns.Add("Đơn Giá");
            Form1.DongHD.Columns.Add("Số Lượng");
            Form1.DongHD.Columns.Add("Thành Tiền");

            Form1.HD = new DataTable();
            Form1.HD.Columns.Add("STT");
            Form1.HD.Columns.Add("Mã Hóa Đơn");
            Form1.HD.Columns.Add("Bàn");
            Form1.HD.Columns.Add("Tổng Tiền");
            Form1.HD.Columns.Add("Tình Trạng");
        }
        private void btnThemSPVaoHoaDon(object sender, EventArgs e)
        {
            if(IDHoaDon==0)
            {
                MessageBox.Show("Chưa chọn bàn");
            }
            else
            {
                DataGridViewRow row = this.dtvDanhMucSanPham.Rows[index];
                string tenmon = row.Cells[1].Value.ToString();
                double gia = double.Parse(row.Cells[3].Value.ToString());
                int sl = int.Parse(nupSoLuongSP.Value.ToString());
                Form1.DongHD.Rows.Add(DemSoDong + 1, IDHoaDon, IDHoaDon, tenmon, gia, sl, sl * gia);
                DemSoDong++;
                ShowChiTietBan();
                nupSoLuongSP.Value = 1;
            }
        }
        private void ShowChiTietBan()
        {
            double tongtienHD = 0;
            dtvHoaDon.Rows.Clear();
            for (int i = 0; i < DemSoDong; i++)
            {              
                DataRow rowdata = Form1.DongHD.Rows[i];
                if (rowdata["Mã Hóa Đơn"].ToString() == IDHoaDon.ToString())
                {
                    dtvHoaDon.Rows.Add(rowdata["Tên Món"].ToString(), rowdata["Số Lượng"].ToString(),
                        rowdata["Đơn Giá"].ToString(), rowdata["Thành Tiền"].ToString());
                    tongtienHD += double.Parse(rowdata["Thành Tiền"].ToString());
                }
            }
            txtTienHang.Text = tongtienHD.ToString();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = this.dtvDanhMucSanPham.Rows[e.RowIndex];
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = this.dtvHoaDon.Rows[e.RowIndex];
            nupSoLuongSP.Value = decimal.Parse(row.Cells[1].Value.ToString());
        }
        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dtvHoaDon.Rows[index];
            row.Cells[1].Value = nupSoLuongSP.Value;
        }
        public Button ban;
        private void btnBan(object sender, EventArgs e)
        {
            ban = (Button)sender;
            soBan = int.Parse(ban.Text);           
            if (trangthaiban[soBan] == false)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn tạo bàn", "Lưu ý!!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DemSoHoaDon++;
                    IDHoaDon = DemSoHoaDon;
                    trangthaiban[soBan] = true;
                    Form1.HD.Rows.Add(DemSoHoaDon, IDHoaDon, soBan, "0", "Chưa");
                    ban.BackgroundImage = Properties.Resources.banhd;
                    ShowChiTietBan();
                }
                else if (dialogResult == DialogResult.No)
                {
                    ShowChiTietBan();
                }
            }
            else
            {
                for (int i = 0; i < DemSoHoaDon; i++)
                {
                    DataRow row = Form1.HD.Rows[i];
                    if (row["Bàn"].ToString() == soBan.ToString() && row["Tình trạng"].ToString() == "Chưa")
                    {
                        IDHoaDon = int.Parse(row["Mã Hóa Đơn"].ToString());
                    }
                }
                ShowChiTietBan();
            }          
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thanh toán hoá đơn", "Lưu ý!!!", MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                for (int i = 0; i < DemSoHoaDon; i++)
                {
                    DataRow rowdata = Form1.HD.Rows[i];
                    if (rowdata["Mã Hóa Đơn"].ToString() == IDHoaDon.ToString())
                    {
                        IDHoaDon = 0;
                        trangthaiban[soBan] = false;
                        rowdata["Tình Trạng"] = "Đã thanh toán";
                        rowdata["Tổng Tiền"] = txtTienHang.Text.ToString();
                        ban.BackgroundImage = Properties.Resources.bàn;
                    }
                }
                ShowChiTietBan();
            }
            else if(dialogResult == DialogResult.No)
            {
                ShowChiTietBan();
            }             
        }
        private void Xoa(object sender, EventArgs e)
        {
        }
        private void btnTimKiem(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
