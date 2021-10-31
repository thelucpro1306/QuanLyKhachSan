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
    public partial class FormMain : Form
    {

        FormPhongL1 formPhongL1;
        public FormMain()
        {
            InitializeComponent();
            CustomizeDesing();
            formPhongL1 = new FormPhongL1();
            
        }

        private void CustomizeDesing()
        {
            pnlSubMenu1.Visible = false;
        }

        private void HideSubMenu()
        {
            if(pnlSubMenu1.Visible == true)
            {
                pnlSubMenu1.Visible = false;
            }

        }
        //

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //open Child form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlChildForm.Controls.Add(childForm);
                pnlChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex);
            }
        }





        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }



        private void btnQLPhongL1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPhongL1());
            ShowSubMenu(pnlSubMenu1);
            //pnlChildForm.Controls.Add(new UserControl1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 2
            //HideSubMenu();
        }

        private void btnPhong2_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 2
            //HideSubMenu();
        }

        private void btnPhong3_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 3
            //HideSubMenu();
        }


        private void btnPhong4_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 4
            //HideSubMenu();
        }

        private void btnPhong5_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 5
            //HideSubMenu();
        }

        private void btnPhong6_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 6
            //HideSubMenu();
        }

        private void btnPhong7_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 7
            //HideSubMenu();
        }

        private void btnPhong8_Click(object sender, EventArgs e)
        {
            //Code...
            //Mo chi tiet phong 8
            //HideSubMenu();
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // chọn chức năng 1 thì panel add form chức năng 1
            //pnlChildForm.Controls.Add(new FomQuanLyPhong());

            //pnlChildForm.Controls.Clear();
            // chọn chức năng 2 thì panel add form chức năng 2
        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyPhong());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyNhanVien());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQuanLyKhachHang());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBaoCao());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gặp quản lý để biết thêm ");
        }
    }
}
