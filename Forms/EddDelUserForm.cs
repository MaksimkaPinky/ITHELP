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
    }
}
