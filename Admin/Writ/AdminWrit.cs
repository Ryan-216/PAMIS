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
            uiRadioButton1.Checked = true;
        }

        private void AdminWrit_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            uiDataGridView1.Rows.Clear();//清空旧数据
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
                uiDataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableSearch()
        {
            uiDataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "";
            if (uiRadioButton1.Checked == true)
            {
                sql = $"select*from t_writ where stu_id='{uiTextBox1.Text}'";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql = $"select*from t_writ where statues='{uiTextBox1.Text}'";
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
                uiDataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string writ_id = uiDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string type = uiDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string stu_id = uiDataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            AdminCheckWrit adminCheckWrit = new AdminCheckWrit(writ_id, type, stu_id);
            adminCheckWrit.ShowDialog();
            Table();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            uiTextBox1.Text = "";
            Table();
        }
    }
}
