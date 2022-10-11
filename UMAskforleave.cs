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
    public partial class UMAskforleave : Form
    {
        public UMAskforleave()
        {
            InitializeComponent();
        }

        string meeting_no;
        public UMAskforleave(string no)
        {
            InitializeComponent();
            meeting_no = no;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"insert into t_leavereasons values('{meeting_no}','{Data.UID}','{textBox1.Text}','未审核')";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("请假成功！");
            }
            else
            {
                MessageBox.Show("请假失败！");
            }
            dao.DaoClose();
        }

        private void UMAskforleave_Load(object sender, EventArgs e)
        {

        }
    }
}
