using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class media : Form
    {
        string learnno;
        public media(string LearnNO)
        {
            InitializeComponent();
            learnno = LearnNO;
            if (vlcControl1.Video != null)
            {
                vlcControl1.Video.IsMouseInputEnabled = false;
                vlcControl1.Video.IsKeyInputEnabled = false;
            }
            videoPlay(LearnNO);
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void videoPlay(string LearnNO)
        {
            vlcControl1.Play(new FileInfo("..\\..\\vid\\"+ LearnNO +"aaa.mp4"));
        }

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            var v = IntPtr.Size == 4 ? "win-x86" : "win-x64";  //自己可以在项目属性 -> 生成 -> 平台目标，选择x86或者x64，注意勾选下面的首选32位
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", v));
            vlcControl1.Dock = DockStyle.Fill;

            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Vlc libraries folder.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void vlcControl1_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
        {
            string sql = "update t_education set clear = '已完成' where stu_id=\'" + Data.UID + "\' and no=\'" + learnno + "\'";
            MessageBox.Show("本课程已完成");
        }

        
    }
}
