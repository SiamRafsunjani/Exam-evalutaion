using System;
using System.Windows.Forms;

namespace ExamSetter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //
        #region window controls
        //
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        //
        #region sidebar controls
        //
        private void SidebarButton_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 95)
            {
                SideBar.Visible = false;
                SideBar.Width = 216;
                panel_ProfileInfo_Min.Visible = false;
                panel_ProfileInfo_Max.Visible = true;
                animate_SlideHorizontal.ShowSync(SideBar);
            }
            else if (SideBar.Width == 216)
            {
                SideBar.Visible = false;
                SideBar.Width = 95;
                animate_SlideHorizontal.Show(SideBar);
                panel_ProfileInfo_Max.Visible = false;
                panel_ProfileInfo_Min.Visible = true;
            }
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exams_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
