namespace ExamSetter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopBar = new System.Windows.Forms.Panel();
            this.label_ApplicationName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivePanel_Label = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btn_Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.animate_SlideHorizontal = new BunifuAnimatorNS.Animator(this.components);
            this.SidebarButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_ProfileInfo_Max = new System.Windows.Forms.Panel();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Exams = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Dashboard = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel_ProfileInfo_Min = new System.Windows.Forms.PictureBox();
            this.TopBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_ProfileInfo_Max.SuspendLayout();
            this.panel_Dashboard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ProfileInfo_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.TopBar.Controls.Add(this.btn_Minimize);
            this.TopBar.Controls.Add(this.btn_Close);
            this.TopBar.Controls.Add(this.label_ApplicationName);
            this.animate_SlideHorizontal.SetDecoration(this.TopBar, BunifuAnimatorNS.DecorationType.None);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1024, 40);
            this.TopBar.TabIndex = 12;
            // 
            // label_ApplicationName
            // 
            this.label_ApplicationName.AutoSize = true;
            this.label_ApplicationName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.label_ApplicationName, BunifuAnimatorNS.DecorationType.None);
            this.label_ApplicationName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ApplicationName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_ApplicationName.Location = new System.Drawing.Point(21, 1);
            this.label_ApplicationName.Name = "label_ApplicationName";
            this.label_ApplicationName.Size = new System.Drawing.Size(211, 30);
            this.label_ApplicationName.TabIndex = 4;
            this.label_ApplicationName.Text = "Exam Evaluation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.ActivePanel_Label);
            this.animate_SlideHorizontal.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(216, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 65);
            this.panel2.TabIndex = 14;
            // 
            // ActivePanel_Label
            // 
            this.ActivePanel_Label.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.ActivePanel_Label, BunifuAnimatorNS.DecorationType.None);
            this.ActivePanel_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivePanel_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActivePanel_Label.Location = new System.Drawing.Point(59, 18);
            this.ActivePanel_Label.Name = "ActivePanel_Label";
            this.ActivePanel_Label.Size = new System.Drawing.Size(113, 22);
            this.ActivePanel_Label.TabIndex = 4;
            this.ActivePanel_Label.Text = "Dashboard";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.SideBar.Controls.Add(this.panel_ProfileInfo_Min);
            this.SideBar.Controls.Add(this.SidebarButton);
            this.SideBar.Controls.Add(this.btn_Dashboard);
            this.SideBar.Controls.Add(this.btn_Logout);
            this.SideBar.Controls.Add(this.btn_Profile);
            this.SideBar.Controls.Add(this.btn_Settings);
            this.SideBar.Controls.Add(this.btn_Exams);
            this.SideBar.Controls.Add(this.panel_ProfileInfo_Max);
            this.animate_SlideHorizontal.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 40);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(216, 603);
            this.SideBar.TabIndex = 13;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.ImageActive = null;
            this.btn_Minimize.Location = new System.Drawing.Point(949, 17);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(28, 20);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimize.TabIndex = 8;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Zoom = 20;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(981, 8);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 7;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 20;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // animate_SlideHorizontal
            // 
            this.animate_SlideHorizontal.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animate_SlideHorizontal.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animate_SlideHorizontal.DefaultAnimation = animation3;
            this.animate_SlideHorizontal.TimeStep = 0.01F;
            // 
            // SidebarButton
            // 
            this.SidebarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SidebarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.SidebarButton, BunifuAnimatorNS.DecorationType.None);
            this.SidebarButton.Image = ((System.Drawing.Image)(resources.GetObject("SidebarButton.Image")));
            this.SidebarButton.Location = new System.Drawing.Point(176, 6);
            this.SidebarButton.Name = "SidebarButton";
            this.SidebarButton.Size = new System.Drawing.Size(37, 38);
            this.SidebarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SidebarButton.TabIndex = 8;
            this.SidebarButton.TabStop = false;
            this.SidebarButton.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // pictureBox2
            // 
            this.animate_SlideHorizontal.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siam Rafsunjani";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Teacher";
            // 
            // panel_ProfileInfo_Max
            // 
            this.panel_ProfileInfo_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.panel_ProfileInfo_Max.Controls.Add(this.label5);
            this.panel_ProfileInfo_Max.Controls.Add(this.label1);
            this.panel_ProfileInfo_Max.Controls.Add(this.pictureBox2);
            this.animate_SlideHorizontal.SetDecoration(this.panel_ProfileInfo_Max, BunifuAnimatorNS.DecorationType.None);
            this.panel_ProfileInfo_Max.Location = new System.Drawing.Point(42, 47);
            this.panel_ProfileInfo_Max.Name = "panel_ProfileInfo_Max";
            this.panel_ProfileInfo_Max.Size = new System.Drawing.Size(158, 158);
            this.panel_ProfileInfo_Max.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.BorderRadius = 0;
            this.btn_Logout.ButtonText = "     Log Out";
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Logout, BunifuAnimatorNS.DecorationType.None);
            this.btn_Logout.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Iconimage")));
            this.btn_Logout.Iconimage_right = null;
            this.btn_Logout.Iconimage_right_Selected = null;
            this.btn_Logout.Iconimage_Selected = null;
            this.btn_Logout.IconZoom = 70D;
            this.btn_Logout.IsTab = false;
            this.btn_Logout.Location = new System.Drawing.Point(42, 520);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Logout.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Logout.selected = false;
            this.btn_Logout.Size = new System.Drawing.Size(175, 45);
            this.btn_Logout.TabIndex = 101;
            this.btn_Logout.Textcolor = System.Drawing.Color.Black;
            this.btn_Logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profile.BorderRadius = 0;
            this.btn_Profile.ButtonText = "     Profile";
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Profile, BunifuAnimatorNS.DecorationType.None);
            this.btn_Profile.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Profile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Profile.Iconimage")));
            this.btn_Profile.Iconimage_right = null;
            this.btn_Profile.Iconimage_right_Selected = null;
            this.btn_Profile.Iconimage_Selected = null;
            this.btn_Profile.IconZoom = 70D;
            this.btn_Profile.IsTab = false;
            this.btn_Profile.Location = new System.Drawing.Point(42, 445);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Profile.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Profile.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Profile.selected = false;
            this.btn_Profile.Size = new System.Drawing.Size(175, 45);
            this.btn_Profile.TabIndex = 100;
            this.btn_Profile.Textcolor = System.Drawing.Color.Black;
            this.btn_Profile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Settings.BorderRadius = 0;
            this.btn_Settings.ButtonText = "     Settings";
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Settings, BunifuAnimatorNS.DecorationType.None);
            this.btn_Settings.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Iconimage")));
            this.btn_Settings.Iconimage_right = null;
            this.btn_Settings.Iconimage_right_Selected = null;
            this.btn_Settings.Iconimage_Selected = null;
            this.btn_Settings.IconZoom = 70D;
            this.btn_Settings.IsTab = false;
            this.btn_Settings.Location = new System.Drawing.Point(42, 370);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Settings.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Settings.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Settings.selected = false;
            this.btn_Settings.Size = new System.Drawing.Size(175, 45);
            this.btn_Settings.TabIndex = 99;
            this.btn_Settings.Textcolor = System.Drawing.Color.Black;
            this.btn_Settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Exams
            // 
            this.btn_Exams.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Exams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Exams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exams.BorderRadius = 0;
            this.btn_Exams.ButtonText = "     Exams";
            this.btn_Exams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Exams, BunifuAnimatorNS.DecorationType.None);
            this.btn_Exams.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exams.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Exams.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Exams.Iconimage")));
            this.btn_Exams.Iconimage_right = null;
            this.btn_Exams.Iconimage_right_Selected = null;
            this.btn_Exams.Iconimage_Selected = null;
            this.btn_Exams.IconZoom = 70D;
            this.btn_Exams.IsTab = false;
            this.btn_Exams.Location = new System.Drawing.Point(42, 295);
            this.btn_Exams.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btn_Exams.Name = "btn_Exams";
            this.btn_Exams.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Exams.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Exams.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Exams.selected = false;
            this.btn_Exams.Size = new System.Drawing.Size(175, 45);
            this.btn_Exams.TabIndex = 103;
            this.btn_Exams.Textcolor = System.Drawing.Color.Black;
            this.btn_Exams.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exams.Click += new System.EventHandler(this.btn_Exams_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dashboard.BorderRadius = 0;
            this.btn_Dashboard.ButtonText = "     Dashboard";
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animate_SlideHorizontal.SetDecoration(this.btn_Dashboard, BunifuAnimatorNS.DecorationType.None);
            this.btn_Dashboard.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Iconimage")));
            this.btn_Dashboard.Iconimage_right = null;
            this.btn_Dashboard.Iconimage_right_Selected = null;
            this.btn_Dashboard.Iconimage_Selected = null;
            this.btn_Dashboard.IconZoom = 70D;
            this.btn_Dashboard.IsTab = false;
            this.btn_Dashboard.Location = new System.Drawing.Point(42, 220);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.btn_Dashboard.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btn_Dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Dashboard.selected = false;
            this.btn_Dashboard.Size = new System.Drawing.Size(175, 45);
            this.btn_Dashboard.TabIndex = 104;
            this.btn_Dashboard.Textcolor = System.Drawing.Color.Black;
            this.btn_Dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // panel_Dashboard
            // 
            this.panel_Dashboard.Controls.Add(this.tableLayoutPanel1);
            this.animate_SlideHorizontal.SetDecoration(this.panel_Dashboard, BunifuAnimatorNS.DecorationType.None);
            this.panel_Dashboard.Location = new System.Drawing.Point(216, 102);
            this.panel_Dashboard.Name = "panel_Dashboard";
            this.panel_Dashboard.Size = new System.Drawing.Size(808, 541);
            this.panel_Dashboard.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.25243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label18, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label23, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label24, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label25, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label26, 3, 5);
            this.animate_SlideHorizontal.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.20497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.79503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 434);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.label21.Location = new System.Drawing.Point(30, 397);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "5.";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.label17.Location = new System.Drawing.Point(30, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "4.";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Location = new System.Drawing.Point(30, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "3.";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Location = new System.Drawing.Point(30, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "2.";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Advanced computer network";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exam Title";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Attended";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Date";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Advanced computer network";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Advanced computer network";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(149, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(230, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Advanced computer network";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(149, 393);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(230, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "Advanced computer network";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(503, 109);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 20);
            this.label22.TabIndex = 33;
            this.label22.Text = "34";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(503, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "89";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(503, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "28";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(503, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "67";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(503, 393);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "78";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(591, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 20);
            this.label23.TabIndex = 38;
            this.label23.Text = "34/23/2017";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(591, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 20);
            this.label20.TabIndex = 39;
            this.label20.Text = "34/23/2017";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(591, 264);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 20);
            this.label24.TabIndex = 40;
            this.label24.Text = "34/23/2017";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(591, 333);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 20);
            this.label25.TabIndex = 41;
            this.label25.Text = "34/23/2017";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.animate_SlideHorizontal.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(591, 393);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "34/23/2017";
            // 
            // panel_ProfileInfo_Min
            // 
            this.animate_SlideHorizontal.SetDecoration(this.panel_ProfileInfo_Min, BunifuAnimatorNS.DecorationType.None);
            this.panel_ProfileInfo_Min.Image = ((System.Drawing.Image)(resources.GetObject("panel_ProfileInfo_Min.Image")));
            this.panel_ProfileInfo_Min.Location = new System.Drawing.Point(32, 73);
            this.panel_ProfileInfo_Min.Name = "panel_ProfileInfo_Min";
            this.panel_ProfileInfo_Min.Size = new System.Drawing.Size(55, 55);
            this.panel_ProfileInfo_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panel_ProfileInfo_Min.TabIndex = 105;
            this.panel_ProfileInfo_Min.TabStop = false;
            this.panel_ProfileInfo_Min.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 643);
            this.Controls.Add(this.panel_Dashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TopBar);
            this.animate_SlideHorizontal.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidebarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_ProfileInfo_Max.ResumeLayout(false);
            this.panel_ProfileInfo_Max.PerformLayout();
            this.panel_Dashboard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ProfileInfo_Min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ActivePanel_Label;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel TopBar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.Label label_ApplicationName;
        private BunifuAnimatorNS.Animator animate_SlideHorizontal;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profile;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Settings;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Exams;
        private System.Windows.Forms.Panel panel_ProfileInfo_Max;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox SidebarButton;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Dashboard;
        private System.Windows.Forms.Panel panel_Dashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox panel_ProfileInfo_Min;




    }
}

