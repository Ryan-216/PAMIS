namespace Party_MS2.Admin
{
    partial class AdminExamScoreChart
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
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.SuspendLayout();
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBarChart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBarChart1.LegendFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBarChart1.Location = new System.Drawing.Point(3, 12);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.Size = new System.Drawing.Size(1529, 875);
            this.uiBarChart1.SubFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBarChart1.TabIndex = 0;
            this.uiBarChart1.Text = "uiBarChart1";
            this.uiBarChart1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AdminExamScoreChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 899);
            this.Controls.Add(this.uiBarChart1);
            this.Name = "AdminExamScoreChart";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBarChart uiBarChart1;
    }
}