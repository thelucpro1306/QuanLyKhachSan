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
    public partial class FormVatTu : Form
    {
        QLKSModel context;
        public FormVatTu()
        {
            InitializeComponent();
            context = new QLKSModel();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            CaiDatChucNang(true);
            List<VatTu> list = context.VatTu.ToList();
            BindGrid(list);
        }

        private void BindGrid(List<VatTu> list)
        {
            dgvVatTu.Rows.Clear();
            int id = 1;
            foreach (var item in list)
            {
                int index = dgvVatTu.Rows.Add();
                dgvVatTu.Rows[index].Cells[0].Value = id++;
                dgvVatTu.Rows[index].Cells[1].Value = item.VatTuID;
                dgvVatTu.Rows[index].Cells[2].Value = item.TenVT;
                
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

        public bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenVatTu.Text))
            {
                return false;
            }
            return true;
        }

        private void ReloadDGV()
        {
            List<VatTu> list = context.VatTu.ToList();
            BindGrid(list);
        }

        private VatTu GetVatTu()
        {
            VatTu k = new VatTu();
            k.TenVT = txtTenVatTu.Text;
            return k;
        }

        private void resetTextBox()
        {
            txtTenVatTu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                try
                {
                    VatTu s = GetVatTu();
                    VatTu db = VatTu.GetVatTu(s.VatTuID);
                    if (db == null)
                    {
                        s.InsertUpdate();
                        MessageBox.Show("Thêm vật tư thành công!");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = (int)dgvVatTu.CurrentRow.Cells[1].Value;
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa Vật tư này?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    VatTu.Delete(rowIndex);
                    MessageBox.Show("Xóa vật tư thành công");
                    ReloadDGV();
                    resetTextBox();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int ID = int.Parse(dgvVatTu.CurrentRow.Cells[1].Value.ToString());
                VatTu dbUpdate = context.VatTu.FirstOrDefault(s => s.VatTuID == ID);
                if (dbUpdate != null)
                {
                    dbUpdate.TenVT = txtTenVatTu.Text;
                    MessageBox.Show("Sửa thành công!");
                    ReloadDGV();
                    CaiDatChucNang(false);
                    resetTextBox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vật tư cần sửa!", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
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

        private void btnKLuu_Click(object sender, EventArgs e)
        {
            CaiDatChucNang(true);
            resetTextBox();
        }

        private void dgvVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvVatTu.Rows[e.RowIndex];
                int maVatTu = int.Parse(row.Cells[1].Value.ToString());
                VatTu dbContext = VatTu.GetVatTu(maVatTu);
                txtTenVatTu.Text = dbContext.TenVT.ToString();
                
            }
        }
    }
}
