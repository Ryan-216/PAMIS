using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2.User
{
    public partial class UserSelectWrit : Form
    {
        public UserSelectWrit()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if(uiComboBox1.SelectedIndex == 0)
            {
                upload_apply();
            }
            if(uiComboBox1.SelectedIndex == 1)
            {
                upload_wish();
            }
            if(uiComboBox1.SelectedIndex == 2)
            {
                upload_FullMember();
            }
        }

        private void upload_apply()
        {
            string sql = "select a";        //-----------------
        }

        private void upload_wish()
        {

        }

        private void upload_FullMember()
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
