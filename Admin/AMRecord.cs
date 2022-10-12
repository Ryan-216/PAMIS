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
    public partial class AMRecord : Form
    {
        public AMRecord()
        {
            InitializeComponent();
            Table();
        }
        string meeting_no;
        public AMRecord(string no)
        {
            InitializeComponent();
            Table();
            meeting_no = no;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AMRecord_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_meetingrecord1";
            IDataReader dc = dao.read(sql);
            string no,upload,time;
            while (dc.Read())
            {
                no = dc[0].ToString();
                upload = dc[1].ToString();
                time = dc[2].ToString();                
                string[] table = { no,upload,time };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void Upload()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "*.jpg|*.JPG";//设置弹出对话框选择图片
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                using (FileStream filestream = new FileStream(path, FileMode.Open))
                {
                    Byte[] imageByte = new byte[filestream.Length];
                    filestream.Read(imageByte, 0, imageByte.Length);//将图片数据读入比特数组存储
                    //在pictureBox1中显示图片
                    MemoryStream ms = new MemoryStream(imageByte);//创建图片数据流
                    Bitmap bmap = new Bitmap(ms);//获取图片
                    ms.Close();
                    pictureBox1.Image = bmap;
                    //string connectionstring = "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI";
                    string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
                    SqlConnection sqlcon = new SqlConnection(str);
                    sqlcon.Open();
                    SqlCommand sqlcom = new SqlCommand($"insert into t_meetingrecord1 values ('{meeting_no}','已上传',getdate(),@ImageList)", sqlcon);//此处设置一个占位符ImageList，含义将在以下定义
                    sqlcom.Parameters.Add("ImageList", SqlDbType.Image);
                    sqlcom.Parameters["ImageList"].Value = imageByte;
                    uiLabel1.Text = DateTime.Now.ToString();

                    if (sqlcom.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("上传成功");
                    }
                    sqlcon.Close();


                }
            }
        }
        public void Watch()
        {
            
            string meeting_id = basicDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            byte[] imagebytes;
            SqlCommand sqlcom = new SqlCommand($"select record from t_meetingrecord1 where no='{meeting_id}'", sqlcon);//查询到要提取的图片
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.Read())
            {
                imagebytes = (byte[])dr["record"];
                
                MemoryStream ms = new MemoryStream(imagebytes);//创建图片数据流
                Bitmap bmap = new Bitmap(ms);//获取图片
                ms.Close();
                pictureBox1.Image = bmap;
            }
        }
        public void Refresh1()
        {
            pictureBox1.Image=null;
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Upload();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Watch();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Table();
            Refresh1();
        }
    }
}
