
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
            System.Windows.Forms.Label iD_GenderLabel;
            System.Windows.Forms.Label iD_OfficeLabel;
            System.Windows.Forms.Label iD_RoleLabel;
            System.Windows.Forms.Label iD_UserLabel;
            System.Windows.Forms.Label дата_РожденияLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label почтаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label iD_OfficeLabel1;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label название_отделаLabel;
            System.Windows.Forms.Label рольLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EddDelUserForm));
            this.DelUsers = new System.Windows.Forms.Button();
            this.iD_GenderComboBox = new System.Windows.Forms.ComboBox();
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.iD_RoleComboBox = new System.Windows.Forms.ComboBox();
            this.iD_UserComboBox = new System.Windows.Forms.ComboBox();
            this.дата_РожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.iD_OfficeTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.название_отделаTextBox = new System.Windows.Forms.TextBox();
            this.рольComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labForm = new System.Windows.Forms.Label();
            iD_GenderLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel = new System.Windows.Forms.Label();
            iD_RoleLabel = new System.Windows.Forms.Label();
            iD_UserLabel = new System.Windows.Forms.Label();
            дата_РожденияLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            почтаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel1 = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            название_отделаLabel = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DelUsers
            // 
            this.DelUsers.Location = new System.Drawing.Point(279, 393);
            this.DelUsers.Name = "DelUsers";
            this.DelUsers.Size = new System.Drawing.Size(75, 23);
            this.DelUsers.TabIndex = 0;
            this.DelUsers.Text = "button1";
            this.DelUsers.UseVisualStyleBackColor = true;
            this.DelUsers.Click += new System.EventHandler(this.DelUsers_Click);
            // 
            // iD_GenderLabel
            // 
            iD_GenderLabel.AutoSize = true;
            iD_GenderLabel.Location = new System.Drawing.Point(88, 207);
            iD_GenderLabel.Name = "iD_GenderLabel";
            iD_GenderLabel.Size = new System.Drawing.Size(105, 25);
            iD_GenderLabel.TabIndex = 2;
            iD_GenderLabel.Text = "ID Gender:";
            // 
            // iD_GenderComboBox
            // 
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.FormattingEnabled = true;
            this.iD_GenderComboBox.Location = new System.Drawing.Point(184, 204);
            this.iD_GenderComboBox.Name = "iD_GenderComboBox";
            this.iD_GenderComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_GenderComboBox.TabIndex = 3;
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.Location = new System.Drawing.Point(88, 234);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(94, 25);
            iD_OfficeLabel.TabIndex = 4;
            iD_OfficeLabel.Text = "ID Office:";
            // 
            // iD_OfficeComboBox
            // 
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(184, 231);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_OfficeComboBox.TabIndex = 5;
            // 
            // iD_RoleLabel
            // 
            iD_RoleLabel.AutoSize = true;
            iD_RoleLabel.Location = new System.Drawing.Point(88, 261);
            iD_RoleLabel.Name = "iD_RoleLabel";
            iD_RoleLabel.Size = new System.Drawing.Size(79, 25);
            iD_RoleLabel.TabIndex = 6;
            iD_RoleLabel.Text = "ID Role:";
            // 
            // iD_RoleComboBox
            // 
            this.iD_RoleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Role", true));
            this.iD_RoleComboBox.FormattingEnabled = true;
            this.iD_RoleComboBox.Location = new System.Drawing.Point(184, 258);
            this.iD_RoleComboBox.Name = "iD_RoleComboBox";
            this.iD_RoleComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_RoleComboBox.TabIndex = 7;
            // 
            // iD_UserLabel
            // 
            iD_UserLabel.AutoSize = true;
            iD_UserLabel.Location = new System.Drawing.Point(88, 288);
            iD_UserLabel.Name = "iD_UserLabel";
            iD_UserLabel.Size = new System.Drawing.Size(81, 25);
            iD_UserLabel.TabIndex = 8;
            iD_UserLabel.Text = "ID User:";
            // 
            // iD_UserComboBox
            // 
            this.iD_UserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_User", true));
            this.iD_UserComboBox.FormattingEnabled = true;
            this.iD_UserComboBox.Location = new System.Drawing.Point(184, 285);
            this.iD_UserComboBox.Name = "iD_UserComboBox";
            this.iD_UserComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_UserComboBox.TabIndex = 9;
            // 
            // дата_РожденияLabel
            // 
            дата_РожденияLabel.AutoSize = true;
            дата_РожденияLabel.Location = new System.Drawing.Point(421, 223);
            дата_РожденияLabel.Name = "дата_РожденияLabel";
            дата_РожденияLabel.Size = new System.Drawing.Size(153, 25);
            дата_РожденияLabel.TabIndex = 10;
            дата_РожденияLabel.Text = "Дата Рождения:";
            // 
            // дата_РожденияDateTimePicker
            // 
            this.дата_РожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Дата_Рождения", true));
            this.дата_РожденияDateTimePicker.Location = new System.Drawing.Point(517, 219);
            this.дата_РожденияDateTimePicker.Name = "дата_РожденияDateTimePicker";
            this.дата_РожденияDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.дата_РожденияDateTimePicker.TabIndex = 11;
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(421, 248);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(71, 25);
            логинLabel.TabIndex = 12;
            логинLabel.Text = "Логин:";
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(517, 245);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(200, 33);
            this.логинTextBox.TabIndex = 13;
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(421, 274);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(84, 25);
            парольLabel.TabIndex = 14;
            парольLabel.Text = "Пароль:";
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(517, 271);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(200, 33);
            this.парольTextBox.TabIndex = 15;
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(421, 300);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(71, 25);
            почтаLabel.TabIndex = 16;
            почтаLabel.Text = "Почта:";
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(517, 297);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(200, 33);
            this.почтаTextBox.TabIndex = 17;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(421, 326);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(61, 25);
            фИОLabel.TabIndex = 18;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(517, 323);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 33);
            this.фИОTextBox.TabIndex = 19;
            // 
            // iD_OfficeLabel1
            // 
            iD_OfficeLabel1.AutoSize = true;
            iD_OfficeLabel1.Location = new System.Drawing.Point(421, 386);
            iD_OfficeLabel1.Name = "iD_OfficeLabel1";
            iD_OfficeLabel1.Size = new System.Drawing.Size(94, 25);
            iD_OfficeLabel1.TabIndex = 20;
            iD_OfficeLabel1.Text = "ID Office:";
            // 
            // iD_OfficeTextBox
            // 
            this.iD_OfficeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Office.ID_Office", true));
            this.iD_OfficeTextBox.Location = new System.Drawing.Point(525, 383);
            this.iD_OfficeTextBox.Name = "iD_OfficeTextBox";
            this.iD_OfficeTextBox.Size = new System.Drawing.Size(100, 33);
            this.iD_OfficeTextBox.TabIndex = 21;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(421, 412);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(72, 25);
            адресLabel.TabIndex = 22;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Office.Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(525, 409);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 33);
            this.адресTextBox.TabIndex = 23;
            // 
            // название_отделаLabel
            // 
            название_отделаLabel.AutoSize = true;
            название_отделаLabel.Location = new System.Drawing.Point(421, 438);
            название_отделаLabel.Name = "название_отделаLabel";
            название_отделаLabel.Size = new System.Drawing.Size(169, 25);
            название_отделаLabel.TabIndex = 24;
            название_отделаLabel.Text = "Название отдела:";
            // 
            // название_отделаTextBox
            // 
            this.название_отделаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Office.Название_отдела", true));
            this.название_отделаTextBox.Location = new System.Drawing.Point(525, 435);
            this.название_отделаTextBox.Name = "название_отделаTextBox";
            this.название_отделаTextBox.Size = new System.Drawing.Size(100, 33);
            this.название_отделаTextBox.TabIndex = 25;
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(68, 407);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(59, 25);
            рольLabel.TabIndex = 26;
            рольLabel.Text = "Роль:";
            // 
            // рольComboBox
            // 
            this.рольComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role.Роль", true));
            this.рольComboBox.FormattingEnabled = true;
            this.рольComboBox.Location = new System.Drawing.Point(109, 404);
            this.рольComboBox.Name = "рольComboBox";
            this.рольComboBox.Size = new System.Drawing.Size(121, 33);
            this.рольComboBox.TabIndex = 27;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITHelpWinFrm.EF.User);
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
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 28;
            // 
            // CloseBut
            // 
            this.CloseBut.FlatAppearance.BorderSize = 0;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.CloseBut.Location = new System.Drawing.Point(725, 3);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 35);
            this.CloseBut.TabIndex = 3;
            this.CloseBut.Text = "x";
            this.CloseBut.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ITHelpWinFrm.Properties.Resources.incom;
            this.pictureBox2.Location = new System.Drawing.Point(13, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labForm
            // 
            this.labForm.AutoSize = true;
            this.labForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.labForm.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labForm.Location = new System.Drawing.Point(318, 36);
            this.labForm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labForm.Name = "labForm";
            this.labForm.Size = new System.Drawing.Size(179, 25);
            this.labForm.TabIndex = 0;
            this.labForm.Text = "Имя пользователя";
            // 
            // EddDelUserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольComboBox);
            this.Controls.Add(iD_OfficeLabel1);
            this.Controls.Add(this.iD_OfficeTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(название_отделаLabel);
            this.Controls.Add(this.название_отделаTextBox);
            this.Controls.Add(iD_GenderLabel);
            this.Controls.Add(this.iD_GenderComboBox);
            this.Controls.Add(iD_OfficeLabel);
            this.Controls.Add(this.iD_OfficeComboBox);
            this.Controls.Add(iD_RoleLabel);
            this.Controls.Add(this.iD_RoleComboBox);
            this.Controls.Add(iD_UserLabel);
            this.Controls.Add(this.iD_UserComboBox);
            this.Controls.Add(дата_РожденияLabel);
            this.Controls.Add(this.дата_РожденияDateTimePicker);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(почтаLabel);
            this.Controls.Add(this.почтаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.DelUsers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EddDelUserForm";
            this.Text = "EddDelUserForm";
            this.Load += new System.EventHandler(this.EddDelUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ComboBox iD_GenderComboBox;
        private System.Windows.Forms.ComboBox iD_OfficeComboBox;
        private System.Windows.Forms.ComboBox iD_RoleComboBox;
        private System.Windows.Forms.ComboBox iD_UserComboBox;
        private System.Windows.Forms.DateTimePicker дата_РожденияDateTimePicker;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox iD_OfficeTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox название_отделаTextBox;
        private System.Windows.Forms.ComboBox рольComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labForm;
    }
}