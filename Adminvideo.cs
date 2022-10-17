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
    public partial class Adminvideo : Form
    {
        public Adminvideo()
        {
            InitializeComponent();
            Table();
        }
        string type;
        public Adminvideo(string train_no)
        {
            InitializeComponent();
            Table();
            type = train_no;
        }
        public void Table()
        {
            Dao dao = new Dao();
            basicDataGridView.Rows.Clear();//清空旧数据            
            string sql = $"select  distinct video_no,video_name,location from t_video where train_no='{type}'";
            IDataReader dc = dao.read(sql);
            string  no2, name, loc;
            while (dc.Read())
            {
                no2 = dc[0].ToString();
                name = dc[1].ToString();
                loc = dc[2].ToString();
               

                string[] table = { no2, name, loc };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void Adminvideo_Load(object sender, EventArgs e)
        {
            Table();
        }
        public void set_Null()
        {
            uiTextBox2.Text = "";
            uiTextBox3.Text = "";
            uiTextBox4.Text = "";
            uiTextBox1.Text = "";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (  uiTextBox2.Text != "" && uiTextBox3.Text != "" && uiTextBox4.Text != "" )
            {
                Dao dao = new Dao();
                string sql = $"insert into t_video values('{type}','{uiTextBox2.Text}','{uiTextBox3.Text}','{uiTextBox4.Text}','未完成','id')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
                Table();
                set_Null();
            }
            else
            {
                MessageBox.Show("信息不可为空！");
            }
        }
        string no = "";
        private void uiButton2_Click(object sender, EventArgs e)
        {
            no=uiTextBox2.Text = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            uiTextBox3.Text = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            uiTextBox4.Text = basicDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            if ( uiTextBox2.Text != "" && uiTextBox3.Text != "" && uiTextBox4.Text != "" )
            {
                Dao dao = new Dao();
                string sql = $"update t_video set train_no = '{type}', video_no = '{uiTextBox2.Text}',video_name = '{uiTextBox3.Text}', location = '{uiTextBox4.Text}'where train_no = '{type}'and video_no = '{no}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
                set_Null();
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("信息不可为空！");
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                //label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = $"delete from t_video where train_no = '{type }'and video_no='{no}'";
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
                MessageBox.Show("请先选中要删除的课程!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Table();
            set_Null();
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select distinct video_no,video_name,location from t_video where train_no='{type}'and video_no={uiTextBox1.Text}";
            IDataReader dc = dao.read(sql);
            string no2, name, loc;
            while (dc.Read())
            {
                no2 = dc[0].ToString();
                name = dc[1].ToString();
                loc = dc[2].ToString();


                string[] table = { no2, name, loc };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
