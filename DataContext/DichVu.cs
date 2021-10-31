namespace QuanLyKhachSan.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        public int DichVuID { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        public int? GiaDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }

    }
    public partial class DichVu
    {
        public int SoLuong = 0;
        public int ThanhTien = 0;

        public static List<DichVu> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.DichVu.ToList();
        }
        public static DichVu GetDichVu(int dichVuId)
        {
            QLKSModel context = new QLKSModel();
            return context.DichVu.Where(p => p.DichVuID == dichVuId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.DichVu.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            DichVu db = context.DichVu.Where(p => p.DichVuID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.DichVu.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
