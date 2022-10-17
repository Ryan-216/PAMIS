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
    public partial class ALAdd : Form
    {
        public ALAdd()
        {
            InitializeComponent();
        }
        public void set_Null()
        {
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" )
            {
                Dao dao = new Dao();
                int n=-1;
                for (int i =1;i<=2;i++)
                {
                    string sql = $"insert into t_letter values('{Data.UID + "01000" + i}','{textBox2.Text}','{textBox3.Text}', NULL, NULL, '待提交', '未审核')";
                    n = dao.Execute(sql);
                }
                if (n > 0)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
                set_Null();
            }
            else
            {
                MessageBox.Show("信息不可为空！");
            }
        }

        private void ALAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
