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
        int ifsearch = 0;

        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "update t_timerecord set cul_time=datediff(CONVERT(varchar(100), GETDATE(), 23)"
                        + "select t_user.stu_id,t_user.[name],t_user.[status],t_timerecord.cul_time,count_reports,failed,score1,score2,application1,application2,befull"
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
            string sql_conditions = "";


            ifsearch = 1;
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql_basic = "select t_user.stu_id,t_user.[name],t_user.[status],cul_time,count_reports,failed,score1,score2,application1,application2,befull"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        + " and t_user.stu_id = t_writsum.stu_id";
                        //+ $" and t_user.stu_id = '{Data.UID}'";
            
            if (uiRadioButton1.Checked == true)
            {
                sql_conditions = " and status='入党申请人'and cul_time >= 6 and application1='通过'and count_reports >= 2 and failed='否' ";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql_conditions = " and status='入党积极分子' and cul_time >= 12 and count_reports >= 6 and failed='否' and score1> = 60";
            }
            else if (uiRadioButton3.Checked == true)
            {
                sql_conditions = " and status='发展对象' and count_reports >= 6 + (cul_time/4) and failed='否' and score2> = 60 and application2='通过'";
            }
            else if (uiRadioButton4.Checked == true)
            {
                sql_conditions = " and status='预备党员' and cul_time >= 12 and count_reports >= (count_reports_last + 4) and failed='否' and befull='通过'";
            }

            string sql = sql_basic + sql_conditions;
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
        public void Update_status()
        {
            string sql_conditions = "";
            string update_status = "";
            string update_time = "";
            if (uiRadioButton1.Checked == true)
            {
                sql_conditions = " and status='入党申请人'and cul_time >= 6 and application1='通过'and count_reports >= 2 and failed='否' ";
                update_status = "入党积极分子";
                update_time = "activist_time";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql_conditions = " and status='入党积极分子' and cul_time >= 12 and count_reports >= 6 and failed='否' and score1> = 60";
                update_status = "发展对象";
                update_time = "developer_time";
            }
            else if (uiRadioButton3.Checked == true)
            {
                sql_conditions = " and status='发展对象' and count_reports >= 6 + (cul_time/4) and failed='否' and score2> = 60 and application2='通过'";
                update_status = "预备党员";
                update_time = "member_time";
            }
            else if (uiRadioButton4.Checked == true)
            {
                sql_conditions = " and status='预备党员' and cul_time >= 12 and count_reports >= (count_reports_last + 4) and failed='否' and befull='通过'";
                update_status = "正式党员";
                update_time = "fullmember_time";
            }

            string sql_basic = "select t_user.stu_id"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        + " and t_user.stu_id = t_writsum.stu_id"
                        + sql_conditions;

            string sql_update = $"update t_user set status='{update_status}' where stu_id in ({sql_basic})";
            string sql_time=$"update t_timerecord set {update_time}=CONVERT(varchar(100), GETDATE(), 23),final_time= CONVERT(varchar(100), GETDATE(), 23) where stu_id in ({sql_basic})";

            
            if (uiTextBox1.Text != "")
            {
                string sql_exclude = " and stu_id not in " + $"({uiTextBox1.Text})";
                sql_update = sql_update + sql_exclude;
                sql_time = sql_time + sql_exclude;
            }
            Dao dao = new Dao();
            int n = dao.Execute(sql_update);
            int m = dao.Execute(sql_time);
            if (m > 0 && n > 0)
            {
                MessageBox.Show($"{n}名学生的身份已改为“{update_status}”");
            }
            else
            {
                MessageBox.Show("没有需要发展的学生！");
            }            
            dao.DaoClose();
        }

        private void AdminPlan_Load(object sender, EventArgs e)
        {

        }

      



        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (ifsearch == 0)
            {
                MessageBox.Show("请先查询需要发展的学生！");
            }
            else
            { 
                 Update_status();
            }
            
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
