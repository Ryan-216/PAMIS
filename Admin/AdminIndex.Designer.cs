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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox3 = new Sunny.UI.UICheckBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
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
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(314, 33);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 27;
            this.uiDataGridView1.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(1170, 349);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 5;
            this.uiDataGridView1.Visible = false;
            this.uiDataGridView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(542, 507);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 6;
            this.uiButton1.Text = "uiButton1";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(868, 507);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 7;
            this.uiButton2.Text = "uiButton2";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(1227, 507);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.TabIndex = 8;
            this.uiButton3.Text = "uiButton3";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox1.Location = new System.Drawing.Point(596, 604);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox1.TabIndex = 9;
            this.uiCheckBox1.Text = "uiCheckBox1";
            this.uiCheckBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox2.Location = new System.Drawing.Point(868, 604);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox2.TabIndex = 10;
            this.uiCheckBox2.Text = "uiCheckBox2";
            this.uiCheckBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox3
            // 
            this.uiCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox3.Location = new System.Drawing.Point(1154, 604);
            this.uiCheckBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox3.Name = "uiCheckBox3";
            this.uiCheckBox3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox3.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox3.TabIndex = 11;
            this.uiCheckBox3.Text = "uiCheckBox3";
            this.uiCheckBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(793, 709);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 12;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(1002, 709);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(100, 35);
            this.uiButton4.TabIndex = 13;
            this.uiButton4.Text = "uiButton4";
            this.uiButton4.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 816);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiCheckBox3);
            this.Controls.Add(this.uiCheckBox2);
            this.Controls.Add(this.uiCheckBox1);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uiNavMenu1);
            this.Controls.Add(this.uiDataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "党务管理系统";
            this.Load += new System.EventHandler(this.AdminIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
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
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UICheckBox uiCheckBox3;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton4;
    }
}