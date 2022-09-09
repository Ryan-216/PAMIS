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
    public partial class AdminPlan : Form
    {
        public AdminPlan()
        {
            InitializeComponent();
            Table();
            radioButton1.Checked = true;
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_plan";
            IDataReader dc = dao.read(sql);
            string no,stu_id, name, test1, test2,pass;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                name = dc[2].ToString();
                test1 = dc[3].ToString();
                test2 = dc[4].ToString();
                pass = dc[5].ToString();

                string[] table = { no, stu_id, name, test1, test2, pass };
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
                sql = $"select*from t_plan where stu_id='{textBox1.Text}'";
            }
            else if (radioButton3.Checked == true)
            {
                sql = $"select*from t_plan where pass='{textBox1.Text}'";
            }
            IDataReader dc = dao.read(sql);
            string no,stu_id, name, test1,test2, pass;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                name = dc[2].ToString();
                test1 = dc[3].ToString();
                test2 = dc[4].ToString();
                pass = dc[5].ToString();

                string[] table = { no, stu_id, name, test1, test2, pass };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void AdminPlan_Load(object sender, EventArgs e)
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
    }
}
