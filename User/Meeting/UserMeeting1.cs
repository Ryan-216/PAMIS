﻿using System;
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
            basicDataGridView.Rows.Clear();//清空旧数据
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
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

      

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string meeting_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            UMSignin1 user = new UMSignin1(meeting_id);
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string meeting_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string name = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string meeting_time = basicDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string meeting_place = basicDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            UMAskforleave user = new UMAskforleave(meeting_id, name, meeting_time, meeting_place);
            this.Hide();
            user.ShowDialog();
            this.Show();
        }
    }
}
