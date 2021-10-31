namespace QuanLyKhachSan.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDon = new HashSet<HoaDon>();
            LichLamViec = new HashSet<LichLamViec>();
            MatKhau = new HashSet<MatKhau>();
        }

        public int NhanVienID { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(200)]
        public string PathImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichLamViec> LichLamViec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatKhau> MatKhau { get; set; }
    }

    public partial class NhanVien
    {
        public static List<NhanVien> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.NhanVien.ToList();
        }
        public static NhanVien GetNhanVien(int idNhanVien)
        {
            QLKSModel context = new QLKSModel();
            return context.NhanVien.Where(p => p.NhanVienID == idNhanVien).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.NhanVien.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            NhanVien db = context.NhanVien.Where(p => p.NhanVienID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.NhanVien.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }

}
