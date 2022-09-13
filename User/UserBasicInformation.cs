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

                textBox1.Text = name;
                textBox2.Text = stu_id;
                textBox3.Text = sex;
                textBox4.Text = ID;
                textBox5.Text = status;
                textBox6.Text = school_id;
                textBox7.Text = nation;
                textBox8.Text = origin;
                textBox9.Text = e_mail;
                textBox10.Text = apply_time;
                textBox11.Text = pri_party;
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
            try 
            {
                string sql = $"update t_user set stu_id = '{textBox2.Text}', name = '{textBox1.Text}', sex = '{textBox3.Text}', ID = '{textBox4.Text}', status = '{textBox5.Text}', school_id = '{textBox6.Text}', nation = '{textBox7.Text}', origin = '{textBox8.Text}', e_mail = '{textBox9.Text}', pri_party= '{textBox11.Text}', apply_time = '{textBox10.Text}'where stu_id = '{Data.UID}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                    UserIndex userindex = new UserIndex();
                    userindex.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
