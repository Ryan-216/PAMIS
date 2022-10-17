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
    public partial class UMAskforleave : Form
    {
        public UMAskforleave()
        {
            InitializeComponent();
            Table();
        }

        string meeting_no;
        string meeting_name;
        string meeting_time;
        string meeting_place;
        public UMAskforleave(string no,string name,string time,string place)
        {
            InitializeComponent();
            Table();
            meeting_no = no;
            meeting_name = name;
            meeting_time = time;
            meeting_place = place;
            uiLabel2.Text = $"您要请假的会议名称：{meeting_name}";
            uiLabel3.Text = $"时间：{meeting_time}";
            uiLabel4.Text = $"地点：{meeting_place}";
        }
        
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_leavereasons where stu_id ='{Data.UID}';";
            IDataReader dc = dao.read(sql);
            string no, stu_id, reason, audit;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                reason = dc[2].ToString();
                audit = dc[3].ToString();

                string[] table = { no, stu_id, reason, audit };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
       

        


        private void UMAskforleave_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"insert into t_leavereasons values('{meeting_no}','{Data.UID}','{uiRichTextBox1.Text}','未审核')";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("请假成功！");
            }
            else
            {
                MessageBox.Show("请假失败！");
            }
            dao.DaoClose();
        }
    }
}
