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
    public partial class AdminIndex : Form
    {
        public AdminIndex()
        {
            InitializeComponent();
            hideAll();
            label1.Show();
        }

        private void 申请人基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBasicInfomation admin = new AdminBasicInfomation();
            this.Hide();
            admin.ShowDialog();
            this.Show();

        }

        private void AdminIndex_Load(object sender, EventArgs e)
        {

        }

        private void 成绩审查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminScore admin = new AdminScore();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 思想汇报管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminReport admin = new AdminReport();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 发展计划管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPlan adminPlan = new AdminPlan();
            this.Hide();
            adminPlan.ShowDialog();
            this.Show();
        }

        private void 函调管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLetter adminletter = new AdminLetter();
            this.Hide();
            adminletter.ShowDialog();
            this.Show();
        }

        private void 基本资料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 文书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminWrit admin = new AdminWrit();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void 会议管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AdminMeeting admin = new AdminMeeting();
            this.Hide();
            //admin.ShowDialog();
            this.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 思政教育管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminEducation admin = new AdminEducation();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hideAll()
        {
            label1.Hide();
            basicDataGridView.Hide();
            uiButton1.Hide();
            uiButton2.Hide();
            uiButton5.Hide();
            uiButton4.Hide();
            uiButton3.Hide();
            uiRadioButton1.Hide();
            uiRadioButton2.Hide();
            uiRadioButton3.Hide();
            uiTextBox1.Hide();
            uiLine1.Hide();
        }

        private void uiNavMenu1_MenuItemClick(TreeNode node, Sunny.UI.NavMenuItem item, int pageIndex)
        {
            //UIMessageTip.ShowOk(node.Text + ", " + pageIndex);
            if (node.Text == "申请人基本资料")
            {
                //AdminBasicInfomation adminBasicInfomation = new AdminBasicInfomation();
                //adminBasicInfomation.ShowDialog();
                ShowAdminBasicInformation();
                table();
            }
        }
        
        private void ShowAdminBasicInformation()
        {
            hideAll();
            basicDataGridView.Show();
            uiButton1.Show();
            uiButton2.Show();
            uiButton5.Show();
            uiButton4.Show();
            uiButton3.Show();
            uiRadioButton1.Show();
            uiRadioButton2.Show();
            uiRadioButton3.Show();
            uiTextBox1.Show();
            uiLine1.Show();
            uiRadioButton1.Checked = true;
        }


        private void table()
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ABIAdd add = new ABIAdd();
            this.Hide();
            add.ShowDialog();
            table();
            this.Show();
        }

        private void uiLine1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();//获取学号
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_user where stu_id = '{stu_id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        table();
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

        private void uiButton2_Click(object sender, EventArgs e)
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

                table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "";
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

        private void uiButton4_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            table();
            uiTextBox1.Text = "";
        }

        private void basicDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
