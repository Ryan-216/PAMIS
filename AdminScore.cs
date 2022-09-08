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
            radioButton1.Checked = true;
        }

        private void AdminScore_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_score";
            IDataReader dc = dao.read(sql);
            string stu_id, name, avg_score, failed;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                avg_score = dc[2].ToString();
                failed = dc[3].ToString();

                string[] table = { stu_id, name, avg_score, failed };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableSearch()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "";
            if (radioButton1.Checked == true)
            {
                sql = $"select*from t_score where stu_id='{textBox1.Text}'";
            }
            else if (radioButton2.Checked == true)
            {
                sql = $"select*from t_score where avg_score='{textBox1.Text}'";
            }
            else if (radioButton3.Checked == true)
            {
                sql = $"select*from t_score where failed='{textBox1.Text}'";
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
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
        }
    }
}
