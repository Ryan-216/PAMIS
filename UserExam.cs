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
    public partial class UserExam : Form
    {
        public UserExam()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("提交成功！");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否确认退出", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void uiLedStopwatch1_TimerTick(object sender, EventArgs e)
        {

        }
    }
}
