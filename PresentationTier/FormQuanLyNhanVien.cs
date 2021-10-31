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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            BindGrid(LichLamViec.GetAll());
        }


        private void BindGrid(List<LichLamViec> listLichLamViec)
        {
            dgvNhanVien.Rows.Clear();
            int id = 1;
            foreach (var item in listLichLamViec)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = id++;
                dgvNhanVien.Rows[index].Cells[1].Value = item.NhanVien.TenNV;
                dgvNhanVien.Rows[index].Cells[2].Value = item.Ca;
                dgvNhanVien.Rows[index].Cells[3].Value = item.Ngay;
                dgvNhanVien.Rows[index].Cells[4].Value = item.NhanVienID;
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            FormNhanVien frm = new FormNhanVien();
            frm.Show();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            FormLichLamViec frm = new FormLichLamViec();
            frm.Show();
        }
    }
}
