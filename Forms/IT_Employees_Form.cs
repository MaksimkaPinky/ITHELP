using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHelpWinFrm.Forms
{
    public partial class IT_Employees_Form : Form
    {
        public IT_Employees_Form()
        {
            InitializeComponent();
        }

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

        }

        private void Exitbut_Click(object sender, EventArgs e)
        {
            Aut_Form AUTFORM = new Aut_Form();
            this.Close();
            AUTFORM.Show();
        }
    }
}
