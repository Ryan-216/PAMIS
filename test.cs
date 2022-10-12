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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdminWrit frm2 = new AdminWrit();



            frm2.TopLevel = false;


            frm2.FormBorderStyle = FormBorderStyle.None;


            frm2.Dock = DockStyle.Fill;


            this.panel2.Controls.Clear();


            this.panel2.Controls.Add(frm2);          

            frm2.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminMeeting frm2 = new AdminMeeting();
           

            //设置子窗口不显示为顶级窗口

            frm2.TopLevel = false;

            //设置子窗口的样式，没有上面的标题栏

            frm2.FormBorderStyle = FormBorderStyle.None;

            //填充

            frm2.Dock = DockStyle.Fill;

            //清空Panel里面的控件

            this.panel2.Controls.Clear();

            //加入控件

            this.panel2.Controls.Add(frm2);

            //让窗体显示

            frm2.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
