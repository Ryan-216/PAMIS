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
    public partial class AMLeavereasons : Form
    {
        public AMLeavereasons()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_leavereasons";
            IDataReader dc = dao.read(sql);
            string no, stu_id, reason, audit;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                reason = dc[2].ToString();
                audit = dc[3].ToString();

                string[] table = { no,stu_id, reason, audit };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        string meeting_no = "";
        string mstu_id = "";
        
        private void AMLeavereasons_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            meeting_no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            mstu_id= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Dao dao = new Dao();
            string sql = $"update t_leavereasons set audit='批准'where no='{meeting_no}'and stu_id='{mstu_id}';insert into t_mattend values('{meeting_no}','{mstu_id}','请假')";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("批准成功！");
            }
            else
            {
                MessageBox.Show("批准失败！");
            }
            dao.DaoClose();
            Table();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            meeting_no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            mstu_id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Dao dao = new Dao();
            string sql = $"update t_leavereasons set audit='拒绝'where no='{meeting_no}'and stu_id='{mstu_id}';";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("拒绝成功！");
            }
            else
            {
                MessageBox.Show("拒绝失败！");
            }
            dao.DaoClose();
            Table();
        }
    }
}
