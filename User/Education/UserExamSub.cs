using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Party_MS2
{
    public partial class UserExamSub : Form
    {
        string no = null;
        public UserExamSub(string exam_no)
        {
            InitializeComponent();
            lablechange(exam_no);
            no = exam_no;
        }

        private void lablechange(string exam_no)
        {
            Dao dao = new Dao();
            string sql = "select exam_content from t_exam where exam_no=\'" + exam_no + "\'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            uiLabel1.Text = dc[0].ToString();
            dc.Close();
            dao.DaoClose();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string stu_answer = uiRichTextBox1.Text;
            string sql = "insert into t_stu_exam values (" + "\'" + Data.UID + "\'" + ", " + "\'" + no + "\'" + ", " + "\'" + stu_answer + "\'" + "," + -1 + ")";
            Dao dao = new Dao();
            try
            {
                dao.Execute(sql);
                MessageBox.Show("提交成功");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
