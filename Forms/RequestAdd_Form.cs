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
    public partial class RequestAdd_Form : Form
    {
        public RequestAdd_Form()
        {
            InitializeComponent();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.incom.ru"); //Ссылка на сайт агентства
        }

        private void Regbut_Click(object sender, EventArgs e)
        {
            
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
        }

        private void RequestAdd_Form_Load(object sender, EventArgs e)
        {
            statusBindingSource.DataSource = DatabaseContext.db.Status.ToList();
            criticalityBindingSource.DataSource = DatabaseContext.db.Criticality.ToList();
            hardwareBindingSource.DataSource = DatabaseContext.db.Hardware.ToList();
            officeBindingSource.DataSource = DatabaseContext.db.Office.ToList();
            typeOfProblemBindingSource.DataSource = DatabaseContext.db.TypeOfProblem.ToList();

        }
    }
}
