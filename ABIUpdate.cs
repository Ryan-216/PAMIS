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
    public partial class ABIUpdate : Form
    {
        string id = "";
        public ABIUpdate()
        {
            InitializeComponent();
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
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }
        public ABIUpdate(string stu_id, string name, string sex, string ID, string statu, string school_id, string nation, string region, string e_mail, string pri_party, string apply_time)
        {
            InitializeComponent();
            id =textBox1.Text = stu_id;
            textBox2.Text = name;
            textBox3.Text = sex;
            textBox4.Text = ID;
            textBox5.Text = statu;
            textBox6.Text = school_id;
            textBox7.Text = nation;
            textBox8.Text = region;
            textBox9.Text = e_mail;
            textBox10.Text = pri_party;
            textBox11.Text = apply_time;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_user set stu_id = '{textBox1.Text}', name = '{textBox2.Text}', sex = '{textBox3.Text}', ID = '{textBox4.Text}', status = '{textBox5.Text}', school_id = '{textBox6.Text}', nation = '{textBox7.Text}', origin = '{textBox8.Text}', e_mail = '{textBox9.Text}', pri_party= '{textBox10.Text}', apply_time = '{textBox11.Text}'where stu_id = '{id}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }
        private void ABIUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            set_Null();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
