using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITHelpWinFrm.EF;

namespace ITHelpWinFrm
{
    public partial class ReportUserControl1 : UserControl
    {
        public ReportUserControl1()
        {
            InitializeComponent();
        }

        public void GenerateToDataToReportUserControl(Report rep)
        {
            ID_report.Text = rep.ID_Report.ToString();
            IDQuest.Text = rep.ID_Quest.ToString();
            TitleLAb.Text = rep.Описание;
            dateLab.Text = rep.ДатаНаписания.ToString();
            IdItEMpLab.Text = rep.IT_Employees.Фамилия;
            nameemp.Text = rep.IT_Employees.Имя;
            patronimycLab.Text = rep.IT_Employees.Отчество;
        }
        private void ReportUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
