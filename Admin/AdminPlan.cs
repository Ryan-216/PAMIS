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
            //radioButton1.Checked = true;
        }

        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select t_user.stu_id,t_user.[name],t_user.[status],t_timerecord.final_time,count_reports,failed,score1,score2,application1,application2,befull"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        +" and t_user.stu_id = t_writsum.stu_id"
                        +$" and t_user.stu_id = '{Data.UID}'";
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
            string sql  = "select t_user.stu_id,t_user.[name],t_user.[status],t_timerecord.final_time,count_reports,failed,score1,score2,application1,application2,befull"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        + " and t_user.stu_id = t_writsum.stu_id"
                        + $" and t_user.stu_id = '{Data.UID}'";
            string sql1 = "";
            if (uiRadioButton1.Checked == true)
            {
           //     sql = $"select*from t_plan where stu_id='{textBox1.Text}'";
            }
            else if (uiRadioButton2.Checked == true)
            {
           //     sql = $"select*from t_plan where pass='{textBox1.Text}'";
            }
            else if (uiRadioButton3.Checked == true)
            {
                
            }
            IDataReader dc = dao.read(sql);
            string no,stu_id, name, test1,test2, pass;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                name = dc[2].ToString();
                test1 = dc[3].ToString();
                test2 = dc[4].ToString();
                pass = dc[5].ToString();

                string[] table = { no, stu_id, name, test1, test2, pass };
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
            Table();
            //textBox1.Text = "";
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
