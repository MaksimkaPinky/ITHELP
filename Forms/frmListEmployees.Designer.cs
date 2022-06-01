
namespace ITHelpWinFrm.Forms
{
    partial class frmListEmployees
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
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.AddEmp = new System.Windows.Forms.PictureBox();
            this.EMPflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminUserControl2 = new ITHelpWinFrm.AdminUserControl();
            this.FiltrCB = new System.Windows.Forms.ComboBox();
            this.empPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddEmp)).BeginInit();
            this.EMPflowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(4, 12);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(265, 33);
            this.SearchTB.TabIndex = 23;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // AddEmp
            // 
            this.AddEmp.Image = global::ITHelpWinFrm.Properties.Resources.PlusAdd;
            this.AddEmp.Location = new System.Drawing.Point(746, 12);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(56, 27);
            this.AddEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddEmp.TabIndex = 22;
            this.AddEmp.TabStop = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // EMPflowLayoutPanel1
            // 
            this.EMPflowLayoutPanel1.AutoScroll = true;
            this.EMPflowLayoutPanel1.Controls.Add(this.adminUserControl2);
            this.EMPflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EMPflowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.EMPflowLayoutPanel1.Name = "EMPflowLayoutPanel1";
            this.EMPflowLayoutPanel1.Size = new System.Drawing.Size(833, 380);
            this.EMPflowLayoutPanel1.TabIndex = 21;
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
            // FiltrCB
            // 
            this.FiltrCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empPostBindingSource, "ID_Emp_Post", true));
            this.FiltrCB.DataSource = this.empPostBindingSource;
            this.FiltrCB.DisplayMember = "Наименование";
            this.FiltrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrCB.FormattingEnabled = true;
            this.FiltrCB.Location = new System.Drawing.Point(430, 12);
            this.FiltrCB.Name = "FiltrCB";
            this.FiltrCB.Size = new System.Drawing.Size(189, 33);
            this.FiltrCB.TabIndex = 24;
            this.FiltrCB.ValueMember = "ID_Emp_Post";
            this.FiltrCB.SelectedIndexChanged += new System.EventHandler(this.FiltrCB_SelectedIndexChanged);
            // 
            // empPostBindingSource
            // 
            this.empPostBindingSource.DataSource = typeof(ITHelpWinFrm.EF.EmpPost);
            // 
            // iTEmployeesBindingSource
            // 
            this.iTEmployeesBindingSource.DataSource = typeof(ITHelpWinFrm.EF.IT_Employees);
            // 
            // frmListEmployees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.FiltrCB);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.AddEmp);
            this.Controls.Add(this.EMPflowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListEmployees";
            this.Text = "frmListEmployees";
            this.Load += new System.EventHandler(this.frmListEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddEmp)).EndInit();
            this.EMPflowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.PictureBox AddEmp;
        private System.Windows.Forms.FlowLayoutPanel EMPflowLayoutPanel1;
        private AdminUserControl adminUserControl2;
        private System.Windows.Forms.ComboBox FiltrCB;
        private System.Windows.Forms.BindingSource iTEmployeesBindingSource;
        private System.Windows.Forms.BindingSource empPostBindingSource;
    }
}