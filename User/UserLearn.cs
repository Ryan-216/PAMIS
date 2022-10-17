using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Party_MS2.User
{
    public partial class UserLearn : Form
    {
        public UserLearn()
        {
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select no, name, hours, status, s_time, e_time, clear, from t_education where stu_id="+Data.UID;
            IDataReader dc = dao.read(sql);
            string education_no, education_name, education_hours, education_contents, education_status, education_stime, education_etime, education_clear;
            while (dc.Read())
            {
                education_no = dc[0].ToString();
                education_name = dc[1].ToString();
                education_hours = dc[2].ToString();
                education_contents = dc[3].ToString();
                education_status = dc[4].ToString();
                education_stime = dc[5].ToString();
                education_etime = dc[6].ToString();
                education_clear = dc[7].ToString();

                string[] table = { education_no, education_name, education_hours, education_contents, education_status, education_stime, education_etime, education_clear };
               basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserLearn_Load(object sender, EventArgs e)
        {

        }

      

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string train_no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Uservideos user = new Uservideos(train_no);
            user.Show();
        }
    }
}
