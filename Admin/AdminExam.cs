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
    public partial class AdminExam : Form
    {
        public AdminExam()
        {
            InitializeComponent();
            table();
        }

        private void table()
        {
            uiDataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select stu_id, t_exam.exam_no , exam_name from t_exam , t_stu_exam where t_exam.exam_no = t_stu_exam.exam_no and t_exam.exam_type = \'问答题\' and t_stu_exam.exam_score = -1";
            IDataReader dc = dao.read(sql);
            string stu_id, exam_no, exam_name ;
            while(dc.Read())
            {
                stu_id = dc[0].ToString();
                exam_no = dc[1].ToString();
                exam_name = dc[2].ToString();

                string[] table = { stu_id, exam_no, exam_name };

                uiDataGridView1.AddRow(table);
            }
            dao.DaoClose();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string stu_id = uiDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string exam_no = uiDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            AdminCheckExam adminCheckExam = new AdminCheckExam(exam_no, stu_id);
            adminCheckExam.ShowDialog();
            table();
        }
    }
}
