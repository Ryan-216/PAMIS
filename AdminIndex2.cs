using Party_MS2.Admin;
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
            preload();
            //
            toolStripLabel3.Text = $"{Data.UID}";
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }
        public void preload()
        {
            Notification1 admin = new Notification1();
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            this.panel5.Controls.Clear();
            this.panel5.Controls.Add(admin);
            admin.Show();
            //
            News admin1 = new News();
            admin1.TopLevel = false;
            admin1.FormBorderStyle = FormBorderStyle.None;
            admin1.Dock = DockStyle.Fill;
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(admin1);
            admin1.Show();
        }

        string weekstr = "";
        private void control_Load(object sender, EventArgs e)
        {

            timer1.Start();

            //把得到的星期转换成中文
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": weekstr = "星期一"; break;
                case "Tuesday": weekstr = "星期二"; break;
                case "Wednesday": weekstr = "星期三"; break;
                case "Thursday": weekstr = "星期四"; break;
                case "Friday": weekstr = "星期五"; break;
                case "Saturday": weekstr = "星期六"; break;
                case "Sunday": weekstr = "星期日"; break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel2.Text = DateTime.Now.ToString() + " " + weekstr;
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
            else if (node.Text == "考试批改")
            {
                AdminExam admin = new AdminExam();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "考试统计")
            {
                AdminExamScoreChart admin = new AdminExamScoreChart("E03");                  //static!!!!!!!!!!!!
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

        private void uiAvatar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
