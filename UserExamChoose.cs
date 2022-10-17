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
    public partial class UserExamChoose : Form
    {
        public UserExamChoose()
        {
            InitializeComponent();
            //setExam("E03");             
        }
        public UserExamChoose(string no)
        {
            InitializeComponent();
            setExam(no);             //need alter
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
                uiLabel2.Text = "3." + sArray[10];
                uiRadioButton9.Text = "A." + sArray[11];
                uiRadioButton10.Text = "B." + sArray[12];
                uiRadioButton11.Text = "C." + sArray[13];
                uiRadioButton12.Text = "D." + sArray[14];

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
            if(uiRadioButton9.Checked)
            {
                answer += "A*";
            }
            if(uiRadioButton10.Checked)
            {
                answer += "B*";
            }
            if (uiRadioButton11.Checked)
            {
                answer += "C*";
            }
            if (uiRadioButton12.Checked)
            {
                answer += "D*";
            }
            Dao dao = new Dao();
            string sql = "insert into t_stu_exam values (" + "\'" + Data.UID + "\'" + ", " + "\'" + exam_no + "\'" + ", " + "\'" + answer + "\'" + "," + 0 + ")";
            dao.Execute(sql);
        }
        
        private int setScore(string exam_no)
        {
            int correct = 0;
            int score = 0;
            Dao dao = new Dao();
            string sql = "select exam_answer from t_exam where exam_no=\'" + exam_no + "\'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            string answer = dc[0].ToString();
            string[] answerArray = answer.Split('*');
            sql = "select stu_answer from t_stu_exam where exam_no=\'" + exam_no + "\' and stu_id =" + Data.UID;
            dc = dao.read(sql);
            dc.Read();
            string stu_answer = dc[0].ToString();
            string[] stu_answerArray = stu_answer.Split('*');
            for(int i = 0; i<= answerArray.Length - 1; i++)
            {
                if (answerArray[i].ToLower() == stu_answerArray[i].ToLower())
                {
                    correct++;
                    score = correct * 100 / answerArray.Length;
                }
            }
            sql = "update t_stu_exam set exam_score =" + score + "where stu_id = " + Data.UID + "and exam_no =\'" + exam_no + "\'";
            dao.Execute(sql);
            return score;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            setAnswer("E03");               //need alter
            int score = setScore("E03");
            MessageBox.Show("提交成功！ 您本次考试的得分为" + score + "分");
            this.Close();
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

        private void UserExam_Load(object sender, EventArgs e)
        {

        }
    }
}
