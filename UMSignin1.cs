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
        string meeting_no;
        public UMSignin1(string no)
        {
            InitializeComponent();
            meeting_no = no;
        }
        public void upload()
        {

            //debug文件夹下建文件夹Photo
            //数据库存入

            //创建文件对话框对象
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择上传的图片";
            ofd.Filter = "图片格式|*.jpg";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获得文件的完整路径
                string filePath = ofd.FileName;
                label2.Text = filePath;

                //int position = filePath.LastIndexOf("\\");
                //string photoName = filePath.Substring(position + 1);

                //获取最后一个点的位置（图片后缀名）
                int position = filePath.LastIndexOf(".");
                string geshi = filePath.Substring(position);

                //重命名该文件
                string photoName = Data.UID + DateTime.Now.ToOADate().ToString() + geshi;

                //上传至指定程序所在的debug文件夹下，并在pictureBox中显示
                //如果存在，则删除
                if (System.IO.File.Exists(Application.StartupPath + "\\Photo\\" + photoName))
                {
                    System.IO.File.Delete(Application.StartupPath + "\\Photo\\" + photoName);
                }
                //System.IO.File.Delete(Application.StartupPath + "\\Photo\\" + photoName)
                System.IO.File.Copy(ofd.FileName, Application.StartupPath + "\\Photo\\" + photoName);
                pictureBox1.ImageLocation = Application.StartupPath + "\\Photo\\" + photoName;

                //数据库存入 该文件名 photoName

                //如果需要调用该图片，则只需要通过数据库中的图片名，和文件夹Photo下的文件名调用即可；
                                                               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            upload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"insert into t_mattend values('{meeting_no}','{Data.UID}','出席')";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("签到成功！");
            }
            else
            {
                MessageBox.Show("签到失败！");
            }
            dao.DaoClose();
        }
    }
}
