using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class AdminIndex2 : Form
    {
        public AdminIndex2()
        {
            InitializeComponent();
        }

        private void uiNavMenu1_MenuItemClick(TreeNode node, Sunny.UI.NavMenuItem item, int pageIndex)
        {
            if (node.Text == "申请人基本信息管理")
            {
                AdminBasicInfomation admin = new AdminBasicInfomation();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "成绩审查")
            {
                AdminScore admin = new AdminScore();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "思想汇报管理")
            {
                AdminReport admin = new AdminReport();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "发展计划管理")
            {
                AdminPlan admin = new AdminPlan();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "思政教育管理")
            {
                AdminEducation admin = new AdminEducation();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "函调管理")
            {
                AdminLetter admin = new AdminLetter();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "会议管理")
            {
                AdminMeeting admin = new AdminMeeting();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "文书管理")
            {
                AdminWrit admin = new AdminWrit();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
        }

        private void AdminIndex2_Load(object sender, EventArgs e)
        {

        }
    }
}
