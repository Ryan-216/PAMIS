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
    public partial class AdminEducation : Form
    {
        public AdminEducation()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_education";
            IDataReader dc = dao.read(sql);
            string no, name, hours, contents, status, s_time, e_time;
            while (dc.Read())
            {
                no = dc[0].ToString();
                name = dc[1].ToString();
                hours = dc[3].ToString();
                contents = dc[4].ToString();
                status = dc[5].ToString();
                s_time = dc[6].ToString();
                e_time = dc[7].ToString();

                string[] table = { no, name, hours, contents, status, s_time, e_time };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
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
        }
        /*
        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "";
            if (radioButton1.Checked == true)
            {
                sql = $"select*from t_eudcation where no='{textBox1.Text}'";
            }
            else if (radioButton2.Checked == true)
            {
                sql = $"select*from t_education where name like '%{textBox1.Text}%'";
            }
            else if (radioButton3.Checked == true)
            {
                sql = $"select*from t_education where status='{textBox1.Text}'";
            }
            IDataReader dc = dao.read(sql);
            string no, name, hours, contents, status, s_time, e_time;
            while (dc.Read())
            {
                no = dc[0].ToString();
                name = dc[1].ToString();
                hours = dc[2].ToString();
                contents = dc[3].ToString();
                status = dc[4].ToString();
                s_time = dc[5].ToString();
                e_time = dc[6].ToString();

                string[] table = { no, name, hours, contents, status, s_time, e_time };
                basicDataGridView.Rows.Add(table);
            };
       
            
            dc.Close();
            dao.DaoClose();
        }
         */
        private void button1_Click(object sender, EventArgs e)
        {
            AMAdd aEAdd = new AMAdd();
            this.Hide();
            aEAdd.ShowDialog();
            this.Show();
            Table();
        }

      

        private void AdminEducation_Load(object sender, EventArgs e)
        {

        }

       
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text != "" && uiTextBox2.Text != "" && uiTextBox3.Text != "" && uiTextBox4.Text != "" && uiTextBox5.Text != "" && uiTextBox6.Text != "" && uiTextBox7.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_education values('{uiTextBox1.Text}','{uiTextBox2.Text}','id','{uiTextBox3.Text}','{uiTextBox4.Text}','{uiTextBox5.Text}','{uiTextBox6.Text}','{uiTextBox7.Text}','0')";
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
        string id = "";
        private void uiButton2_Click(object sender, EventArgs e)
        {
             id =uiTextBox1.Text = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            uiTextBox2.Text = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            uiTextBox3.Text = basicDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            uiTextBox4.Text = basicDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            uiTextBox5.Text = basicDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            uiTextBox6.Text = basicDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            uiTextBox7.Text = basicDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text != "" && uiTextBox2.Text != "" && uiTextBox3.Text != "" && uiTextBox4.Text != "" && uiTextBox5.Text != "" && uiTextBox6.Text != "" && uiTextBox7.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"update t_education set no = '{uiTextBox1.Text}', name = '{uiTextBox2.Text}',stu_id='id', hours = '{uiTextBox3.Text}', contents = '{uiTextBox4.Text}', status = '{uiTextBox5.Text}', s_time = '{uiTextBox6.Text}', e_time = '{uiTextBox7.Text}',clear ='未完成',score='0' where no='{id}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
                set_Null();
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("信息不可为空！");
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Table();
            set_Null();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_education where no = '{no }'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的课程!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Adminvideo adminvideo = new Adminvideo(id);
            adminvideo.ShowDialog();
        }
    }
}
