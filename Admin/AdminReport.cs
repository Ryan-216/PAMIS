using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
            Table();
        }
        string report_id;
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select report_id,update_time,status from t_reports";
            IDataReader dc = dao.read(sql);
            string id, time, audit;
            while (dc.Read())
            {
                id = dc[0].ToString();
                time = dc[1].ToString();
                audit = dc[2].ToString();

                string[] table = { id, time, audit };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableSearch()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select report_id,update_time,status from t_reports where stu_id='{uiTextBox1.Text}'";          
            IDataReader dc = dao.read(sql);
            string id, time, audit;
            while (dc.Read())
            {
                id = dc[0].ToString();
                time = dc[1].ToString();
                audit = dc[2].ToString();

                string[] table = { id, time, audit };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void Check()
        {
            report_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            byte[] imagebytes;
            SqlCommand sqlcom = new SqlCommand($"select file_content from t_reports where report_id ='{report_id}'", sqlcon);//查询到要提取的图片
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.Read())
            {
                imagebytes = (byte[])dr["file_content"];

                MemoryStream ms = new MemoryStream(imagebytes);//创建图片数据流
                Bitmap bmap = new Bitmap(ms);//获取图片
                ms.Close();
                pictureBox1.Image = bmap;
            }
        }

        private void AdminReport_Load(object sender, EventArgs e)
        {

        }

      
  

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            TableSearch();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"update t_reports set status='通过' ,check_time=getdate() where report_id='{report_id}'";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("审核成功！");
                Table();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            dao.DaoClose();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"update t_reports set status='拒绝',check_time=getdate() where report_id='{report_id}'";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("审核成功！");
                Table();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            dao.DaoClose();

        }
    }
}
