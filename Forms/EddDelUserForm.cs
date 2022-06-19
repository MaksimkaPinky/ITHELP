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
    public partial class EddDelUserForm : Form
    {
        public EddDelUserForm()
        {
            InitializeComponent();
        }
        private void DelUsers_Click(object sender, EventArgs e)
        {
            User usr = (User)userBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить учетную запись" + usr.Логин + "?", "Удаление учетной записи", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DatabaseContext.db.User.Remove(usr);
                try
                {
                    DatabaseContext.db.SaveChanges();
                    MessageBox.Show("Данные о пользователе удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EddDelUserForm_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DatabaseContext.db.User.ToList();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
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
