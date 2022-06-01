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
using ITHelpWinFrm.Utils;

namespace ITHelpWinFrm.Forms
{
    public partial class frmListReport : Form
    {
        public List<Report> reports = new List<Report>(DatabaseContext.db.Report);
        public static List<ReportUserControl1> selectedReportUserControl = new List<ReportUserControl1>();
        public frmListReport()
        {
            InitializeComponent();
            GenerateReportUserControlList(reports);
        }
        private void GenerateReportUserControlList(List<Report> reports)
        {
            ReportflowLayoutPanel1.Controls.Clear();
            foreach (var a in reports)
            {
                ReportUserControl1 RUC = new ReportUserControl1();
                RUC.GenerateToDataToReportUserControl(a);
                ReportflowLayoutPanel1.Controls.Add(RUC);

                //AUC.Click += new System.EventHandler(this.AUC_Click);
                RUC.DoubleClick += new System.EventHandler(this.RUC_DoubleClick);
            }
        }

        private void RUC_DoubleClick(object sender, EventArgs e)
        {
            //EddDelUserForm EDDDEL = new EddDelUserForm();
            //EDDDEL.Show();
            //this.Hide();
            //AdminUserControl AUC = sender as AdminUserControl;
            //selectedAdminUserControls.Add(AUC);
            //Reg_Form RegEditForm = new Reg_Form();
            //DialogResult dialogResult = RegEditForm.ShowDialog();
            //SortListView();
        }
        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Report.ToList();
            // Поиск
            if (SearchTB.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(SearchTB.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.IT_Employees.Фамилия.ToLower()
                    .Contains(SearchTB.Text
                    .ToLower()) || x.Описание
                    .Contains(SearchTB.Text) || x.IT_Employees.Имя.ToLower()
                    .Contains(SearchTB.Text.ToLower())).ToList();
            }

            // Фильтрация
            if (FiltrCB.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.IT_Employees.Фамилия == FiltrCB.SelectedItem
                    .ToString())
                    .ToList();
            }
            ReportflowLayoutPanel1.Controls.Clear();
            GenerateReportUserControlList(listUpdate);
        }
        private void AddReport_Click(object sender, EventArgs e)
        {
            ReportAdd_form REPADD = new ReportAdd_form();
            REPADD.Show();
            this.Hide();

        }
    }
}
