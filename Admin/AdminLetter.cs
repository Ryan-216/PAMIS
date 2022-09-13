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
    public partial class AdminLetter : Form
    {
        public AdminLetter()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_letter";
            IDataReader dc = dao.read(sql);
            string no, stu_id, name, contents, time,pass;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                name = dc[2].ToString();
                contents = dc[3].ToString();
                time = dc[4].ToString();
                pass = dc[5].ToString();

                string[] table = { no, stu_id, name, contents, time, pass };
                dataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ALAdd aLAdd = new ALAdd();
            this.Hide();
            aLAdd.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string stu_id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string contents = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string time = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string pass = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
               


                ALUpdate1 admin = new ALUpdate1(no, stu_id, name, contents,time, pass);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
           
        }

        private void AdminLetter_Load(object sender, EventArgs e)
        {

        }
    }
}
