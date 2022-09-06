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
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入党流程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计划函调及培训管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会议管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.入党流程ToolStripMenuItem,
            this.计划函调及培训管理ToolStripMenuItem,
            this.会议管理ToolStripMenuItem,
            this.文书管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 入党流程ToolStripMenuItem
            // 
            this.入党流程ToolStripMenuItem.Name = "入党流程ToolStripMenuItem";
            this.入党流程ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.入党流程ToolStripMenuItem.Text = "入党流程";
            // 
            // 计划函调及培训管理ToolStripMenuItem
            // 
            this.计划函调及培训管理ToolStripMenuItem.Name = "计划函调及培训管理ToolStripMenuItem";
            this.计划函调及培训管理ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.计划函调及培训管理ToolStripMenuItem.Text = "计划、函调及培训管理";
            // 
            // 会议管理ToolStripMenuItem
            // 
            this.会议管理ToolStripMenuItem.Name = "会议管理ToolStripMenuItem";
            this.会议管理ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.会议管理ToolStripMenuItem.Text = "会议管理";
            // 
            // 文书管理ToolStripMenuItem
            // 
            this.文书管理ToolStripMenuItem.Name = "文书管理ToolStripMenuItem";
            this.文书管理ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.文书管理ToolStripMenuItem.Text = "文书管理";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserIndex";
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