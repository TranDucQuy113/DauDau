using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pj3
{
    public class ListPBook
    {
        private static ListPBook instance;

        public static ListPBook Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ListPBook();
                return ListPBook.instance; 
            }
            set { ListPBook.instance = value; }
        }

        List<PBook> ListDangNhap;

        public List<PBook> ListDangNhap1
        {
            get { return ListDangNhap; }
            set { ListDangNhap = value; }
        }

        

        

        private ListPBook()
        {
            ListDangNhap = new List<PBook>();
            ListDangNhap.Add(new PBook("Nguyễn Ngọc Minh Thư", "120001110", "Biên Hòa", "Biên Hòa"));
            ListDangNhap.Add(new PBook("Trần Thi Thanh", "120004567", "Biên Hòa", "Đồng Nai"));
            ListDangNhap.Add(new PBook("Đồng Hữu Sang", "120001155", "Đồng Nai", "Bình Dương"));
        }
    }
}
