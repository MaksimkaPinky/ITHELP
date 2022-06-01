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

namespace ITHelpWinFrm
{
    public partial class Aut_Form : Form
    {
        User USER = new User();
        public static Aut_Form AUTHF { get; set; }
        Model1 db = new Model1();
        public Aut_Form()
        {
            InitializeComponent();
            textBoxPassword.Controls.Add(pictureBoxEye);
            pictureBoxEye.BackColor = Color.Transparent;
            pictureBoxEye.Location = new Point(240, -5);
            textBoxPassword.UseSystemPasswordChar = true;


            pictureBoxEye.MouseDown += new MouseEventHandler(pictureBoxEye_MouseDown);
            pictureBoxEye.MouseUp += new MouseEventHandler(pictureBoxEye_MouseUp);
        }
        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;

        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;

        }
        private void Aut_Form_Load(object sender, EventArgs e)
        {

        }

        private void ButExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelLogIn.Text))
               labelLogIn.Text = "Введите значение";
            else
                labelLogIn.Text = "";
            if (string.IsNullOrWhiteSpace(labelPassword.Text))
                labelPassword.Text = "Введите значение";
            else
                labelPassword.Text = "";
            User UsersFind = db.User.Find(textBoxLogin.Text);
            if ((UsersFind != null) && (UsersFind.Пароль == textBoxPassword.Text))
            {
                USER = UsersFind;
                AUTHF = this;
                if (USER.Role.Наименование == "Администратор")
                {
                    Admin_Form FRMAdm = new Admin_Form();
                    FRMAdm.Show();
                    this.Hide();
                }
                else if (USER.Role.Наименование == "Сотрудник ИТ-отдела")
                {
                    IT_Employees_Form ITEMP = new IT_Employees_Form();
                    ITEMP.Show();
                    this.Hide();
                }
                else if (USER.Role.Наименование == "Пользователь")
                {
                    Users_Form USEFRM = new Users_Form();
                    USEFRM.Show();
                    this.Hide();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(labelRole.Text))
                        labelRole.Text = $"Роли {USER.Role.Наименование} в системе нет!";
                    else
                        labelRole.Text = "";
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(labelRole.Text))
                    labelRole.Text = "Логин или пароль введены неверно!";
                else
                    labelRole.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
