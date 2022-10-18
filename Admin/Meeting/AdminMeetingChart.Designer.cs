namespace Party_MS2.Admin
{
    partial class AdminMeetingChart
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
            this.uiPieChart1 = new Sunny.UI.UIPieChart();
            this.SuspendLayout();
            // 
            // uiPieChart1
            // 
            this.uiPieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPieChart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPieChart1.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPieChart1.Location = new System.Drawing.Point(12, 12);
            this.uiPieChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPieChart1.Name = "uiPieChart1";
            this.uiPieChart1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiPieChart1.Size = new System.Drawing.Size(1520, 875);
            this.uiPieChart1.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiPieChart1.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPieChart1.TabIndex = 0;
            this.uiPieChart1.Text = "uiPieChart1";
            this.uiPieChart1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AdminMeetingChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 899);
            this.Controls.Add(this.uiPieChart1);
            this.Name = "AdminMeetingChart";
            this.Text = "AdminMeetingChart";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPieChart uiPieChart1;
    }
}