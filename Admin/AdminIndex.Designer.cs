namespace Party_MS2
{
    partial class AdminIndex
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("申请人基本资料");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("成绩管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("思想汇报管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("基本资料管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("计划发展管理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("思政教育管理");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("函调管理");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("计划、培训及函调管理", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("会议管理");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("文书管理");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("联系管理员");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIndex));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本资料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.申请人基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩审查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.思想汇报管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计划培训及函调管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发展计划管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.思政教育管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.函调管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会议管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(587, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "欢迎管理员登录！";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本资料管理ToolStripMenuItem,
            this.计划培训及函调管理ToolStripMenuItem,
            this.会议管理ToolStripMenuItem,
            this.文书管理ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 基本资料管理ToolStripMenuItem
            // 
            this.基本资料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.申请人基本信息管理ToolStripMenuItem,
            this.成绩审查ToolStripMenuItem,
            this.思想汇报管理ToolStripMenuItem});
            this.基本资料管理ToolStripMenuItem.Name = "基本资料管理ToolStripMenuItem";
            this.基本资料管理ToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.基本资料管理ToolStripMenuItem.Text = "基本资料管理";
            this.基本资料管理ToolStripMenuItem.Click += new System.EventHandler(this.基本资料管理ToolStripMenuItem_Click);
            // 
            // 申请人基本信息管理ToolStripMenuItem
            // 
            this.申请人基本信息管理ToolStripMenuItem.Name = "申请人基本信息管理ToolStripMenuItem";
            this.申请人基本信息管理ToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.申请人基本信息管理ToolStripMenuItem.Text = "申请人基本信息管理";
            this.申请人基本信息管理ToolStripMenuItem.Click += new System.EventHandler(this.申请人基本信息管理ToolStripMenuItem_Click);
            // 
            // 成绩审查ToolStripMenuItem
            // 
            this.成绩审查ToolStripMenuItem.Name = "成绩审查ToolStripMenuItem";
            this.成绩审查ToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.成绩审查ToolStripMenuItem.Text = "成绩审查";
            this.成绩审查ToolStripMenuItem.Click += new System.EventHandler(this.成绩审查ToolStripMenuItem_Click);
            // 
            // 思想汇报管理ToolStripMenuItem
            // 
            this.思想汇报管理ToolStripMenuItem.Name = "思想汇报管理ToolStripMenuItem";
            this.思想汇报管理ToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.思想汇报管理ToolStripMenuItem.Text = "思想汇报管理";
            this.思想汇报管理ToolStripMenuItem.Click += new System.EventHandler(this.思想汇报管理ToolStripMenuItem_Click);
            // 
            // 计划培训及函调管理ToolStripMenuItem
            // 
            this.计划培训及函调管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发展计划管理ToolStripMenuItem,
            this.思政教育管理ToolStripMenuItem,
            this.函调管理ToolStripMenuItem});
            this.计划培训及函调管理ToolStripMenuItem.Name = "计划培训及函调管理ToolStripMenuItem";
            this.计划培训及函调管理ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.计划培训及函调管理ToolStripMenuItem.Text = "计划、培训及函调管理";
            // 
            // 发展计划管理ToolStripMenuItem
            // 
            this.发展计划管理ToolStripMenuItem.Name = "发展计划管理ToolStripMenuItem";
            this.发展计划管理ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.发展计划管理ToolStripMenuItem.Text = "发展计划管理";
            this.发展计划管理ToolStripMenuItem.Click += new System.EventHandler(this.发展计划管理ToolStripMenuItem_Click);
            // 
            // 思政教育管理ToolStripMenuItem
            // 
            this.思政教育管理ToolStripMenuItem.Name = "思政教育管理ToolStripMenuItem";
            this.思政教育管理ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.思政教育管理ToolStripMenuItem.Text = "思政教育管理";
            this.思政教育管理ToolStripMenuItem.Click += new System.EventHandler(this.思政教育管理ToolStripMenuItem_Click);
            // 
            // 函调管理ToolStripMenuItem
            // 
            this.函调管理ToolStripMenuItem.Name = "函调管理ToolStripMenuItem";
            this.函调管理ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.函调管理ToolStripMenuItem.Text = "函调管理";
            this.函调管理ToolStripMenuItem.Click += new System.EventHandler(this.函调管理ToolStripMenuItem_Click);
            // 
            // 会议管理ToolStripMenuItem
            // 
            this.会议管理ToolStripMenuItem.Name = "会议管理ToolStripMenuItem";
            this.会议管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.会议管理ToolStripMenuItem.Text = "会议管理";
            this.会议管理ToolStripMenuItem.Click += new System.EventHandler(this.会议管理ToolStripMenuItem_Click);
            // 
            // 文书管理ToolStripMenuItem
            // 
            this.文书管理ToolStripMenuItem.Name = "文书管理ToolStripMenuItem";
            this.文书管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.文书管理ToolStripMenuItem.Text = "文书管理";
            this.文书管理ToolStripMenuItem.Click += new System.EventHandler(this.文书管理ToolStripMenuItem_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.联系管理员ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 联系管理员ToolStripMenuItem
            // 
            this.联系管理员ToolStripMenuItem.Name = "联系管理员ToolStripMenuItem";
            this.联系管理员ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.联系管理员ToolStripMenuItem.Text = "联系管理员";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(0, 33);
            this.uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu1.Name = "uiNavMenu1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "申请人基本资料";
            treeNode2.Name = "节点2";
            treeNode2.Text = "成绩管理";
            treeNode3.Name = "节点4";
            treeNode3.Text = "思想汇报管理";
            treeNode4.Name = "基本资料管理";
            treeNode4.Text = "基本资料管理";
            treeNode5.Name = "节点9";
            treeNode5.Text = "计划发展管理";
            treeNode6.Name = "节点10";
            treeNode6.Text = "思政教育管理";
            treeNode7.Name = "节点11";
            treeNode7.Text = "函调管理";
            treeNode8.Name = "节点5";
            treeNode8.Text = "计划、培训及函调管理";
            treeNode9.Name = "节点6";
            treeNode9.Text = "会议管理";
            treeNode10.Name = "节点7";
            treeNode10.Text = "文书管理";
            treeNode11.Name = "节点13";
            treeNode11.Text = "联系管理员";
            treeNode12.Name = "节点14";
            treeNode12.Text = "退出";
            treeNode13.Name = "节点8";
            treeNode13.Text = "系统";
            this.uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode13});
            this.uiNavMenu1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.ScrollBarPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.SecondBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.uiNavMenu1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiNavMenu1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiNavMenu1.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiNavMenu1.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(317, 787);
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.LayuiRed;
            this.uiNavMenu1.TabIndex = 4;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // AdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 816);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uiNavMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "党务管理系统";
            this.Load += new System.EventHandler(this.AdminIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本资料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 申请人基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩审查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 思想汇报管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计划培训及函调管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发展计划管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 思政教育管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 函调管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会议管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private Sunny.UI.UINavMenu uiNavMenu1;
    }
}