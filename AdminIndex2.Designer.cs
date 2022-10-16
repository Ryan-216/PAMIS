
namespace Party_MS2
{
    partial class AdminIndex2
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
            Sunny.UI.UINavMenu uiNavMenu1;
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("申请人基本信息管理");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("成绩审查");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("思想汇报管理");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("基本资料管理", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("发展计划管理");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("考试批改");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("思政教育管理", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("函调管理");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("计划、培训及函调管理", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("会议管理");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("文书管理");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("联系管理员");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(uiNavMenu1);
            this.panel1.Location = new System.Drawing.Point(1, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 768);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(51, 787);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1322, 34);
            this.panel6.TabIndex = 3;
            // 
            // uiNavMenu1
            // 
            uiNavMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            uiNavMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            uiNavMenu1.ExpandSelectFirst = false;
            uiNavMenu1.FillColor = System.Drawing.Color.OrangeRed;
            uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            uiNavMenu1.ForeColor = System.Drawing.Color.Beige;
            uiNavMenu1.FullRowSelect = true;
            uiNavMenu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            uiNavMenu1.ItemHeight = 50;
            uiNavMenu1.Location = new System.Drawing.Point(3, 0);
            uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavMenu1.Name = "uiNavMenu1";
            treeNode15.Name = "节点1";
            treeNode15.Text = "申请人基本信息管理";
            treeNode16.Name = "节点2";
            treeNode16.Text = "成绩审查";
            treeNode17.Name = "节点4";
            treeNode17.Text = "思想汇报管理";
            treeNode18.Name = "基本资料管理";
            treeNode18.Text = "基本资料管理";
            treeNode19.Name = "节点9";
            treeNode19.Text = "发展计划管理";
            treeNode20.Name = "节点0";
            treeNode20.Text = "考试批改";
            treeNode21.Name = "节点10";
            treeNode21.Text = "思政教育管理";
            treeNode22.Name = "节点11";
            treeNode22.Text = "函调管理";
            treeNode23.Name = "节点5";
            treeNode23.Text = "计划、培训及函调管理";
            treeNode24.Name = "节点6";
            treeNode24.Text = "会议管理";
            treeNode25.Name = "节点7";
            treeNode25.Text = "文书管理";
            treeNode26.Name = "节点13";
            treeNode26.Text = "联系管理员";
            treeNode27.Name = "节点14";
            treeNode27.Text = "退出";
            treeNode28.Name = "节点8";
            treeNode28.Text = "系统";
            uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode28});
            uiNavMenu1.ScrollBarColor = System.Drawing.Color.Tomato;
            uiNavMenu1.ScrollBarHoverColor = System.Drawing.Color.Tomato;
            uiNavMenu1.ScrollBarPressColor = System.Drawing.Color.Maroon;
            uiNavMenu1.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            uiNavMenu1.SecondBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            uiNavMenu1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            uiNavMenu1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            uiNavMenu1.SelectedForeColor = System.Drawing.Color.SeaShell;
            uiNavMenu1.SelectedHighColor = System.Drawing.Color.SeaShell;
            uiNavMenu1.ShowLines = false;
            uiNavMenu1.Size = new System.Drawing.Size(326, 765);
            uiNavMenu1.Style = Sunny.UI.UIStyle.Custom;
            uiNavMenu1.TabIndex = 5;
            uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(841, 810);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(606, 34);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "地址：中国吉林长春 联系电话：85168315 邮箱：nicxxb@jlu.edu.cn";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(123, 810);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(671, 34);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "吉林大学 版权所有 Copyright © 2022 Jilin University，All Rights Reserved";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiAvatar1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 35);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 35;
            this.uiAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiAvatar1.Enabled = false;
            this.uiAvatar1.FillColor = System.Drawing.Color.Red;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.ForeColor = System.Drawing.Color.Yellow;
            this.uiAvatar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiAvatar1.Location = new System.Drawing.Point(1192, 0);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(43, 39);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.SymbolSize = 30;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiAvatar1.Click += new System.EventHandler(this.uiAvatar1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1489, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(385, 31);
            this.toolStripLabel1.Text = "吉林大学党务管理信息系统";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 31);
            this.toolStripLabel2.Text = "时间";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 31);
            this.toolStripLabel3.Text = "用户名";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Party_MS2.Properties.Resources.微信图片_20220906155730;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(339, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 765);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(103, 376);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 355);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(654, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 355);
            this.panel4.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Party_MS2.Properties.Resources.t01cd4b59a94db03b3b;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Party_MS2.Properties.Resources.t01cd4b59a94db03b3b;
            this.pictureBox1.Location = new System.Drawing.Point(23, 718);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 853);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminIndex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIndex2";
            this.Load += new System.EventHandler(this.AdminIndex2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}