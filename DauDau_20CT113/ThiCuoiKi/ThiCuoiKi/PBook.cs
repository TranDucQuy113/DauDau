using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj3
{
    public class PBook
    {
        private string tensinhvien;

        public string Tensinhvien
        {
            get { return tensinhvien; }
            set { tensinhvien = value; }
        }
        private string masinhvien;

        public string Masinhvien
        {
            get { return masinhvien; }
            set { masinhvien = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string noisinh;

        public string Noisinh
        {
            get { return noisinh; }
            set { noisinh = value; }
        }

        public PBook(string tensinhvien, string masinhvien, string diachi, string noisinh)
        {
            Tensinhvien = tensinhvien;
            Masinhvien = masinhvien;
            Diachi = diachi;
            Noisinh = noisinh;
        }

    }
}
