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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2.User
{
    public partial class UserSelectWrit : Form
    {
        
        public UserSelectWrit()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string getCurrentTimeString()
        {
            System.DateTime currentTime = System.DateTime.Now;
            string dateNO = currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString() + currentTime.Second.ToString();
            return dateNO;
        }

        int amount = 0;

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择要上传的文书类型");
            }
            if (uiComboBox1.SelectedIndex == 0)
            {
                upload_apply();
            }
            if(uiComboBox1.SelectedIndex == 1)
            {
                upload_wish();
            }
            if(uiComboBox1.SelectedIndex == 2)
            {
                upload_FullMember();
            }
        }

        private void upload_apply()
        {
            if(amount == 0)
            {
                MessageBox.Show("请输入要上传的图片张数");
                return;
            }
            //create byte[] list
            List<Byte[]> imageByteList = new List<byte[]>();
            //establish the database connection
            string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            //fetch the current time
            System.DateTime currentTime = System.DateTime.Now;
            //string dateNO = currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString() + currentTime.Second.ToString();
            
            UserAddReports userAddReports = new UserAddReports();

            for (int i = 0; i <= amount - 1; i++)
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

                        //string connectionstring = "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI";
                        MessageBox.Show("图片" + (i + 1) + "选择成功");
                        if (i == amount - 1)
                        {
                            int j = 1;
                            foreach (Byte[] imageStream in imageByteList)
                            {
                                SqlCommand sqlcom = new SqlCommand($"insert into t_writ values ('{Data.UID}', '入党申请书', '{Data.UID + "02" + userAddReports.numberAddZero(j)}','{currentTime}', NULL, '待审批', @ImageList)", sqlcon);//此处设置一个占位符ImageList，含义将在以下定义
                                sqlcom.Parameters.Add("ImageList", SqlDbType.Image);
                                sqlcom.Parameters["ImageList"].Value = imageStream;
                                sqlcom.ExecuteNonQuery();
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

        private void upload_wish()
        {
            if (amount == 0)
            {
                MessageBox.Show("请输入要上传的图片张数");
                return;
            }
            //create byte[] list
            List<Byte[]> imageByteList = new List<byte[]>();
            //establish the database connection
            string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            //fetch the current time
            System.DateTime currentTime = System.DateTime.Now;
            //string dateNO = currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString() + currentTime.Second.ToString();
            UserAddReports userAddReports = new UserAddReports();

            for (int i = 0; i <= amount - 1; i++)
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

                        //string connectionstring = "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI";
                        MessageBox.Show("图片" + (i + 1) + "选择成功");
                        if (i == amount - 1)
                        {
                            int j = 1;
                            foreach (Byte[] imageStream in imageByteList)
                            {
                                SqlCommand sqlcom = new SqlCommand($"insert into t_writ values ('{Data.UID}','入党志愿书', '{Data.UID + "03" + userAddReports.numberAddZero(j)}','{currentTime}', NULL, '待审批', @ImageList)", sqlcon);//此处设置一个占位符ImageList，含义将在以下定义
                                sqlcom.Parameters.Add("ImageList", SqlDbType.Image);
                                sqlcom.Parameters["ImageList"].Value = imageStream;
                                sqlcom.ExecuteNonQuery();
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

        private void upload_FullMember()
        {
            if (amount == 0)
            {
                MessageBox.Show("请输入要上传的图片张数");
                return;
            }
            //create byte[] list
            List<Byte[]> imageByteList = new List<byte[]>();
            //establish the database connection
            string str = @"Data Source=LAPTOP-TESM5QR4; Initial Catalog=PartyDBII; User Id = test; Password = 123456";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            //fetch the current time
            System.DateTime currentTime = System.DateTime.Now;
            //string dateNO = currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString() + currentTime.Second.ToString();
            UserAddReports userAddReports = new UserAddReports();

            for (int i = 0; i <= amount - 1; i++)
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

                        //string connectionstring = "Data Source=(local);Initial Catalog=Test;Integrated Security=SSPI";
                        MessageBox.Show("图片" + (i + 1) + "选择成功");
                        if (i == amount - 1)
                        {
                            int j = 1;
                            foreach (Byte[] imageStream in imageByteList)
                            {
                                SqlCommand sqlcom = new SqlCommand($"insert into t_writ values ('{Data.UID}', '转正申请书', '{Data.UID + "04" + userAddReports.numberAddZero(j)}','{currentTime}', NULL, '待审批', @ImageList)", sqlcon);//此处设置一个占位符ImageList，含义将在以下定义
                                sqlcom.Parameters.Add("ImageList", SqlDbType.Image);
                                sqlcom.Parameters["ImageList"].Value = imageStream;
                                sqlcom.ExecuteNonQuery();
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

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            amount = uiTextBox1.Text.ToInt();
            MessageBox.Show("您选择上传的类型为"+ uiComboBox1.SelectedItem.ToString() +"，图片数为" + amount + "张，请点击上传按钮开始上传。");
        }
    }
}
