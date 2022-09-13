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
    public partial class ALUpdate1 : Form
    {
        public ALUpdate1()
        {
            InitializeComponent();
        }
        string id;
        public ALUpdate1(string no, string stu_id, string name, string contents, string time, string pass)
        {
            InitializeComponent();
            id = textBox1.Text = no;
            textBox2.Text = stu_id;
            textBox3.Text = name;
            textBox4.Text = contents;
            textBox5.Text = time;
            textBox6.Text = pass;

        }
        public void set_Null()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void ALUpdate1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_letter set no = '{textBox1.Text}', stu_id = '{textBox2.Text}', name = '{textBox3.Text}', contents = '{textBox4.Text}', time = '{textBox5.Text}', pass = '{textBox6.Text}'where no={id}";
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
