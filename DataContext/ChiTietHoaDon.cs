namespace QuanLyKhachSan.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        public int ChiTietHoaDonID { get; set; }

        public int? HoaDonID { get; set; }

        public int? DichVuID { get; set; }

        public int? GiaDV { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
    public partial class ChiTietHoaDon
    {
        public static List<ChiTietHoaDon> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.ChiTietHoaDon.ToList();
        }
        public static ChiTietHoaDon GetChiTietHoaDon(int cthdId)
        {
            QLKSModel context = new QLKSModel();
            return context.ChiTietHoaDon.Where(p => p.ChiTietHoaDonID == cthdId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.ChiTietHoaDon.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
