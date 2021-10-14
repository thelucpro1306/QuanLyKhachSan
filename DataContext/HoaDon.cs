namespace QuanLyKhachSan.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        public int HoaDonID { get; set; }

        public int? NhanVienID { get; set; }

        public int? KhachHangID { get; set; }

        public int? PhongID { get; set; }

        [StringLength(15)]
        public string TenLoai { get; set; }

        public int? SoDem { get; set; }

        public int? SoKhach { get; set; }

        [StringLength(15)]
        public string NgayHD { get; set; }

        public int? TongTien { get; set; }

        public int? BookingID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
