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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string picPath = Application.StartupPath + "\\img/loginBackground.png";
            this.BackgroundImage = Image.FromFile(picPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("账号或密码不能为空，请重新输入！");
            }
        }
        public void Login()
        {
            //user
            if (radioButton1.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select* from t_user where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    //Data.UID = dc["id"].ToString();
                    //Data.UName = dc["name"].ToString();

                    MessageBox.Show("登录成功！");

                    //user_index user = new user_index();
                    this.Hide();
                    //user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
            //admin
            if (radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select* from t_admin where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功！");
                    //admin_index admin = new admin_index();
                    this.Hide();
                    //admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
