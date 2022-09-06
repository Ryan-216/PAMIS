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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string picPath = Application.StartupPath + "\\img/loginBackground.png";
            this.BackgroundImage = Image.FromFile(picPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
