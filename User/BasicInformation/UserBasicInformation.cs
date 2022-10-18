using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2.User
{
    public partial class UserBasicInformation : Form
    {
        public UserBasicInformation()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            uiTextBox4.ReadOnly = true;
            uiTextBox7.ReadOnly = true;
            uiComboBox3.ReadOnly = true;
            uiTextBox9.ReadOnly = true;
            Dao dao = new Dao();
            string sql = "select * from t_user where stu_id="+Data.UID;
            IDataReader dc = dao.read(sql);
            string stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                sex = dc[2].ToString();
                ID = dc[3].ToString();
                status = dc[4].ToString();
                school_id = dc[5].ToString();
                nation = dc[6].ToString();
                origin = dc[7].ToString();
                e_mail = dc[8].ToString();
                pri_party = dc[9].ToString();
                apply_time = dc[10].ToString();

                uiTextBox1.Text = stu_id;
                uiTextBox2.Text = name;
                uiTextBox3.Text = sex;
                uiTextBox4.Text = ID;
                uiTextBox5.Text = status;
                uiTextBox6.Text = school_id;
                uiTextBox7.Text = nation;
                uiComboBox3.Text = origin;
                uiTextBox9.Text = e_mail;
                uiTextBox10.Text = pri_party;
                uiTextBox11.Text = apply_time;
            }

        }
        public void Update()
        {
            try
            {
                string sql = $"update t_user set stu_id = '{uiTextBox1.Text}', name = '{uiTextBox2.Text}', sex = '{uiTextBox3.Text}', ID = '{uiTextBox4.Text}', status = '{uiTextBox5.Text}', school_id = '{uiTextBox6.Text}', nation = '{uiTextBox7.Text}', origin = '{uiComboBox3.Text}', e_mail = '{uiTextBox9.Text}', pri_party= '{uiTextBox10.Text}', apply_time = '{uiTextBox11.Text}'where stu_id = '{Data.UID}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功！");                   
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
        private void button2_Click(object sender, EventArgs e)  //返回
        {
            this.Hide();
            UserIndex userIndex = new UserIndex();
            userIndex.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBasicInformation_Load(object sender, EventArgs e)
        {

        }

        private void uiTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiTextBox4.ReadOnly = false;
            uiTextBox7.ReadOnly = false;
            uiComboBox3.ReadOnly = false;
            uiTextBox9.ReadOnly = false;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (uiTextBox4.Text != "" && uiTextBox7.Text != "" && uiComboBox3.Text != "" && uiTextBox9.Text != "")
            {
                if (uiTextBox4.Text.Length == 18)
                {
                    Update();
                    Init();
                }
                else
                {
                    MessageBox.Show("身份证号格式不正确！");
                }
               
            }
            else
            {
                MessageBox.Show("输入不能为空！");
            }
            
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            
            Init();
        }
    }
}
