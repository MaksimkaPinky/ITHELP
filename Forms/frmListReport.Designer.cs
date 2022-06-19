
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
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.AddReport = new System.Windows.Forms.PictureBox();
            this.ReportflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminUserControl2 = new ITHelpWinFrm.AdminUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddReport)).BeginInit();
            this.ReportflowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Report);
            // 
            // iTEmployeesBindingSource
            // 
            this.iTEmployeesBindingSource.DataSource = typeof(ITHelpWinFrm.EF.IT_Employees);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(4, 12);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(265, 33);
            this.SearchTB.TabIndex = 27;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
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
            this.ReportflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReportflowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.ReportflowLayoutPanel1.Name = "ReportflowLayoutPanel1";
            this.ReportflowLayoutPanel1.Size = new System.Drawing.Size(833, 380);
            this.ReportflowLayoutPanel1.TabIndex = 25;
            // 
            // adminUserControl2
            // 
            this.adminUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.adminUserControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminUserControl2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.adminUserControl2.Location = new System.Drawing.Point(6, 6);
            this.adminUserControl2.Margin = new System.Windows.Forms.Padding(6);
            this.adminUserControl2.Name = "adminUserControl2";
            this.adminUserControl2.Size = new System.Drawing.Size(8, 8);
            this.adminUserControl2.TabIndex = 1;
            // 
            // frmListReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.AddReport);
            this.Controls.Add(this.ReportflowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListReport";
            this.Text = "frmListReport";
            this.Load += new System.EventHandler(this.frmListReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddReport)).EndInit();
            this.ReportflowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.PictureBox AddReport;
        private System.Windows.Forms.FlowLayoutPanel ReportflowLayoutPanel1;
        private AdminUserControl adminUserControl2;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.BindingSource iTEmployeesBindingSource;
    }
}