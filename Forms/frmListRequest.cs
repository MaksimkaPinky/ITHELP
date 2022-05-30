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
    public partial class frmListRequest : Form
    {
        public List<Quest> REQ = new List<Quest>(DatabaseContext.db.Quest);
        public static List<RequestUserControl> selectedREQUserControls = new List<RequestUserControl>();
        public frmListRequest()
        {
            InitializeComponent();
            GenerateREQUserControlList(REQ);
        }
        private void GenerateREQUserControlList(List<Quest> REQ)
        {
            foreach (var a in REQ)
            {
                RequestUserControl REQUC = new RequestUserControl();
                REQUC.GenerateDataToRequestUserControl(a);
                RequestflowLayoutPanel1.Controls.Add(REQUC);

                REQUC.Click += new System.EventHandler(this.REQUC_Click);
                REQUC.DoubleClick += new System.EventHandler(this.REQUC_DoubleClick);
            }
        }
        private void REQUC_DoubleClick(object sender, EventArgs e)
        {
            RequestUserControl REQUC = sender as RequestUserControl;
            selectedREQUserControls.Add(REQUC);
            Reg_Form RegEditForm = new Reg_Form();
            DialogResult dialogResult = RegEditForm.ShowDialog();
            SortListView();
        }
        private void REQUC_Click(object sender, EventArgs e)
        {
            RequestUserControl REQUC = sender as RequestUserControl;

        }
        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Quest.ToList();
            // Фильтрация
            if (FiltrCB.SelectedIndex > 0)
            {
                listUpdate = listUpdate
                    .Where(type => type.Приоритет.ToString() == FiltrCB.SelectedItem
                    .ToString())
                    .ToList();
            }
            // Поиск
            if (SearchTB.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(SearchTB.Text))
            {
                listUpdate = listUpdate
                    .Where(x => x.ДатаПодачи.ToString().ToLower()
                    .Contains(SearchTB.Text
                    .ToLower()) || x.TypeOfProblem.ToString()
                    .Contains(SearchTB.Text) || x.ОписаниеПроблемы.ToLower()
                    .Contains(SearchTB.Text.ToLower())).ToList();
            }
            RequestflowLayoutPanel1.Controls.Clear();
            GenerateREQUserControlList(listUpdate);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmListRequest_Load(object sender, EventArgs e)
        {
            var allType = DatabaseContext.db.Quest.Select(type => type.Приоритет.ToString()).ToList();
            allType.Insert(0, "Все типы");
            FiltrCB.DataSource = allType;
            FiltrCB.SelectedIndex = 0;
        }

        private void AddUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void adminUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            RequestflowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void FiltrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestflowLayoutPanel1.Controls.Clear();
            SortListView();
        }

        private void AddRequest_Click(object sender, EventArgs e)
        {
            RequestAdd_Form REQADD = new RequestAdd_Form();
            REQADD.Show();
            this.Hide();
        }
    }
}
