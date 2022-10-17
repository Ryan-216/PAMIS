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
    public partial class UserReports : Form
    {
        public UserReports()
        {
            InitializeComponent();
            table();
        }

        private void table()
        {
            Dao dao = new Dao();
            string sql = "select report_id, update_time, check_time, status from t_reports where report_id like \'" + Data.UID +"01___001\'" + " and upload_counts != 0";
            IDataReader dc = dao.read(sql);
            string report_id, update_time, check_time, status;
            while (dc.Read())
            {
                report_id = dc[0].ToString();
                update_time = dc[1].ToString();
                check_time = dc[2].ToString();
                status = dc[3].ToString();

                string[] table = { report_id, update_time, check_time, status };

                uiDataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            UserAddReports userAddReports = new UserAddReports();
            userAddReports.Show();
        }
    }
}
