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
            uiTextBox1.Text = "";
            uiTextBox2.Text = "";
            uiTextBox3.Text = "";
            uiTextBox4.Text = "";
            uiTextBox5.Text = "";
            uiTextBox6.Text = "";
            uiTextBox7.Text = "";
            uiTextBox8.Text = "";
            uiTextBox9.Text = "";
            uiTextBox10.Text = "";
            uiTextBox11.Text = "";
        }
        public ABIUpdate(string stu_id, string name, string sex, string ID, string statu, string school_id, string nation, string region, string e_mail, string pri_party, string apply_time)
        {
            InitializeComponent();
            id = uiTextBox1.Text = stu_id;
            uiTextBox2.Text = name;
            uiTextBox3.Text = sex;
            uiTextBox4.Text = ID;
            uiTextBox5.Text = statu;
            uiTextBox6.Text = school_id;
            uiTextBox7.Text = nation;
            uiTextBox8.Text = region;
            uiTextBox9.Text = e_mail;
            uiTextBox10.Text = pri_party;
            uiTextBox11.Text = apply_time;
        }

       

       
        private void uiButton2_Click(object sender, EventArgs e)
        {
            string sql = $"update t_user set stu_id = '{uiTextBox1.Text}', name = '{uiTextBox2.Text}', sex = '{uiTextBox3.Text}', ID = '{uiTextBox4.Text}', status = '{uiTextBox5.Text}', school_id = '{uiTextBox6.Text}', nation = '{uiTextBox7.Text}', origin = '{uiTextBox8.Text}', e_mail = '{uiTextBox9.Text}', pri_party= '{uiTextBox10.Text}', apply_time = '{uiTextBox11.Text}'where stu_id = '{id}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            set_Null();
        }
        private void ABIUpdate_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
