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
            string sql = "select * from t_letter where no like \'%0001\'";
            IDataReader dc = dao.read(sql);
            string no, stu_id, name, time, pass, status;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                name = dc[2].ToString();
                time = dc[4].ToString();
                status = dc[5].ToString();
                pass = dc[6].ToString();

                string[] table = { no, stu_id, name, status, time, pass };
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
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string stu_id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string time = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string pass = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
               


                ALUpdate1 admin = new ALUpdate1(no, stu_id, name,time, pass);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("您确定要删除编号为"+no+"的函调信吗", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if(dialogResult == DialogResult.Yes)
            {
                Dao dao = new Dao();
                string sql = "delete from t_letter where no=" + no;
                try
                {
                    dao.Execute(sql);
                    dao.DaoClose();
                    MessageBox.Show("删除成功！");
                }
                catch
                {
                    MessageBox.Show("Error!");
                    return;
                }
            }
            Table();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
