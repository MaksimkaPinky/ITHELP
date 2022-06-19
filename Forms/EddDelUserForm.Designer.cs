
namespace ITHelpWinFrm.Forms
{
    partial class EddDelUserForm
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
            System.Windows.Forms.Label passretlabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label iD_GenderLabel;
            System.Windows.Forms.Label iD_OfficeLabel;
            System.Windows.Forms.Label iD_RoleLabel;
            System.Windows.Forms.Label дата_РожденияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label почтаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EddDelUserForm));
            this.DelUsers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labForm = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditBut = new System.Windows.Forms.Button();
            this.passwordRetTB = new System.Windows.Forms.TextBox();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.iD_GenderComboBox = new System.Windows.Forms.ComboBox();
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.iD_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.дата_РожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            passretlabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            iD_GenderLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel = new System.Windows.Forms.Label();
            iD_RoleLabel = new System.Windows.Forms.Label();
            дата_РожденияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            почтаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passretlabel
            // 
            passretlabel.AutoSize = true;
            passretlabel.ForeColor = System.Drawing.Color.White;
            passretlabel.Location = new System.Drawing.Point(433, 206);
            passretlabel.Name = "passretlabel";
            passretlabel.Size = new System.Drawing.Size(181, 25);
            passretlabel.TabIndex = 73;
            passretlabel.Text = "Повторите пароль:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.ForeColor = System.Drawing.Color.White;
            телефонLabel.Location = new System.Drawing.Point(7, 239);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(92, 25);
            телефонLabel.TabIndex = 71;
            телефонLabel.Text = "Телефон:";
            // 
            // iD_GenderLabel
            // 
            iD_GenderLabel.AutoSize = true;
            iD_GenderLabel.ForeColor = System.Drawing.Color.White;
            iD_GenderLabel.Location = new System.Drawing.Point(11, 317);
            iD_GenderLabel.Name = "iD_GenderLabel";
            iD_GenderLabel.Size = new System.Drawing.Size(53, 25);
            iD_GenderLabel.TabIndex = 51;
            iD_GenderLabel.Text = "Пол:";
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.ForeColor = System.Drawing.Color.White;
            iD_OfficeLabel.Location = new System.Drawing.Point(478, 245);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(132, 25);
            iD_OfficeLabel.TabIndex = 53;
            iD_OfficeLabel.Text = "Адрес офиса:";
            // 
            // iD_RoleLabel
            // 
            iD_RoleLabel.AutoSize = true;
            iD_RoleLabel.ForeColor = System.Drawing.Color.White;
            iD_RoleLabel.Location = new System.Drawing.Point(551, 284);
            iD_RoleLabel.Name = "iD_RoleLabel";
            iD_RoleLabel.Size = new System.Drawing.Size(59, 25);
            iD_RoleLabel.TabIndex = 55;
            iD_RoleLabel.Text = "Роль:";
            // 
            // дата_РожденияLabel
            // 
            дата_РожденияLabel.AutoSize = true;
            дата_РожденияLabel.ForeColor = System.Drawing.Color.White;
            дата_РожденияLabel.Location = new System.Drawing.Point(457, 323);
            дата_РожденияLabel.Name = "дата_РожденияLabel";
            дата_РожденияLabel.Size = new System.Drawing.Size(153, 25);
            дата_РожденияLabel.TabIndex = 57;
            дата_РожденияLabel.Text = "Дата Рождения:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.ForeColor = System.Drawing.Color.White;
            имяLabel.Location = new System.Drawing.Point(7, 164);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(56, 25);
            имяLabel.TabIndex = 59;
            имяLabel.Text = "Имя:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.ForeColor = System.Drawing.Color.White;
            логинLabel.Location = new System.Drawing.Point(539, 128);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(71, 25);
            логинLabel.TabIndex = 61;
            логинLabel.Text = "Логин:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.ForeColor = System.Drawing.Color.White;
            отчествоLabel.Location = new System.Drawing.Point(7, 203);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(99, 25);
            отчествоLabel.TabIndex = 63;
            отчествоLabel.Text = "Отчество:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.ForeColor = System.Drawing.Color.White;
            парольLabel.Location = new System.Drawing.Point(526, 172);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(84, 25);
            парольLabel.TabIndex = 65;
            парольLabel.Text = "Пароль:";
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.ForeColor = System.Drawing.Color.White;
            почтаLabel.Location = new System.Drawing.Point(7, 281);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(71, 25);
            почтаLabel.TabIndex = 67;
            почтаLabel.Text = "Почта:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.ForeColor = System.Drawing.Color.White;
            фамилияLabel.Location = new System.Drawing.Point(7, 125);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(99, 25);
            фамилияLabel.TabIndex = 69;
            фамилияLabel.Text = "Фамилия:";
            // 
            // DelUsers
            // 
            this.DelUsers.FlatAppearance.BorderSize = 0;
            this.DelUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelUsers.ForeColor = System.Drawing.Color.White;
            this.DelUsers.Location = new System.Drawing.Point(12, 408);
            this.DelUsers.Name = "DelUsers";
            this.DelUsers.Size = new System.Drawing.Size(187, 70);
            this.DelUsers.TabIndex = 0;
            this.DelUsers.Text = "Удалить";
            this.DelUsers.UseVisualStyleBackColor = true;
            this.DelUsers.Click += new System.EventHandler(this.DelUsers_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 88);
            this.panel1.TabIndex = 28;
            // 
            // CloseBut
            // 
            this.CloseBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBut.FlatAppearance.BorderSize = 0;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.CloseBut.Location = new System.Drawing.Point(845, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 88);
            this.CloseBut.TabIndex = 3;
            this.CloseBut.Text = "x";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ITHelpWinFrm.Properties.Resources.incom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labForm
            // 
            this.labForm.AutoSize = true;
            this.labForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.labForm.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labForm.Location = new System.Drawing.Point(409, 32);
            this.labForm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labForm.Name = "labForm";
            this.labForm.Size = new System.Drawing.Size(210, 25);
            this.labForm.TabIndex = 0;
            this.labForm.Text = "Данные пользователя";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITHelpWinFrm.EF.User);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Gender);
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Office);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Role);
            // 
            // EditBut
            // 
            this.EditBut.FlatAppearance.BorderSize = 0;
            this.EditBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBut.ForeColor = System.Drawing.Color.White;
            this.EditBut.Location = new System.Drawing.Point(722, 408);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(187, 70);
            this.EditBut.TabIndex = 50;
            this.EditBut.Text = "Изменить";
            this.EditBut.UseVisualStyleBackColor = true;
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // passwordRetTB
            // 
            this.passwordRetTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.passwordRetTB.Location = new System.Drawing.Point(622, 203);
            this.passwordRetTB.Name = "passwordRetTB";
            this.passwordRetTB.Size = new System.Drawing.Size(286, 33);
            this.passwordRetTB.TabIndex = 74;
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(166, 239);
            this.телефонMaskedTextBox.Mask = "+7 (000) 000 -00 -00  ";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(166, 33);
            this.телефонMaskedTextBox.TabIndex = 72;
            // 
            // iD_GenderComboBox
            // 
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.DataSource = this.genderBindingSource;
            this.iD_GenderComboBox.DisplayMember = "Наименование";
            this.iD_GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_GenderComboBox.FormattingEnabled = true;
            this.iD_GenderComboBox.Location = new System.Drawing.Point(166, 317);
            this.iD_GenderComboBox.Name = "iD_GenderComboBox";
            this.iD_GenderComboBox.Size = new System.Drawing.Size(47, 33);
            this.iD_GenderComboBox.TabIndex = 52;
            this.iD_GenderComboBox.ValueMember = "ID_Gender";
            // 
            // iD_OfficeComboBox
            // 
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataSource = this.officeBindingSource;
            this.iD_OfficeComboBox.DisplayMember = "Адрес";
            this.iD_OfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(622, 242);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(286, 33);
            this.iD_OfficeComboBox.TabIndex = 54;
            this.iD_OfficeComboBox.ValueMember = "ID_Office";
            // 
            // iD_RoleComboBox
            // 
            this.iD_RoleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Role", true));
            this.iD_RoleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Role", true));
            this.iD_RoleComboBox.DataSource = this.roleBindingSource;
            this.iD_RoleComboBox.DisplayMember = "Наименование";
            this.iD_RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_RoleComboBox.FormattingEnabled = true;
            this.iD_RoleComboBox.Location = new System.Drawing.Point(622, 281);
            this.iD_RoleComboBox.Name = "iD_RoleComboBox";
            this.iD_RoleComboBox.Size = new System.Drawing.Size(286, 33);
            this.iD_RoleComboBox.TabIndex = 56;
            this.iD_RoleComboBox.ValueMember = "ID_Role";
            // 
            // дата_РожденияDateTimePicker
            // 
            this.дата_РожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Дата_Рождения", true));
            this.дата_РожденияDateTimePicker.Location = new System.Drawing.Point(622, 320);
            this.дата_РожденияDateTimePicker.MaxDate = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.MinDate = new System.DateTime(1932, 5, 31, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.Name = "дата_РожденияDateTimePicker";
            this.дата_РожденияDateTimePicker.Size = new System.Drawing.Size(268, 33);
            this.дата_РожденияDateTimePicker.TabIndex = 58;
            this.дата_РожденияDateTimePicker.Value = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.ValueChanged += new System.EventHandler(this.дата_РожденияDateTimePicker_ValueChanged);
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(166, 161);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(264, 33);
            this.имяTextBox.TabIndex = 60;
            this.имяTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.имяTextBox_KeyPress);
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(622, 122);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(286, 33);
            this.логинTextBox.TabIndex = 62;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(166, 200);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(264, 33);
            this.отчествоTextBox.TabIndex = 64;
            this.отчествоTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.отчествоTextBox_KeyPress);
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(622, 164);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(286, 33);
            this.парольTextBox.TabIndex = 66;
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(166, 278);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(264, 33);
            this.почтаTextBox.TabIndex = 68;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(166, 122);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(264, 33);
            this.фамилияTextBox.TabIndex = 70;
            this.фамилияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.фамилияTextBox_KeyPress);
            // 
            // EddDelUserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(920, 480);
            this.Controls.Add(passretlabel);
            this.Controls.Add(this.passwordRetTB);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонMaskedTextBox);
            this.Controls.Add(iD_GenderLabel);
            this.Controls.Add(this.iD_GenderComboBox);
            this.Controls.Add(iD_OfficeLabel);
            this.Controls.Add(this.iD_OfficeComboBox);
            this.Controls.Add(iD_RoleLabel);
            this.Controls.Add(this.iD_RoleComboBox);
            this.Controls.Add(дата_РожденияLabel);
            this.Controls.Add(this.дата_РожденияDateTimePicker);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(почтаLabel);
            this.Controls.Add(this.почтаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DelUsers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EddDelUserForm";
            this.Text = "EddDelUserForm";
            this.Load += new System.EventHandler(this.EddDelUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labForm;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.TextBox passwordRetTB;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.ComboBox iD_GenderComboBox;
        private System.Windows.Forms.ComboBox iD_OfficeComboBox;
        private System.Windows.Forms.ComboBox iD_RoleComboBox;
        private System.Windows.Forms.DateTimePicker дата_РожденияDateTimePicker;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
    }
}