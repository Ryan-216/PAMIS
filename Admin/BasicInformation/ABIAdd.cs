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
    public partial class ABIAdd : Form
    {
        public ABIAdd()
        {
            InitializeComponent();
        }

        public void set_Null()
        {
            uiTextBox1.Text = "";
            uiTextBox2.Text = "";
            uiComboBox1.Text = "男";
            uiTextBox4.Text = "";
            uiComboBox2.Text = "";
            uiComboBox4.Text = "";
            uiTextBox7.Text = "";
            uiComboBox3.Text = "";
            uiTextBox9.Text = "";
            uiTextBox10.Text = "";
            uiDatetimePicker1.Text = "";
        }
       
     

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ADBIAdd_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text != "" && uiTextBox2.Text != "" && uiComboBox1.Text != "" && uiTextBox4.Text != "" && uiComboBox2.Text != "" && uiComboBox4.Text != "" && uiTextBox7.Text != "" && uiComboBox3.Text != "" && uiTextBox9.Text != "" && uiTextBox10.Text != "" && uiDatetimePicker1.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_user values('{uiTextBox1.Text}','{uiTextBox2.Text}','{uiComboBox1.Text}','{uiTextBox4.Text}','{uiComboBox2.Text}','{uiComboBox4.Text}','{uiTextBox7.Text}','{uiComboBox3.Text}','{uiTextBox9.Text}','{uiTextBox10.Text}','{uiDatetimePicker1.Text}')";
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            set_Null();
        }
    }
}
