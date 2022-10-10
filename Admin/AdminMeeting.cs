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
    public partial class AdminMeeting : Form
    {
        public AdminMeeting()
        {
            InitializeComponent();
            Table();
            radioButton1.Checked = true;
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_meeting";
            IDataReader dc = dao.read(sql);
            string no, name, m_content, time, place,attendee,record,host;
            while (dc.Read())
            {
                no = dc[0].ToString();
                name = dc[1].ToString();
                m_content = dc[2].ToString();
                time = dc[3].ToString();
                place = dc[4].ToString();
                attendee = dc[5].ToString();
                record = dc[6].ToString();
                host = dc[7].ToString();


                string[] table = { no, name, m_content, time,place,attendee,record,host };
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
                sql = $"select*from t_meeting where no='{textBox1.Text}'";
            }
            else if (radioButton2.Checked == true)
            {
                sql = $"select*from t_meeting where host='{textBox1.Text}'";
            }
           
            IDataReader dc = dao.read(sql);
            string no, name, m_content, time, place, attendee, record, host;
            while (dc.Read())
            {
                no = dc[0].ToString();
                name = dc[1].ToString();
                m_content = dc[2].ToString();
                time = dc[3].ToString();
                place = dc[4].ToString();
                attendee = dc[5].ToString();
                record = dc[6].ToString();
                host = dc[7].ToString();


                string[] table = { no, name, m_content, time, place, attendee, record, host };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void AdminMeeting_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            AMAttendee aMAttendee = new AMAttendee();
            this.Hide();
            aMAttendee.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AMRecord aMRecord = new AMRecord();
            this.Hide();
            aMRecord.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AMadd aMRecord = new AMadd();
            this.Hide();
            aMRecord.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string m_content = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string time = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string place = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string attendee = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string record = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string host = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();


                AMupdate admin = new AMupdate( no,  name,  m_content,  time,  place,attendee,  record,  host);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取学号
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_meeting where no = '{no }'";
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

        
    }
}
