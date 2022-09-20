namespace Party_MS2.User
{
    partial class UserLearn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.是否完成 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.截止时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学时 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.课程名称,
            this.学时,
            this.内容,
            this.开始时间,
            this.截止时间,
            this.是否完成});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // 是否完成
            // 
            this.是否完成.HeaderText = "是否完成";
            this.是否完成.MinimumWidth = 10;
            this.是否完成.Name = "是否完成";
            this.是否完成.Width = 200;
            // 
            // 截止时间
            // 
            this.截止时间.HeaderText = "截止时间";
            this.截止时间.MinimumWidth = 10;
            this.截止时间.Name = "截止时间";
            this.截止时间.Width = 200;
            // 
            // 开始时间
            // 
            this.开始时间.HeaderText = "开始时间";
            this.开始时间.MinimumWidth = 10;
            this.开始时间.Name = "开始时间";
            this.开始时间.Width = 200;
            // 
            // 内容
            // 
            this.内容.HeaderText = "内容";
            this.内容.MinimumWidth = 10;
            this.内容.Name = "内容";
            this.内容.Width = 200;
            // 
            // 学时
            // 
            this.学时.HeaderText = "学时";
            this.学时.MinimumWidth = 10;
            this.学时.Name = "学时";
            this.学时.Width = 200;
            // 
            // 课程名称
            // 
            this.课程名称.HeaderText = "课程名称";
            this.课程名称.MinimumWidth = 10;
            this.课程名称.Name = "课程名称";
            this.课程名称.Width = 200;
            // 
            // 编号
            // 
            this.编号.HeaderText = "编号";
            this.编号.MinimumWidth = 10;
            this.编号.Name = "编号";
            this.编号.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "学习";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 714);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserLearn";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学时;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 截止时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否完成;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}