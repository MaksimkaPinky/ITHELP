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
    public partial class EMPUserControl : UserControl
    {
        public EMPUserControl()
        {
            InitializeComponent();
        }
        public void GenerateDataToEMPUserControl(IT_Employees EMP)
        {
            ID_Label.Text = EMP.ID_IT_Employees.ToString();
            FIOlabel.Text = EMP.ФИО;
            PostLabel.Text = EMP.Должность;
        }

            private void EMPUserControl_Load(object sender, EventArgs e)
            {

            }
    }
}
