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
    public partial class UserIndex : Form
    {
        public UserIndex()
        {
            InitializeComponent();
            label1.Text = $"欢迎{Data.UName}登录!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void 入党流程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserLearn userLearn = new UserLearn();
            userLearn.Show();
            this.Hide();
        }

        private void 我的个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBasicInformation userBasicInformation = new UserBasicInformation();
            this.Hide();
            userBasicInformation.ShowDialog();
            this.Show();
        }

        private void UserIndex_Load(object sender, EventArgs e)
        {

        }

        private void 会议管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMeeting1 user=new UserMeeting1();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }
    }
}
