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
    public partial class LogIn : UserControl
    {
        Panel MainWindow;
        public LogIn(Panel x)
        {
            this.MainWindow = x;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.MainWindow.Controls.Clear();
            this.MainWindow.Controls.Add(new Dashboard(this.MainWindow));  
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.MainWindow.Controls.Clear();
            this.MainWindow.Controls.Add(new Registration());
        }
    }
}
