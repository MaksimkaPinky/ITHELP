
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closebut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_GenderLabel
            // 
            iD_GenderLabel.AutoSize = true;
            iD_GenderLabel.Location = new System.Drawing.Point(30, 138);
            iD_GenderLabel.Name = "iD_GenderLabel";
            iD_GenderLabel.Size = new System.Drawing.Size(53, 25);
            iD_GenderLabel.TabIndex = 22;
            iD_GenderLabel.Text = "Пол:";
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.Location = new System.Drawing.Point(30, 177);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(132, 25);
            iD_OfficeLabel.TabIndex = 24;
            iD_OfficeLabel.Text = "Адрес офиса:";
            // 
            // iD_RoleLabel
            // 
            iD_RoleLabel.AutoSize = true;
            iD_RoleLabel.Location = new System.Drawing.Point(30, 216);
            iD_RoleLabel.Name = "iD_RoleLabel";
            iD_RoleLabel.Size = new System.Drawing.Size(59, 25);
            iD_RoleLabel.TabIndex = 26;
            iD_RoleLabel.Text = "Роль:";
            // 
            // дата_РожденияLabel
            // 
            дата_РожденияLabel.AutoSize = true;
            дата_РожденияLabel.Location = new System.Drawing.Point(30, 255);
            дата_РожденияLabel.Name = "дата_РожденияLabel";
            дата_РожденияLabel.Size = new System.Drawing.Size(153, 25);
            дата_РожденияLabel.TabIndex = 30;
            дата_РожденияLabel.Text = "Дата Рождения:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(30, 293);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(56, 25);
            имяLabel.TabIndex = 32;
            имяLabel.Text = "Имя:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(474, 142);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(71, 25);
            логинLabel.TabIndex = 34;
            логинLabel.Text = "Логин:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(474, 181);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(99, 25);
            отчествоLabel.TabIndex = 36;
            отчествоLabel.Text = "Отчество:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(474, 220);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(84, 25);
            парольLabel.TabIndex = 38;
            парольLabel.Text = "Пароль:";
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(474, 259);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(71, 25);
            почтаLabel.TabIndex = 40;
            почтаLabel.Text = "Почта:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(474, 298);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(99, 25);
            фамилияLabel.TabIndex = 42;
            фамилияLabel.Text = "Фамилия:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(474, 334);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(92, 25);
            телефонLabel.TabIndex = 43;
            телефонLabel.Text = "Телефон:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Closebut);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LAB_Reg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 109);
            this.panel1.TabIndex = 13;
            // 
            // Closebut
            // 
            this.Closebut.FlatAppearance.BorderSize = 0;
            this.Closebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.Closebut.Location = new System.Drawing.Point(863, 0);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(75, 35);
            this.Closebut.TabIndex = 4;
            this.Closebut.Text = "x";
            this.Closebut.UseVisualStyleBackColor = true;
            this.Closebut.Click += new System.EventHandler(this.Closebut_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ITHelpWinFrm.Properties.Resources.incom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.Regbut.FlatAppearance.BorderSize = 0;
            this.Regbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regbut.Location = new System.Drawing.Point(382, 425);
            this.Regbut.Name = "Regbut";
            this.Regbut.Size = new System.Drawing.Size(191, 50);
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
            this.iD_GenderComboBox.FormattingEnabled = true;
            this.iD_GenderComboBox.Location = new System.Drawing.Point(189, 135);
            this.iD_GenderComboBox.Name = "iD_GenderComboBox";
            this.iD_GenderComboBox.Size = new System.Drawing.Size(200, 33);
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
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(189, 174);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(200, 33);
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
            this.iD_RoleComboBox.FormattingEnabled = true;
            this.iD_RoleComboBox.Location = new System.Drawing.Point(189, 213);
            this.iD_RoleComboBox.Name = "iD_RoleComboBox";
            this.iD_RoleComboBox.Size = new System.Drawing.Size(200, 33);
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
            this.дата_РожденияDateTimePicker.Location = new System.Drawing.Point(189, 251);
            this.дата_РожденияDateTimePicker.MinDate = new System.DateTime(1932, 5, 31, 0, 0, 0, 0);
            this.дата_РожденияDateTimePicker.Name = "дата_РожденияDateTimePicker";
            this.дата_РожденияDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.дата_РожденияDateTimePicker.TabIndex = 31;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(189, 290);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 33);
            this.имяTextBox.TabIndex = 33;
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(633, 139);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(200, 33);
            this.логинTextBox.TabIndex = 35;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(633, 178);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 33);
            this.отчествоTextBox.TabIndex = 37;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(633, 217);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(200, 33);
            this.парольTextBox.TabIndex = 39;
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(633, 256);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(200, 33);
            this.почтаTextBox.TabIndex = 41;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(633, 295);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 33);
            this.фамилияTextBox.TabIndex = 43;
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(633, 334);
            this.телефонMaskedTextBox.Mask = "+7 (000) 000 -00 -00  ";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(200, 33);
            this.телефонMaskedTextBox.TabIndex = 44;
            // 
            // Reg_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(938, 610);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}