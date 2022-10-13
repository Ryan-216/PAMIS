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
    public partial class NNcontents : Form
    {
        public NNcontents()
        {
            InitializeComponent();
        }
        string title, type;
        
        public NNcontents(string title_selected,string type_selected)
        {
            InitializeComponent();
            string title = title_selected;
            string type1 = type_selected;
            load_contents();
        }

        private void load_contents()
        {
            Dao dao = new Dao();
            string sql = "";
            if (type == "notification")
            {
                sql = $"select contents from t_notification where title='{title}'; ";
            }
            else if (type == "news")
            {
                sql = $"select contents from t_news where title='{title}'; ";
            }           
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                uiRichTextBox1.Text = dc[0].ToString();               
            }
            dc.Close();
            dao.DaoClose();
        }
        private void NNcontents_Load(object sender, EventArgs e)
        {

        }
    }
}
