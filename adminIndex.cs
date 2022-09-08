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
    public partial class AdminIndex : Form
    {
        public AdminIndex()
        {
            InitializeComponent();
        }

        private void 申请人基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBasicInfomation admin = new AdminBasicInfomation();
            this.Hide();
            admin.ShowDialog();
            this.Show();

        }

        private void AdminIndex_Load(object sender, EventArgs e)
        {

        }

        private void 成绩审查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminScore admin = new AdminScore();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 思想汇报管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminReport admin = new AdminReport();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
    }
}
