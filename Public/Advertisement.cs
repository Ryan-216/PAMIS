using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class Advertisement : Form
    {
        private List<AD> ads = new List<AD>();
        private int count = 0;

        public Advertisement()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random(1);
            if (count < ads.Count)
            {
                count++;
                foreach (AD a in ads)
                {
                    if (a.Id == count)
                    {
                        toolStripStatusLabel1.Text = a.Key;
                        toolStripStatusLabel1.Tag = a.Value;
                    }
                }
            }
            else
            {
                count = 0;
            }
        }

        private void Advertisement_Load(object sender, EventArgs e)
        {
            int id = 0;
            ads.Add(new AD(++id, "CSDN", "http://www.csdn.net"));
            ads.Add(new AD(++id, "百度一下", "http://www.baidu.com"));
            ads.Add(new AD(++id, "网易", "http://www.163.com"));
            ads.Add(new AD(++id, "百名书阁", "http://www.bmebook.com"));

            int val = Convert.ToInt32(ConfigurationManager.AppSettings["Interval"].ToString()) * 1000;

            timer1.Enabled = true;
            timer1.Interval = val;

        }
        class AD
        {
            int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            string key;

            public string Key
            {
                get { return key; }
                set { key = value; }
            }
            string value;

            public string Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            public AD(int id, string key, string value)
            {
                this.id = id;
                this.key = key;
                this.value = value;
            }
        }
    }
}
