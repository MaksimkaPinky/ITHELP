
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
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label почтаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_РожденияLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label рольLabel;
            System.Windows.Forms.Label iD_GenderLabel;
            System.Windows.Forms.Label iD_OfficeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.почтаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.Regbut = new System.Windows.Forms.Button();
            this.Closebut = new System.Windows.Forms.Button();
            this.дата_РожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PasstextBox1 = new System.Windows.Forms.TextBox();
            this.рольComboBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_GenderComboBox = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            почтаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_РожденияLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            iD_GenderLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(559, 147);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(71, 25);
            логинLabel.TabIndex = 15;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(546, 198);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(84, 25);
            парольLabel.TabIndex = 16;
            парольLabel.Text = "Пароль:";
            // 
            // почтаLabel
            // 
            почтаLabel.AutoSize = true;
            почтаLabel.Location = new System.Drawing.Point(559, 296);
            почтаLabel.Name = "почтаLabel";
            почтаLabel.Size = new System.Drawing.Size(71, 25);
            почтаLabel.TabIndex = 17;
            почтаLabel.Text = "Почта:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(41, 154);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(61, 25);
            фИОLabel.TabIndex = 18;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_РожденияLabel1
            // 
            дата_РожденияLabel1.AutoSize = true;
            дата_РожденияLabel1.Location = new System.Drawing.Point(477, 353);
            дата_РожденияLabel1.Name = "дата_РожденияLabel1";
            дата_РожденияLabel1.Size = new System.Drawing.Size(153, 25);
            дата_РожденияLabel1.TabIndex = 22;
            дата_РожденияLabel1.Text = "Дата Рождения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(449, 252);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 25);
            label1.TabIndex = 16;
            label1.Text = "Повторите пароль:";
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(43, 301);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(59, 25);
            рольLabel.TabIndex = 23;
            рольLabel.Text = "Роль:";
            // 
            // iD_GenderLabel
            // 
            iD_GenderLabel.AutoSize = true;
            iD_GenderLabel.Location = new System.Drawing.Point(49, 250);
            iD_GenderLabel.Name = "iD_GenderLabel";
            iD_GenderLabel.Size = new System.Drawing.Size(53, 25);
            iD_GenderLabel.TabIndex = 24;
            iD_GenderLabel.Text = "Пол:";
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.Location = new System.Drawing.Point(37, 202);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(65, 25);
            iD_OfficeLabel.TabIndex = 25;
            iD_OfficeLabel.Text = "Офис:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 109);
            this.panel1.TabIndex = 13;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(437, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Регистрация";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITHelpWinFrm.EF.User);
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(636, 144);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(100, 33);
            this.логинTextBox.TabIndex = 16;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(636, 195);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(100, 33);
            this.парольTextBox.TabIndex = 17;
            // 
            // почтаTextBox
            // 
            this.почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Почта", true));
            this.почтаTextBox.Location = new System.Drawing.Point(636, 293);
            this.почтаTextBox.Name = "почтаTextBox";
            this.почтаTextBox.Size = new System.Drawing.Size(100, 33);
            this.почтаTextBox.TabIndex = 18;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(116, 151);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(306, 33);
            this.фИОTextBox.TabIndex = 19;
            // 
            // Regbut
            // 
            this.Regbut.FlatAppearance.BorderSize = 0;
            this.Regbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regbut.Location = new System.Drawing.Point(44, 398);
            this.Regbut.Name = "Regbut";
            this.Regbut.Size = new System.Drawing.Size(191, 50);
            this.Regbut.TabIndex = 22;
            this.Regbut.Text = "Зарегистрировать";
            this.Regbut.UseVisualStyleBackColor = true;
            this.Regbut.Click += new System.EventHandler(this.Regbut_Click);
            // 
            // Closebut
            // 
            this.Closebut.FlatAppearance.BorderSize = 0;
            this.Closebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebut.Location = new System.Drawing.Point(709, 398);
            this.Closebut.Name = "Closebut";
            this.Closebut.Size = new System.Drawing.Size(191, 50);
            this.Closebut.TabIndex = 22;
            this.Closebut.Text = "Закрыть";
            this.Closebut.UseVisualStyleBackColor = true;
            this.Closebut.Click += new System.EventHandler(this.Closebut_Click);
            // 
            // дата_РожденияDateTimePicker
            // 
            this.дата_РожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Дата_Рождения", true));
            this.дата_РожденияDateTimePicker.Location = new System.Drawing.Point(636, 349);
            this.дата_РожденияDateTimePicker.Name = "дата_РожденияDateTimePicker";
            this.дата_РожденияDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.дата_РожденияDateTimePicker.TabIndex = 23;
            // 
            // PasstextBox1
            // 
            this.PasstextBox1.Location = new System.Drawing.Point(636, 249);
            this.PasstextBox1.Name = "PasstextBox1";
            this.PasstextBox1.Size = new System.Drawing.Size(100, 33);
            this.PasstextBox1.TabIndex = 17;
            // 
            // рольComboBox
            // 
            this.рольComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role.Роль", true));
            this.рольComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Role", true));
            this.рольComboBox.DataSource = this.roleBindingSource;
            this.рольComboBox.DisplayMember = "Роль";
            this.рольComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.рольComboBox.FormattingEnabled = true;
            this.рольComboBox.Location = new System.Drawing.Point(114, 298);
            this.рольComboBox.Name = "рольComboBox";
            this.рольComboBox.Size = new System.Drawing.Size(121, 33);
            this.рольComboBox.TabIndex = 24;
            this.рольComboBox.ValueMember = "ID_Role";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Role);
            // 
            // iD_GenderComboBox
            // 
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "ID_Gender", true));
            this.iD_GenderComboBox.DataSource = this.genderBindingSource;
            this.iD_GenderComboBox.DisplayMember = "Наименование";
            this.iD_GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_GenderComboBox.FormattingEnabled = true;
            this.iD_GenderComboBox.Location = new System.Drawing.Point(114, 247);
            this.iD_GenderComboBox.Name = "iD_GenderComboBox";
            this.iD_GenderComboBox.Size = new System.Drawing.Size(121, 33);
            this.iD_GenderComboBox.TabIndex = 25;
            this.iD_GenderComboBox.ValueMember = "ID_Gender";
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
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(114, 198);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(121, 33);
            this.iD_OfficeComboBox.TabIndex = 26;
            this.iD_OfficeComboBox.ValueMember = "ID_Office";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Office);
            // 
            // Reg_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(938, 468);
            this.Controls.Add(iD_OfficeLabel);
            this.Controls.Add(this.iD_OfficeComboBox);
            this.Controls.Add(iD_GenderLabel);
            this.Controls.Add(this.iD_GenderComboBox);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольComboBox);
            this.Controls.Add(дата_РожденияLabel1);
            this.Controls.Add(this.дата_РожденияDateTimePicker);
            this.Controls.Add(this.Closebut);
            this.Controls.Add(this.Regbut);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(почтаLabel);
            this.Controls.Add(this.почтаTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.PasstextBox1);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox почтаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.Button Regbut;
        private System.Windows.Forms.Button Closebut;
        private System.Windows.Forms.DateTimePicker дата_РожденияDateTimePicker;
        private System.Windows.Forms.TextBox PasstextBox1;
        private System.Windows.Forms.ComboBox рольComboBox;
        private System.Windows.Forms.ComboBox iD_GenderComboBox;
        private System.Windows.Forms.ComboBox iD_OfficeComboBox;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
    }
}