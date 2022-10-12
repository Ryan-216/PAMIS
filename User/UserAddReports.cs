using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2.User
{
    public partial class UserAddReports : Form
    {
        int amount = 0;
        public UserAddReports()
        {
            InitializeComponent();
            
        }


        private void uiButton2_Click(object sender, EventArgs e)
        {
            if(amount == 0)
            {
                MessageBox.Show("请先输入上传张数");
                return;
            }
            uploadReport();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            amount = uiTextBox1.Text.ToInt();
            MessageBox.Show("您选择上传3张图片");
            uiLabel2.Text = "请上传3张图片";
        }

        private void uploadReport()
        {
            //create byte[] list
            List<Byte[]> imageByteList = new List<byte[]>();
            //establish the database connection
            string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            //fetch the current time
            System.DateTime currentTime = System.DateTime.Now;
            string dateNO = currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString() + currentTime.Second.ToString();
            for (int i=0; i<= amount-1; i++)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "*.jpg|*.*";//设置弹出对话框选择图片
                //openFileDialog1.ShowDialog();
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    string path = openFileDialog1.FileName;
                    using (FileStream filestream = new FileStream(path, FileMode.Open))
                    {
                        Byte[] imageByte = new byte[filestream.Length];
                        imageByteList.Add(imageByte);                       //add to list
                        filestream.Read(imageByte, 0, imageByte.Length);//将图片数据读入比特数组存储
                        //在pictureBox1中显示图片
                        MemoryStream ms = new MemoryStream(imageByte);//创建图片数据流
                        Bitmap bmap = new Bitmap(ms);//获取图片
                        ms.Close();
                        pictureBox1.Image = bmap;
                        //string connectionstring = "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI";
                        MessageBox.Show("图片"+(i+1)+"选择成功");
                        if (i == amount-1)
                        {
                            int j = 1;
                            foreach (Byte[] imageStream in imageByteList)
                            {
                                SqlCommand sqlcom = new SqlCommand($"insert into t_reports values ('{Data.UID + dateNO}','{Data.UID}','{currentTime}', NULL,'待审批',@ImageList)", sqlcon);//此处设置一个占位符ImageList，含义将在以下定义
                                sqlcom.Parameters.Add("ImageList", SqlDbType.Image);
                                sqlcom.Parameters["ImageList"].Value = imageStream;
                                /*
                                if (sqlcom.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("图片" + j + "上传成功");
                                }
                                */
                                j++;
                            }
                        }

                    }
                }
            }
            MessageBox.Show("图片均已上传成功");
            sqlcon.Close();
        }


        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
