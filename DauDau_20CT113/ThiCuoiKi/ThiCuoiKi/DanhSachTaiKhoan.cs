using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj3
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        public static DanhSachTaiKhoan Instance
        {
            get 
            { 
                if(instance == null)
                    instance = new DanhSachTaiKhoan();
                return DanhSachTaiKhoan.instance; 
            }
            set { DanhSachTaiKhoan.instance = value; }
        }

        List<TaiKhoan> listtaikhoan;

        public List<TaiKhoan> Listtaikhoan
        {
            get { return listtaikhoan; }
            set { listtaikhoan = value; }
        }

        DanhSachTaiKhoan()
        {
            listtaikhoan = new List<TaiKhoan>();
            listtaikhoan.Add(new TaiKhoan("thu", "1", TaiKhoan.loaiTK.quantrivien));
            listtaikhoan.Add(new TaiKhoan("linh", "12", TaiKhoan.loaiTK.sinhvien));
            listtaikhoan.Add(new TaiKhoan("quy", "123", TaiKhoan.loaiTK.hocvien));
        }
    }
}
