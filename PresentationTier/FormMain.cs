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
        public FormMain()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void CustomizeDesing()
        {
            pnlSubMenu1.Visible = false;
            pnlSubMenu2.Visible = false;
            pnlSubMenu3.Visible = false;
        }

        private void HideSubMenu()
        {
            if(pnlSubMenu1.Visible == true)
            {
                pnlSubMenu1.Visible = false;
            }

            if (pnlSubMenu2.Visible == true)
            {
                pnlSubMenu2.Visible = false;
            }

            if (pnlSubMenu3.Visible == true)
            {
                pnlSubMenu3.Visible = false;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLPhongL1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenu1);
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

        private void btnQLPhongL2_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenu2);
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

        private void btnQLPhongL3_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenu3);
        }
    }
}
