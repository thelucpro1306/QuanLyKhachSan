using QuanLyKhachSan.DataContext;
using QuanLyKhachSan.DataTier;

using QuanLyKhachSan.LIbs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BussinessTier
{
    class MatKhauBT
    {
        private readonly MatKhauDT matKhauDT;
        public MatKhauBT()
        {
            matKhauDT = new MatKhauDT();
        }

        public MatKhau LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            matKhau = Helper.MaHoaMd5(matKhau);
            return matKhauDT.LayDanhSachTaiKhoan(tenDangNhap, matKhau);
        }

    }
}
