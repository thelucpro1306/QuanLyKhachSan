
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
    public delegate void LuuChiTietThanhCong();
    public partial class FormChiTietPhong : Form
    {
        public event LuuChiTietThanhCong luuChiTietThanhCong;

        public FormPhongL1 objManHinhChinh;
        public FormChiTietPhong()
        {
            InitializeComponent();

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FillLoaiPhongCombobox(List<LoaiPhong> listLoaiPhong)
        {
            this.cbxLoaiPhong.DataSource = listLoaiPhong;
            this.cbxLoaiPhong.DisplayMember = "TenLoai";
            this.cbxLoaiPhong.ValueMember = "LoaiPhongID";
        }
        private void FillSoPhongCombobox(List<Phong> listSoPhong)
        {
            this.cbxSoPhong.DataSource = listSoPhong;
            this.cbxSoPhong.DisplayMember = "PhongID";
            this.cbxSoPhong.ValueMember = "PhongID";
        }

        private void FillDichVuCombobox(List<DichVu> listDichVu)
        {
            this.cbxTenDichVu.DataSource = listDichVu; 
            this.cbxTenDichVu.DisplayMember = "TenDV";
            this.cbxTenDichVu.ValueMember = "DichVuID";
        }

        private void FillComboboxNhanVien(ComboBox cmbName, List<NhanVien> listNhanVien)
        {
            this.cbxNhanVien.DataSource = listNhanVien;
            this.cbxNhanVien.DisplayMember = "TenNV";
            this.cbxNhanVien.ValueMember = "NhanVienID";
        }

        private void FormChiTietPhong_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = "0";
            txtThanhTien.Text = "0";
            txtThanhTienDV.Text = "0";
            FillDichVuCombobox(DichVu.GetAll());
            FillLoaiPhongCombobox(LoaiPhong.GetAll());
            FillSoPhongCombobox(Phong.GetAll());
            FillComboboxNhanVien(cbxNhanVien, NhanVien.GetAll());
            cbxSoPhong.SelectedIndex = 0;
            cbxNhanVien.SelectedIndex = -1;
        }

        private void STT()          
        {
            for (int i = 0; i < (dgvDichVu.Rows.Count) - 1; i++)
            {
                dgvDichVu.Rows[i].Cells["colSTT"].Value = (i + 1);
            }
        }

        private void ToTal()
        {
            int sum = 0;
            int n = dgvDichVu.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                sum += int.Parse(dgvDichVu.Rows[i].Cells["colThanhTien"].Value.ToString());
            }
            txtThanhTienDV.Text = sum.ToString();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvDichVu.SelectedRows)
            {
                dgvDichVu.Rows.RemoveAt(item.Index);
            }
            ToTal();
            STT();
        }

        private List<DichVu> GetListDichVu()  
        {            
            List<DichVu> list = new List<DichVu>();
            for (int i = 0; i < dgvDichVu.Rows.Count-1; i++)
            {
                DichVu dv = new DichVu();
                dv.DichVuID = int.Parse(dgvDichVu.Rows[i].Cells["id"].Value.ToString() + "");
                dv.GiaDV = int.Parse(dgvDichVu.Rows[i].Cells[2].Value + "");
                dv.SoLuong = int.Parse(dgvDichVu.Rows[i].Cells[3].Value + "");
                dv.ThanhTien = int.Parse(dgvDichVu.Rows[i].Cells[4].Value + "");
                list.Add(dv);
            }

            return list;
        }

        private void menuLuu_Click_1(object sender, EventArgs e)
        {             
                KhachHang kh = new KhachHang();
                kh.TenKH = txtTenKH.Text;
                kh.QuocTich = txtQuocTich.Text;
                kh.CCCD = txtCCCD.Text;
                kh = kh.InsertUpdate();
                List<DichVu> listDV = GetListDichVu();

                //insert hoa don
                HoaDon hd = GetHoaDon();
                //insert  khách hàng trước khi insert hóa đơn
                hd.KhachHangID = kh.KhachHangID;
                hd.TongTien = int.Parse(listDV.Sum(p => p.ThanhTien).ToString()) + int.Parse(txtGiaPhong.Text) * hd.SoDem.Value;

                int hoaDonID = hd.InsertUpdate();
                //MessageBox.Show("2");
                //có hóa đơn rồi insert chi tiet hoa don
                foreach (DichVu d in listDV)
                {
                    ChiTietHoaDon item = new ChiTietHoaDon();
                    item.DichVuID = d.DichVuID;
                    item.GiaDV = d.GiaDV;
                    item.HoaDonID = hoaDonID;
                    item.SoLuong = d.SoLuong;
                    item.ThanhTien = d.ThanhTien;
                    item.InsertUpdate();
                }
                FormPhongL1 frm = new FormPhongL1();
                frm.SetBookingRoom();
                this.Close();
        }


        private HoaDon GetHoaDon()
        {

                HoaDon hd = new HoaDon();
                hd.TenLoai = cbxLoaiPhong.Text;
                hd.NhanVienID = int.Parse(cbxNhanVien.SelectedValue.ToString() + "");
                hd.PhongID = int.Parse(cbxSoPhong.SelectedValue + "");
                hd.SoDem = int.Parse(txtSoDem.Text);
                hd.SoKhach = int.Parse(txtSoNguoi.Text);
                hd.NgayHD = dtpNgayTra.Value.ToString("dd/MM/yyyy");
                return hd;
       
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGiaPhong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (int.Parse(txtGiaPhong.Text) * int.Parse(txtSoDem.Text)).ToString();
            }
            catch
            {
                txtThanhTien.Text = "";
            }
            txtTongTien.Text = (int.Parse(txtThanhTien.Text) + int.Parse(txtThanhTienDV.Text)).ToString();
        }

        private void cbxSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxSoPhong.SelectedValue != null)
                {
                    Phong objPHong = Phong.GetPhong(int.Parse(cbxSoPhong.SelectedValue + ""));
                    if (objPHong != null)
                    {
                        txtGiaPhong.Text = objPHong.GiaPhong.ToString();
                    }
                }
            }
            catch 
            {
                
            }
        }

        private void cbxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxLoaiPhong.SelectedValue != null)
                {
                    LoaiPhong temp = (LoaiPhong)cbxLoaiPhong.SelectedItem;
                    var list = Phong.GetAll(temp.LoaiPhongID);
                    FillSoPhongCombobox(list);
                }
            }
            catch { }
        }

        private void txtSoNguoi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormChiTietPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            luuChiTietThanhCong();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = DichVu.GetDichVu(int.Parse(cbxTenDichVu.SelectedValue.ToString()));
                if (txtSoLuong.Text == "")
                    throw new Exception("Vui long nhap so luong!");
                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = (index + 1).ToString();
                dgvDichVu.Rows[index].Cells[1].Value = dv.TenDV;
                dgvDichVu.Rows[index].Cells[2].Value = dv.GiaDV + "";
                dgvDichVu.Rows[index].Cells[3].Value = txtSoLuong.Text + "";
                int thanhtien = dv.GiaDV.Value * int.Parse(txtSoLuong.Text);
                dgvDichVu.Rows[index].Cells[4].Value = thanhtien;
                dgvDichVu.Rows[index].Cells["id"].Value = dv.DichVuID + "";
                ToTal();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi cho nay` " + ex.Message);
            }
        }

        private void txtSoDem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (int.Parse(txtGiaPhong.Text) * int.Parse(txtSoDem.Text)).ToString();
            }
            catch
            {
                txtThanhTien.Text = "";
            }
            txtTongTien.Text = (int.Parse(txtThanhTien.Text) + int.Parse(txtThanhTienDV.Text)).ToString();
        }
    }   
}
