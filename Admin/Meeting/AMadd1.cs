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
    public partial class AMadd1 : Form
    {
        public AMadd1()
        {
            InitializeComponent();
        }

        private void AMadd_Load(object sender, EventArgs e)
        {

        }
        public void set_Null()
        {
            uiTextBox1.Text = "";
            uiTextBox2.Text = "";
            uiTextBox3.Text = "";
            uiTextBox4.Text = "";
            uiTextBox5.Text = "";
            uiTextBox6.Text = "";
            uiTextBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text != "" && uiTextBox2.Text != "" && uiTextBox3.Text != "" && uiTextBox4.Text != "" && uiTextBox5.Text != "" && uiTextBox6.Text != "" && uiTextBox7.Text != "" && uiTextBox8.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_meeting values('{uiTextBox1.Text}','{uiTextBox2.Text}','{uiTextBox3.Text}','{uiTextBox4.Text}','{uiTextBox5.Text}','{uiTextBox6.Text}','{uiTextBox7.Text}'，'{uiTextBox8.Text}')";
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

        private void uiButton2_Click(object sender, EventArgs e)
        {
            set_Null();
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
