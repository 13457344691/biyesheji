namespace 参考文献管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出系统QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者类型设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.参考文献管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参考文献类型设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参考文献档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出版社管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.参考文献注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参考文献征定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参考文献ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.参考文献管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员信息ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出系统QToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 管理员信息ToolStripMenuItem
            // 
            this.管理员信息ToolStripMenuItem.Name = "管理员信息ToolStripMenuItem";
            this.管理员信息ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.管理员信息ToolStripMenuItem.Text = "管理员信息";
            this.管理员信息ToolStripMenuItem.Click += new System.EventHandler(this.管理员信息ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // 退出系统QToolStripMenuItem
            // 
            this.退出系统QToolStripMenuItem.Name = "退出系统QToolStripMenuItem";
            this.退出系统QToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.退出系统QToolStripMenuItem.Text = "退出(&X)";
            this.退出系统QToolStripMenuItem.Click += new System.EventHandler(this.退出系统QToolStripMenuItem_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者类型设置ToolStripMenuItem,
            this.读者档案管理ToolStripMenuItem,
            this.toolStripSeparator4});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.读者管理ToolStripMenuItem.Text = "读者管理(&D)";
            // 
            // 读者类型设置ToolStripMenuItem
            // 
            this.读者类型设置ToolStripMenuItem.Name = "读者类型设置ToolStripMenuItem";
            this.读者类型设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.读者类型设置ToolStripMenuItem.Text = "读者类型设置";
            this.读者类型设置ToolStripMenuItem.Click += new System.EventHandler(this.读者类型设置ToolStripMenuItem_Click);
            // 
            // 读者档案管理ToolStripMenuItem
            // 
            this.读者档案管理ToolStripMenuItem.Name = "读者档案管理ToolStripMenuItem";
            this.读者档案管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.读者档案管理ToolStripMenuItem.Text = "读者档案管理";
            this.读者档案管理ToolStripMenuItem.Click += new System.EventHandler(this.读者档案管理ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // 参考文献管理ToolStripMenuItem
            // 
            this.参考文献管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参考文献类型设置ToolStripMenuItem,
            this.参考文献档案管理ToolStripMenuItem,
            this.出版社管理ToolStripMenuItem,
            this.toolStripSeparator3,
            this.参考文献注销ToolStripMenuItem,
            this.参考文献征定ToolStripMenuItem,
            this.参考文献ToolStripMenuItem});
            this.参考文献管理ToolStripMenuItem.Name = "参考文献管理ToolStripMenuItem";
            this.参考文献管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.参考文献管理ToolStripMenuItem.Text = "参考文献管理";
            // 
            // 参考文献类型设置ToolStripMenuItem
            // 
            this.参考文献类型设置ToolStripMenuItem.Name = "参考文献类型设置ToolStripMenuItem";
            this.参考文献类型设置ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.参考文献类型设置ToolStripMenuItem.Text = "参考文献类型设置";
            this.参考文献类型设置ToolStripMenuItem.Click += new System.EventHandler(this.参考文献类型设置ToolStripMenuItem_Click);
            // 
            // 参考文献档案管理ToolStripMenuItem
            // 
            this.参考文献档案管理ToolStripMenuItem.Name = "参考文献档案管理ToolStripMenuItem";
            this.参考文献档案管理ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.参考文献档案管理ToolStripMenuItem.Text = "参考文献档案管理";
            this.参考文献档案管理ToolStripMenuItem.Click += new System.EventHandler(this.参考文献档案管理ToolStripMenuItem_Click);
            // 
            // 出版社管理ToolStripMenuItem
            // 
            this.出版社管理ToolStripMenuItem.Name = "出版社管理ToolStripMenuItem";
            this.出版社管理ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.出版社管理ToolStripMenuItem.Text = "出版社管理";
            this.出版社管理ToolStripMenuItem.Click += new System.EventHandler(this.出版社管理ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // 参考文献注销ToolStripMenuItem
            // 
            this.参考文献注销ToolStripMenuItem.Name = "参考文献注销ToolStripMenuItem";
            this.参考文献注销ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.参考文献注销ToolStripMenuItem.Text = "参考文献注销";
            this.参考文献注销ToolStripMenuItem.Click += new System.EventHandler(this.参考文献注销ToolStripMenuItem_Click);
            // 
            // 参考文献征定ToolStripMenuItem
            // 
            this.参考文献征定ToolStripMenuItem.Name = "参考文献征定ToolStripMenuItem";
            this.参考文献征定ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.参考文献征定ToolStripMenuItem.Text = "参考文献征定";
            this.参考文献征定ToolStripMenuItem.Click += new System.EventHandler(this.参考文献征定ToolStripMenuItem_Click);
            // 
            // 参考文献ToolStripMenuItem
            // 
            this.参考文献ToolStripMenuItem.Name = "参考文献ToolStripMenuItem";
            this.参考文献ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.参考文献ToolStripMenuItem.Text = "参考文献验收";
            this.参考文献ToolStripMenuItem.Click += new System.EventHandler(this.参考文献ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员管理ToolStripMenuItem,
            this.音乐ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.管理员管理ToolStripMenuItem.Text = "管理员管理";
            this.管理员管理ToolStripMenuItem.Click += new System.EventHandler(this.管理员管理ToolStripMenuItem_Click);
            // 
            // 音乐ToolStripMenuItem
            // 
            this.音乐ToolStripMenuItem.Name = "音乐ToolStripMenuItem";
            this.音乐ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.音乐ToolStripMenuItem.Text = "音乐";
            this.音乐ToolStripMenuItem.Click += new System.EventHandler(this.音乐ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 774);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(221, 23);
            this.toolStripStatusLabel1.Text = "欢迎使用本参考文献管理系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(372, 23);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Image = global::图书馆管理系统.Properties.Resources._865;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(372, 23);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "密码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 136);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(122, 25);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 24);
            this.textBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "参考文献管理系统登录";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\MSSQL;Initial Catalog=libbook;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::图书馆管理系统.Properties.Resources.bj;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(93, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 291);
            this.panel1.TabIndex = 14;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(649, 747);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(129, 23);
            this.axWindowsMediaPlayer2.TabIndex = 17;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("华文楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "欢迎使用本软件";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.Resize += new System.EventHandler(this.Form1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 742);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::图书馆管理系统.Properties.Resources.bj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 802);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.Text = "参考文献管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参考文献类型设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参考文献档案管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出版社管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参考文献注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参考文献征定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参考文献ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参考文献管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统QToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 读者类型设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者档案管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 参考文献2管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.ToolStripMenuItem 音乐ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

