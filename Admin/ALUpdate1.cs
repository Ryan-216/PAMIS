using Sunny.UI;
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
    public partial class ALUpdate1 : Form
    {
        int page = 0;
        int count = 0;
        string id;
        //create byte[] list
        List<Byte[]> imageByteList = new List<byte[]>();

        public ALUpdate1()
        {
            InitializeComponent();

            
        }
        public ALUpdate1(string no, string stu_id, string name, string time, string pass)
        {
            InitializeComponent();
            id = textBox1.Text = no;
            textBox2.Text = stu_id;
            textBox3.Text = name;
            textBox5.Text = time;
            textBox6.Text = pass;
            pictureShow(id);
        }

        private void pictureShow(string id)
        {
            Dao dao = new Dao();
            string sql = "select contents from t_letter where no like \'" + id.Substring(0, id.Length - 3) + "___\'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                imageByteList.Add((byte[])dc[0]);
                count++;
            }
            MemoryStream ms = new MemoryStream(imageByteList[page]);
            Bitmap bmap = new Bitmap(ms);
            ms.Close();
            pictureBox1.Image = bmap;
        }


        public void set_Null()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void ALUpdate1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_letter set no = '{textBox1.Text}', stu_id = '{textBox2.Text}', name = '{textBox3.Text}', time = '{textBox5.Text}', pass = '{textBox6.Text}'where no={id}";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                MemoryStream ms = new MemoryStream(imageByteList[page]);
                Bitmap bmap = new Bitmap(ms);
                ms.Close();
                pictureBox1.Image = bmap;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (page < count - 1)
            {
                page++;
                MemoryStream ms = new MemoryStream(imageByteList[page]);
                Bitmap bmap = new Bitmap(ms);
                ms.Close();
                pictureBox1.Image = bmap;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
