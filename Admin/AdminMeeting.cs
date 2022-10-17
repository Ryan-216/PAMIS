using Party_MS2.Admin;
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
            uiRadioButton1.Checked = true;
        }
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
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
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "";
            if (uiRadioButton1.Checked == true)
            {
                sql = $"select*from t_meeting where no='{uiTextBox1.Text}'";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql = $"select*from t_meeting where host='{uiTextBox1.Text}'";
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
                basicDataGridView.Rows.Add(table);
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
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string meeting_no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            AdminMeetingChart adminMeetingChart = new AdminMeetingChart(meeting_no);
            this.Hide();
            adminMeetingChart.ShowDialog();
            this.Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            AMadd1 aMRecord = new AMadd1();
            this.Hide();
            aMRecord.ShowDialog();
            this.Show();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string m_content = basicDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string time = basicDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string place = basicDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string attendee = basicDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string record = basicDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                string host = basicDataGridView.SelectedRows[0].Cells[7].Value.ToString();


                AMupdate admin = new AMupdate(no, name, m_content, time, place, attendee, record, host);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取学号
                //label2.Text = id + basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_meeting where no = '{no}'";
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

        private void uiButton5_Click(object sender, EventArgs e)
        {
            string meeting_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            AMRecord aMRecord = new AMRecord(meeting_id);
            this.Hide();
            aMRecord.ShowDialog();
            this.Show();
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            AMLeavereasons admin = new AMLeavereasons();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            Table();
            uiTextBox1.Text = "";
        }
    }
}
