using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class Uservideos : Form
    {
        public Uservideos()
        {
            InitializeComponent();
        }
        string train_no="";
        string location="";
        string video_name = "";
        public Uservideos(string no)
        {
            InitializeComponent();
            train_no = no;
            Table();            
        }

        public void Table()
        {
            uiDataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select video_no, video_name, complete from t_video where train_no='{train_no}'";
            IDataReader dc = dao.read(sql);
            string no, name, complete;
            while (dc.Read())
            {
                no = dc[0].ToString();
                name = dc[1].ToString();               
                complete = dc[2].ToString();               

                string[] table = { no,name,complete };
                uiDataGridView1.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
        public void Get_location()
        {
            string id = uiDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Dao dao = new Dao();
            string sql = $"select location,video_name from t_video where train_no='{train_no}' and video_no='{id}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                location = dc[0].ToString();
                uiLabel1.Text= dc[1].ToString();

            }
            dc.Close();
            dao.DaoClose();
        }
        private void Uservideos_Load(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Get_location();
            media admin = new media(location);
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            this.uiPanel1.Controls.Clear();
            this.uiPanel1.Controls.Add(admin);
            admin.Show();

        }
    }
}
