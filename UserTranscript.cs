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
    public partial class UserTranscript : Form
    {
        public UserTranscript()
        {
            InitializeComponent();
            Table();
        }
        
        private void Table()
        {
            basicDataGridView.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select failed,score1,score2 from t_scoresum where stu_id= '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            string failed,score1,score2;
            while(dc.Read())
            {
                failed = dc[0].ToString();
                score1 = dc[1].ToString();
                score2 = dc[2].ToString();
                string[] table = new string[] { failed,score1,score2 };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void Check()
        {
            string type = "";
            string sql = "";
            if (uiRadioButton3.Checked == true)
            {
                type = "学业成绩";
            }
            else if (uiRadioButton1.Checked == true)
            {
                type = "积极分子培训成绩";
            }
            else if (uiRadioButton2.Checked == true)
            {
                type = "发展对象培训成绩";
            }
            
            Dao dao = new Dao();
            if (type != "")
            {
                sql = $"insert into t_asktocheck values('{Data.UID}','type','未审核')";
            }
            else
            {
                MessageBox.Show("请选择申诉类型！");
            }
           
            int n = dao.Execute(sql);
            if (n>0)
            {
                MessageBox.Show("申诉请求已发送！");
            }
            else 
            {
                MessageBox.Show($"Error[{sql}]");
            }
            
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void UserTranscript_Load(object sender, EventArgs e)
        {

        }
    }
}
