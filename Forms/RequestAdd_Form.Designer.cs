
namespace ITHelpWinFrm.Forms
{
    partial class RequestAdd_Form
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
            System.Windows.Forms.Label iD_CriticalityLabel;
            System.Windows.Forms.Label iD_HardwareLabel;
            System.Windows.Forms.Label iD_OfficeLabel;
            System.Windows.Forms.Label iD_TypeOfProblemLabel;
            System.Windows.Forms.Label iD_UserLabel;
            System.Windows.Forms.Label датаЗакрытияLabel;
            System.Windows.Forms.Label датаПодачиLabel;
            System.Windows.Forms.Label датаПринятияLabel;
            System.Windows.Forms.Label номерКабинетаLabel;
            System.Windows.Forms.Label описаниеПроблемыLabel;
            System.Windows.Forms.Label приоритетLabel;
            System.Windows.Forms.Label срочностьВыполненияLabel;
            System.Windows.Forms.Label статусЗаявкиIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestAdd_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LAB_Request = new System.Windows.Forms.Label();
            this.Regbut = new System.Windows.Forms.Button();
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_CriticalityComboBox = new System.Windows.Forms.ComboBox();
            this.iD_HardwareComboBox = new System.Windows.Forms.ComboBox();
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.iD_TypeOfProblemComboBox = new System.Windows.Forms.ComboBox();
            this.iD_UserComboBox = new System.Windows.Forms.ComboBox();
            this.датаЗакрытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаПодачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаПринятияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номерКабинетаTextBox = new System.Windows.Forms.TextBox();
            this.описаниеПроблемыTextBox = new System.Windows.Forms.TextBox();
            this.приоритетComboBox = new System.Windows.Forms.ComboBox();
            this.срочностьВыполненияTextBox = new System.Windows.Forms.TextBox();
            this.статусЗаявкиIDComboBox = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criticalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeOfProblemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iD_CriticalityLabel = new System.Windows.Forms.Label();
            iD_HardwareLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel = new System.Windows.Forms.Label();
            iD_TypeOfProblemLabel = new System.Windows.Forms.Label();
            iD_UserLabel = new System.Windows.Forms.Label();
            датаЗакрытияLabel = new System.Windows.Forms.Label();
            датаПодачиLabel = new System.Windows.Forms.Label();
            датаПринятияLabel = new System.Windows.Forms.Label();
            номерКабинетаLabel = new System.Windows.Forms.Label();
            описаниеПроблемыLabel = new System.Windows.Forms.Label();
            приоритетLabel = new System.Windows.Forms.Label();
            срочностьВыполненияLabel = new System.Windows.Forms.Label();
            статусЗаявкиIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfProblemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LAB_Request);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 109);
            this.panel1.TabIndex = 14;
            // 
            // CloseBut
            // 
            this.CloseBut.FlatAppearance.BorderSize = 0;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.CloseBut.Location = new System.Drawing.Point(587, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 35);
            this.CloseBut.TabIndex = 4;
            this.CloseBut.Text = "x";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
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
            // LAB_Request
            // 
            this.LAB_Request.AutoSize = true;
            this.LAB_Request.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.LAB_Request.ForeColor = System.Drawing.Color.Black;
            this.LAB_Request.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LAB_Request.Location = new System.Drawing.Point(316, 33);
            this.LAB_Request.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.LAB_Request.Name = "LAB_Request";
            this.LAB_Request.Size = new System.Drawing.Size(73, 25);
            this.LAB_Request.TabIndex = 0;
            this.LAB_Request.Text = "Заявка";
            // 
            // Regbut
            // 
            this.Regbut.FlatAppearance.BorderSize = 0;
            this.Regbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regbut.ForeColor = System.Drawing.Color.White;
            this.Regbut.Location = new System.Drawing.Point(198, 693);
            this.Regbut.Name = "Regbut";
            this.Regbut.Size = new System.Drawing.Size(191, 50);
            this.Regbut.TabIndex = 24;
            this.Regbut.Text = "Отправить";
            this.Regbut.UseVisualStyleBackColor = true;
            this.Regbut.Click += new System.EventHandler(this.Regbut_Click);
            // 
            // questBindingSource
            // 
            this.questBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Quest);
            // 
            // iD_CriticalityLabel
            // 
            iD_CriticalityLabel.AutoSize = true;
            iD_CriticalityLabel.Location = new System.Drawing.Point(109, 124);
            iD_CriticalityLabel.Name = "iD_CriticalityLabel";
            iD_CriticalityLabel.Size = new System.Drawing.Size(130, 25);
            iD_CriticalityLabel.TabIndex = 24;
            iD_CriticalityLabel.Text = "Критичность:";
            // 
            // iD_CriticalityComboBox
            // 
            this.iD_CriticalityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_Criticality", true));
            this.iD_CriticalityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_Criticality", true));
            this.iD_CriticalityComboBox.DataSource = this.criticalityBindingSource;
            this.iD_CriticalityComboBox.DisplayMember = "Описание";
            this.iD_CriticalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_CriticalityComboBox.FormattingEnabled = true;
            this.iD_CriticalityComboBox.Location = new System.Drawing.Point(342, 121);
            this.iD_CriticalityComboBox.Name = "iD_CriticalityComboBox";
            this.iD_CriticalityComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_CriticalityComboBox.TabIndex = 25;
            this.iD_CriticalityComboBox.ValueMember = "ID_Criticality";
            // 
            // iD_HardwareLabel
            // 
            iD_HardwareLabel.AutoSize = true;
            iD_HardwareLabel.Location = new System.Drawing.Point(109, 163);
            iD_HardwareLabel.Name = "iD_HardwareLabel";
            iD_HardwareLabel.Size = new System.Drawing.Size(148, 25);
            iD_HardwareLabel.TabIndex = 26;
            iD_HardwareLabel.Text = "Оборудование:";
            // 
            // iD_HardwareComboBox
            // 
            this.iD_HardwareComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_Hardware", true));
            this.iD_HardwareComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_Hardware", true));
            this.iD_HardwareComboBox.DataSource = this.hardwareBindingSource;
            this.iD_HardwareComboBox.DisplayMember = "Наименование";
            this.iD_HardwareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_HardwareComboBox.FormattingEnabled = true;
            this.iD_HardwareComboBox.Location = new System.Drawing.Point(342, 160);
            this.iD_HardwareComboBox.Name = "iD_HardwareComboBox";
            this.iD_HardwareComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_HardwareComboBox.TabIndex = 27;
            this.iD_HardwareComboBox.ValueMember = "ID_Hardware";
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.Location = new System.Drawing.Point(109, 202);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(132, 25);
            iD_OfficeLabel.TabIndex = 28;
            iD_OfficeLabel.Text = "Адрес офиса:";
            // 
            // iD_OfficeComboBox
            // 
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataSource = this.officeBindingSource;
            this.iD_OfficeComboBox.DisplayMember = "Адрес";
            this.iD_OfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(342, 199);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_OfficeComboBox.TabIndex = 29;
            this.iD_OfficeComboBox.ValueMember = "ID_Office";
            // 
            // iD_TypeOfProblemLabel
            // 
            iD_TypeOfProblemLabel.AutoSize = true;
            iD_TypeOfProblemLabel.Location = new System.Drawing.Point(109, 241);
            iD_TypeOfProblemLabel.Name = "iD_TypeOfProblemLabel";
            iD_TypeOfProblemLabel.Size = new System.Drawing.Size(146, 25);
            iD_TypeOfProblemLabel.TabIndex = 32;
            iD_TypeOfProblemLabel.Text = "Тип проблемы:";
            // 
            // iD_TypeOfProblemComboBox
            // 
            this.iD_TypeOfProblemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_TypeOfProblem", true));
            this.iD_TypeOfProblemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_TypeOfProblem", true));
            this.iD_TypeOfProblemComboBox.DataSource = this.typeOfProblemBindingSource;
            this.iD_TypeOfProblemComboBox.DisplayMember = "ТипПроблемы";
            this.iD_TypeOfProblemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_TypeOfProblemComboBox.FormattingEnabled = true;
            this.iD_TypeOfProblemComboBox.Location = new System.Drawing.Point(342, 238);
            this.iD_TypeOfProblemComboBox.Name = "iD_TypeOfProblemComboBox";
            this.iD_TypeOfProblemComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_TypeOfProblemComboBox.TabIndex = 33;
            this.iD_TypeOfProblemComboBox.ValueMember = "ID_TypeOfProblem";
            // 
            // iD_UserLabel
            // 
            iD_UserLabel.AutoSize = true;
            iD_UserLabel.Location = new System.Drawing.Point(109, 280);
            iD_UserLabel.Name = "iD_UserLabel";
            iD_UserLabel.Size = new System.Drawing.Size(81, 25);
            iD_UserLabel.TabIndex = 34;
            iD_UserLabel.Text = "ID User:";
            // 
            // iD_UserComboBox
            // 
            this.iD_UserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_User", true));
            this.iD_UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_UserComboBox.FormattingEnabled = true;
            this.iD_UserComboBox.Location = new System.Drawing.Point(342, 277);
            this.iD_UserComboBox.Name = "iD_UserComboBox";
            this.iD_UserComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_UserComboBox.TabIndex = 35;
            // 
            // датаЗакрытияLabel
            // 
            датаЗакрытияLabel.AutoSize = true;
            датаЗакрытияLabel.Location = new System.Drawing.Point(109, 320);
            датаЗакрытияLabel.Name = "датаЗакрытияLabel";
            датаЗакрытияLabel.Size = new System.Drawing.Size(148, 25);
            датаЗакрытияLabel.TabIndex = 36;
            датаЗакрытияLabel.Text = "Дата Закрытия:";
            // 
            // датаЗакрытияDateTimePicker
            // 
            this.датаЗакрытияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questBindingSource, "ДатаЗакрытия", true));
            this.датаЗакрытияDateTimePicker.Location = new System.Drawing.Point(342, 316);
            this.датаЗакрытияDateTimePicker.Name = "датаЗакрытияDateTimePicker";
            this.датаЗакрытияDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.датаЗакрытияDateTimePicker.TabIndex = 37;
            // 
            // датаПодачиLabel
            // 
            датаПодачиLabel.AutoSize = true;
            датаПодачиLabel.Location = new System.Drawing.Point(109, 359);
            датаПодачиLabel.Name = "датаПодачиLabel";
            датаПодачиLabel.Size = new System.Drawing.Size(132, 25);
            датаПодачиLabel.TabIndex = 38;
            датаПодачиLabel.Text = "Дата Подачи:";
            // 
            // датаПодачиDateTimePicker
            // 
            this.датаПодачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questBindingSource, "ДатаПодачи", true));
            this.датаПодачиDateTimePicker.Location = new System.Drawing.Point(342, 355);
            this.датаПодачиDateTimePicker.Name = "датаПодачиDateTimePicker";
            this.датаПодачиDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.датаПодачиDateTimePicker.TabIndex = 39;
            // 
            // датаПринятияLabel
            // 
            датаПринятияLabel.AutoSize = true;
            датаПринятияLabel.Location = new System.Drawing.Point(109, 398);
            датаПринятияLabel.Name = "датаПринятияLabel";
            датаПринятияLabel.Size = new System.Drawing.Size(150, 25);
            датаПринятияLabel.TabIndex = 40;
            датаПринятияLabel.Text = "Дата Принятия:";
            // 
            // датаПринятияDateTimePicker
            // 
            this.датаПринятияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questBindingSource, "ДатаПринятия", true));
            this.датаПринятияDateTimePicker.Location = new System.Drawing.Point(342, 394);
            this.датаПринятияDateTimePicker.Name = "датаПринятияDateTimePicker";
            this.датаПринятияDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.датаПринятияDateTimePicker.TabIndex = 41;
            // 
            // номерКабинетаLabel
            // 
            номерКабинетаLabel.AutoSize = true;
            номерКабинетаLabel.Location = new System.Drawing.Point(109, 436);
            номерКабинетаLabel.Name = "номерКабинетаLabel";
            номерКабинетаLabel.Size = new System.Drawing.Size(165, 25);
            номерКабинетаLabel.TabIndex = 42;
            номерКабинетаLabel.Text = "Номер Кабинета:";
            // 
            // номерКабинетаTextBox
            // 
            this.номерКабинетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "НомерКабинета", true));
            this.номерКабинетаTextBox.Location = new System.Drawing.Point(342, 433);
            this.номерКабинетаTextBox.Name = "номерКабинетаTextBox";
            this.номерКабинетаTextBox.Size = new System.Drawing.Size(200, 33);
            this.номерКабинетаTextBox.TabIndex = 43;
            // 
            // описаниеПроблемыLabel
            // 
            описаниеПроблемыLabel.AutoSize = true;
            описаниеПроблемыLabel.Location = new System.Drawing.Point(109, 475);
            описаниеПроблемыLabel.Name = "описаниеПроблемыLabel";
            описаниеПроблемыLabel.Size = new System.Drawing.Size(202, 25);
            описаниеПроблемыLabel.TabIndex = 44;
            описаниеПроблемыLabel.Text = "Описание проблемы:";
            // 
            // описаниеПроблемыTextBox
            // 
            this.описаниеПроблемыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ОписаниеПроблемы", true));
            this.описаниеПроблемыTextBox.Location = new System.Drawing.Point(342, 472);
            this.описаниеПроблемыTextBox.Name = "описаниеПроблемыTextBox";
            this.описаниеПроблемыTextBox.Size = new System.Drawing.Size(200, 33);
            this.описаниеПроблемыTextBox.TabIndex = 45;
            // 
            // приоритетLabel
            // 
            приоритетLabel.AutoSize = true;
            приоритетLabel.Location = new System.Drawing.Point(109, 514);
            приоритетLabel.Name = "приоритетLabel";
            приоритетLabel.Size = new System.Drawing.Size(112, 25);
            приоритетLabel.TabIndex = 46;
            приоритетLabel.Text = "Приоритет:";
            // 
            // приоритетComboBox
            // 
            this.приоритетComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "Приоритет", true));
            this.приоритетComboBox.FormattingEnabled = true;
            this.приоритетComboBox.Location = new System.Drawing.Point(342, 511);
            this.приоритетComboBox.Name = "приоритетComboBox";
            this.приоритетComboBox.Size = new System.Drawing.Size(200, 33);
            this.приоритетComboBox.TabIndex = 47;
            // 
            // срочностьВыполненияLabel
            // 
            срочностьВыполненияLabel.AutoSize = true;
            срочностьВыполненияLabel.Location = new System.Drawing.Point(109, 553);
            срочностьВыполненияLabel.Name = "срочностьВыполненияLabel";
            срочностьВыполненияLabel.Size = new System.Drawing.Size(227, 25);
            срочностьВыполненияLabel.TabIndex = 48;
            срочностьВыполненияLabel.Text = "Срочность выполнения:";
            // 
            // срочностьВыполненияTextBox
            // 
            this.срочностьВыполненияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "СрочностьВыполнения", true));
            this.срочностьВыполненияTextBox.Location = new System.Drawing.Point(342, 550);
            this.срочностьВыполненияTextBox.Name = "срочностьВыполненияTextBox";
            this.срочностьВыполненияTextBox.Size = new System.Drawing.Size(200, 33);
            this.срочностьВыполненияTextBox.TabIndex = 49;
            // 
            // статусЗаявкиIDLabel
            // 
            статусЗаявкиIDLabel.AutoSize = true;
            статусЗаявкиIDLabel.Location = new System.Drawing.Point(109, 592);
            статусЗаявкиIDLabel.Name = "статусЗаявкиIDLabel";
            статусЗаявкиIDLabel.Size = new System.Drawing.Size(140, 25);
            статусЗаявкиIDLabel.TabIndex = 50;
            статусЗаявкиIDLabel.Text = "Статус заявки:";
            // 
            // статусЗаявкиIDComboBox
            // 
            this.статусЗаявкиIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "СтатусЗаявкиID", true));
            this.статусЗаявкиIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "СтатусЗаявкиID", true));
            this.статусЗаявкиIDComboBox.DataSource = this.statusBindingSource;
            this.статусЗаявкиIDComboBox.DisplayMember = "Наименование";
            this.статусЗаявкиIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.статусЗаявкиIDComboBox.FormattingEnabled = true;
            this.статусЗаявкиIDComboBox.Location = new System.Drawing.Point(342, 589);
            this.статусЗаявкиIDComboBox.Name = "статусЗаявкиIDComboBox";
            this.статусЗаявкиIDComboBox.Size = new System.Drawing.Size(200, 33);
            this.статусЗаявкиIDComboBox.TabIndex = 51;
            this.статусЗаявкиIDComboBox.ValueMember = "ID_Status";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Status);
            // 
            // criticalityBindingSource
            // 
            this.criticalityBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Criticality);
            // 
            // hardwareBindingSource
            // 
            this.hardwareBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Hardware);
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Office);
            // 
            // typeOfProblemBindingSource
            // 
            this.typeOfProblemBindingSource.DataSource = typeof(ITHelpWinFrm.EF.TypeOfProblem);
            // 
            // RequestAdd_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(662, 822);
            this.Controls.Add(iD_CriticalityLabel);
            this.Controls.Add(this.iD_CriticalityComboBox);
            this.Controls.Add(iD_HardwareLabel);
            this.Controls.Add(this.iD_HardwareComboBox);
            this.Controls.Add(iD_OfficeLabel);
            this.Controls.Add(this.iD_OfficeComboBox);
            this.Controls.Add(iD_TypeOfProblemLabel);
            this.Controls.Add(this.iD_TypeOfProblemComboBox);
            this.Controls.Add(iD_UserLabel);
            this.Controls.Add(this.iD_UserComboBox);
            this.Controls.Add(датаЗакрытияLabel);
            this.Controls.Add(this.датаЗакрытияDateTimePicker);
            this.Controls.Add(датаПодачиLabel);
            this.Controls.Add(this.датаПодачиDateTimePicker);
            this.Controls.Add(датаПринятияLabel);
            this.Controls.Add(this.датаПринятияDateTimePicker);
            this.Controls.Add(номерКабинетаLabel);
            this.Controls.Add(this.номерКабинетаTextBox);
            this.Controls.Add(описаниеПроблемыLabel);
            this.Controls.Add(this.описаниеПроблемыTextBox);
            this.Controls.Add(приоритетLabel);
            this.Controls.Add(this.приоритетComboBox);
            this.Controls.Add(срочностьВыполненияLabel);
            this.Controls.Add(this.срочностьВыполненияTextBox);
            this.Controls.Add(статусЗаявкиIDLabel);
            this.Controls.Add(this.статусЗаявкиIDComboBox);
            this.Controls.Add(this.Regbut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestAdd_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RequestAdd_Form";
            this.Load += new System.EventHandler(this.RequestAdd_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfProblemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LAB_Request;
        private System.Windows.Forms.Button Regbut;
        private System.Windows.Forms.BindingSource questBindingSource;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.ComboBox iD_CriticalityComboBox;
        private System.Windows.Forms.BindingSource criticalityBindingSource;
        private System.Windows.Forms.ComboBox iD_HardwareComboBox;
        private System.Windows.Forms.BindingSource hardwareBindingSource;
        private System.Windows.Forms.ComboBox iD_OfficeComboBox;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.ComboBox iD_TypeOfProblemComboBox;
        private System.Windows.Forms.BindingSource typeOfProblemBindingSource;
        private System.Windows.Forms.ComboBox iD_UserComboBox;
        private System.Windows.Forms.DateTimePicker датаЗакрытияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаПодачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаПринятияDateTimePicker;
        private System.Windows.Forms.TextBox номерКабинетаTextBox;
        private System.Windows.Forms.TextBox описаниеПроблемыTextBox;
        private System.Windows.Forms.ComboBox приоритетComboBox;
        private System.Windows.Forms.TextBox срочностьВыполненияTextBox;
        private System.Windows.Forms.ComboBox статусЗаявкиIDComboBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
    }
}