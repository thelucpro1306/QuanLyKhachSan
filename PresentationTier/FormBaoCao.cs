using Microsoft.Reporting.WinForms;
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
    
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        public List<HoaDonReport> ConvertData(List<HoaDon> hoadon)
        {
            List<HoaDonReport> result = new List<HoaDonReport>();
            for (int i = 0; i < hoadon.Count; i++)
            {
                HoaDonReport hd = new HoaDonReport();
                hd.HoaDonID = hoadon[i].HoaDonID;
                hd.TenKH = hoadon[i].KhachHang.TenKH;
                hd.NgayHD = hoadon[i].NgayHD;
                hd.TenNhanVien = hoadon[i].NhanVien.TenNV;
                hd.PhongID = hoadon[i].Phong.PhongID;
                hd.SoDem = (int)hoadon[i].SoDem;
                hd.HoaDonID = (int)hoadon[i].SoKhach;
                hd.SoKhach = (int)hoadon[i].SoKhach;
                hd.TenLoai = hoadon[i].TenLoai;
                hd.TongTien = (int)hoadon[i].TongTien;
                result.Add(hd);
            }
            return result;
        }


        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportBaoCao.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", ConvertData(HoaDon.GetAll()));

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
