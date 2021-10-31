namespace QuanLyKhachSan.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("VatTu")]
    public partial class VatTu
    {
        public int VatTuID { get; set; }

        [StringLength(50)]
        public string TenVT { get; set; }
    }

        public partial class VatTu
        {
            public static List<VatTu> GetAll()
            {
                QLKSModel context = new QLKSModel();
                return context.VatTu.ToList();
            }
            public static VatTu GetVatTu(int vatTuId)
            {
                QLKSModel context = new QLKSModel();
                return context.VatTu.Where(p => p.VatTuID == vatTuId).FirstOrDefault();

            }
            public void InsertUpdate()
            {
                QLKSModel context = new QLKSModel();
                context.VatTu.AddOrUpdate(this);
                context.SaveChanges();
            }

            public static void Delete(int id)
            {
                QLKSModel context = new QLKSModel();
                VatTu db = context.VatTu.Where(p => p.VatTuID == id).FirstOrDefault();
                if (db != null)
                {
                    //  context.Students.Attach(db);
                    context.VatTu.Remove(db);
                    context.SaveChanges();
                }
                else
                    throw new Exception("Khong ton tai trong csdl");
            }
        }

}
