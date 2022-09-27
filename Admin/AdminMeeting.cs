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
    }
}
