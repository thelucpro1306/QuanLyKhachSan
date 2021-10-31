using QuanLyKhachSan.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.PresentationTier
{
    public partial class FormQuanLyKhachHang : Form
    {
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            BindGrid(KhachHang.GetAll());
        }

        private void BindGrid(List<KhachHang> khachHangs)
        {
            dgvKhachHang.Rows.Clear();

            foreach (var item in khachHangs)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.KhachHangID;
                dgvKhachHang.Rows[index].Cells[1].Value = item.TenKH;
                dgvKhachHang.Rows[index].Cells[2].Value = item.QuocTich;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            List<KhachHang> listkh = new List<KhachHang>();
            List<HoaDon> listHD = HoaDon.GetAll();
            DateTime tungay = DateTime.Parse(dtpTuNgay.Text);
            DateTime denngay = DateTime.Parse(dtpTuNgay.Text);
            foreach (var item in listHD)
            {
                DateTime dt = DateTime.Parse(item.NgayHD);
                if (dt >= tungay && dt <= denngay)
                {
                    KhachHang kh = new KhachHang();
                    kh.KhachHangID = ((int)item.KhachHangID);
                    kh.TenKH = (item.KhachHang.TenKH);
                    kh.TenKH = (item.KhachHang.QuocTich);
                    listkh.Add(kh);
                }
            }
            BindGrid(listkh);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<KhachHang> listKQTK = KhachHang.GetAll();
            var listKhacHang = listKQTK.Where(p => (p is KhachHang) && (p as KhachHang).TenKH.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            if (listKhacHang.Count > 0)
            {
                BindGrid(listKhacHang);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!");
            }
        }
    }
}
