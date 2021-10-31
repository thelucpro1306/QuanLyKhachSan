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
    
    public partial class FormLichLamViec : Form
    {
        public FormLichLamViec()
        {
            InitializeComponent();
        }

        private void FormLichLamViec_Load(object sender, EventArgs e)
        {
            BindGrid(LichLamViec.GetAll());
            FillCaLamComboBox(LichLamViec.GetAll());
            FillNhanVienComboBox(NhanVien.GetAll());
        }

        private LichLamViec GetLichLamViec()
        {
            LichLamViec k = new LichLamViec();
            k.NhanVienID = int.Parse(cbxNhanVien.SelectedValue.ToString());
            k.Ca = cbxCaLam.Text;
            k.Ngay = dtpNgayLam.Value.ToString("dd/MM/yyyy");
            return k;
        }

        private void FillNhanVienComboBox(List<NhanVien> nhanViens)
        {
            this.cbxNhanVien.DataSource = nhanViens;
            this.cbxNhanVien.DisplayMember = "TenNV";
            this.cbxNhanVien.ValueMember = "NhanVienID";
        }

        private void FillCaLamComboBox(List<LichLamViec> list)
        {
            this.cbxCaLam.DataSource = list;
            this.cbxCaLam.DisplayMember = "Ca";
            this.cbxCaLam.ValueMember = "LichLamViecID";
        }

        private void BindGrid(List<LichLamViec> list)
        {
            dgvLichLam.Rows.Clear();
            int id = 1;
            foreach (var item in list)
            {
                int index = dgvLichLam.Rows.Add();
                dgvLichLam.Rows[index].Cells[0].Value = id++;
                dgvLichLam.Rows[index].Cells[1].Value = item.NhanVien.TenNV;
                dgvLichLam.Rows[index].Cells[2].Value = item.Ca;
                dgvLichLam.Rows[index].Cells[3].Value = item.Ngay;
                dgvLichLam.Rows[index].Cells[4].Value = item.LichLamViecID;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LichLamViec s = GetLichLamViec();
                LichLamViec db = LichLamViec.GetLichLamViec(s.LichLamViecID);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm Lịch Làm Việc thành công!");
                }
                BindGrid(LichLamViec.GetAll());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = (int)dgvLichLam.CurrentRow.Cells[4].Value;
                LichLamViec.Delete(rowIndex);
                BindGrid(LichLamViec.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LichLamViec s = GetLichLamViec();
            s.LichLamViecID = (int)dgvLichLam.CurrentRow.Cells[4].Value;
            LichLamViec db = LichLamViec.GetLichLamViec(s.LichLamViecID);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(LichLamViec.GetAll());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
