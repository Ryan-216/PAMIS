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
    public partial class AMadd : Form
    {
        public AMadd()
        {
            InitializeComponent();
        }

        private void AMadd_Load(object sender, EventArgs e)
        {

        }
        public void set_Null()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_meeting values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}'，'{textBox8.Text}')";
                int n = dao.Execute(sql);
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

        private void button2_Click(object sender, EventArgs e)
        {
            set_Null();
        }
    }
}
