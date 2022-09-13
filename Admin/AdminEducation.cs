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
            radioButton1.Checked = true;
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_education";
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
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableSearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
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
                dataGridView1.Rows.Add(table);
            };
            
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AEAdd aEAdd = new AEAdd();
            this.Hide();
            aEAdd.ShowDialog();
            this.Show();
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string hours = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string contents = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string status = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string s_time = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string e_time = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
               

                AEUpdate admin = new AEUpdate(no, name, hours, contents, status, s_time, e_time );
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void AdminEducation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取学号
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

        private void button5_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
        }
    }
}
