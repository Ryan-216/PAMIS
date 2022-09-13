namespace Party_MS2
{
    partial class UserIndex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.入党流程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计划函调及培训管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会议管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入党流程ToolStripMenuItem,
            this.计划函调及培训管理ToolStripMenuItem,
            this.会议管理ToolStripMenuItem,
            this.文书管理ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1521, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 入党流程ToolStripMenuItem
            // 
            this.入党流程ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.入党流程ToolStripMenuItem.Name = "入党流程ToolStripMenuItem";
            this.入党流程ToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.入党流程ToolStripMenuItem.Text = "基本资料管理";
            this.入党流程ToolStripMenuItem.Click += new System.EventHandler(this.入党流程ToolStripMenuItem_Click);
            // 
            // 计划函调及培训管理ToolStripMenuItem
            // 
            this.计划函调及培训管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.计划函调及培训管理ToolStripMenuItem.Name = "计划函调及培训管理ToolStripMenuItem";
            this.计划函调及培训管理ToolStripMenuItem.Size = new System.Drawing.Size(325, 38);
            this.计划函调及培训管理ToolStripMenuItem.Text = "计划、培训及函调管理";
            // 
            // 会议管理ToolStripMenuItem
            // 
            this.会议管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.会议管理ToolStripMenuItem.Name = "会议管理ToolStripMenuItem";
            this.会议管理ToolStripMenuItem.Size = new System.Drawing.Size(151, 38);
            this.会议管理ToolStripMenuItem.Text = "会议管理";
            // 
            // 文书管理ToolStripMenuItem
            // 
            this.文书管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文书管理ToolStripMenuItem.Name = "文书管理ToolStripMenuItem";
            this.文书管理ToolStripMenuItem.Size = new System.Drawing.Size(151, 38);
            this.文书管理ToolStripMenuItem.Text = "文书管理";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(463, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 79);
            this.label1.TabIndex = 3;
            this.label1.Text = "欢迎用户登录！";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Party_MS2.Properties.Resources.微信图片_20220906155730;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1521, 906);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userIndex";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入党流程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计划函调及培训管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会议管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文书管理ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}