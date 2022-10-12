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
            if (node.Text == "申请人基本资料")
            {
                AdminBasicInfomation admin = new AdminBasicInfomation();
                admin.TopLevel = false;
                admin.FormBorderStyle = FormBorderStyle.None;
                admin.Dock = DockStyle.Fill;
                this.panel3.Controls.Clear();
                this.panel3.Controls.Add(admin);
                admin.Show();
            }
        }
    }
}
