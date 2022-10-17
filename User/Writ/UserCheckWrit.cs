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

namespace Party_MS2.User
{
    public partial class UserCheckWrit : Form
    {
        int page = 0;
        int count = 0;
        //create byte[] list
        List<Byte[]> imageByteList = new List<byte[]>();
        string writ_type = null;

        public UserCheckWrit(string writ_id, string type)
        {
            InitializeComponent();
            labelChange(type, page+1);           
            pictureShow(writ_id);
            uiLabel2.Text = (page + 1) + "/" + count;
            writ_type = type;
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

        private void labelChange(string type, int page)
        {
            uiLabel1.Text = Data.UID + "的" + type + "第" + page + "页";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if(page < count-1)
            {
                page++;
                MemoryStream ms = new MemoryStream(imageByteList[page]);
                Bitmap bmap = new Bitmap(ms);
                ms.Close();
                pictureBox1.Image = bmap;
                uiLabel2.Text = (page + 1) + "/" + count;
                labelChange(writ_type, page + 1);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if(page > 0)
            {
                page--;
                MemoryStream ms = new MemoryStream(imageByteList[page]);
                Bitmap bmap = new Bitmap(ms);
                ms.Close();
                pictureBox1.Image = bmap;
                uiLabel2.Text = (page + 1) + "/" + count;
                labelChange(writ_type, page + 1);
            }

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
