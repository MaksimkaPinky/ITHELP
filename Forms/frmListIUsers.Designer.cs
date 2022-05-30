
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
            this.descCB = new System.Windows.Forms.CheckBox();
            this.FiltrCB = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Passlabel = new System.Windows.Forms.Label();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Birthday_label = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.LFPlabel = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
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
            // descCB
            // 
            this.descCB.AutoSize = true;
            this.descCB.Location = new System.Drawing.Point(621, 21);
            this.descCB.Name = "descCB";
            this.descCB.Size = new System.Drawing.Size(15, 14);
            this.descCB.TabIndex = 21;
            this.descCB.UseVisualStyleBackColor = true;
            this.descCB.CheckedChanged += new System.EventHandler(this.descCB_CheckedChanged);
            // 
            // FiltrCB
            // 
            this.FiltrCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roleBindingSource, "Наименование", true));
            this.FiltrCB.DataSource = this.roleBindingSource;
            this.FiltrCB.DisplayMember = "Наименование";
            this.FiltrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrCB.FormattingEnabled = true;
            this.FiltrCB.Location = new System.Drawing.Point(436, 12);
            this.FiltrCB.Name = "FiltrCB";
            this.FiltrCB.Size = new System.Drawing.Size(147, 33);
            this.FiltrCB.TabIndex = 28;
            this.FiltrCB.ValueMember = "ID_Role";
            this.FiltrCB.SelectedIndexChanged += new System.EventHandler(this.SortCB_SelectedIndexChanged_1);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Role);
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Passlabel.ForeColor = System.Drawing.Color.White;
            this.Passlabel.Location = new System.Drawing.Point(743, 70);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(71, 23);
            this.Passlabel.TabIndex = 29;
            this.Passlabel.Text = "Пароль";
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Loginlabel.ForeColor = System.Drawing.Color.White;
            this.Loginlabel.Location = new System.Drawing.Point(637, 70);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(59, 23);
            this.Loginlabel.TabIndex = 30;
            this.Loginlabel.Text = "Логин";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Emaillabel.ForeColor = System.Drawing.Color.White;
            this.Emaillabel.Location = new System.Drawing.Point(509, 70);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(59, 23);
            this.Emaillabel.TabIndex = 31;
            this.Emaillabel.Text = "Почта";
            // 
            // Birthday_label
            // 
            this.Birthday_label.AutoSize = true;
            this.Birthday_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Birthday_label.ForeColor = System.Drawing.Color.White;
            this.Birthday_label.Location = new System.Drawing.Point(326, 70);
            this.Birthday_label.Name = "Birthday_label";
            this.Birthday_label.Size = new System.Drawing.Size(135, 23);
            this.Birthday_label.TabIndex = 32;
            this.Birthday_label.Text = "День Рождения";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelPatronymic.ForeColor = System.Drawing.Color.White;
            this.labelPatronymic.Location = new System.Drawing.Point(206, 70);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(83, 23);
            this.labelPatronymic.TabIndex = 33;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(145, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 23);
            this.labelName.TabIndex = 34;
            this.labelName.Text = "Имя";
            // 
            // LFPlabel
            // 
            this.LFPlabel.AutoSize = true;
            this.LFPlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.LFPlabel.ForeColor = System.Drawing.Color.White;
            this.LFPlabel.Location = new System.Drawing.Point(41, 70);
            this.LFPlabel.Name = "LFPlabel";
            this.LFPlabel.Size = new System.Drawing.Size(84, 23);
            this.LFPlabel.TabIndex = 35;
            this.LFPlabel.Text = "Фамилия";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(8, 70);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(27, 23);
            this.ID_label.TabIndex = 36;
            this.ID_label.Text = "ID";
            // 
            // frmListIUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Birthday_label);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.LFPlabel);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.FiltrCB);
            this.Controls.Add(this.descCB);
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
        private System.Windows.Forms.CheckBox descCB;
        private System.Windows.Forms.ComboBox FiltrCB;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Birthday_label;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label LFPlabel;
        private System.Windows.Forms.Label ID_label;
    }
}