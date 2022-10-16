using Party_MS2.User;
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
    public partial class UserIndex2 : Form
    {
        public UserIndex2()
        {
            InitializeComponent();
        }

        private void uiNavMenu1_MenuItemClick(TreeNode node, Sunny.UI.NavMenuItem item, int pageIndex)
        {
            if (node.Text == "我的基本信息")
            {
                UserBasicInformation user = new UserBasicInformation();
                user.TopLevel = false;
                user.FormBorderStyle = FormBorderStyle.None;
                user.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(user);
                user.Show();
            }
            else if (node.Text == "我的成绩")
            {
                UserTranscript admin = new UserTranscript();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "我的思想汇报")
            {
                UserReports admin = new UserReports();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "我的发展流程")
            {
                AdminPlan admin = new AdminPlan();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "学习")
            {
                UserLearn admin = new UserLearn();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
             else if (node.Text == "考试")
            {
                UserExam admin = new UserExam();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "我的函调")
            {
                UserCreateLetter admin = new UserCreateLetter();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "我的会议")
            {
                UserMeeting1 admin = new UserMeeting1();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "我的文书")
            {
                UserWrit admin = new UserWrit();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
        }
    }
}
