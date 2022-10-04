using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Party_MS2.User
{
    public partial class UserLearn : Form
    {
        public UserLearn()
        {
            InitializeComponent();
            table();
        }

        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select t_education.no, t_education.name, t_education.hours, t_education.contents, " +
                "t_education.status, t_education.s_time, t_education.e_time, t_stueduscore.clear, e_stueduscore.score from t_education, t_stueduscore " +
                "where t_education.no=t_stueduscore.no and t_education.id="+Data.UID;
            IDataReader dc = dao.read(sql);
            string education_no, education_name, education_hours, education_contents, education_status, education_stime, education_etime, education_clear;
            while (dc.Read())
            {
                education_no = dc[0].ToString();
                education_name = dc[1].ToString();
                education_hours = dc[2].ToString();
                education_contents = dc[3].ToString();
                education_status = dc[4].ToString();
                education_stime = dc[5].ToString();
                education_etime = dc[6].ToString();
                education_clear = dc[7].ToString();

                string[] table = { education_no, education_name, education_hours, education_contents, education_status, education_stime, education_etime, education_clear };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Data.LearningNO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UserLearning userLearning = new UserLearning();
            userLearning.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserLearn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserIndex userIndex = new UserIndex();
            userIndex.Show();
        }
    }
}
