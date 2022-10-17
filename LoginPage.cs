using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            string picPath = Application.StartupPath + "\\../../img/loginBackground.png";
            this.BackgroundImage = Image.FromFile(picPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            GenerateCode();
            textBox2.Text = "123";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton1.Checked = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string code1="";

        public void Login()
        {
            if (textBox3.Text == code1)
            {

                //user
                if (radioButton1.Checked == true)
                {
                    

                    Dao dao = new Dao();
                    string sql = $"select* from t_pwd where stu_id='{textBox1.Text}' and pwd='{textBox2.Text}'";
                    IDataReader dc = dao.read(sql);
                    if (dc.Read())
                    {
                        Data.UID = dc["stu_id"].ToString();
                        Data.UName = dc["pwd"].ToString();

                        MessageBox.Show("登录成功！");

                        UserIndex2 user = new UserIndex2();
                        this.Hide();
                        user.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
                    }
                    dao.DaoClose();
                }
                //admin
                if (radioButton2.Checked == true)
                {
                    textBox1.Text = "admin";
                    Dao dao = new Dao();
                    string sql = $"select* from t_admin where id='{textBox1.Text}' and pwd='{textBox2.Text}'";
                    IDataReader dc = dao.read(sql);
                    if (dc.Read())
                    {
                        Data.UID = dc["id"].ToString();
                        MessageBox.Show("登录成功！");
                        AdminIndex2 admin = new AdminIndex2();
                        this.Hide();
                        admin.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");
                    }
                    dao.DaoClose();
                }
            }
            else
            {
                MessageBox.Show("验证码错误！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "34191035";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("账号或密码不能为空，请重新输入！");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        //生成验证码
        private void GenerateCode(int codeLen = 6)
        {
            string code = "";
            //生成随机数字
            Random rand = new Random();
            for (int i = 0; i < codeLen; i++)
            {
                code += rand.Next(0, 9).ToString();
            }
            textBox3.Text=code1 = code;                                                 //方便测试
            /*这里将code保存下来做比对验证*/

            //生成验证码图片并显示到pictureBox1
            byte[] bytes = GenerateImg(code);
            MemoryStream ms = new MemoryStream(bytes);
            Image image = System.Drawing.Image.FromStream(ms);
            pictureBox1.Image = image;
        }


        /// <summary>
        /// 生成验证码图片
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public byte[] GenerateImg(string code)
        {
            Bitmap image = new Bitmap(code.Length * 10, 25);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //清空图片背景色
                g.Clear(Color.White);

                //增加背景干扰线
                Random random = new Random();
                for (int i = 0; i < 30; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    //颜色可自定义
                    g.DrawLine(new Pen(Color.FromArgb(186, 212, 231)), x1, y1, x2, y2);
                }

                //定义验证码字体
                Font font = new Font("Arial", 10, (FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout));
                //定义验证码的刷子，这里采用渐变的方式，颜色可自定义
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.FromArgb(67, 93, 230), Color.FromArgb(70, 128, 228), 1.5f, true);

                //增加干扰点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    //颜色可自定义
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //将验证码写入图片
                g.DrawString(code, font, brush, 5, 5);


                //图片边框
                g.DrawRectangle(new Pen(Color.FromArgb(93, 142, 228)), 0, 0, image.Width - 1, image.Height - 1);

                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }

        }

        //给pictureBox1添加一个点击刷新的功能
    

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            GenerateCode();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
