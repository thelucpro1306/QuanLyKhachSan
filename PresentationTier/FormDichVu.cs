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
    public partial class FormDichVu : Form
    {
        QLKSModel context;
        public FormDichVu()
        {
            InitializeComponent();
            context = new QLKSModel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindGrid(List<DichVu> listDichVu)
        {
            dgvCapNhatDichVu.Rows.Clear();
            int id = 1;
            foreach (var item in listDichVu)
            {
                int index = dgvCapNhatDichVu.Rows.Add();
                dgvCapNhatDichVu.Rows[index].Cells[0].Value = id++;
                dgvCapNhatDichVu.Rows[index].Cells[1].Value = item.DichVuID;
                dgvCapNhatDichVu.Rows[index].Cells[2].Value = item.TenDV;
                dgvCapNhatDichVu.Rows[index].Cells[3].Value = item.GiaDV;
            }
        }


        private void FormDichVu_Load(object sender, EventArgs e)
        {
            List<DichVu> list = context.DichVu.ToList();
            BindGrid(list);
            CaiDatChucNang(true);
        }

        public bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGiaDichVu.Text))
            {
                return false;
            }
            else
            {
                if (int.TryParse(txtGiaDichVu.Text, out int a))
                {
                    return true;
                }
                return false;
            }
        }

        private void ReloadDGV()
        {
            List<DichVu> list = context.DichVu.ToList();
            BindGrid(list);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                try
                {
                    DichVu s = GetDichVu();
                    DichVu db = DichVu.GetDichVu(s.DichVuID);
                    if (db == null)
                    {
                        s.InsertUpdate();
                        MessageBox.Show("Thêm dịch vụ thành công!");
                    }
                    ReloadDGV();
                    CaiDatChucNang(false);
                    resetTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CaiDatChucNang(bool status)
        {
            btnThem.Enabled = status;
            btnXoa.Enabled = status;
            btnSua.Enabled = status;
            btnLuu.Enabled = !status;
            btnKLuu.Enabled = !status;
            btnThoat.Enabled = status;
        }

        private DichVu GetDichVu()
        {
            DichVu k = new DichVu();
            k.TenDV = txtTenDichVu.Text;
            k.GiaDV = int.Parse(txtGiaDichVu.Text);
            return k;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            ReloadDGV();
            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            CaiDatChucNang(true);
            resetTextBox();
        }

        private void dgvCapNhatDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCapNhatDichVu.Rows[e.RowIndex];
                int maDV = int.Parse(row.Cells[1].Value.ToString());
                DichVu db = DichVu.GetDichVu(maDV);
                txtTenDichVu.Text = db.TenDV.ToString();
                txtGiaDichVu.Text = db.GiaDV.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int ID = int.Parse(dgvCapNhatDichVu.CurrentRow.Cells[1].Value.ToString());
                DichVu dbUpdate = context.DichVu.FirstOrDefault(s => s.DichVuID == ID);
                if (dbUpdate != null)
                {
                    dbUpdate.TenDV = txtTenDichVu.Text;
                    dbUpdate.GiaDV = int.Parse(txtGiaDichVu.Text);
                    MessageBox.Show("Sửa thành công!");
                    CaiDatChucNang(false);
                    resetTextBox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dịch vụ cần sửa!", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void resetTextBox()
        {
            txtGiaDichVu.Text = "";
            txtTenDichVu.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                    int rowIndex = (int)dgvCapNhatDichVu.CurrentRow.Cells[1].Value;
                    DialogResult dlr = MessageBox.Show("Bạn muốn xóa dịch vụ này?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        DichVu.Delete(rowIndex);
                        MessageBox.Show("Xóa dịch vụ thành công");
                        ReloadDGV();
                        resetTextBox();
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnKLuu_Click(object sender, EventArgs e)
        {
            CaiDatChucNang(true);
            resetTextBox();
        }
    }
}
