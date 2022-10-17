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
    public partial class AdminBasicInfomation : Form
    {
        public AdminBasicInfomation()
        {
            InitializeComponent();
            Table();
            uiRadioButton1.Checked = true;
        }
        private void AdminBasicInfomation_Load(object sender, EventArgs e)
        {

        }

        //private void AdminBasicInfomation_Load(object sender, EventArgs e)
        //{
        // TODO: 这行代码将数据加载到表“partyDBIIDataSet.t_user”中。您可以根据需要移动或删除它。
        //    this.t_userTableAdapter.Fill(this.partyDBIIDataSet.t_user);

        // }
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_user";
            IDataReader dc = dao.read(sql);
            string stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                sex = dc[2].ToString();
                ID = dc[3].ToString();
                status = dc[4].ToString();
                school_id = dc[5].ToString();
                nation = dc[6].ToString();
                origin = dc[7].ToString();
                e_mail = dc[8].ToString();
                pri_party = dc[9].ToString();
                apply_time = dc[10].ToString();
               


                string[] table = { stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABIAdd add = new ABIAdd();
            this.Hide();
            add.ShowDialog();
            Table();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string sex = basicDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string ID = basicDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string status = basicDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string school_id = basicDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string nation = basicDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                string origin = basicDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                string e_mail = basicDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                string pri_party  = basicDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                string apply_time = basicDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                
                
                ABIUpdate admin = new ABIUpdate(stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取学号
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_user where stu_id = '{stu_id }'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的学生!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            uiTextBox1.Text = "";
        }

        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql="";
            if (uiRadioButton1.Checked == true)
            {
                sql = $"select*from t_user where stu_id='{uiTextBox1.Text}'";
            }
            else if (uiRadioButton2.Checked == true)
            {
                sql = $"select*from t_user where school_id='{uiTextBox1.Text}'";
            }
            else if (uiRadioButton3.Checked == true)
            {
                sql = $"select*from t_user where pri_party='{uiTextBox1.Text}'";
            }
            IDataReader dc = dao.read(sql);
            string stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                sex = dc[2].ToString();
                ID = dc[3].ToString();
                school_id = dc[5].ToString();
                nation = dc[6].ToString();
                origin = dc[7].ToString();
                e_mail = dc[8].ToString();
                pri_party = dc[9].ToString();
                apply_time = dc[10].ToString();
                status = dc[4].ToString();


                string[] table = { stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time };
                basicDataGridView.Rows.Add(table);
            }
                dc.Close();
            dao.DaoClose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            ABIAdd add = new ABIAdd();
            this.Hide();
            add.ShowDialog();
            Table();
            this.Show();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string name = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string sex = basicDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string ID = basicDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string status = basicDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string school_id = basicDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string nation = basicDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                string origin = basicDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                string e_mail = basicDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                string pri_party = basicDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                string apply_time = basicDataGridView.SelectedRows[0].Cells[10].Value.ToString();


                ABIUpdate admin = new ABIUpdate(stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取学号
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_user where stu_id = '{stu_id }'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的学生!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Table();
            uiTextBox1.Text = "";
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            TableSearch();
        }
    }
}
