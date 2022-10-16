namespace Party_MS2
{
    partial class UserTranscript
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.课程编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.basicDataGridView = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程编号,
            this.课程名称,
            this.成绩});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(813, 145);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 课程编号
            // 
            this.课程编号.HeaderText = "课程编号";
            this.课程编号.MinimumWidth = 10;
            this.课程编号.Name = "课程编号";
            this.课程编号.ReadOnly = true;
            // 
            // 课程名称
            // 
            this.课程名称.HeaderText = "课程名称";
            this.课程名称.MinimumWidth = 10;
            this.课程名称.Name = "课程名称";
            this.课程名称.ReadOnly = true;
            // 
            // 成绩
            // 
            this.成绩.HeaderText = "成绩";
            this.成绩.MinimumWidth = 10;
            this.成绩.Name = "成绩";
            this.成绩.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(129, 260);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "刷新";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // basicDataGridView
            // 
            this.basicDataGridView.AllowUserToAddRows = false;
            this.basicDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.basicDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.basicDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.basicDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.basicDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.basicDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.basicDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.basicDataGridView.ColumnHeadersHeight = 32;
            this.basicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.basicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.basicDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.basicDataGridView.EnableHeadersVisualStyles = false;
            this.basicDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.basicDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(34)))));
            this.basicDataGridView.Location = new System.Drawing.Point(180, 329);
            this.basicDataGridView.MultiSelect = false;
            this.basicDataGridView.Name = "basicDataGridView";
            this.basicDataGridView.ReadOnly = true;
            this.basicDataGridView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.basicDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.basicDataGridView.RowHeadersVisible = false;
            this.basicDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.basicDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.basicDataGridView.RowTemplate.Height = 27;
            this.basicDataGridView.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.basicDataGridView.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.basicDataGridView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.basicDataGridView.SelectedIndex = -1;
            this.basicDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basicDataGridView.Size = new System.Drawing.Size(706, 262);
            this.basicDataGridView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.basicDataGridView.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.basicDataGridView.TabIndex = 30;
            this.basicDataGridView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "学业课程是否挂科";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "积极分子培训成绩";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "发展对象培训成绩";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UserTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 665);
            this.Controls.Add(this.basicDataGridView);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserTranscript";
            this.Text = "我的成绩";
            this.Load += new System.EventHandler(this.UserTranscript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView basicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}