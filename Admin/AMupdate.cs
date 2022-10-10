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
            id = textBox1.Text = no;
            textBox2.Text = name;
            textBox3.Text = m_content;
            textBox4.Text = time;
            textBox5.Text = place;
            textBox6.Text = attendee;
            textBox7.Text = record;
            textBox8.Text = host;

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
            textBox8.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_meeting set no = '{textBox1.Text}', name = '{textBox2.Text}', m_content = '{textBox3.Text}', time = '{textBox4.Text}', place = '{textBox5.Text}', attendee = '{textBox6.Text}', record = '{textBox7.Text}', record = '{textBox8.Text}'where no={id}";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            set_Null();
        }
    }
}
