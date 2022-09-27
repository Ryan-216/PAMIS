using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WMPLib;

namespace Party_MS2.User
{
    public partial class UserLearning : Form
    {
        public UserLearning()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            #region 
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();//axWindowsMediaPlayer2为第三方控件名
            this.Controls.Add(axWindowsMediaPlayer1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            #endregion
            this.axWindowsMediaPlayer1.URL = @"vid\aaa.mp4";
            Player_Media_end();
            //String filename = @"..\..\vid\aaa.mp4";
            //Process.Start(filename);
        }
        private void Player_MediaError(object sender, _WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        private void Player_Media_end()
        {
            while (true)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    Dao dao = new Dao();
                    String sql = "Update t_eduscore clear='1' where id=" + Data.UID + "and no=" + Data.LearningNO;

                }
            }


        }
    }
}
