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
            string sql = "select * from t_writ";
            IDataReader dc = dao.read(sql);
            string stu_id, type, time, contents,pass ;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                type = dc[1].ToString();
                time = dc[2].ToString();
                contents = dc[3].ToString();
                pass = dc[4].ToString();
              
                string[] table = { stu_id,type,time,contents,pass };
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
                sql = $"select*from t_writ where type='{textBox1.Text}'";
            }

            IDataReader dc = dao.read(sql);
            string stu_id, type, time, contents, pass;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                type = dc[1].ToString();
                time = dc[2].ToString();
                contents = dc[3].ToString();
                pass = dc[4].ToString();

                string[] table = { stu_id, type, time, contents, pass };
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
    }
}
