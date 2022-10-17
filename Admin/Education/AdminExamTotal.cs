using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Party_MS2.Admin
{
    public partial class AdminExamTotal : Form
    {
        public AdminExamTotal()
        {
            InitializeComponent();
            table();
        }

        private void table()
        {
            uiDataGridView1.Rows.Clear();

            Dao dao = new Dao();
            string sql = "select exam_no, exam_name, exam_type from t_exam";
            IDataReader dc = dao.read(sql);
            string exam_no, exam_name, exam_type;
            while(dc.Read())
            {
                exam_no = dc[0].ToString();
                exam_name = dc[1].ToString();
                exam_type = dc[2].ToString();

                string[] table = { exam_no, exam_name, exam_type };

                uiDataGridView1.AddRow(table);
            }
            dc.Close();
            dao.DaoClose();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string exam_no = uiDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            AdminExamScoreChart adminExamScoreChart = new AdminExamScoreChart(exam_no);
            this.Hide();
            adminExamScoreChart.ShowDialog();
            this.Show();
            table();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
