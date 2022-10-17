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
    public partial class AMupdate : Form
    {
        public AMupdate()
        {
            InitializeComponent();
        }

        private void AMupdate_Load(object sender, EventArgs e)
        {

        }
        string id = "";
        public AMupdate(string no, string name, string m_content, string time, string place, string attendee, string record, string host)
        {
            InitializeComponent();
            id = uiTextBox1.Text = no;
            uiTextBox2.Text = name;
            uiTextBox3.Text = m_content;
            uiTextBox4.Text = time;
            uiTextBox5.Text = place;
            uiTextBox6.Text = attendee;
            uiTextBox7.Text = record;
            uiTextBox8.Text = host;

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
            uiTextBox8.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_meeting set no = '{uiTextBox1.Text}', name = '{uiTextBox2.Text}', m_content = '{uiTextBox3.Text}', time = '{uiTextBox4.Text}', place = '{uiTextBox5.Text}', attendee = '{uiTextBox6.Text}', record = '{uiTextBox7.Text}', record = '{uiTextBox8.Text}'where no={id}";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            set_Null();
        }
    }
}
