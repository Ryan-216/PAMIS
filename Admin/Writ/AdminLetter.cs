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
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_letter where no like \'%0001\'";
            IDataReader dc = dao.read(sql);
            string no, stu_id,time, pass, status;
            while (dc.Read())
            {
                no = dc[0].ToString();
                stu_id = dc[1].ToString();
                time = dc[3].ToString();
                status = dc[4].ToString();
                pass = dc[5].ToString();

                string[] table = { no, stu_id, status, time, pass };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }

     

       

        private void AdminLetter_Load(object sender, EventArgs e)
        {

        }



     

        private void uiButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string stu_id = basicDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string time = basicDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string pass = basicDataGridView.SelectedRows[0].Cells[4].Value.ToString();

                ALUpdate1 admin = new ALUpdate1(no, stu_id, time, pass);
                admin.ShowDialog();

                Table();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string no = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("您确定要删除编号为" + no + "的函调信吗", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
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

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
