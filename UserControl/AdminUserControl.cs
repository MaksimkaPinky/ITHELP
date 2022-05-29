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
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }
        public void GenerateDataToAdminUserControl(User user)
        {
            ID_label.Text = user.ID_User.ToString();
            LFPlabel.Text = user.Фамилия;
            labelName.Text = user.Имя;
            labelPatronymic.Text = user.Отчество;
            Birthday_label.Text = user.Дата_Рождения;
            Emaillabel.Text = user.Почта;
            Loginlabel.Text = user.Логин;
            Passlabel.Text = user.Пароль;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
