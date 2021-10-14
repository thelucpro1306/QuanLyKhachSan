using QuanLyKhachSan.BussinessTier;
using QuanLyKhachSan.DataContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.PresentationTier;

namespace QuanLyKhachSan
{

    public partial class formLogin : Form
    {

        MatKhauBT matKhauBT;
        public formLogin()
        {
            matKhauBT = new MatKhauBT();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //MatKhau matKhau = new MatKhau();
                List<MatKhauDTO> listMK = matKhauBT.LayDanhSachTaiKhoan();
                string username = txtTaiKhoan.Text;
                string password = txtMatKhau.Text;

                var KiemTra = listMK.Where(s => s.Username.CompareTo(username) == 0).ToList();
                if(KiemTra.Count > 0)
                {
                    if (KiemTra[0].Password.CompareTo(password) == 0)
                    {
                        MessageBox.Show("Dang nhap thanh cong");
                        FormMain formMain = new FormMain();
                        
                        formMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai mat khau");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tai khoan");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi: " + ex);
            }
        }

        private void txtTaiKhoan_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.FromArgb(1, 102, 207);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.ForeColor = System.Drawing.Color.LightGray;
        }
    }
}
