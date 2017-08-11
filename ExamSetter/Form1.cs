using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace ExamSetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            examsPanel.Visible = false;
            settingsPanel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dashboardPanel.Visible = true;

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "Dashboard";

            dashboardPanel.Visible = true;
            examsPanel.Visible = false;
            settingsPanel.Visible = false;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            label2.Text = "Exams";


            dashboardPanel.Visible = false;
            examsPanel.Visible = true;
            settingsPanel.Visible = false;
        }

        private void examsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            label2.Text = "Settings";

            dashboardPanel.Visible = false;
            examsPanel.Visible = false;
            settingsPanel.Visible = true;
        }
    }
}
