using QuanLyKhachSan.DataContext;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DataTier
{
    class MatKhauDT
    {
        public MatKhau LayDanhSachTaiKhoan(string tenDangNhap, string matKhau)
        {
            using (var dbContext = new QLKSModel())
            {
                return dbContext.MatKhau.Where(s => s.username == tenDangNhap && s.password == matKhau).FirstOrDefault();
            }
        }
    }
}
