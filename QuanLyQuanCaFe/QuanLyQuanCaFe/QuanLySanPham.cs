using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace QuanLyQuanCaFe
{
    public partial class QuanLySanPham : UserControl
    {
        List<SanPham> DSSP = new List<SanPham>();
        SanPham sp;
        int index;
        int dem = 0;
        string strfileName = @"D:\DanhSachSanPhamMoi.xlsx";
        public QuanLySanPham()
        {
            InitializeComponent();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int ind = dtvQuanLySanPham.Rows.Count;
            sp  = new SanPham(txtTenSP.Text,cbLoaiSanPham.SelectedItem.ToString(),cboDonViTinh.SelectedItem.ToString(),
                int.Parse(nupSoLuongSP.Value.ToString()),double.Parse(nupGiaSP.Value.ToString()));
            dtvQuanLySanPham.Rows.Add((ind).ToString(),txtTenSP.Text, cbLoaiSanPham.SelectedItem.ToString(),
                cboDonViTinh.SelectedItem.ToString(), nupSoLuongSP.Value, nupGiaSP.Value);
            dem++;
            DSSP.Add(sp);
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dtvQuanLySanPham.Rows[index];
            row.Cells[1].Value = txtTenSP.Text;
            row.Cells[2].Value = cbLoaiSanPham.Text;
            row.Cells[3].Value = cboDonViTinh.Text ;
            row.Cells[4].Value = nupSoLuongSP.Value;
            row.Cells[5].Value = nupGiaSP.Value;
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dtvQuanLySanPham.SelectedCells)
            {
                if (oneCell.Selected)
                    dtvQuanLySanPham.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            XuatExcelSanPham(dtvQuanLySanPham, @"D:\", "DanhSachSanPhamMoi");         
            NhapExcelQLSP();
            reset();
            MessageBox.Show("Xuất và đồng bộ thành công!");
        }
        private void XuatExcelSanPham(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            int StartCol = 1;
            int StartRow = 1;
            for (int i = 0; i < g.Columns.Count - 1; i++)
            {
                obj.Cells[1, i + 1] = g.Columns[i + 1].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 1; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[StartRow + i, StartCol + j - 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            NhapExcelQLSP();
        }
        private void NhapExcelQLSP()
        {
            dtvQuanLySanPham.Rows.Clear();
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlworkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
            int xlRow;
            
            if (strfileName != string.Empty)
            {
                int stt = 0;
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(strfileName);
                xlworkSheet = xlWorkBook.Worksheets["Sheet1"];
                xlRange = xlworkSheet.UsedRange;
      
                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    stt++;
                    dtvQuanLySanPham.Rows.Add(stt,xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text,
                    xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text
                    );

                }
                xlWorkBook.Close();
                xlApp.Quit();
            }        
        }
        private void dtvQuanLySanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = this.dtvQuanLySanPham.Rows[e.RowIndex];
                txtTenSP.Text = row.Cells[1].Value.ToString();
                cbLoaiSanPham.SelectedItem = row.Cells[2].Value.ToString();
                cboDonViTinh.SelectedItem = row.Cells[3].Value.ToString();
                nupSoLuongSP.Value = decimal.Parse(row.Cells[4].Value.ToString());
                nupGiaSP.Value = decimal.Parse(row.Cells[5].Value.ToString());
            }
        }
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            cbLoaiSanPham.Text = "Cà phê";
            cboDonViTinh.Text = "Ly";
            NhapExcelQLSP();
            Form1.dtb = new DataTable();
            Form1.dtb.Columns.Add("STT");
            Form1.dtb.Columns.Add("Tên sản phẩm");
            Form1.dtb.Columns.Add("Loại sản phẩm");
            Form1.dtb.Columns.Add("Giá");
            reset();
        }
        private void reset()
        {
            Form1.dtb.Rows.Clear();
            for (int i = 0; i < dtvQuanLySanPham.Rows.Count; i++)
            {
                DataGridViewRow row = dtvQuanLySanPham.Rows[i];
                Form1.dtb.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[5].Value);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
