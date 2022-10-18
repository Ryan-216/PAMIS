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
    public partial class AEUpdate : Form
    {
        public AEUpdate()
        {
            InitializeComponent();
        }
        string id;
        public AEUpdate(string no, string name, string hours, string contents, string status, string s_time, string e_time)
        {
            InitializeComponent();
            id = textBox1.Text = no;
            textBox2.Text = name;
            textBox3.Text = hours;
            textBox4.Text = contents;
            textBox5.Text = status;
            textBox6.Text = s_time;
            textBox7.Text = e_time;
          
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
            string sql = $"update t_education set no = '{textBox1.Text}', name = '{textBox2.Text}', hours = '{textBox3.Text}', contents = '{textBox4.Text}', status = '{textBox5.Text}', s_time = '{textBox6.Text}', e_time = '{textBox7.Text}'where no={id}";
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

        private void AEUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
