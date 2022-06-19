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

        //Добавление нового пользователя
        private void Regbut_Click(object sender, EventArgs e)
        {
            USR.Логин = логинTextBox.Text;
            USR.Пароль = парольTextBox.Text;
            USR.Почта = почтаTextBox.Text;
            USR.Фамилия = фамилияTextBox.Text;
            USR.Имя = имяTextBox.Text;
            USR.Отчество = отчествоTextBox.Text;
            USR.Дата_Рождения = дата_РожденияDateTimePicker.Text;
            USR.ID_Office =iD_OfficeComboBox.SelectedIndex+1;
            USR.ID_Role = iD_RoleComboBox.SelectedIndex+1;
            USR.ID_Gender = iD_GenderComboBox.SelectedIndex+1;
            USR.Телефон = телефонMaskedTextBox.Text;

            DatabaseContext.db.User.Add(USR);

            try
            {

                DatabaseContext.db.SaveChanges();

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (System.Data.Entity.Validation.DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show(" ");
                        foreach (System.Data.Entity.Validation.DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + " ");
                        }
                }
            }

            this.Close();
        }

        private void Closebut_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
        }

        private void логинLabel_Click(object sender, EventArgs e)
        {

        }

        private void дата_РожденияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime errdate = дата_РожденияDateTimePicker.Value;
            if (errdate.Year > (DateTime.Now.Year - 18))
            {
                MessageBox.Show("Выбрана неверная дата рождения!");
                дата_РожденияDateTimePicker.Controls.Clear();
                return;
            }
        }

        private void фамилияTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void имяTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void отчествоTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }
    }
}
