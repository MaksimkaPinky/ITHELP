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
using System.Runtime.InteropServices;
using ITHelpWinFrm.Forms;

namespace ITHelpWinFrm
{
    public partial class Admin_Form : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );
        public static Admin_Form FRMAdm { get; set; }
        Model1 db = new Model1();
        User use = new User();
        public Admin_Form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //PanNav.Height = ListRequestbut.Height;
            //PanNav.Top = ListRequestbut.Top;
            //PanNav.Left = ListRequestbut.Left;

            //Показ данных формы через панель
            lblTitle.Text = "Список заявок";
            this.PanformLoader.Controls.Clear();
            frmListRequest frmListRequest_VRB = new frmListRequest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();
        }
        public void GenNameLabel(User user)
        {
            UserNamelabel.Text = user.Имя;
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            Reg_Form REGFRM = new Reg_Form();
            FRMAdm = this;
            this.Hide();
            REGFRM.Show();
        }

        private void UserNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void Exitbut_Click(object sender, EventArgs e)
        {
            Aut_Form AUTFORM = new Aut_Form();
            this.Close();
            AUTFORM.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListRequestbut_Click(object sender, EventArgs e)
        {
            //Цвет и вспомогательная полоса для навигации при выбранной форме
            //PanNav.Height = ListRequestbut.Height;
            //PanNav.Top = ListRequestbut.Top;
            //PanNav.Left = ListRequestbut.Left;
            ListEmployeesbut.BackColor = Color.FromArgb(3, 77, 162);
            //Показ данных формы через панель
            lblTitle.Text = "Список заявок";
            this.PanformLoader.Controls.Clear();
            frmListRequest frmListRequest_VRB = new frmListRequest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();
        }

        private void ListEmployeesbut_Click(object sender, EventArgs e)
        {
            //PanNav.Height = ListEmployeesbut.Height;
            //PanNav.Top = ListEmployeesbut.Top;
            ListEmployeesbut.BackColor = Color.FromArgb(3, 77, 162);

            lblTitle.Text = "Список сотрудников";
            this.PanformLoader.Controls.Clear();
            frmListEmployees frmListRequest_VRB = new frmListEmployees() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();
        }

        private void ListReportbut_Click(object sender, EventArgs e)
        {
            //PanNav.Height = ListReportbut.Height;
            //PanNav.Top = ListReportbut.Top;
            ListReportbut.BackColor = Color.FromArgb(3, 77, 162);

            lblTitle.Text = "Список отчетов";
            this.PanformLoader.Controls.Clear();
            frmListReport frmListRequest_VRB = new frmListReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();
        }

        private void butListUsers_Click(object sender, EventArgs e)
        {
            //PanNav.Height = butListUsers.Height;
            //PanNav.Top = butListUsers.Top;
            butListUsers.BackColor = Color.FromArgb(3, 77, 162);

            lblTitle.Text = "Список пользователей";
            this.PanformLoader.Controls.Clear();
            frmListIUsers frmListRequest_VRB = new frmListIUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmListRequest_VRB.FormBorderStyle = FormBorderStyle.None;
            this.PanformLoader.Controls.Add(frmListRequest_VRB);
            frmListRequest_VRB.Show();
        }

        private void butListUsers_Leave(object sender, EventArgs e)
        {
            butListUsers.BackColor = Color.FromArgb(3, 78, 162);
        }

        private void ListReportbut_Leave(object sender, EventArgs e)
        {
            ListReportbut.BackColor = Color.FromArgb(3, 78, 162);

        }

        private void ListEmployeesbut_Leave(object sender, EventArgs e)
        {
            ListEmployeesbut.BackColor = Color.FromArgb(3, 78, 162);
        }

        private void ListRequestbut_Leave(object sender, EventArgs e)
        {
            ListRequestbut.BackColor = Color.FromArgb(3, 78, 162);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства 
        }
    }
}
