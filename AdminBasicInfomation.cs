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
    public partial class AdminBasicInfomation : Form
    {
        public AdminBasicInfomation()
        {
            InitializeComponent();
            Table();
        }
        private void AdminBasicInfomation_Load(object sender, EventArgs e)
        {

        }

        //private void AdminBasicInfomation_Load(object sender, EventArgs e)
        //{
        // TODO: 这行代码将数据加载到表“partyDBIIDataSet.t_user”中。您可以根据需要移动或删除它。
        //    this.t_userTableAdapter.Fill(this.partyDBIIDataSet.t_user);

        // }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_user";
            IDataReader dc = dao.read(sql);
            string stu_id, name, sex, ID, status,school_id, nation, origin, e_mail, pri_party, apply_time;
            while (dc.Read())
            {
                stu_id = dc[0].ToString();
                name = dc[1].ToString();
                sex = dc[2].ToString();
                ID= dc[3].ToString();
                status= dc[4].ToString();
                school_id = dc[5].ToString();
                nation = dc[6].ToString();
                origin= dc[7].ToString();
                e_mail= dc[8].ToString();
                pri_party= dc[9].ToString();
                apply_time = dc[10].ToString();
                

                string[] table = { stu_id, name, sex, ID, status,school_id, nation, origin, e_mail, pri_party, apply_time };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABIAdd add = new ABIAdd();
            this.Hide();
            add.ShowDialog();
            Table();
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string stu_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string sex = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string ID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string status = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string school_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string nation = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string origin = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string e_mail = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();    
                string pri_party = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                string apply_time = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

                ABIUpdate admin = new ABIUpdate(stu_id, name, sex, ID, status, school_id, nation, origin, e_mail, pri_party, apply_time);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
