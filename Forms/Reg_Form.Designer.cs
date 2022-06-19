
namespace ITHelpWinFrm
{
    partial class Reg_Form
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
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label passretlabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebut = new System.Windows.Forms.Button();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.LAB_Reg = new System.Windows.Forms.Label();
            this.Regbut = new System.Windows.Forms.Button();
            this.iD_GenderComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_РожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordRetTB = new System.Windows.Forms.TextBox();
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
            телефонLabel = new System.Windows.Forms.Label();
            passretlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_GenderLabel
            // 
            iD_GenderLabel.AutoSize = true;
            iD_GenderLabel.Location = new System.Drawing.Point(9, 340);
            iD_GenderLabel.Name = "iD_GenderLabel";
            iD_GenderLabel.Size = new System.Drawing.Size(53, 25);
            iD_GenderLabel.TabIndex = 22;
            iD_GenderLabel.Text = "Пол:";
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.Location = new System.Drawing.Point(483, 265);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(132, 25);
            iD_OfficeLabel.TabIndex = 24;
            iD_OfficeLabel.Text = "Адрес офиса:";
            // 
            // iD_RoleLabel
            // 
            iD_RoleLabel.AutoSize = true;
            iD_RoleLabel.Location = new System.Drawing.Point(556, 304);
            iD_RoleLabel.Name = "iD_RoleLabel";
            iD_RoleLabel.Size = new System.Drawing.Size(59, 25);
            iD_RoleLabel.TabIndex = 26;
            iD_RoleLabel.Text = "Роль:";
            // 
            // дата_РожденияLabel
            // 
            дата_РожденияLabel.AutoSize = true;
            дата_РожденияLabel.Location = new System.Drawing.Point(462, 343);
            дата_РожденияLabel.Name = "дата_РожденияLabel";
            дата_РожденияLabel.Size = new System.Drawing.Size(153, 25);
            дата_РожденияLabel.TabIndex = 30;
            дата_РожденияLabel.Text = "Дата Рождения:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(9, 184);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(56, 25);
            имяLabel.TabIndex = 32;
            имяLabel.Text = "Имя:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(544, 148);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(71, 25);
            логинLabel.TabIndex = 34;
            логинLabel.Text = "Логин:";
            логинLabel.Click += new System.EventHandler(this.логинLabel_Click);
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(9, 223);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(99, 25);
            отчествоLabel.TabIndex = 36;
            отчествоLabel.Text = "Отчество:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(531, 192);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(84, 25);
            парольLabel.TabIndex = 38;
            парольLabel.Text = "Пароль:";
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(9, 301);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(71, 25);
            почтаLabel.TabIndex = 40;
            почтаLabel.Text = "Почта:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(9, 145);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(99, 25);
            фамилияLabel.TabIndex = 42;
            фамилияLabel.Text = "Фамилия:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(9, 259);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(92, 25);
            телефонLabel.TabIndex = 43;
            телефонLabel.Text = "Телефон:";
            // 
            // passretlabel
            // 
            passretlabel.AutoSize = true;
            passretlabel.Location = new System.Drawing.Point(438, 226);
            passretlabel.Name = "passretlabel";
            passretlabel.Size = new System.Drawing.Size(181, 25);
            passretlabel.TabIndex = 45;
            passretlabel.Text = "Повторите пароль:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Closebut);
            this.panel1.Controls.Add(this.logoPB);
            this.panel1.Controls.Add(this.LAB_Reg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 109);
            this.panel1.TabIndex = 13;
            // 
            // Closebut
            // 
            this.Closebut.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closebut.FlatAppearance.BorderSize = 0;
            this.Closebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.Closebut.Location = new System.Drawing.Point(881, 0);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(62, 109);
            this.Closebut.TabIndex = 4;
            this.Closebut.Text = "x";
            this.Closebut.UseVisualStyleBackColor = true;
            this.Closebut.Click += new System.EventHandler(this.Closebut_Click_1);
            // 
            // logoPB
            // 
            this.logoPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPB.Image = global::ITHelpWinFrm.Properties.Resources.incom;
            this.logoPB.Location = new System.Drawing.Point(0, 0);
            this.logoPB.Margin = new System.Windows.Forms.Padding(6);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(188, 109);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPB.TabIndex = 2;
            this.logoPB.TabStop = false;
            this.logoPB.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LAB_Reg
            // 
            this.LAB_Reg.AutoSize = true;
            this.LAB_Reg.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.LAB_Reg.ForeColor = System.Drawing.Color.Black;
            this.LAB_Reg.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LAB_Reg.Location = new System.Drawing.Point(437, 32);
            this.LAB_Reg.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.LAB_Reg.Name = "LAB_Reg";
            this.LAB_Reg.Size = new System.Drawing.Size(122, 25);
            this.LAB_Reg.TabIndex = 0;
            this.LAB_Reg.Text = "Регистрация";
            // 
            // Regbut
            // 
            this.Regbut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Regbut.FlatAppearance.BorderSize = 0;
            this.Regbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regbut.Location = new System.Drawing.Point(0, 430);
            this.Regbut.Name = "Regbut";
            this.Regbut.Size = new System.Drawing.Size(943, 50);
            this.Regbut.TabIndex = 22;
            this.Regbut.Text = "Зарегистрировать";
            this.Regbut.UseVisualStyleBackColor = true;
            this.Regbut.Click += new System.EventHandler(this.Regbut_Click);
            // 
            // iD_GenderComboBox
            // 
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.DataSource = this.genderBindingSource;
            this.iD_GenderComboBox.DisplayMember = "Наименование";
            this.iD_GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_GenderComboBox.FormattingEnabled = true;
            this.iD_GenderComboBox.Location = new System.Drawing.Point(168, 337);
            this.iD_GenderComboBox.Name = "iD_GenderComboBox";
            this.iD_GenderComboBox.Size = new System.Drawing.Size(47, 33);
            this.iD_GenderComboBox.TabIndex = 23;
            this.iD_GenderComboBox.ValueMember = "ID_Gender";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITHelpWinFrm.EF.User);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Gender);
            // 
            // iD_OfficeComboBox
            // 
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataSource = this.officeBindingSource;
            this.iD_OfficeComboBox.DisplayMember = "Адрес";
            this.iD_OfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(627, 262);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(304, 33);
            this.iD_OfficeComboBox.TabIndex = 25;
            this.iD_OfficeComboBox.ValueMember = "ID_Office";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Office);
            // 
            // iD_RoleComboBox
            // 
            this.iD_RoleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Role", true));
            this.iD_RoleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Role", true));
            this.iD_RoleComboBox.DataSource = this.roleBindingSource;
            this.iD_RoleComboBox.DisplayMember = "Наименование";
            this.iD_RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_RoleComboBox.FormattingEnabled = true;
            this.iD_RoleComboBox.Location = new System.Drawing.Point(627, 301);
            this.iD_RoleComboBox.Name = "iD_RoleComboBox";
            this.iD_RoleComboBox.Size = new System.Drawing.Size(304, 33);
            this.iD_RoleComboBox.TabIndex = 27;
            this.iD_RoleComboBox.ValueMember = "ID_Role";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Role);
            // 
            // дата_РожденияDateTimePicker
            // 
            this.дата_РожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Дата_Рождения", true));
            this.дата_РожденияDateTimePicker.Location = new System.Drawing.Point(627, 340);
            this.дата_РожденияDateTimePicker.MaxDate = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.MinDate = new System.DateTime(1932, 5, 31, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.Name = "дата_РожденияDateTimePicker";
            this.дата_РожденияDateTimePicker.Size = new System.Drawing.Size(268, 33);
            this.дата_РожденияDateTimePicker.TabIndex = 31;
            this.дата_РожденияDateTimePicker.Value = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.ValueChanged += new System.EventHandler(this.дата_РожденияDateTimePicker_ValueChanged);
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(168, 181);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(264, 33);
            this.имяTextBox.TabIndex = 33;
            this.имяTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.имяTextBox_KeyPress);
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(627, 142);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(304, 33);
            this.логинTextBox.TabIndex = 35;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(168, 220);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(264, 33);
            this.отчествоTextBox.TabIndex = 37;
            this.отчествоTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.отчествоTextBox_KeyPress);
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(627, 184);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(304, 33);
            this.парольTextBox.TabIndex = 39;
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(168, 298);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(264, 33);
            this.почтаTextBox.TabIndex = 41;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(168, 142);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(264, 33);
            this.фамилияTextBox.TabIndex = 43;
            this.фамилияTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.фамилияTextBox_KeyPress);
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(168, 259);
            this.телефонMaskedTextBox.Mask = "+7 (000) 000 -00 -00  ";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(166, 33);
            this.телефонMaskedTextBox.TabIndex = 44;
            // 
            // passwordRetTB
            // 
            this.passwordRetTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.passwordRetTB.Location = new System.Drawing.Point(627, 223);
            this.passwordRetTB.Name = "passwordRetTB";
            this.passwordRetTB.Size = new System.Drawing.Size(304, 33);
            this.passwordRetTB.TabIndex = 46;
            // 
            // Reg_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(943, 480);
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
            this.Controls.Add(this.Regbut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Reg_Form";
            this.Text = "Reg_Form";
            this.Load += new System.EventHandler(this.Reg_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Label LAB_Reg;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button Regbut;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
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
        private System.Windows.Forms.Button Closebut;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.TextBox passwordRetTB;
    }
}