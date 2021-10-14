using QuanLyKhachSan.DataContext;
using QuanLyKhachSan.DataTier;
using QuanLyKhachSan.DTO;
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

        public List<MatKhauDTO> LayDanhSachTaiKhoan()
        {
            return matKhauDT.LayDanhSachTaiKhoan();
        }

    }
}
