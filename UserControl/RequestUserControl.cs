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
    public partial class RequestUserControl : UserControl
    {
        public RequestUserControl()
        {
            InitializeComponent();
        }
        public void GenerateDataToRequestUserControl(Quest REQ)
        {
            ReqIDlabel.Text = REQ.ID_Quest.ToString();
            Hardware.Text = REQ.Hardware.Наименование;
            Crit.Text = REQ.Criticality.Описание;
            Office.Text = REQ.Office.Адрес;
            TypeProb.Text = REQ.TypeOfProblem.ТипПроблемы;
            Cab.Text = REQ.НомерКабинета;
        }
    }
}
