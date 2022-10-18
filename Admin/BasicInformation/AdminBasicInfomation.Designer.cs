
namespace Party_MS2
{
    partial class AdminBasicInfomation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBasicInfomation));
            this.partyDBIIDataSet = new Party_MS2.PartyDBIIDataSet();
            this.tuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_userTableAdapter = new Party_MS2.PartyDBIIDataSetTableAdapters.t_userTableAdapter();
            this.basicDataGridView = new Sunny.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton3 = new Sunny.UI.UIRadioButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton5 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.partyDBIIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partyDBIIDataSet
            // 
            this.partyDBIIDataSet.DataSetName = "PartyDBIIDataSet";
            this.partyDBIIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tuserBindingSource
            // 
            this.tuserBindingSource.DataMember = "t_user";
            this.tuserBindingSource.DataSource = this.partyDBIIDataSet;
            // 
            // t_userTableAdapter
            // 
            this.t_userTableAdapter.ClearBeforeFill = true;
            // 
            // basicDataGridView
            // 
            this.basicDataGridView.AllowUserToAddRows = false;
            this.basicDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.basicDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.basicDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.basicDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicDataGridView.EnableHeadersVisualStyles = false;
            this.basicDataGridView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.basicDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(34)))));
            this.basicDataGridView.Location = new System.Drawing.Point(0, 0);
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
            this.basicDataGridView.Size = new System.Drawing.Size(1544, 502);
            this.basicDataGridView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.basicDataGridView.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.basicDataGridView.TabIndex = 28;
            this.basicDataGridView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "学号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "身份证号";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "政治面貌";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "学院";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "民族";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "籍贯";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "电子邮件";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "党组织";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "申请编号";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // uiButton2
            // 
            this.uiButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(374, 577);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton2.TabIndex = 29;
            this.uiButton2.Text = "添加学生";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(575, 577);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton1.TabIndex = 30;
            this.uiButton1.Text = "修改信息";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(777, 577);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton3.TabIndex = 31;
            this.uiButton3.Text = "删除学生";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.Location = new System.Drawing.Point(1002, 577);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton4.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton4.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton4.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton4.Size = new System.Drawing.Size(100, 35);
            this.uiButton4.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton4.TabIndex = 32;
            this.uiButton4.Text = "刷新";
            this.uiButton4.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton1.Location = new System.Drawing.Point(492, 696);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton1.TabIndex = 33;
            this.uiRadioButton1.Text = "学号查询";
            this.uiRadioButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton2.Location = new System.Drawing.Point(656, 696);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton2.TabIndex = 34;
            this.uiRadioButton2.Text = "学院查询";
            this.uiRadioButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiRadioButton3
            // 
            this.uiRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButton3.Location = new System.Drawing.Point(831, 696);
            this.uiRadioButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton3.Name = "uiRadioButton3";
            this.uiRadioButton3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton3.Size = new System.Drawing.Size(150, 29);
            this.uiRadioButton3.TabIndex = 35;
            this.uiRadioButton3.Text = "党组织查询";
            this.uiRadioButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(530, 747);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(364, 29);
            this.uiTextBox1.TabIndex = 36;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton5
            // 
            this.uiButton5.BackColor = System.Drawing.Color.Transparent;
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton5.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton5.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton5.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Location = new System.Drawing.Point(1002, 747);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiButton5.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.uiButton5.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton5.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.uiButton5.Size = new System.Drawing.Size(100, 35);
            this.uiButton5.Style = Sunny.UI.UIStyle.LayuiOrange;
            this.uiButton5.TabIndex = 37;
            this.uiButton5.Text = "查询";
            this.uiButton5.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // AdminBasicInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 899);
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiRadioButton3);
            this.Controls.Add(this.uiRadioButton2);
            this.Controls.Add(this.uiRadioButton1);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.basicDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBasicInfomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "申请人基本信息管理";
            this.Load += new System.EventHandler(this.AdminBasicInfomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partyDBIIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PartyDBIIDataSet partyDBIIDataSet;
        private System.Windows.Forms.BindingSource tuserBindingSource;
        private PartyDBIIDataSetTableAdapters.t_userTableAdapter t_userTableAdapter;
        private Sunny.UI.UIDataGridView basicDataGridView;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton3;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}