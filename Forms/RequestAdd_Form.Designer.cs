
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
            System.Windows.Forms.Label датаПодачиLabel;
            System.Windows.Forms.Label номерКабинетаLabel;
            System.Windows.Forms.Label описаниеПроблемыLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestAdd_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LAB_Request = new System.Windows.Forms.Label();
            this.Regbut = new System.Windows.Forms.Button();
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_CriticalityComboBox = new System.Windows.Forms.ComboBox();
            this.criticalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_HardwareComboBox = new System.Windows.Forms.ComboBox();
            this.hardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_TypeOfProblemComboBox = new System.Windows.Forms.ComboBox();
            this.typeOfProblemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.датаПодачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номерКабинетаTextBox = new System.Windows.Forms.TextBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CriticalPB = new System.Windows.Forms.PictureBox();
            this.HardwarePB = new System.Windows.Forms.PictureBox();
            this.TypeOfProblemPB = new System.Windows.Forms.PictureBox();
            this.TitProblemPB = new System.Windows.Forms.PictureBox();
            this.описаниеПроблемыTextBox = new System.Windows.Forms.TextBox();
            iD_CriticalityLabel = new System.Windows.Forms.Label();
            iD_HardwareLabel = new System.Windows.Forms.Label();
            iD_OfficeLabel = new System.Windows.Forms.Label();
            iD_TypeOfProblemLabel = new System.Windows.Forms.Label();
            датаПодачиLabel = new System.Windows.Forms.Label();
            номерКабинетаLabel = new System.Windows.Forms.Label();
            описаниеПроблемыLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfProblemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriticalPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardwarePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfProblemPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitProblemPB)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CriticalityLabel
            // 
            iD_CriticalityLabel.AutoSize = true;
            iD_CriticalityLabel.ForeColor = System.Drawing.Color.White;
            iD_CriticalityLabel.Location = new System.Drawing.Point(10, 120);
            iD_CriticalityLabel.Name = "iD_CriticalityLabel";
            iD_CriticalityLabel.Size = new System.Drawing.Size(130, 25);
            iD_CriticalityLabel.TabIndex = 24;
            iD_CriticalityLabel.Text = "Критичность:";
            // 
            // iD_HardwareLabel
            // 
            iD_HardwareLabel.AutoSize = true;
            iD_HardwareLabel.ForeColor = System.Drawing.Color.White;
            iD_HardwareLabel.Location = new System.Drawing.Point(10, 159);
            iD_HardwareLabel.Name = "iD_HardwareLabel";
            iD_HardwareLabel.Size = new System.Drawing.Size(148, 25);
            iD_HardwareLabel.TabIndex = 26;
            iD_HardwareLabel.Text = "Оборудование:";
            // 
            // iD_OfficeLabel
            // 
            iD_OfficeLabel.AutoSize = true;
            iD_OfficeLabel.ForeColor = System.Drawing.Color.White;
            iD_OfficeLabel.Location = new System.Drawing.Point(10, 198);
            iD_OfficeLabel.Name = "iD_OfficeLabel";
            iD_OfficeLabel.Size = new System.Drawing.Size(132, 25);
            iD_OfficeLabel.TabIndex = 28;
            iD_OfficeLabel.Text = "Адрес офиса:";
            // 
            // iD_TypeOfProblemLabel
            // 
            iD_TypeOfProblemLabel.AutoSize = true;
            iD_TypeOfProblemLabel.ForeColor = System.Drawing.Color.White;
            iD_TypeOfProblemLabel.Location = new System.Drawing.Point(10, 237);
            iD_TypeOfProblemLabel.Name = "iD_TypeOfProblemLabel";
            iD_TypeOfProblemLabel.Size = new System.Drawing.Size(146, 25);
            iD_TypeOfProblemLabel.TabIndex = 32;
            iD_TypeOfProblemLabel.Text = "Тип проблемы:";
            // 
            // датаПодачиLabel
            // 
            датаПодачиLabel.AutoSize = true;
            датаПодачиLabel.ForeColor = System.Drawing.Color.White;
            датаПодачиLabel.Location = new System.Drawing.Point(10, 619);
            датаПодачиLabel.Name = "датаПодачиLabel";
            датаПодачиLabel.Size = new System.Drawing.Size(132, 25);
            датаПодачиLabel.TabIndex = 50;
            датаПодачиLabel.Text = "Дата Подачи:";
            датаПодачиLabel.Visible = false;
            // 
            // номерКабинетаLabel
            // 
            номерКабинетаLabel.AutoSize = true;
            номерКабинетаLabel.ForeColor = System.Drawing.Color.White;
            номерКабинетаLabel.Location = new System.Drawing.Point(10, 276);
            номерКабинетаLabel.Name = "номерКабинетаLabel";
            номерКабинетаLabel.Size = new System.Drawing.Size(165, 25);
            номерКабинетаLabel.TabIndex = 42;
            номерКабинетаLabel.Text = "Номер Кабинета:";
            // 
            // описаниеПроблемыLabel
            // 
            описаниеПроблемыLabel.AutoSize = true;
            описаниеПроблемыLabel.ForeColor = System.Drawing.Color.White;
            описаниеПроблемыLabel.Location = new System.Drawing.Point(7, 320);
            описаниеПроблемыLabel.Name = "описаниеПроблемыLabel";
            описаниеПроблемыLabel.Size = new System.Drawing.Size(202, 25);
            описаниеПроблемыLabel.TabIndex = 44;
            описаниеПроблемыLabel.Text = "Описание проблемы:";
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
            this.panel1.Size = new System.Drawing.Size(791, 109);
            this.panel1.TabIndex = 14;
            // 
            // CloseBut
            // 
            this.CloseBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBut.FlatAppearance.BorderSize = 0;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.CloseBut.Location = new System.Drawing.Point(716, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(75, 109);
            this.CloseBut.TabIndex = 4;
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
            this.pictureBox2.Size = new System.Drawing.Size(188, 109);
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
            this.LAB_Request.Location = new System.Drawing.Point(434, 42);
            this.LAB_Request.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.LAB_Request.Name = "LAB_Request";
            this.LAB_Request.Size = new System.Drawing.Size(73, 25);
            this.LAB_Request.TabIndex = 0;
            this.LAB_Request.Text = "Заявка";
            // 
            // Regbut
            // 
            this.Regbut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Regbut.FlatAppearance.BorderSize = 0;
            this.Regbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regbut.ForeColor = System.Drawing.Color.White;
            this.Regbut.Location = new System.Drawing.Point(0, 714);
            this.Regbut.Name = "Regbut";
            this.Regbut.Size = new System.Drawing.Size(791, 50);
            this.Regbut.TabIndex = 24;
            this.Regbut.Text = "Отправить";
            this.Regbut.UseVisualStyleBackColor = true;
            this.Regbut.Click += new System.EventHandler(this.Regbut_Click);
            // 
            // questBindingSource
            // 
            this.questBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Quest);
            // 
            // iD_CriticalityComboBox
            // 
            this.iD_CriticalityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_Criticality", true));
            this.iD_CriticalityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_Criticality", true));
            this.iD_CriticalityComboBox.DataSource = this.criticalityBindingSource;
            this.iD_CriticalityComboBox.DisplayMember = "Описание";
            this.iD_CriticalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_CriticalityComboBox.FormattingEnabled = true;
            this.iD_CriticalityComboBox.Location = new System.Drawing.Point(243, 121);
            this.iD_CriticalityComboBox.Name = "iD_CriticalityComboBox";
            this.iD_CriticalityComboBox.Size = new System.Drawing.Size(487, 33);
            this.iD_CriticalityComboBox.TabIndex = 25;
            this.iD_CriticalityComboBox.ValueMember = "ID_Criticality";
            // 
            // criticalityBindingSource
            // 
            this.criticalityBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Criticality);
            // 
            // iD_HardwareComboBox
            // 
            this.iD_HardwareComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_Hardware", true));
            this.iD_HardwareComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_Hardware", true));
            this.iD_HardwareComboBox.DataSource = this.hardwareBindingSource;
            this.iD_HardwareComboBox.DisplayMember = "Наименование";
            this.iD_HardwareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_HardwareComboBox.FormattingEnabled = true;
            this.iD_HardwareComboBox.Location = new System.Drawing.Point(243, 160);
            this.iD_HardwareComboBox.Name = "iD_HardwareComboBox";
            this.iD_HardwareComboBox.Size = new System.Drawing.Size(487, 33);
            this.iD_HardwareComboBox.TabIndex = 27;
            this.iD_HardwareComboBox.ValueMember = "ID_Hardware";
            // 
            // hardwareBindingSource
            // 
            this.hardwareBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Hardware);
            // 
            // iD_OfficeComboBox
            // 
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_Office", true));
            this.iD_OfficeComboBox.DataSource = this.officeBindingSource;
            this.iD_OfficeComboBox.DisplayMember = "Адрес";
            this.iD_OfficeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_OfficeComboBox.FormattingEnabled = true;
            this.iD_OfficeComboBox.Location = new System.Drawing.Point(243, 198);
            this.iD_OfficeComboBox.Name = "iD_OfficeComboBox";
            this.iD_OfficeComboBox.Size = new System.Drawing.Size(487, 33);
            this.iD_OfficeComboBox.TabIndex = 29;
            this.iD_OfficeComboBox.ValueMember = "ID_Office";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Office);
            // 
            // iD_TypeOfProblemComboBox
            // 
            this.iD_TypeOfProblemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ID_TypeOfProblem", true));
            this.iD_TypeOfProblemComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questBindingSource, "ID_TypeOfProblem", true));
            this.iD_TypeOfProblemComboBox.DataSource = this.typeOfProblemBindingSource;
            this.iD_TypeOfProblemComboBox.DisplayMember = "ТипПроблемы";
            this.iD_TypeOfProblemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_TypeOfProblemComboBox.FormattingEnabled = true;
            this.iD_TypeOfProblemComboBox.Location = new System.Drawing.Point(243, 237);
            this.iD_TypeOfProblemComboBox.Name = "iD_TypeOfProblemComboBox";
            this.iD_TypeOfProblemComboBox.Size = new System.Drawing.Size(487, 33);
            this.iD_TypeOfProblemComboBox.TabIndex = 33;
            this.iD_TypeOfProblemComboBox.ValueMember = "ID_TypeOfProblem";
            // 
            // typeOfProblemBindingSource
            // 
            this.typeOfProblemBindingSource.DataSource = typeof(ITHelpWinFrm.EF.TypeOfProblem);
            // 
            // датаПодачиDateTimePicker
            // 
            this.датаПодачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questBindingSource, "ДатаПодачи", true));
            this.датаПодачиDateTimePicker.Location = new System.Drawing.Point(243, 619);
            this.датаПодачиDateTimePicker.Name = "датаПодачиDateTimePicker";
            this.датаПодачиDateTimePicker.Size = new System.Drawing.Size(338, 33);
            this.датаПодачиDateTimePicker.TabIndex = 50;
            this.датаПодачиDateTimePicker.Visible = false;
            // 
            // номерКабинетаTextBox
            // 
            this.номерКабинетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "НомерКабинета", true));
            this.номерКабинетаTextBox.Location = new System.Drawing.Point(243, 276);
            this.номерКабинетаTextBox.MaxLength = 10;
            this.номерКабинетаTextBox.Name = "номерКабинетаTextBox";
            this.номерКабинетаTextBox.Size = new System.Drawing.Size(487, 33);
            this.номерКабинетаTextBox.TabIndex = 43;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Status);
            // 
            // CriticalPB
            // 
            this.CriticalPB.Image = global::ITHelpWinFrm.Properties.Resources.ВопросБел;
            this.CriticalPB.Location = new System.Drawing.Point(748, 124);
            this.CriticalPB.Name = "CriticalPB";
            this.CriticalPB.Size = new System.Drawing.Size(31, 33);
            this.CriticalPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CriticalPB.TabIndex = 52;
            this.CriticalPB.TabStop = false;
            // 
            // HardwarePB
            // 
            this.HardwarePB.Image = global::ITHelpWinFrm.Properties.Resources.ВопросБел;
            this.HardwarePB.Location = new System.Drawing.Point(748, 158);
            this.HardwarePB.Name = "HardwarePB";
            this.HardwarePB.Size = new System.Drawing.Size(31, 33);
            this.HardwarePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HardwarePB.TabIndex = 52;
            this.HardwarePB.TabStop = false;
            // 
            // TypeOfProblemPB
            // 
            this.TypeOfProblemPB.Image = global::ITHelpWinFrm.Properties.Resources.ВопросБел;
            this.TypeOfProblemPB.Location = new System.Drawing.Point(748, 240);
            this.TypeOfProblemPB.Name = "TypeOfProblemPB";
            this.TypeOfProblemPB.Size = new System.Drawing.Size(31, 33);
            this.TypeOfProblemPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TypeOfProblemPB.TabIndex = 52;
            this.TypeOfProblemPB.TabStop = false;
            // 
            // TitProblemPB
            // 
            this.TitProblemPB.Image = global::ITHelpWinFrm.Properties.Resources.ВопросБел;
            this.TitProblemPB.Location = new System.Drawing.Point(748, 312);
            this.TitProblemPB.Name = "TitProblemPB";
            this.TitProblemPB.Size = new System.Drawing.Size(31, 33);
            this.TitProblemPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitProblemPB.TabIndex = 52;
            this.TitProblemPB.TabStop = false;
            // 
            // описаниеПроблемыTextBox
            // 
            this.описаниеПроблемыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questBindingSource, "ОписаниеПроблемы", true));
            this.описаниеПроблемыTextBox.Location = new System.Drawing.Point(12, 348);
            this.описаниеПроблемыTextBox.Multiline = true;
            this.описаниеПроблемыTextBox.Name = "описаниеПроблемыTextBox";
            this.описаниеПроблемыTextBox.Size = new System.Drawing.Size(767, 255);
            this.описаниеПроблемыTextBox.TabIndex = 45;
            // 
            // RequestAdd_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(791, 764);
            this.Controls.Add(this.TitProblemPB);
            this.Controls.Add(this.TypeOfProblemPB);
            this.Controls.Add(this.HardwarePB);
            this.Controls.Add(this.CriticalPB);
            this.Controls.Add(iD_CriticalityLabel);
            this.Controls.Add(this.iD_CriticalityComboBox);
            this.Controls.Add(iD_HardwareLabel);
            this.Controls.Add(this.iD_HardwareComboBox);
            this.Controls.Add(iD_OfficeLabel);
            this.Controls.Add(this.iD_OfficeComboBox);
            this.Controls.Add(iD_TypeOfProblemLabel);
            this.Controls.Add(this.iD_TypeOfProblemComboBox);
            this.Controls.Add(датаПодачиLabel);
            this.Controls.Add(this.датаПодачиDateTimePicker);
            this.Controls.Add(номерКабинетаLabel);
            this.Controls.Add(this.номерКабинетаTextBox);
            this.Controls.Add(описаниеПроблемыLabel);
            this.Controls.Add(this.описаниеПроблемыTextBox);
            this.Controls.Add(this.Regbut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestAdd_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestAdd_Form";
            this.Load += new System.EventHandler(this.RequestAdd_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfProblemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriticalPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardwarePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfProblemPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitProblemPB)).EndInit();
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
        private System.Windows.Forms.DateTimePicker датаПодачиDateTimePicker;
        private System.Windows.Forms.TextBox номерКабинетаTextBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.PictureBox CriticalPB;
        private System.Windows.Forms.PictureBox HardwarePB;
        private System.Windows.Forms.PictureBox TypeOfProblemPB;
        private System.Windows.Forms.PictureBox TitProblemPB;
        private System.Windows.Forms.TextBox описаниеПроблемыTextBox;
    }
}