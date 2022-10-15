using Party_MS2.User;
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
    public partial class AdminPlan : Form
    {
        public AdminPlan()
        {
            InitializeComponent();
            Table();
            uiRadioButton1.Checked = true;
        }

        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select t_user.stu_id,t_user.[name],t_user.[status],t_timerecord.cul_time,count_reports,failed,score1,score2,application1,application2,befull"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        + " and t_user.stu_id = t_writsum.stu_id";
                        //+$" and t_user.stu_id = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            string stu_id, name, status, final_time, count_reports, failed, score1, score2, application1, application2, befull;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                status = dc[2].ToString();
                final_time = dc[3].ToString();
                count_reports = dc[4].ToString();
                failed = dc[5].ToString();
                score1 = dc[6].ToString();
                score2 = dc[7].ToString();
                application1 = dc[8].ToString();
                application2 = dc[9].ToString();
                befull = dc[10].ToString();

                string[] table = { stu_id, name, status, final_time, count_reports, failed, score1, score2, application1, application2, befull };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select t_user.stu_id,t_user.[name],t_user.[status],cul_time,count_reports,failed,score1,score2,application1,application2,befull"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        + " and t_user.stu_id = t_writsum.stu_id";
                        //+ $" and t_user.stu_id = '{Data.UID}'";

            string sql1 = "";
            if (uiRadioButton1.Checked == true)
            {
                sql1 = " and cul_time >= 6 and application1='通过'and count_reports >= 2 and failed='否' ";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql1 = " and status='入党积极分子' cul_time >= 12 and count_reports >= 6 and failed='否' and score1> = 60";
            }
            else if (uiRadioButton3.Checked == true)
            {
                sql1 = " and status='发展对象' and count_reports >= 6 + (cul_time/4) and failed='否' and score2> = 60 and application2='通过'";
            }
            else if (uiRadioButton3.Checked == true)
            {
                sql1 = " and status='预备党员' and cul_time >= 12 and count_reports >= (count_reports_last + 4) and failed='否' and befull='通过'";
            }

            string sql2 = sql + sql1;
            IDataReader dc = dao.read(sql2);
            string stu_id, name, status, final_time, count_reports, failed, score1, score2, application1, application2, befull;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                status = dc[2].ToString();
                final_time = dc[3].ToString();
                count_reports = dc[4].ToString();
                failed = dc[5].ToString();
                score1 = dc[6].ToString();
                score2 = dc[7].ToString();
                application1 = dc[8].ToString();
                application2 = dc[9].ToString();
                befull = dc[10].ToString();

                string[] table = { stu_id, name, status, final_time, count_reports, failed, score1, score2, application1, application2, befull };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void AdminPlan_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Table();
            uiTextBox1.Text = "";
        }
    }
}
