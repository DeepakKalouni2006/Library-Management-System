namespace Library_Management_System
{
    partial class DashBoard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            cuiButton7 = new CuoreUI.Controls.cuiButton();
            cuiButton6 = new CuoreUI.Controls.cuiButton();
            cuiButton4 = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiButton5 = new CuoreUI.Controls.cuiButton();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            panel2 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            panel4 = new Panel();
            label15 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label5 = new Label();
            cuiSpinner1 = new CuoreUI.Controls.cuiSpinner();
            uiBarChart1 = new Sunny.UI.UIBarChart();
            cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(179, 54);
            label1.TabIndex = 4;
            label1.Text = "LIBRARY\r\n";
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(260, 31);
            label2.TabIndex = 5;
            label2.Text = "MANAGEMENT SYSTEM";
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 31, 77);
            panel1.Controls.Add(cuiSeparator1);
            panel1.Controls.Add(cuiButton7);
            panel1.Controls.Add(cuiButton6);
            panel1.Controls.Add(cuiButton4);
            panel1.Controls.Add(cuiButton2);
            panel1.Controls.Add(cuiButton5);
            panel1.Controls.Add(cuiButton3);
            panel1.Controls.Add(cuiButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 723);
            panel1.TabIndex = 6;
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(0, 112);
            cuiSeparator1.Margin = new Padding(4, 5, 4, 5);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(275, 25);
            cuiSeparator1.TabIndex = 3;
            cuiSeparator1.Thickness = 0.5F;
            cuiSeparator1.Vertical = false;
            // 
            // cuiButton7
            // 
            cuiButton7.CheckButton = false;
            cuiButton7.Checked = false;
            cuiButton7.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton7.CheckedForeColor = Color.White;
            cuiButton7.CheckedImageTint = Color.White;
            cuiButton7.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton7.Content = "   Log Out";
            cuiButton7.Cursor = Cursors.Hand;
            cuiButton7.DialogResult = DialogResult.None;
            cuiButton7.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton7.ForeColor = Color.White;
            cuiButton7.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton7.HoverForeColor = Color.White;
            cuiButton7.HoverImageTint = Color.White;
            cuiButton7.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton7.Image = (Image)resources.GetObject("cuiButton7.Image");
            cuiButton7.ImageExpand = new Point(15, 15);
            cuiButton7.Location = new Point(10, 619);
            cuiButton7.Name = "cuiButton7";
            cuiButton7.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton7.NormalForeColor = Color.White;
            cuiButton7.NormalImageTint = Color.White;
            cuiButton7.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton7.OutlineThickness = 0F;
            cuiButton7.Padding = new Padding(20);
            cuiButton7.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton7.PressedForeColor = Color.White;
            cuiButton7.PressedImageTint = Color.White;
            cuiButton7.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton7.Rounding = new Padding(8);
            cuiButton7.Size = new Size(256, 60);
            cuiButton7.TabIndex = 6;
            cuiButton7.TextAlignment = StringAlignment.Near;
            cuiButton7.TextPadding = 20;
            cuiButton7.TextSpacing = 15;
            cuiButton7.Click += cuiButton7_Click;
            // 
            // cuiButton6
            // 
            cuiButton6.CheckButton = false;
            cuiButton6.Checked = false;
            cuiButton6.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton6.CheckedForeColor = Color.White;
            cuiButton6.CheckedImageTint = Color.White;
            cuiButton6.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton6.Content = "Students";
            cuiButton6.Cursor = Cursors.Hand;
            cuiButton6.DialogResult = DialogResult.None;
            cuiButton6.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton6.ForeColor = Color.White;
            cuiButton6.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton6.HoverForeColor = Color.White;
            cuiButton6.HoverImageTint = Color.White;
            cuiButton6.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton6.Image = (Image)resources.GetObject("cuiButton6.Image");
            cuiButton6.ImageExpand = new Point(12, 12);
            cuiButton6.Location = new Point(10, 542);
            cuiButton6.Name = "cuiButton6";
            cuiButton6.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton6.NormalForeColor = Color.White;
            cuiButton6.NormalImageTint = Color.White;
            cuiButton6.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton6.OutlineThickness = 0F;
            cuiButton6.Padding = new Padding(20);
            cuiButton6.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton6.PressedForeColor = Color.White;
            cuiButton6.PressedImageTint = Color.White;
            cuiButton6.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton6.Rounding = new Padding(8);
            cuiButton6.Size = new Size(256, 60);
            cuiButton6.TabIndex = 6;
            cuiButton6.TextAlignment = StringAlignment.Near;
            cuiButton6.TextPadding = 20;
            cuiButton6.TextSpacing = 35;
            cuiButton6.Click += cuiButton6_Click;
            // 
            // cuiButton4
            // 
            cuiButton4.CheckButton = false;
            cuiButton4.Checked = false;
            cuiButton4.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton4.CheckedForeColor = Color.White;
            cuiButton4.CheckedImageTint = Color.White;
            cuiButton4.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton4.Content = "Issue Book";
            cuiButton4.Cursor = Cursors.Hand;
            cuiButton4.DialogResult = DialogResult.None;
            cuiButton4.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton4.ForeColor = Color.White;
            cuiButton4.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton4.HoverForeColor = Color.White;
            cuiButton4.HoverImageTint = Color.White;
            cuiButton4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton4.Image = (Image)resources.GetObject("cuiButton4.Image");
            cuiButton4.ImageExpand = new Point(10, 10);
            cuiButton4.Location = new Point(10, 388);
            cuiButton4.Name = "cuiButton4";
            cuiButton4.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton4.NormalForeColor = Color.White;
            cuiButton4.NormalImageTint = Color.White;
            cuiButton4.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton4.OutlineThickness = 0F;
            cuiButton4.Padding = new Padding(20);
            cuiButton4.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton4.PressedForeColor = Color.White;
            cuiButton4.PressedImageTint = Color.White;
            cuiButton4.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton4.Rounding = new Padding(8);
            cuiButton4.Size = new Size(256, 60);
            cuiButton4.TabIndex = 6;
            cuiButton4.TextAlignment = StringAlignment.Near;
            cuiButton4.TextPadding = 20;
            cuiButton4.TextSpacing = 35;
            cuiButton4.Click += cuiButton4_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Add Book";
            cuiButton2.Cursor = Cursors.Hand;
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton2.HoverForeColor = Color.White;
            cuiButton2.HoverImageTint = Color.White;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = (Image)resources.GetObject("cuiButton2.Image");
            cuiButton2.ImageExpand = new Point(10, 10);
            cuiButton2.Location = new Point(10, 234);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 0F;
            cuiButton2.Padding = new Padding(20);
            cuiButton2.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(256, 60);
            cuiButton2.TabIndex = 6;
            cuiButton2.TextAlignment = StringAlignment.Near;
            cuiButton2.TextPadding = 20;
            cuiButton2.TextSpacing = 35;
            cuiButton2.Click += cuiButton2_Click;
            // 
            // cuiButton5
            // 
            cuiButton5.CheckButton = false;
            cuiButton5.Checked = false;
            cuiButton5.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton5.CheckedForeColor = Color.White;
            cuiButton5.CheckedImageTint = Color.White;
            cuiButton5.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton5.Content = "Return Book";
            cuiButton5.Cursor = Cursors.Hand;
            cuiButton5.DialogResult = DialogResult.None;
            cuiButton5.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton5.ForeColor = Color.White;
            cuiButton5.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton5.HoverForeColor = Color.White;
            cuiButton5.HoverImageTint = Color.White;
            cuiButton5.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton5.Image = (Image)resources.GetObject("cuiButton5.Image");
            cuiButton5.ImageExpand = new Point(10, 10);
            cuiButton5.Location = new Point(10, 465);
            cuiButton5.Name = "cuiButton5";
            cuiButton5.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton5.NormalForeColor = Color.White;
            cuiButton5.NormalImageTint = Color.White;
            cuiButton5.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton5.OutlineThickness = 0F;
            cuiButton5.Padding = new Padding(20);
            cuiButton5.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton5.PressedForeColor = Color.White;
            cuiButton5.PressedImageTint = Color.White;
            cuiButton5.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton5.Rounding = new Padding(8);
            cuiButton5.Size = new Size(256, 60);
            cuiButton5.TabIndex = 6;
            cuiButton5.TextAlignment = StringAlignment.Near;
            cuiButton5.TextPadding = 20;
            cuiButton5.TextSpacing = 35;
            cuiButton5.Click += cuiButton5_Click;
            // 
            // cuiButton3
            // 
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = Color.White;
            cuiButton3.CheckedImageTint = Color.White;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "View Books";
            cuiButton3.Cursor = Cursors.Hand;
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton3.ForeColor = Color.White;
            cuiButton3.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton3.HoverForeColor = Color.White;
            cuiButton3.HoverImageTint = Color.White;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = (Image)resources.GetObject("cuiButton3.Image");
            cuiButton3.ImageExpand = new Point(10, 10);
            cuiButton3.Location = new Point(10, 311);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton3.NormalForeColor = Color.White;
            cuiButton3.NormalImageTint = Color.White;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 0F;
            cuiButton3.Padding = new Padding(20);
            cuiButton3.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton3.PressedForeColor = Color.White;
            cuiButton3.PressedImageTint = Color.White;
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(256, 60);
            cuiButton3.TabIndex = 6;
            cuiButton3.TextAlignment = StringAlignment.Near;
            cuiButton3.TextPadding = 20;
            cuiButton3.TextSpacing = 35;
            cuiButton3.Click += cuiButton3_Click;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Dashboard";
            cuiButton1.Cursor = Cursors.Hand;
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold);
            cuiButton1.ForeColor = Color.WhiteSmoke;
            cuiButton1.HoverBackground = Color.FromArgb(37, 99, 235);
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = (Image)resources.GetObject("cuiButton1.Image");
            cuiButton1.ImageExpand = new Point(8, 8);
            cuiButton1.Location = new Point(10, 157);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(11, 31, 77);
            cuiButton1.NormalForeColor = Color.WhiteSmoke;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 0F;
            cuiButton1.Padding = new Padding(20);
            cuiButton1.PressedBackground = Color.FromArgb(30, 64, 175);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(256, 60);
            cuiButton1.TabIndex = 6;
            cuiButton1.TextAlignment = StringAlignment.Near;
            cuiButton1.TextPadding = 20;
            cuiButton1.TextSpacing = 40;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 31, 77);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(275, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1142, 88);
            panel2.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(871, 30);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1037, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 88);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 24);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 0;
            label3.Text = "☰    Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(282, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 195);
            panel3.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 24, 39);
            label10.Location = new Point(207, 73);
            label10.Name = "label10";
            label10.Size = new Size(114, 54);
            label10.TabIndex = 2;
            label10.Text = "label";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI Variable Small Semibol", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(37, 99, 235);
            label8.Location = new Point(218, 153);
            label8.Name = "label8";
            label8.Size = new Size(107, 22);
            label8.TabIndex = 2;
            label8.Text = "View Details";
            label8.Click += label8_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(20, 46);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(153, 111);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(207, 38);
            label4.Name = "label4";
            label4.Size = new Size(120, 27);
            label4.TabIndex = 0;
            label4.Text = "Total Books";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(1062, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 195);
            panel4.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(17, 24, 39);
            label15.Location = new Point(206, 71);
            label15.Name = "label15";
            label15.Size = new Size(114, 54);
            label15.TabIndex = 3;
            label15.Text = "label";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Segoe UI Variable Small Semibol", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(37, 99, 235);
            label14.Location = new Point(203, 151);
            label14.Name = "label14";
            label14.Size = new Size(107, 22);
            label14.TabIndex = 2;
            label14.Text = "View Details";
            label14.Click += label14_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(188, 38);
            label6.Name = "label6";
            label6.Size = new Size(146, 27);
            label6.TabIndex = 0;
            label6.Text = "Total Students";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(131, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(658, 135);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 195);
            panel6.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(223, 73);
            label11.Name = "label11";
            label11.Size = new Size(114, 54);
            label11.TabIndex = 3;
            label11.Text = "label";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI Variable Small Semibol", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(37, 99, 235);
            label12.Location = new Point(223, 153);
            label12.Name = "label12";
            label12.Size = new Size(107, 22);
            label12.TabIndex = 2;
            label12.Text = "View Details";
            label12.Click += label12_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(168, 35);
            label5.Name = "label5";
            label5.Size = new Size(212, 27);
            label5.TabIndex = 0;
            label5.Text = "Issued/Return Details";
            // 
            // cuiSpinner1
            // 
            cuiSpinner1.ArcColor = Color.FromArgb(37, 99, 235);
            cuiSpinner1.BackColor = SystemColors.ButtonHighlight;
            cuiSpinner1.Location = new Point(766, 286);
            cuiSpinner1.Name = "cuiSpinner1";
            cuiSpinner1.RingColor = Color.FromArgb(64, 128, 128, 128);
            cuiSpinner1.RotateSpeed = 2F;
            cuiSpinner1.Rotation = 166.407486F;
            cuiSpinner1.Size = new Size(75, 75);
            cuiSpinner1.TabIndex = 11;
            cuiSpinner1.Text = "cuiSpinner1";
            cuiSpinner1.Thickness = 5F;
            // 
            // uiBarChart1
            // 
            uiBarChart1.ChartStyleType = Sunny.UI.UIChartStyleType.LiveChart;
            uiBarChart1.Cursor = Cursors.Hand;
            uiBarChart1.FillColor = Color.FromArgb(16, 36, 71);
            uiBarChart1.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Bold);
            uiBarChart1.ForeColor = Color.FromArgb(170, 170, 170);
            uiBarChart1.LegendFont = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiBarChart1.Location = new Point(302, 367);
            uiBarChart1.MinimumSize = new Size(1, 1);
            uiBarChart1.Name = "uiBarChart1";
            uiBarChart1.RectColor = Color.Black;
            uiBarChart1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiBarChart1.ShowFocusColor = true;
            uiBarChart1.Size = new Size(1094, 344);
            uiBarChart1.SubFont = new Font("Microsoft Sans Serif", 9F);
            uiBarChart1.TabIndex = 13;
            // 
            // cuiFormAnimator1
            // 
            cuiFormAnimator1.AnimateOnStart = true;
            cuiFormAnimator1.Duration = 400;
            cuiFormAnimator1.EasingType = CuoreUI.Helpers.DrawingHelper.EasingTypes.QuartInOut;
            cuiFormAnimator1.StartOpacity = 0D;
            cuiFormAnimator1.TargetForm = this;
            cuiFormAnimator1.TargetOpacity = 1D;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1417, 723);
            Controls.Add(uiBarChart1);
            Controls.Add(cuiSpinner1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Label label4;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label14;
        private Label label12;
        private PictureBox pictureBox6;
        private Label label10;
        private Label label15;
        private Label label11;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton7;
        private CuoreUI.Controls.cuiButton cuiButton6;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton5;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiSpinner cuiSpinner1;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private Sunny.UI.UIBarChart uiBarChart1;
        private PictureBox pictureBox1;
        private Label label7;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
    }
}