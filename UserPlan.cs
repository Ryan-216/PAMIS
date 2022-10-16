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
    public partial class UserPlan : Form
    {
        public UserPlan()
        {
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql  = "select t_user.stu_id,t_user.[name],t_user.[status],cul_time,count_reports,failed,score1,score2,application1,application2,befull,count_reports_last"
                        + " from t_user, t_timerecord, t_score, t_edufinalscore, t_writsum"
                        + " where t_user.stu_id = t_timerecord.stu_id"
                        + " and t_user.stu_id = t_score.stu_id"
                        + " and t_user.stu_id = t_edufinalscore.stu_id"
                        + " and t_user.stu_id = t_writsum.stu_id"
                        + $" and t_user.stu_id = '34191035'";
            IDataReader dc = dao.read(sql);
            string stu_id = "", name = "", status = "", cul_time = "", count_reports = "", failed = "", score1 = "", score2 = "", application1 = "", application2 = "", befull = "", count_reports_last = "";
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                status = dc[2].ToString();
                cul_time = dc[3].ToString();
                count_reports = dc[4].ToString();
                failed = dc[5].ToString();
                score1 = dc[6].ToString();
                score2 = dc[7].ToString();
                application1 = dc[8].ToString();
                application2 = dc[9].ToString();
                befull = dc[10].ToString();
                count_reports_last= dc[11].ToString();

                string[] table = { stu_id, name, status, cul_time, count_reports, failed, score1, score2, application1, application2, befull };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
            /*
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
            */
            uiLabel6.Text = $"恭喜您！您已经是一名“{status}”了！";
            if (status == "入党申请人")
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                if (int.Parse(cul_time) >= 6)
                {
                    uiCheckBox1.Checked = true;
                }
                if (failed=="否")
                {
                    uiCheckBox2.Checked = true;
                }
                if (int.Parse(count_reports) >= 2)
                {
                    uiCheckBox3.Checked = true;
                }
            }
            else if (status == "入党积极分子")
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                uiLight2.State = Sunny.UI.UILightState.On;
                uiCheckBox1.Checked = true;
                uiCheckBox2.Checked = true;
                uiCheckBox3.Checked = true;
                if (int.Parse(cul_time) >= 12)
                {
                    uiCheckBox4.Checked = true;
                }
                if (failed == "否")
                {
                    uiCheckBox5.Checked = true;
                }
                if (int.Parse(count_reports) >= 6)
                {
                    uiCheckBox6.Checked = true;
                }
                if (int.Parse(score1) >= 60)
                {
                    uiCheckBox7.Checked = true;
                }
            }
            else if (status == "发展对象")
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                uiLight2.State = Sunny.UI.UILightState.On;
                uiLight3.State = Sunny.UI.UILightState.On;
                uiCheckBox1.Checked = true;
                uiCheckBox2.Checked = true;
                uiCheckBox3.Checked = true;
                uiCheckBox4.Checked = true;
                uiCheckBox5.Checked = true;
                uiCheckBox6.Checked = true;
                uiCheckBox7.Checked = true;
                if (failed == "否")
                {
                    uiCheckBox8.Checked = true;
                }
                if (int.Parse(count_reports) >= 6 + (int.Parse(cul_time)/4))
                {
                    uiCheckBox9.Checked = true;
                }
                if (int.Parse(score2) >= 60)
                {
                    uiCheckBox10.Checked = true;
                }
                if (application2 == "通过")
                {
                    uiCheckBox11.Checked = true;
                }
            }
            else if (status == "中共预备党员")
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                uiLight2.State = Sunny.UI.UILightState.On;
                uiLight3.State = Sunny.UI.UILightState.On;
                uiLight4.State = Sunny.UI.UILightState.On;
                uiCheckBox1.Checked = true;
                uiCheckBox2.Checked = true;
                uiCheckBox3.Checked = true;
                uiCheckBox4.Checked = true;
                uiCheckBox5.Checked = true;
                uiCheckBox6.Checked = true;
                uiCheckBox7.Checked = true;
                uiCheckBox8.Checked = true;
                uiCheckBox9.Checked = true;
                uiCheckBox10.Checked = true;
                uiCheckBox11.Checked = true;

                if (int.Parse(cul_time) >= 12)
                {
                    uiCheckBox12.Checked = true;
                }
                if (failed == "否")
                {
                    uiCheckBox13.Checked = true;
                }
                if (int.Parse(count_reports) >= int.Parse(count_reports_last)+4)
                {
                    uiCheckBox14.Checked = true;
                }
                if (befull == "通过")
                {
                    uiCheckBox15.Checked = true;
                }
            }
            else if (status == "正式党员")
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                uiLight2.State = Sunny.UI.UILightState.On;
                uiLight3.State = Sunny.UI.UILightState.On;
                uiLight4.State = Sunny.UI.UILightState.On;
                uiLight5.State = Sunny.UI.UILightState.On;

            }


        }
        private void uiBreadcrumb1_ItemIndexChanged(object sender, int value)
        {

        }

        private void UserPlan_Load(object sender, EventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void uiCheckBox14_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
