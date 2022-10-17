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
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql =  $"select writ_id, type, upload_time, check_time, statues from t_writ where t_writ.writ_id like \'" +Data.UID + "02001\' or writ_id like \'" + Data.UID + "03001\' or writ_id like \'" + Data.UID + "04001\'";
            //string sql = "select report_id, update_time, check_time, status from t_reports where report_id like \'" + Data.UID + "01___001\'" + " and upload_counts != 0";

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
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string writ_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string type = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                UserCheckWrit userCheckWrit = new UserCheckWrit(writ_id, type);
                userCheckWrit.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            UserSelectWrit userSelectWrit = new UserSelectWrit();
            userSelectWrit.Show();
            Table();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

      
    }
}
