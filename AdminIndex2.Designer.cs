
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("申请人基本信息管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("成绩审查");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("思想汇报管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("基本资料管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("发展计划管理");
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.uiNavMenu1);
            this.panel1.Location = new System.Drawing.Point(1, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 640);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 646);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1304, 34);
            this.panel6.TabIndex = 3;
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.ExpandSelectFirst = false;
            this.uiNavMenu1.FillColor = System.Drawing.Color.Red;
            this.uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ForeColor = System.Drawing.Color.Yellow;
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(3, 3);
            this.uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu1.Name = "uiNavMenu1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "申请人基本信息管理";
            treeNode2.Name = "节点2";
            treeNode2.Text = "成绩审查";
            treeNode3.Name = "节点4";
            treeNode3.Text = "思想汇报管理";
            treeNode4.Name = "基本资料管理";
            treeNode4.Text = "基本资料管理";
            treeNode5.Name = "节点9";
            treeNode5.Text = "发展计划管理";
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
            this.uiNavMenu1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiNavMenu1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiNavMenu1.SelectedForeColor = System.Drawing.Color.Yellow;
            this.uiNavMenu1.SelectedHighColor = System.Drawing.Color.Yellow;
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(252, 634);
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiNavMenu1.TabIndex = 5;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiLabel5);
            this.panel2.Controls.Add(this.uiAvatar1);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 46);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑 Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(654, 8);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(287, 34);
            this.uiLabel5.TabIndex = 2;
            this.uiLabel5.Text = "时间";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 40;
            this.uiAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiAvatar1.Enabled = false;
            this.uiAvatar1.FillColor = System.Drawing.Color.Red;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.ForeColor = System.Drawing.Color.Yellow;
            this.uiAvatar1.Location = new System.Drawing.Point(992, -3);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(51, 45);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.SymbolSize = 40;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiAvatar1.Click += new System.EventHandler(this.uiAvatar1_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(1059, 6);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 34);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "用户名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Red;
            this.uiLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.uiLabel1.Location = new System.Drawing.Point(100, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(369, 35);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "吉林大学党务管理信息系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(12, 697);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(671, 34);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "吉林大学 版权所有 Copyright © 2022 Jilin University，All Rights Reserved";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(719, 694);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(606, 34);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "地址：中国吉林长春 联系电话：85168315 邮箱：nicxxb@jlu.edu.cn";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.panel3.Location = new System.Drawing.Point(265, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 640);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(77, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 365);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(568, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 359);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Party_MS2.Properties.Resources.t01cd4b59a94db03b3b;
            this.pictureBox1.Location = new System.Drawing.Point(35, -1);
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
            this.ClientSize = new System.Drawing.Size(1337, 733);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UINavMenu uiNavMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILabel uiLabel5;
    }
}