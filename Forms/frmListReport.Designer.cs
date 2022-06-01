
namespace ITHelpWinFrm.Forms
{
    partial class frmListReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FiltrCB = new System.Windows.Forms.ComboBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.AddReport = new System.Windows.Forms.PictureBox();
            this.ReportflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminUserControl2 = new ITHelpWinFrm.AdminUserControl();
            this.reportUserControl11 = new ITHelpWinFrm.ReportUserControl1();
            this.iTEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddReport)).BeginInit();
            this.ReportflowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrCB
            // 
            this.FiltrCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reportBindingSource, "ID_IT_Employees", true));
            this.FiltrCB.DataSource = this.iTEmployeesBindingSource;
            this.FiltrCB.DisplayMember = "Фамилия";
            this.FiltrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrCB.FormattingEnabled = true;
            this.FiltrCB.Location = new System.Drawing.Point(430, 12);
            this.FiltrCB.Name = "FiltrCB";
            this.FiltrCB.Size = new System.Drawing.Size(189, 33);
            this.FiltrCB.TabIndex = 28;
            this.FiltrCB.ValueMember = "ID_IT_Employees";
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(4, 12);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(265, 33);
            this.SearchTB.TabIndex = 27;
            // 
            // AddReport
            // 
            this.AddReport.Image = global::ITHelpWinFrm.Properties.Resources.PlusAdd;
            this.AddReport.Location = new System.Drawing.Point(746, 12);
            this.AddReport.Name = "AddReport";
            this.AddReport.Size = new System.Drawing.Size(56, 27);
            this.AddReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddReport.TabIndex = 26;
            this.AddReport.TabStop = false;
            this.AddReport.Click += new System.EventHandler(this.AddReport_Click);
            // 
            // ReportflowLayoutPanel1
            // 
            this.ReportflowLayoutPanel1.AutoScroll = true;
            this.ReportflowLayoutPanel1.Controls.Add(this.adminUserControl2);
            this.ReportflowLayoutPanel1.Controls.Add(this.reportUserControl11);
            this.ReportflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReportflowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.ReportflowLayoutPanel1.Name = "ReportflowLayoutPanel1";
            this.ReportflowLayoutPanel1.Size = new System.Drawing.Size(833, 380);
            this.ReportflowLayoutPanel1.TabIndex = 25;
            // 
            // adminUserControl2
            // 
            this.adminUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.adminUserControl2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.adminUserControl2.Location = new System.Drawing.Point(6, 6);
            this.adminUserControl2.Margin = new System.Windows.Forms.Padding(6);
            this.adminUserControl2.Name = "adminUserControl2";
            this.adminUserControl2.Size = new System.Drawing.Size(8, 8);
            this.adminUserControl2.TabIndex = 1;
            // 
            // reportUserControl11
            // 
            this.reportUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.reportUserControl11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.reportUserControl11.ForeColor = System.Drawing.Color.White;
            this.reportUserControl11.Location = new System.Drawing.Point(3, 23);
            this.reportUserControl11.Name = "reportUserControl11";
            this.reportUserControl11.Size = new System.Drawing.Size(833, 50);
            this.reportUserControl11.TabIndex = 2;
            // 
            // iTEmployeesBindingSource
            // 
            this.iTEmployeesBindingSource.DataSource = typeof(ITHelpWinFrm.EF.IT_Employees);
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Report);
            // 
            // frmListReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.FiltrCB);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.AddReport);
            this.Controls.Add(this.ReportflowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListReport";
            this.Text = "frmListReport";
            ((System.ComponentModel.ISupportInitialize)(this.AddReport)).EndInit();
            this.ReportflowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrCB;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.PictureBox AddReport;
        private System.Windows.Forms.FlowLayoutPanel ReportflowLayoutPanel1;
        private AdminUserControl adminUserControl2;
        private ReportUserControl1 reportUserControl11;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.BindingSource iTEmployeesBindingSource;
    }
}