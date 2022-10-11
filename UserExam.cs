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
    public partial class UserExam : Form
    {
        public UserExam()
        {
            InitializeComponent();
            setExam("E01");             //need alter
        }

        private void setExam(string exam_no)
        {
            Dao dao = new Dao();
            string sql = "select exam_content, exam_type from t_exam where exam_no=\'" + exam_no + "\'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            string exam_type = dc[1].ToString();

            if(exam_type == "choose")
            {
                string text = dc[0].ToString();
                string[] sArray = text.Split('*');

                uiLabel1.Text = "1." + sArray[0];
                uiRadioButton1.Text = "A." + sArray[1];
                uiRadioButton2.Text = "B." + sArray[2];
                uiRadioButton3.Text = "C." + sArray[3];
                uiRadioButton4.Text = "D." + sArray[4];
                uiLabel6.Text = "2." + sArray[5];
                uiRadioButton5.Text = "A." + sArray[6];
                uiRadioButton6.Text = "B." + sArray[7];
                uiRadioButton7.Text = "C." + sArray[8];
                uiRadioButton8.Text = "D." + sArray[9];

            }

            dc.Close();
        }

        private void setAnswer(string exam_no)
        {
            string answer = "";
            if(uiRadioButton1.Checked)
            {
                answer += "A*";
            }
            if (uiRadioButton2.Checked)
            {
                answer += "B*";
            }
            if (uiRadioButton3.Checked)
            {
                answer += "C*";
            }
            if (uiRadioButton4.Checked)
            {
                answer += "D*";
            }
            if (uiRadioButton5.Checked)
            {
                answer += "A*";
            }
            if (uiRadioButton6.Checked)
            {
                answer += "B*";
            }
            if (uiRadioButton7.Checked)
            {
                answer += "C*";
            }
            if (uiRadioButton8.Checked)
            {
                answer += "D*";
            }
            Dao dao = new Dao();
            string sql = "insert into t_stu_exam values (" + "\'" + Data.UID + "\'" + ", " + "\'" + exam_no + "\'" + ", " + "\'" + answer + "\'" + ")";
            dao.Execute(sql);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            setAnswer("E01");               //need alter
            MessageBox.Show("提交成功！");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否确认退出", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void uiLedStopwatch1_TimerTick(object sender, EventArgs e)
        {

        }

    }
}
