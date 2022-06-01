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
using ITHelpWinFrm.Forms;

namespace ITHelpWinFrm.Forms
{
    public partial class Users_Form : Form
    {
        User use= new User();
        public Users_Form()
        {
            InitializeComponent();
            NameUser.Text = $"Добро пожаловать {use.Имя}  {use.Отчество} !";
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            RequestAdd_Form REQADD = new RequestAdd_Form();
            REQADD.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
        }

        private void Exitbut_Click(object sender, EventArgs e)
        {
            Aut_Form AUTFORM = new Aut_Form();
            this.Close();
            AUTFORM.Show();
        }
    }
}
