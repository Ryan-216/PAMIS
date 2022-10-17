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
    public partial class AdminScore : Form
    {
        public AdminScore()
        {
            InitializeComponent();
            Table();
            uiRadioButton1.Checked = true;
        }

        private void AdminScore_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_scoresum";
            IDataReader dc = dao.read(sql);
            string stu_id, failed, score1, score2;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                failed = dc[1].ToString();
                score1 = dc[2].ToString();
                score2 = dc[3].ToString();

                string[] table = { stu_id, failed,score1, score2 };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "";
            if (uiRadioButton1.Checked == true)
            {
                sql = $"select * from t_scoresum where stu_id='{uiTextBox1.Text}'";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql = $"select * from t_scoresum where failed = '{uiTextBox1.Text}'";
            }
            else if (uiRadioButton3.Checked == true)
            {
                sql = $"select * from t_scoresum where score1 ='{uiTextBox1.Text}'";
            }
            else if (uiRadioButton4.Checked == true)
            {
                sql = $"select * from t_scoresum where score2='{uiTextBox1.Text}'";
            }
            IDataReader dc = dao.read(sql);
            string stu_id, name, avg_score, failed;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                avg_score = dc[2].ToString();
                failed = dc[3].ToString();

                string[] table = { stu_id, name, avg_score, failed };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }


        private void uiButton1_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Table();
            uiTextBox1.Text = "";
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            AScheck aScheck = new AScheck();
            aScheck.ShowDialog();
        }
    }
}
