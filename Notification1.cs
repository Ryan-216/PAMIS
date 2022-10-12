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
    public partial class Notification1 : Form
    {
        public Notification1()
        {
            InitializeComponent();
            Table();
        }

        private void Notification1_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            basicDataGridView.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select title from t_notification order by time desc; ";
            IDataReader dc = dao.read(sql);
            string contents;
            while (dc.Read())
            {
                contents = dc[0].ToString();

                string[] table = { contents };
                basicDataGridView.Rows.Add(table);
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
