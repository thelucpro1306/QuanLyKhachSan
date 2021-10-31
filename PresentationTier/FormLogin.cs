
using QuanLyKhachSan.DataContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using QuanLyKhachSan.PresentationTier;
using System.Drawing;
using QuanLyKhachSan.BusinessTier;

namespace QuanLyKhachSan
{
    public partial class formLogin : Form
    {
        Label clickedLabel;
        TaiKhoanBT taiKhoanBT;
        public formLogin()
        {
            InitializeComponent();
            taiKhoanBT = new TaiKhoanBT();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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

                string tenDangNhap = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                MatKhau taiKhoan = taiKhoanBT.LayTaiKhoan(tenDangNhap, matKhau);
                if (taiKhoan != null)
                {
                    MessageBox.Show("Dang nhap thanh cong !!!");
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
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

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
