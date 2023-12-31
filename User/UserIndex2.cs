﻿using Party_MS2.User;
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
        string status="";
        string Name1="";
        public UserIndex2()
        {
            InitializeComponent();           
            preload();
            Dao dao = new Dao();
            string sql2 = $"select name,status from t_user where stu_id='{Data.UID}'";
            IDataReader dc2 = dao.read(sql2);

            while (dc2.Read())
            {
                Name1= dc2[0].ToString();
                status = dc2[1].ToString();
            }
            dc2.Close();
            dao.DaoClose();
            toolStripLabel3.Text = $"{Name1}";
            uiLabel1.Text = $"欢迎{status}{Name1}登录！";
        }

        private void preload()
        {
            Notification1 admin = new Notification1();
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            this.panel6.Controls.Clear();
            this.panel6.Controls.Add(admin);
            admin.Show();
            //
            News admin1 = new News();
            admin1.TopLevel = false;
            admin1.FormBorderStyle = FormBorderStyle.None;
            admin1.Dock = DockStyle.Fill;
            this.panel7.Controls.Clear();
            this.panel7.Controls.Add(admin1);
            admin1.Show();
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
                UserPlan admin = new UserPlan();
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
                UserExam1 admin = new UserExam1();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(admin);
                admin.Show();
            }
            else if (node.Text == "我的函调")
            {
                status = "发展对象";//测试
                if (status == "发展对象")
                {
                    UserCreateLetter admin = new UserCreateLetter();
                    admin.TopLevel = false;
                    admin.FormBorderStyle = FormBorderStyle.None;
                    admin.Dock = DockStyle.Fill;
                    this.panel2.Controls.Clear();
                    this.panel2.Controls.Add(admin);
                    admin.Show();
                }
                else 
                {
                    MessageBox.Show("对不起，您不是发展对象，不具备函调资格！");
                }
                
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
            else if (node.Text == "联系管理员")
            {
                Developers developers = new Developers();
                developers.TopLevel = false;
                developers.FormBorderStyle = FormBorderStyle.None;
                developers.Dock = DockStyle.Fill;
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(developers);
                developers.Show();
            }
            else if (node.Text == "退出")
            {
                this.Close();
            }
        }

        private void UserIndex2_Load(object sender, EventArgs e)
        {

        }
    }
}
