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

namespace ITHelpWinFrm
{
    public partial class Reg_Form : Form
    {
        User USR = new User();
        List<User> userList = DatabaseContext.db.User.ToList();
        public Reg_Form()
        {
            InitializeComponent();
        }

        private void Reg_Form_Load(object sender, EventArgs e)
        {
            genderBindingSource.DataSource = DatabaseContext.db.Gender.ToList();
            officeBindingSource.DataSource = DatabaseContext.db.Office.ToList();
            roleBindingSource.DataSource = DatabaseContext.db.Role.ToList();
        }

        private void Closebut_Click(object sender, EventArgs e)
        {
            Admin_Form FRMAdm = new Admin_Form();
            this.Close();
            FRMAdm.Show();
        }
        //Добавление нового пользователя
        private void Regbut_Click(object sender, EventArgs e)
        {
            //USR.Логин = логинTextBox.Text;
            //USR.Пароль = парольTextBox.Text;
            //USR.Почта = почтаTextBox.Text;
            //USR.Фамилия = фИОTextBox.Text;
            //USR.Дата_Рождения = дата_РожденияDateTimePicker.ToString();
            //USR.ID_Office = Convert.ToInt32(iD_OfficeComboBox.Text);
            //USR.ID_Role = Convert.ToInt32(рольComboBox.Text);
            //USR.ID_Gender = Convert.ToInt32(iD_GenderComboBox.Text);
            DatabaseContext.db.User.Add(USR);
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }
    }
}
