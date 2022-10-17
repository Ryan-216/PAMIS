using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2.Admin
{
    public partial class AdminCheckExam : Form
    {
        string exam_no_global, stu_id_global;
        public AdminCheckExam(string exam_no, string stu_id)
        {
            InitializeComponent();
            ExamAnswerContent(exam_no, stu_id);
        }

        private void ExamAnswerContent(string exam_no, string stu_id)
        {
            string sql = "select stu_answer from t_stu_exam where exam_no=\'" + exam_no + "\' and stu_id=\'" + stu_id + "\'";
            Dao dao = new Dao();
            IDataReader dc = dao.read(sql);
            dc.Read();
            uiRichTextBox1.Text = dc[0].ToString();
            sql = "select exam_content from t_exam where exam_no=\'" + exam_no + "\'";
            dc = dao.read(sql);
            dc.Read();
            uiLabel2.Text = dc[0].ToString();
            exam_no_global = exam_no;
            stu_id_global = stu_id;
            dc.Close();
            dao.DaoClose();
        }

        private void uiTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AdminCheckExam_Load(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int score = -1;
            try
            {
                score = int.Parse(uiTextBox1.Text);
            }
            catch
            {
                MessageBox.Show("请输入0-100以内的整数");
                return;
            }
            if(score >= 0 && score <= 100)
            {
                Dao dao = new Dao();
                string sql = "update t_stu_exam set exam_score=" + score + "where exam_no =\'" + exam_no_global + "\' and stu_id=\'" + stu_id_global + "\'";
                dao.Execute(sql);
                MessageBox.Show("成绩上传成功");
                dao.DaoClose();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请输入0-100以内的整数");
                return;
            }

        }
    }
}
