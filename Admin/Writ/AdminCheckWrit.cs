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

namespace Party_MS2.Admin
{
    public partial class AdminCheckWrit : Form
    {
        int page = 0;
        int count = 0;
        //create byte[] list
        List<Byte[]> imageByteList = new List<byte[]>();
        string writ_type = null;
        string id = null;
        string student_id = null;
        public AdminCheckWrit(string writ_id, string type, string stu_id)
        {
            InitializeComponent();
            labelChange(stu_id, type, page + 1);
            pictureShow(writ_id);
            uiLabel2.Text = (page + 1) + "/" + count;
            writ_type = type;
            id = writ_id;
            student_id = stu_id;
            if(page + 1 != count)
            {
                uiTextBox1.Hide();
                uiButton3.Hide();
            }
        }

        private void labelChange(string stu_id, string type, int page)
        {
            uiLabel1.Text = stu_id + "的" + type + "第" + page + "页";
        }

        private void pictureShow(string writ_id)
        {
            Dao dao = new Dao();
            string sql = "select writ_content from t_writ where writ_id like \'" + writ_id.Substring(0, writ_id.Length - 3) + "___\'";
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

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            System.DateTime currentTime = System.DateTime.Now;
            string sql = "update t_writ set statues = \'" + uiTextBox1.Text + "\', check_time = \'" + currentTime + "\' where writ_id =\'" + id + "\'";
            dao.Execute(sql);
            MessageBox.Show("审核完成");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                MemoryStream ms = new MemoryStream(imageByteList[page]);
                Bitmap bmap = new Bitmap(ms);
                ms.Close();
                pictureBox1.Image = bmap;
                uiLabel2.Text = (page + 1) + "/" + count;
                labelChange(student_id, writ_type, page + 1);
                uiButton3.Hide();
                uiTextBox1.Hide();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (page < count - 1)
            {
                page++;
                MemoryStream ms = new MemoryStream(imageByteList[page]);
                Bitmap bmap = new Bitmap(ms);
                ms.Close();
                pictureBox1.Image = bmap;
                uiLabel2.Text = (page + 1) + "/" + count;
                labelChange(student_id, writ_type, page + 1);
                if (page + 1 == count)
                {
                    uiTextBox1.Show();
                    uiButton3.Show();
                }
            }
        }
    }
}
