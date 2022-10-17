using Party_MS2.Admin;
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

namespace Party_MS2
{
    public partial class AdminWrit : Form
    {
        public AdminWrit()
        {
            InitializeComponent();
            Table();
            radioButton1.Checked = true;
        }

        private void AdminWrit_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_writ where writ_id like \'%001\'";
            IDataReader dc = dao.read(sql);
            string stu_id, type, writ_id, upload_time, check_time, pass;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                type = dc[1].ToString();
                writ_id = dc[2].ToString();
                upload_time = dc[3].ToString();
                check_time = dc[4].ToString();
                pass = dc[5].ToString();
              
                string[] table = { stu_id, type, writ_id, upload_time, check_time, pass };
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
                sql = $"select*from t_writ where stu_id='{textBox1.Text}'";
            }
            else if (radioButton2.Checked == true)
            {
                sql = $"select*from t_writ where statues='{textBox1.Text}'";
            }

            IDataReader dc = dao.read(sql);
            string stu_id, type,writ_id, upload_time, check_time, pass;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                type = dc[1].ToString();
                writ_id = dc[2].ToString();
                upload_time = dc[3].ToString();
                check_time = dc[4].ToString();
                pass = dc[5].ToString();

                string[] table = { stu_id, type, writ_id, upload_time, check_time, pass };
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
            textBox1.Text = "";
            Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string writ_id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string type = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string stu_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            AdminCheckWrit adminCheckWrit = new AdminCheckWrit(writ_id, type, stu_id);
            adminCheckWrit.ShowDialog();
            Table();
        }
    }
}
