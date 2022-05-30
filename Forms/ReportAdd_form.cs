using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITHelpWinFrm.Utils;
using ITHelpWinFrm.EF;

namespace ITHelpWinFrm.Forms
{
    public partial class ReportAdd_form : Form
    {
        Report REP = new Report();   
        public ReportAdd_form()
        {
            InitializeComponent();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            REP.Описание = описаниеTextBox.Text;
            REP.ДатаНаписания = датаНаписанияDateTimePicker.Value;
            REP.ID_Quest = iD_QuestComboBox.SelectedIndex + 1; 
            REP.ID_IT_Employees = iD_IT_EmployeesComboBox.SelectedIndex + 1;

            DatabaseContext.db.Report.Add(REP);
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

        private void ReportAdd_form_Load(object sender, EventArgs e)
        {
            iTEmployeesBindingSource.DataSource = DatabaseContext.db.IT_Employees.ToList();
            questBindingSource.DataSource = DatabaseContext.db.Quest.ToList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
        }
    }
}
