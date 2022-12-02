using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj3
{
    public partial class FormDangNhap : Form
    {
        /*string tentaikhoan = "admin";
        string matkhau = "admin";*/
        List<TaiKhoan> listtaikhoan = DanhSachTaiKhoan.Instance.Listtaikhoan;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kiemtradangnhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
            FormChuongTrinh f = new FormChuongTrinh();
            f.Show();
            this.Hide();
            f.DangXuat += f_DangXuat; 
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu","Lỗi");
                txtTaiKhoan.Focus();
            }
                 
        }

        void f_DangXuat(object sender, EventArgs e)
        {
            (sender as FormChuongTrinh).isThoat = false;
            (sender as FormChuongTrinh).Close();
            this.Show();
        }

        bool kiemtradangnhap(string tentaikhoan, string matkhau)
        {
           /* if(tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }*/
            for (int i = 0; i < listtaikhoan.Count; i++)
            {
                if (tentaikhoan == listtaikhoan[i].Tentaikhoan && matkhau == listtaikhoan[i].Matkhau)
                {
                    Const.TaiKhoan = listtaikhoan[i];
                    return true;
                }
                    
           }
                return false;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
        
    }
}
