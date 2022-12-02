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
    public partial class FormChuongTrinh : Form
    {
        string Status = "";
        int Index = -1; 

        public bool isThoat = true;

        public event EventHandler DangXuat;

        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
            
            /*this.Close();
           isThoat = false;
            FormDangNhap f = new FormDangNhap();
            f.Show();*/
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void FormChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
            }
            
        }

        void PhanQuyen()
        {
           /* if(Const.TaiKhoan.LoaiTaiKhoan == false)
            {
                btnQuanLyTaiKhoan.Enabled = false;
            }*/

            switch(Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.loaiTK.sinhvien:
                    btnQuanLyTaiKhoan.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                    break;
                case TaiKhoan.loaiTK.hocvien:
                    btnQuanLyTaiKhoan.Enabled  = btnSua.Enabled = btnXoa.Enabled = false;
                    break;
            }

            txtLoaiTk.Text = Const.TaiKhoan.Tenhienthi;

        }

        void CreateColumnForDataGridView()
        {
            var coltensinhvien = new DataGridViewTextBoxColumn();
            var colmasinhvien = new DataGridViewTextBoxColumn();
            var coldiachi = new DataGridViewTextBoxColumn();
            var colnoisinh = new DataGridViewTextBoxColumn();

            coltensinhvien.HeaderText = "Tên sinh viên";
            colmasinhvien.HeaderText = "Mã sinh viên";
            coldiachi.HeaderText = "Địa chỉ";
            colnoisinh.HeaderText = "Nơi sinh";

            coltensinhvien.DataPropertyName = "tensinhvien";
            colmasinhvien.DataPropertyName = "masinhvien";
            coldiachi.DataPropertyName = "diachi";
            colnoisinh.DataPropertyName = "noisinh";

            dtgvPhoneBook.Columns.AddRange(new DataGridViewTextBoxColumn[] { coltensinhvien, colmasinhvien, coldiachi, colnoisinh });

            coltensinhvien.Width = 200;
            colmasinhvien.Width = 120;
            coldiachi.Width = 220;
            colnoisinh.Width = 150;
        }

        void EnableControl(bool isEnableTextBox, bool isEnableDataGridView)
        {
            txbtensinhvien.Enabled = txbmasinhvien.Enabled = txbdiachi.Enabled = txbnoisinh.Enabled = isEnableTextBox;
            dtgvPhoneBook.Enabled = isEnableDataGridView;

        }

        void LoadListPBook()
        {
            dtgvPhoneBook.DataSource = null;
            CreateColumnForDataGridView();
            dtgvPhoneBook.DataSource = ListPBook.Instance.ListDangNhap1;
            dtgvPhoneBook.Refresh();
        }
        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            CreateColumnForDataGridView();
            LoadListPBook();
            EnableControl(false, true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControl(true, false);
            Status = "Add";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string tensinhvien = txbtensinhvien.Text;
            string masinhvien = txbmasinhvien.Text;
            string diachi = txbdiachi.Text;
            string noisinh = txbnoisinh.Text;
            if(Status == "Add")
            {
                ListPBook.Instance.ListDangNhap1.Add(new PBook(tensinhvien, masinhvien, diachi, noisinh));
            }
            if (Status == "Edit")
            {
                ListPBook.Instance.ListDangNhap1[Index].Tensinhvien = txbtensinhvien.Text;
                ListPBook.Instance.ListDangNhap1[Index].Masinhvien = txbmasinhvien.Text;
                ListPBook.Instance.ListDangNhap1[Index].Diachi = txbdiachi.Text;
                ListPBook.Instance.ListDangNhap1[Index].Noisinh = txbnoisinh.Text;

            }

            EnableControl(false, true);
            LoadListPBook();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl(true, false);
            if(Index < 0)
            {
                MessageBox.Show("Hãy chọn một bản ghi", "Cảnh báo");
                    return;
            }
            

            Status = "Edit";
        }

        private void dtgvPhoneBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListPBook.Instance.ListDangNhap1.RemoveAt(Index);
            LoadListPBook();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_user f = new frm_user();
            f.ShowDialog();
        }

        private void txbtensinhvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbmasinhvien_TextChanged(object sender, EventArgs e)
        {
            string search = txbmasinhvien.Text;

            if (search != "")
            {
                List<PBook> listSearch = new List<PBook>();
                foreach (var item in ListPBook.Instance.ListDangNhap1)
                {

                    if (item.Masinhvien.ToLower().Contains(search.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    dtgvPhoneBook.DataSource = null;
                    CreateColumnForDataGridView();
                    dtgvPhoneBook.DataSource = listSearch;

                }


            }
            else
            {
                dtgvPhoneBook.DataSource = null;
                LoadListPBook();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void txbTimkiem_TextChanged(object sender, EventArgs e)
        { 
        
        }
    }
}
