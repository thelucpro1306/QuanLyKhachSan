using QuanLyKhachSan.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.PresentationTier
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            BindGrid(NhanVien.GetAll());
            string imageFolder = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Images");
            string fileDefaultImage = Path.Combine(imageFolder, "login.png");
            picAnhNhanVien.Image = Image.FromFile(fileDefaultImage);
        }

        private void BindGrid(List<NhanVien> nhanViens)
        {
            dgvTTNhanVien.Rows.Clear();
            int id = 1;
            foreach (var item in nhanViens)
            {
                int index = dgvTTNhanVien.Rows.Add();
                dgvTTNhanVien.Rows[index].Cells[0].Value = id++;
                dgvTTNhanVien.Rows[index].Cells[1].Value = item.NhanVienID;
                dgvTTNhanVien.Rows[index].Cells[2].Value = item.TenNV;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien s = GetNhanVien();
                NhanVien db = NhanVien.GetNhanVien(s.NhanVienID);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private NhanVien GetNhanVien()
        {
            NhanVien k = new NhanVien();
            k.TenNV = txtTimKiem.Text;
            return k;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = (int)dgvTTNhanVien.CurrentRow.Cells[1].Value;
                NhanVien.Delete(rowIndex);
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công !");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien s = GetNhanVien();
            s.NhanVienID = (int)dgvTTNhanVien.CurrentRow.Cells[1].Value;
            NhanVien db = NhanVien.GetNhanVien(s.NhanVienID);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(NhanVien.GetAll());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(NhanVien.GetAll());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<NhanVien> listKQTK = NhanVien.GetAll();
            var listTimNhanVien = listKQTK.Where(p => (p is NhanVien) 
                && (p as NhanVien).TenNV.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            if (listTimNhanVien.Count > 0)
            {
                BindGrid(listTimNhanVien);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!");
            }
        }

        private void dgvTTNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTTNhanVien.Rows[e.RowIndex];
            int maNV = int.Parse(row.Cells[1].Value.ToString());
            NhanVien db = NhanVien.GetNhanVien(maNV);
            if (db != null)
            {
                txtTimKiem.Text = db.TenNV.ToString();
                string imageFolder = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "Images");
                string fileDefaultImage = Path.Combine(imageFolder, "user.png");
                if (db.PathImage != null)
                {
                    string filePath = Path.Combine(imageFolder, db.PathImage);
                    if (File.Exists(filePath))
                    {
                        picAnhNhanVien.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        if (File.Exists(fileDefaultImage))
                            picAnhNhanVien.Image = Image.FromFile(fileDefaultImage);
                    }  
                }
                else
                {
                    if (File.Exists(fileDefaultImage))
                        picAnhNhanVien.Image = Image.FromFile(fileDefaultImage);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

