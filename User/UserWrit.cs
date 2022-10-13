using Party_MS2.User;
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
    public partial class UserWrit : Form
    {
        public UserWrit()
        {
            InitializeComponent();
            Table();
        }

        private void UserWrit_Load(object sender, EventArgs e)
        {

        }

        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql =  $"select writ_id, type, upload_time, check_time, statues from t_writ where t_writ.stu_id ='{Data.UID}'; ";
            IDataReader dc = dao.read(sql);
            string writ_id, type, upload_time, check_time, statues;
            while (dc.Read())
            {
                writ_id = dc[0].ToString();
                type = dc[1].ToString();
                upload_time = dc[2].ToString();
                check_time = dc[3].ToString();
                statues = dc[4].ToString();

                string[] table = { writ_id, type, upload_time, check_time, statues};
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSelectWrit userSelectWrit = new UserSelectWrit();
            userSelectWrit.Show();
        }
    }
}
