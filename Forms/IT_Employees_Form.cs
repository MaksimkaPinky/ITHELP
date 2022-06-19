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
    public partial class IT_Employees_Form : Form
    {
        public List<Quest> REQ = new List<Quest>(DatabaseContext.db.Quest);
        public static List<RequestUserControl> selectedREQUserControls = new List<RequestUserControl>();
        public Label itname { get {return LBLNameForm; } }
        public IT_Employees_Form()
        {
            InitializeComponent();
            GenerateREQUserControlList(REQ);
            LBLNameForm.Text = "Список заявок";
            this.PanformLoader.Controls.Clear();
            frmListRequest frmListRequest_VRB = new frmListRequest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();

        }
        private void GenerateREQUserControlList(List<Quest> REQ)
        {
            foreach (var a in REQ)
            {
                RequestUserControl REQUC = new RequestUserControl();
                REQUC.GenerateDataToRequestUserControl(a);
                RequestToEMPLayoutPanel1.Controls.Add(REQUC);
                //REQUC.DoubleClick += new System.EventHandler(this.REQUC_DoubleClick);
            }
        }
        //private void REQUC_DoubleClick(object sender, EventArgs e)
        //{
        //    RequestUserControl REQUC = sender as RequestUserControl;
        //    selectedREQUserControls.Add(REQUC);
        //    Reg_Form RegEditForm = new Reg_Form();
        //    DialogResult dialogResult = RegEditForm.ShowDialog();
        //    SortListView();
        //}


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            ReportAdd_form REPADD = new ReportAdd_form();
            REPADD.ShowDialog();
        }

        private void Exitbut_Click(object sender, EventArgs e)
        {
            Aut_Form AUTFORM = new Aut_Form();
            this.Close();
            AUTFORM.Show();
        }

        private void ListReportbut_Click(object sender, EventArgs e)
        {
            LBLNameForm.Text = "Список отчетов";
            this.PanformLoader.Controls.Clear();
            frmListReport frmListReport_VRB = new frmListReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListReport_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListReport_VRB);
            frmListReport_VRB.Show();
        }

        private void IT_Employees_Form_Load(object sender, EventArgs e)
        {

        }

        private void ListRequestbut_Click(object sender, EventArgs e)
        {
            LBLNameForm.Text = "Список заявок";
            this.PanformLoader.Controls.Clear();
            frmListRequest frmListRequest_VRB = new frmListRequest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();
        }
    }
}
