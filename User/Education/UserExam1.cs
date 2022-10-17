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
    public partial class UserExam1 : Form
    {
        public UserExam1()
        {
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select Exam_no,Exam_name,Exam_type from t_exam";
            IDataReader dc = dao.read(sql);
            string no,name,type;
            while (dc.Read())
            {
                no = dc[0].ToString();
                name = dc[1].ToString();
                type = dc[2].ToString();              

                string[] table = { no,name,type };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void UserExam1_Load(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string exam_no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string exam_type = basicDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Dao dao = new Dao();
            string sql = "select * from t_stu_exam where stu_id =\'" + Data.UID + "\' and exam_no = \'" + exam_no + "\'";
            IDataReader dc = dao.read(sql);
            int count = 0;
            while(dc.Read())
            {
                count++;
            }
            if(count == 0)
            {
                if (exam_type == "选择题")
                {
                    UserExamChoose userExam = new UserExamChoose(exam_no);
                    userExam.ShowDialog();
                }
                if (exam_type == "问答题")
                {
                    UserExamSub userExamSub = new UserExamSub(exam_no);
                    userExamSub.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("您已经完成本次考试，无需再次考试");
            }



        }
    }
}
