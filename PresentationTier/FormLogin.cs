using QuanLyKhachSan.BussinessTier;
using QuanLyKhachSan.DataContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.PresentationTier;
using System.Drawing;

namespace QuanLyKhachSan
{

    public partial class formLogin : Form
    {

        MatKhauBT matKhauBT;
        Label clickedLabel;
        public formLogin()
        {
            matKhauBT = new MatKhauBT();
            //lblError.Visible = false;
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

        private void txtTaiKhoan_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            customButton1.ForeColor = System.Drawing.Color.FromArgb(1, 102, 207);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            customButton1.ForeColor = System.Drawing.Color.LightGray;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //MatKhau matKhau = new MatKhau();
                List<MatKhauDTO> listMK = matKhauBT.LayDanhSachTaiKhoan();
                string username = txtTaiKhoan.Text;
                string password = txtMatKhau.Text;

                var KiemTra = listMK.Where(s => s.Username.CompareTo(username) == 0).ToList();
                if (KiemTra.Count > 0)
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

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void formLogin_MouseHover(object sender, EventArgs e)
        {
            //lblThoat.BackColor = Color.Red;
        }

        public void setColor()
        {
            if (clickedLabel != default(Label))
                clickedLabel.BackColor = Color.Yellow;
            //Resetting clicked label because another (or the same) was just clicked.
        }

        private void lblThoat_MouseEnter(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.BackColor = Color.Red;
        }

        private void lblThoat_MouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.BackColor = Color.White;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            setColor();//Calling this here so clickedLabel is still the old value
            Label theLabel = (Label)sender;
            lblThoat = theLabel;
            this.Close();
        }
    }
}
