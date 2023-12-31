﻿using Sunny.UI;
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

namespace Party_MS2.User
{
    public partial class UserCreateLetter : Form
    {
        int amount = 2;
        
        public UserCreateLetter()
        {
            InitializeComponent();
            Create_letter();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            upload_letter();
        }
        private void Create_letter()
        {
            MessageBox.Show("您需要添加函调信，请上传两张函调信图片！");
        }

        private void upload_letter()
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

            int flag = 0;
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
                                    SqlCommand sqlcom = new SqlCommand($"insert into t_letter values('{Data.UID}' + '01000'+ '{i}','" + Data.UID + "', @ImageList, '"+currentTime+"', '待提交', '未审核')", sqlcon);//此处设置一个占位符ImageList，含义将在以下定义
                                    sqlcom.Parameters.Add("ImageList", SqlDbType.Image);
                                    sqlcom.Parameters["ImageList"].Value = imageStream;
                                    if (sqlcom.ExecuteNonQuery() > 0)
                                    {
                                        flag++;
                                    }
                                    j++;
                                }
                        }

                    }
                }
            }
            if(flag == amount)
            {
                MessageBox.Show("图片均已上传成功");
            }
            else
            {
                MessageBox.Show("图片上传失败");
            }

            sqlcon.Close();
        }

        private void UserCreateLetter_Load(object sender, EventArgs e)
        {

        }
    }
}
