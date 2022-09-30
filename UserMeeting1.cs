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
    public partial class UserMeeting1 : Form
    {
        public UserMeeting1()
        {
            InitializeComponent();
            Table();
        }

        private void UserMeeting1_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_meeting where t_meeting.attendee=(select status from t_user where stu_id ='{Data.UID}'); ";
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
    }
}
