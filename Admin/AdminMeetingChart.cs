using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2.Admin
{
    public partial class AdminMeetingChart : Form
    {
        public AdminMeetingChart(string meeting_no)
        {
            InitializeComponent();
            PieChart(meeting_no);
        }

        private void PieChart(string meeting_no)
        {
            //fetch data
            Dao dao = new Dao();
            string sql = "select COUNT(*) from t_mattend where no=" + meeting_no + " and attend = \'出席\'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            int attend_count = dc[0].ToString().ToInt();

            sql = "select COUNT(*) from t_mattend where no=" + meeting_no + " and attend like \'请假%\'";
            dc = dao.read(sql);
            dc.Read();
            int leave_count = dc[0].ToString().ToInt();

            sql= "select COUNT(*) from t_mattend where no=" + meeting_no + " and attend = \'缺席\'";
            dc = dao.read(sql);
            dc.Read();
            int absent_count = dc[0].ToString().ToInt();

            dc.Close();
            dao.DaoClose();
            
            UIPieOption option = new UIPieOption();
            option.Title = new UITitle();
            option.Title.Text = "会议出勤率";
            option.Title.SubText = meeting_no;
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("出席");
            option.Legend.AddData("请假");
            option.Legend.AddData("缺席");


            //设置Series
            var series = new UIPieSeries();
            series.Name = "Star count";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            //增加数据
            series.AddData("出席", attend_count);
            series.AddData("请假", leave_count);
            series.AddData("缺席", absent_count);


            //增加Series
            option.Series.Add(series);

            //设置Option
            uiPieChart1.SetOption(option);
            uiPieChart1.ChartStyleType = UIChartStyleType.Default;
        }
    }
}
