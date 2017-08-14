using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_evaluation
{
    public partial class Dashboard : UserControl
    {
        Panel MainWindow;

        public Dashboard(Panel MainWindow)
        {
            this.MainWindow = MainWindow;
            InitializeComponent();
            this.SubPanel.Controls.Add(new examTable());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.SubPanel.Controls.Clear();
            this.SubPanel.Controls.Add(new examTable());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.SubPanel.Controls.Clear();
            this.SubPanel.Controls.Add(new examDetails());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.SubPanel.Controls.Clear();
            this.SubPanel.Controls.Add(new Settings());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.SubPanel.Controls.Clear();
            this.SubPanel.Controls.Add(new Profile());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.MainWindow.Controls.Clear();
            this.MainWindow.Controls.Add(new LogIn(MainWindow));
        }
    }
}
