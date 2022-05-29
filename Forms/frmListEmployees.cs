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
    public partial class frmListEmployees : Form
    {
        public List<IT_Employees> EMP = new List<IT_Employees>(DatabaseContext.db.IT_Employees);
        public static List<EMPUserControl> selectedEMPUserControls = new List<EMPUserControl>();
        public List<EmpPost> empp = new List<EmpPost>(DatabaseContext.db.EmpPost);
        public frmListEmployees()
        {
            InitializeComponent();
            GenerateEMPUserControlList(EMP);
        }
        private void GenerateEMPUserControlList(List<IT_Employees> EMP)
        {
            foreach (var a in EMP )
            {
                EMPUserControl EMPUC = new EMPUserControl();
                EMPUC.GenerateDataToEMPUserControl(a);
                EMPflowLayoutPanel1.Controls.Add(EMPUC);

                EMPUC.Click += new System.EventHandler(this.EMPUC_Click);
                EMPUC.DoubleClick += new System.EventHandler(this.EMPUC_DoubleClick);
            }
        }
        private void EMPUC_DoubleClick(object sender, EventArgs e)
        {
            EMPUserControl EMPUC = sender as EMPUserControl;
            selectedEMPUserControls.Add(EMPUC);
            Reg_Form RegEditForm = new Reg_Form();
            DialogResult dialogResult = RegEditForm.ShowDialog();
            SortListView();
        }
        private void EMPUC_Click(object sender, EventArgs e)
        {
            EMPUserControl EMPUC = sender as EMPUserControl;

        }
        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.IT_Employees.ToList();
            // Фильтрация
            if (FiltrCB.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Фамилия == FiltrCB.SelectedItem
                    .ToString())
                    .ToList();
            }
            // Поиск
            if (SearchTB.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(SearchTB.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.Фамилия.ToLower()
                    .Contains(SearchTB.Text
                    .ToLower()) || x.ID_IT_Employees.ToString()
                    .Contains(SearchTB.Text) || x.Фамилия.ToLower()
                    .Contains(SearchTB.Text.ToLower())).ToList();
            }   
            EMPflowLayoutPanel1.Controls.Clear();
            GenerateEMPUserControlList(listUpdate);
        }

        private void FiltrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EMPflowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            EMPflowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void frmListEmployees_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.IT_Employees.Select(type => type.Фамилия).ToList();
            allType.Insert(0, "Все типы");
            FiltrCB.DataSource = allType;
            FiltrCB.SelectedIndex = 0;
        }
    }
}
