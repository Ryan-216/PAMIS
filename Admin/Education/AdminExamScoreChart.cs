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
    public partial class AdminExamScoreChart : Form
    {
        public AdminExamScoreChart(string exam_no)
        {
            InitializeComponent();
            BarChart(exam_no);
        }

        private void BarChart(string exam_no)
        {
            Dao dao = new Dao();
            string sql = "select count(*) from t_stu_exam where exam_no = \'" + exam_no + "\' and exam_score between 90 and 100";
            IDataReader dc = dao.read(sql);
            dc.Read();
            int A_score_count = dc[0].ToString().ToInt();

            sql = "select count(*) from t_stu_exam where exam_no = \'" + exam_no + "\' and exam_score between 80 and 89";
            dc = dao.read(sql);
            dc.Read();
            int B_score_count = dc[0].ToString().ToInt();

            sql = "select count(*) from t_stu_exam where exam_no = \'" + exam_no + "\' and exam_score between 70 and 79";
            dc = dao.read(sql);
            dc.Read();
            int C_score_count = dc[0].ToString().ToInt();

            sql = "select count(*) from t_stu_exam where exam_no = \'" + exam_no + "\' and exam_score between 60 and 69";
            dc = dao.read(sql);
            dc.Read();
            int D_score_count = dc[0].ToString().ToInt();

            sql = "select count(*) from t_stu_exam where exam_no = \'" + exam_no + "\' and exam_score between 0 and 59";
            dc = dao.read(sql);
            dc.Read();
            int E_score_count = dc[0].ToString().ToInt();

            dc.Close();
            dao.DaoClose();

            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "考试成绩分布";
            //option.Title.SubText = "BarChart";

            //设置Legend
            //option.Legend = new UILegend();
            //option.Legend.Orient = UIOrient.Horizontal;
            //option.Legend.Top = UITopAlignment.Top;
            //option.Legend.Left = UILeftAlignment.Left;
            //option.Legend.AddData("Bar1");


            var series = new UIBarSeries();
            //series.Name = "Bar1";
            series.AddData(E_score_count);
            series.AddData(D_score_count);
            series.AddData(C_score_count);
            series.AddData(B_score_count);
            series.AddData(A_score_count);
            option.Series.Add(series);


            option.XAxis.Data.Add("0-59");
            option.XAxis.Data.Add("60-69");
            option.XAxis.Data.Add("70-79");
            option.XAxis.Data.Add("80-89");
            option.XAxis.Data.Add("90-100");

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.Name = "分数";
            option.YAxis.Name = "人数";

            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 60 });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = 0 });

            uiBarChart1.SetOption(option);
            uiBarChart1.ChartStyleType = UIChartStyleType.Plain;
        }
    }
}
