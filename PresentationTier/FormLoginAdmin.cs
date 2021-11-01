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
    public delegate void DangNhapThanhCong();
    public partial class FormLoginAdmin : Form
    {
        public event DangNhapThanhCong dangNhapThanhCong;
        public FormLoginAdmin()
        {
            
            InitializeComponent();
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //MatKhau matKhau = new MatKhau();
                if (string.IsNullOrEmpty(txtTaiKhoan.Text))
                {
                    MessageBox.Show("Vui long nhap ten dang nhap!!");
                    return;
                }
                if (string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui long nhap mat khau!!");
                    return;
                }

                if(txtTaiKhoan.Text.CompareTo("admin") == 0)
                {
                    if (txtMatKhau.Text.CompareTo("admin")==0)
                    {
                        MessageBox.Show("Dang nhap thanh cong");
                        this.Close();
                    }
                    else
                    {
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Visible = true;
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show("Loi: " + ex);
            }
        }

        private void FormLoginAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            dangNhapThanhCong();
        }
    }
}
