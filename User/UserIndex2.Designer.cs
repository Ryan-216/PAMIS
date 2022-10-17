
namespace Party_MS2
{
    partial class UserIndex2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("我的基本信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("我的成绩");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("我的思想汇报");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("我的基本资料", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("我的发展流程");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("学习");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("考试");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("思政学习", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("我的函调");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("计划、培训及函调管理", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("我的会议");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("我的文书");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("联系管理员");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiNavMenu1);
            this.panel1.Location = new System.Drawing.Point(1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 833);
            this.panel1.TabIndex = 0;
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
            treeNode1.Text = "我的基本信息";
            treeNode2.Name = "节点2";
            treeNode2.Text = "我的成绩";
            treeNode3.Name = "节点4";
            treeNode3.Text = "我的思想汇报";
            treeNode4.Name = "我的基本资料";
            treeNode4.Text = "我的基本资料";
            treeNode5.Name = "节点9";
            treeNode5.Text = "我的发展流程";
            treeNode6.Name = "节点0";
            treeNode6.Text = "学习";
            treeNode7.Name = "节点1";
            treeNode7.Text = "考试";
            treeNode8.Name = "节点10";
            treeNode8.Text = "思政学习";
            treeNode9.Name = "节点11";
            treeNode9.Text = "我的函调";
            treeNode10.Name = "节点5";
            treeNode10.Text = "计划、培训及函调管理";
            treeNode11.Name = "节点6";
            treeNode11.Text = "我的会议";
            treeNode12.Name = "节点7";
            treeNode12.Text = "我的文书";
            treeNode13.Name = "节点13";
            treeNode13.Text = "联系管理员";
            treeNode14.Name = "节点14";
            treeNode14.Text = "退出";
            treeNode15.Name = "节点8";
            treeNode15.Text = "系统";
            this.uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode15});
            this.uiNavMenu1.ScrollBarColor = System.Drawing.Color.Tomato;
            this.uiNavMenu1.ScrollBarHoverColor = System.Drawing.Color.Tomato;
            this.uiNavMenu1.ScrollBarPressColor = System.Drawing.Color.Maroon;
            this.uiNavMenu1.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.SecondBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.uiNavMenu1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiNavMenu1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiNavMenu1.SelectedForeColor = System.Drawing.Color.Yellow;
            this.uiNavMenu1.SelectedHighColor = System.Drawing.Color.Yellow;
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(363, 827);
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiNavMenu1.TabIndex = 6;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(373, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1452, 833);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1825, 52);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 897);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1825, 39);
            this.panel4.TabIndex = 1;
            // 
            // UserIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 936);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserIndex2";
            this.Text = "UserIndex2";
            this.Load += new System.EventHandler(this.UserIndex2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UINavMenu uiNavMenu1;
    }
}