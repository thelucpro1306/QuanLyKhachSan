using QuanLyKhachSan.DataContext;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DataTier
{
    class MatKhauDT
    {
        public List<MatKhauDTO> LayDanhSachTaiKhoan()
        {
            using (var dbContext = new QLKSModel())
            {
                return (from tk in dbContext.MatKhau
                        select new MatKhauDTO() {
                            Username = tk.username,
                            Password = tk.password
                        }).ToList();
            }
        }
    }
}
