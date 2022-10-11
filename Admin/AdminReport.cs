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
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
            Table();
            radioButton1.Checked = true;
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_report";
            IDataReader dc = dao.read(sql);
            string stu_id, name, th_report, pass;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                th_report = dc[2].ToString();
                pass = dc[3].ToString();

                string[] table = { stu_id, name, th_report, pass };
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
                sql = $"select*from t_report where stu_id='{textBox1.Text}'";
            }           
            else if (radioButton3.Checked == true)
            {
                sql = $"select*from t_report where pass='{textBox1.Text}'";
            }
            IDataReader dc = dao.read(sql);
            string stu_id, name, th_report, pass;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                th_report = dc[2].ToString();
                pass = dc[3].ToString();

                string[] table = { stu_id, name, th_report,pass };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminReport_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
