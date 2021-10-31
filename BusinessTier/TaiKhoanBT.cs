using QuanLyKhachSan.DataContext;
using QuanLyKhachSan.DataTier;
using QuanLyKhachSan.LIbs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BusinessTier
{
    class TaiKhoanBT
    {
        private readonly TaiKhoanDT taiKhoanDT;
        public TaiKhoanBT()
        {
            taiKhoanDT = new TaiKhoanDT();
        }
        public MatKhau LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            matKhau = Helper.MaHoaMd5(matKhau);
            return taiKhoanDT.LayTaiKhoan(tenDangNhap, matKhau);
        }
    }
}
