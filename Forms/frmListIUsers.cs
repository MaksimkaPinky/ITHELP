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
    public partial class frmListIUsers : Form
    {
        public List<User> users = new List<User>(DatabaseContext.db.User);
        public static List<AdminUserControl> selectedAdminUserControls = new List<AdminUserControl>();
        public frmListIUsers()
        {
            InitializeComponent();
            GenerateAdminUserControlList(users);
        }

        private void GenerateAdminUserControlList(List<User> users)
        {
            foreach (var a in users)
            {
                AdminUserControl AUC = new AdminUserControl();
                AUC.GenerateDataToAdminUserControl(a);
                UserflowLayoutPanel1.Controls.Add(AUC);

                //AUC.Click += new System.EventHandler(this.AUC_Click);
                AUC.DoubleClick += new System.EventHandler(this.AUC_DoubleClick);
            }
        }
        private void AUC_DoubleClick(object sender, EventArgs e)
        {
            EddDelUserForm EDDDEL = new EddDelUserForm();
            EDDDEL.Show();
            this.Hide();
            //AdminUserControl AUC = sender as AdminUserControl;
            //selectedAdminUserControls.Add(AUC);
            //Reg_Form RegEditForm = new Reg_Form();
            //DialogResult dialogResult = RegEditForm.ShowDialog();
            //SortListView();
        }
        //private void AUC_Click(object sender, EventArgs e)
        //{
        //    AdminUserControl AUC = sender as AdminUserControl;

        //}
        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.User.ToList();
            // Поиск
            if (SearchTB.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(SearchTB.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.ФИО.ToLower()
                    .Contains(SearchTB.Text
                    .ToLower()) || x.Логин
                    .Contains(SearchTB.Text) || x.Почта.ToLower()
                    .Contains(SearchTB.Text.ToLower())).ToList();
            }

            // Сортировка
            if (SortCB.Text == "ФИО")
            {
                if (!descCB.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.ФИО).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.ФИО).ToList();
                }
            }
            if (SortCB.Text == "Дата рождения")
            {
                if (!descCB.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Дата_Рождения).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Дата_Рождения).ToList();
                }
            }
            UserflowLayoutPanel1.Controls.Clear();
            GenerateAdminUserControlList(listUpdate);
        }


        private void UserflowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            if (SearchTB.Text != "Введите для поиска")
            {
                UserflowLayoutPanel1.Controls.Clear();
                SortListView();
            }
        }

        private void SortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserflowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void descCB_CheckedChanged(object sender, EventArgs e)
        {
            UserflowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void frmListIUsers_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = DatabaseContext.db.User.ToList();
            var allType = DatabaseContext.db.User.Select(type => type.ФИО).ToList();
            allType.Insert(0, "Все типы");
            SortCB.SelectedIndex = 0;
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            AdminUserControl AUC = sender as AdminUserControl;
            selectedAdminUserControls.Add(AUC);

            Reg_Form RegEditForm = new Reg_Form();
            RegEditForm.ShowDialog();
            this.Hide();
            //RegEditForm.USERS = null;
            //DialogResult dialogResult = RegEditForm.ShowDialog();
            //if(dialogResult==DialogResult.OK)
            //{
            //    SortListView();

            //}
        }
    }
}
