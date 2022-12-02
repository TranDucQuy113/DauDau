using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj3
{
    public class TaiKhoan
    {
        private string tentaikhoan;

        public string Tentaikhoan
        {
            get { return tentaikhoan; }
            set { tentaikhoan = value; }
        }
        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public enum loaiTK
        {
            quantrivien,
            sinhvien,
            hocvien
        }

        private loaiTK loaiTaiKhoan;

        public loaiTK LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }

        private string tenhienthi;

        public string Tenhienthi
        {
            get 
            { 
                switch(LoaiTaiKhoan)
                {
                    case loaiTK.quantrivien:
                        Tenhienthi = "Quản trị viên";
                        break;
                    case loaiTK.sinhvien:
                        Tenhienthi = "Sinh viên";
                        break;
                    default:
                        Tenhienthi = "Học viên";
                        break;
                    
                }
                return tenhienthi; 
            }
            set { tenhienthi = value; }
        }

        public TaiKhoan(string tentaikhoan, string matkhau, loaiTK loaiTaiKhoan)
        {
            this.Tentaikhoan = tentaikhoan;
            this.Matkhau = matkhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

    }
}
