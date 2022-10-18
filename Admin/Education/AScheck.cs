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
    public partial class AScheck : Form
    {
        public AScheck()
        {
            InitializeComponent();
            Table();
        }

        string stu_id1 = "";
        string type1 = "";
        private void Table()
        {
            basicDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_asktocheck";
            IDataReader dc = dao.read(sql);
            string stu_id, type, audit;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                type = dc[1].ToString();
                audit = dc[2].ToString();
                string[] table = new string[] { stu_id, type, audit };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void Get_answer()
        {
            stu_id1 = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
             type1 = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string course_id = "";
            if (type1 == "积极分子培训成绩")
            {
                course_id = "ACT";
            }
            else if (type1 == "发展对象培训成绩")
            {
                course_id = "IMP";
            }
            uiDataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select stu_id,t_exam.exam_no,stu_answer,exam_answer"
                        +" from t_stu_exam, t_exam"
                        +" where t_stu_exam.exam_no = t_exam.exam_no"
                        +$" and stu_id = '{stu_id1}' and t_exam.exam_no = 'ACT'";
            IDataReader dc = dao.read(sql);
            string stu_id, exam_no, stu_answer, exam_answer;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                exam_no = dc[1].ToString();
                stu_answer = dc[2].ToString();
                exam_answer = dc[3].ToString();
                string[] table = new string[] { stu_id, exam_no, stu_answer, exam_answer };
                uiDataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();


        }

        private void AScheck_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Get_answer();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"update t_asktocheck set audit='成绩无误' where stu_id='{stu_id1}' and type='{type1}'";
            int n = dao.Execute(sql);
            
            if (n > 0)
            {
                MessageBox.Show("审核成功！");
            }
            else
            {
                MessageBox.Show("审核失败！");
            }
            Table();


            dao.DaoClose();
            
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"select * from t_scoresum where stu_id ='{stu_id1}'";
            IDataReader dc = dao.read(sql);
            string stu_id, s1, s2, s3;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                s1 = dc[1].ToString();
                s2 = dc[2].ToString();
                s3 = dc[3].ToString();
                uiTextBox1.Text = $"{stu_id}";
                uiTextBox2.Text = $"{s1}";
                uiTextBox3.Text = $"{s2}";
                uiTextBox4.Text = $"{s3}";
            }
            
            dao.DaoClose();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"update t_scoresum set stu_id='{uiTextBox1.Text}',failed='{uiTextBox2.Text}',score1='{uiTextBox3.Text}',score2='{uiTextBox4.Text}'";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("修改成功！");

                string sql2 = $"update t_asktocheck set audit= '成绩已修改' where stu_id='{stu_id1}' and type='{type1}'";
                int m = dao.Execute(sql2);

                if (m > 0)
                {
                    MessageBox.Show("审核成功！");
                }
                else
                {
                    MessageBox.Show("审核失败！");
                }
                Table();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
