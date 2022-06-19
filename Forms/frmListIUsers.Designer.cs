
namespace ITHelpWinFrm.Forms
{
    partial class frmListIUsers
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
            this.AddUsers = new System.Windows.Forms.PictureBox();
            this.UserflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminUserControl2 = new ITHelpWinFrm.AdminUserControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.FiltrCB = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddUsers)).BeginInit();
            this.UserflowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUsers
            // 
            this.AddUsers.Image = global::ITHelpWinFrm.Properties.Resources.PlusAdd;
            this.AddUsers.Location = new System.Drawing.Point(746, 12);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(56, 27);
            this.AddUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddUsers.TabIndex = 18;
            this.AddUsers.TabStop = false;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // UserflowLayoutPanel1
            // 
            this.UserflowLayoutPanel1.AutoScroll = true;
            this.UserflowLayoutPanel1.Controls.Add(this.adminUserControl2);
            this.UserflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserflowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.UserflowLayoutPanel1.Name = "UserflowLayoutPanel1";
            this.UserflowLayoutPanel1.Size = new System.Drawing.Size(833, 380);
            this.UserflowLayoutPanel1.TabIndex = 17;
            this.UserflowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.UserflowLayoutPanel1_Paint);
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
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITHelpWinFrm.EF.User);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(4, 12);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(265, 33);
            this.SearchTB.TabIndex = 20;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // FiltrCB
            // 
            this.FiltrCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Role", true));
            this.FiltrCB.DataSource = this.roleBindingSource;
            this.FiltrCB.DisplayMember = "Наименование";
            this.FiltrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrCB.FormattingEnabled = true;
            this.FiltrCB.Location = new System.Drawing.Point(412, 12);
            this.FiltrCB.Name = "FiltrCB";
            this.FiltrCB.Size = new System.Drawing.Size(203, 33);
            this.FiltrCB.TabIndex = 28;
            this.FiltrCB.ValueMember = "ID_Role";
            this.FiltrCB.SelectedIndexChanged += new System.EventHandler(this.SortCB_SelectedIndexChanged_1);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Role);
            // 
            // frmListIUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.FiltrCB);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.UserflowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListIUsers";
            this.Text = "frmListIUsers";
            this.Load += new System.EventHandler(this.frmListIUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddUsers)).EndInit();
            this.UserflowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddUsers;
        private System.Windows.Forms.FlowLayoutPanel UserflowLayoutPanel1;
        private AdminUserControl adminUserControl2;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ComboBox FiltrCB;
        private System.Windows.Forms.BindingSource roleBindingSource;
    }
}