using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class UMSignin1 : Form
    {
        public UMSignin1()
        {
            InitializeComponent();
        }

        private void UMSignin1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string strPicPath = @"ImgSign-in";  // 存储路径
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "图片文件|*.bmp;*.jpg;*.jpeg;*.png";
            openPic.FilterIndex = 1;
            //openPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//获取桌面文件夹路径为初始地址                                    
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件，并判断文件大小不能超过20K，fileInfo.Length是以字节为单位的 
                FileInfo fileInfo = new FileInfo(openPic.FileName);
               // if (fileInfo.Length > 20480)
                {
                    //MessageBox.Show("上传的图片不能大于20K");
                }
              // else
                {
                    strPicPath = openPic.FileName;
                    pictureBox1.BackgroundImage = Image.FromFile(strPicPath);  // picReceiptLogo是存储图片的路径
                }
            }
        }
    }
}
