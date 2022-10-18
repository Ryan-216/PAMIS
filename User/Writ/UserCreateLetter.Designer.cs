namespace Party_MS2.User
{
    partial class UserCreateLetter
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
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiLine1.Location = new System.Drawing.Point(11, 31);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(2);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(1486, 44);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 1;
            this.uiLine1.Text = "创建函调信";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(680, 867);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.Size = new System.Drawing.Size(141, 50);
            this.uiButton2.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton2.TabIndex = 4;
            this.uiButton2.Text = "上传图片";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 754);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UserCreateLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 948);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiLine1);
            this.Name = "UserCreateLetter";
            this.Text = "UserCreateLetter";
            this.Load += new System.EventHandler(this.UserCreateLetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIButton uiButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}