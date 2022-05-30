using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHelpWinFrm.Forms
{
    public partial class frmListReport : Form
    {
        public frmListReport()
        {
            InitializeComponent();
        }

        private void AddReport_Click(object sender, EventArgs e)
        {
            ReportAdd_form REPADD = new ReportAdd_form();
            REPADD.Show();
            this.Hide();

        }
    }
}
