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
    public partial class FormQuanLyPhong : Form
    {
        public FormQuanLyPhong()
        {
            InitializeComponent();
        }

        //Do du lieu ra dgv
        private void BindGrid(List<Phong> listPhong)
        {
            dgvQuanLyPhong.Rows.Clear();

            foreach (var item in listPhong)
            {
                int index = dgvQuanLyPhong.Rows.Add();
                dgvQuanLyPhong.Rows[index].Cells[0].Value = item.PhongID;
                dgvQuanLyPhong.Rows[index].Cells[1].Value = item.LoaiPhong.TenLoai;
                dgvQuanLyPhong.Rows[index].Cells[2].Value = item.GiaPhong;
            }
        }


        private void FormQuanLyPhong_Load(object sender, EventArgs e)
        {
            BindGrid(Phong.GetAll());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatVatTu_Click(object sender, EventArgs e)
        {
            FormVatTu frm = new FormVatTu();
            frm.Show();
        }

        private void btnCapNhatDichVu_Click(object sender, EventArgs e)
        {
            FormDichVu frm = new FormDichVu();
            frm.Show();
        }

        private void btnCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
