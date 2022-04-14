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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(cbPhanQuyen.SelectedIndex==0)
            {
                if (txtTaiKhoan.Text == "springcuong" && txtMatKhau.Text == "875857")
                {
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    this.Hide();
                    Form1 a = new Form1();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (txtTaiKhoan.Text != "springcuong" && txtMatKhau.Text != "875857")
                    {
                        MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu vui lòng nhạp lại");
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                    else if (txtTaiKhoan.Text != "springcuong")
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                    else if (txtMatKhau.Text != "875857")
                    {
                        MessageBox.Show("Mật khẩu sai");
                        txtMatKhau.Clear();
                        txtMatKhau.Focus();
                    }
                }
            }
            if (cbPhanQuyen.SelectedIndex == 1)
            {
                if (txtTaiKhoan.Text == "springcuong15" && txtMatKhau.Text == "875857")
                {
                    this.Hide();
                    Form1 a = new Form1();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (txtTaiKhoan.Text != "springcuong15" && txtMatKhau.Text != "875857")
                    {
                        MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu vui lòng nhạp lại");
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                    else if (txtTaiKhoan.Text != "springcuong15")
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                    else if (txtMatKhau.Text != "875857")
                    {
                        MessageBox.Show("Mật khẩu sai");
                        txtMatKhau.Clear();
                        txtMatKhau.Focus();
                    }
                }
            }
        }
    }
}
