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
    public partial class AMAttendee : Form
    {
        public AMAttendee()
        {
            InitializeComponent();
            Table();
        }

        private void AMAttendee_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
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
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
