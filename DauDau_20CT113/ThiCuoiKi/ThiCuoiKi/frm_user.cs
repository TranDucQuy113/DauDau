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
    public partial class frm_user : Form
    {

        int index = -1;
        public frm_user()
        {
            InitializeComponent();
        }

        void LoadListUser()
        {
            dtgvUser.DataSource = null;
            dtgvUser.DataSource = DanhSachTaiKhoan.Instance.Listtaikhoan;
            dtgvUser.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txbUsername.Text;
            string matkhau = txbPassWord.Text;



            DanhSachTaiKhoan.Instance.Listtaikhoan.Add(new TaiKhoan(tentaikhoan, matkhau, TaiKhoan.loaiTK.sinhvien));
            LoadListUser();
        }
        private void frm_user_Load(object sender, EventArgs e)
        {
            
            LoadListUser();
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvUser.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txbUsername.Text = row.Cells[0].Value.ToString();
                txbPassWord.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txbUsername.Text;
            string matkhau = txbPassWord.Text;
            DanhSachTaiKhoan.Instance.Listtaikhoan[index].Tentaikhoan = tentaikhoan;
            DanhSachTaiKhoan.Instance.Listtaikhoan[index].Matkhau = matkhau;

            LoadListUser();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhSachTaiKhoan.Instance.Listtaikhoan.RemoveAt(index);
            LoadListUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
