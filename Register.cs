using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Sunny.UI;

namespace Party_MS2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        public void set_Null()
        {
            textBox1.Text = "";
            textBox2.Text = "";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }


        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_pwd values('{textBox1.Text}','{textBox2.Text}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("注册成功！");
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
                set_Null();
            }
            else
            {
                MessageBox.Show("信息不可为空！");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            set_Null();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            var accountSid = "ACca294c5c8bf71e24c8f68c2847addbe2";
            var authToken = "0f0bffca4971544d4af01884a2fabe9e";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("+8617371626432"));
            messageOptions.MessagingServiceSid = "MGc71bb8b0e759683aa6c7d95307cd9051";
            messageOptions.Body = "寄寄寄寄";

            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);

            MessageBox.Show("短信已发送");
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
