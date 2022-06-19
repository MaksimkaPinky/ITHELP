
namespace ITHelpWinFrm.Forms
{
    partial class ReportAdd_form
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
            System.Windows.Forms.Label датаНаписанияLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label iD_IT_EmployeesLabel;
            System.Windows.Forms.Label iD_QuestLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAdd_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBut = new System.Windows.Forms.Button();
            this.датаНаписанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.iD_IT_EmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.iTEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_QuestComboBox = new System.Windows.Forms.ComboBox();
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            датаНаписанияLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            iD_IT_EmployeesLabel = new System.Windows.Forms.Label();
            iD_QuestLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // датаНаписанияLabel
            // 
            датаНаписанияLabel.AutoSize = true;
            датаНаписанияLabel.ForeColor = System.Drawing.Color.White;
            датаНаписанияLabel.Location = new System.Drawing.Point(185, 289);
            датаНаписанияLabel.Name = "датаНаписанияLabel";
            датаНаписанияLabel.Size = new System.Drawing.Size(161, 25);
            датаНаписанияLabel.TabIndex = 21;
            датаНаписанияLabel.Text = "Дата Написания:";
            датаНаписанияLabel.Visible = false;
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.ForeColor = System.Drawing.Color.White;
            описаниеLabel.Location = new System.Drawing.Point(185, 249);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(104, 25);
            описаниеLabel.TabIndex = 23;
            описаниеLabel.Text = "Описание:";
            // 
            // iD_IT_EmployeesLabel
            // 
            iD_IT_EmployeesLabel.AutoSize = true;
            iD_IT_EmployeesLabel.ForeColor = System.Drawing.Color.White;
            iD_IT_EmployeesLabel.Location = new System.Drawing.Point(185, 171);
            iD_IT_EmployeesLabel.Name = "iD_IT_EmployeesLabel";
            iD_IT_EmployeesLabel.Size = new System.Drawing.Size(106, 25);
            iD_IT_EmployeesLabel.TabIndex = 24;
            iD_IT_EmployeesLabel.Text = "Сотрудник";
            // 
            // iD_QuestLabel
            // 
            iD_QuestLabel.AutoSize = true;
            iD_QuestLabel.ForeColor = System.Drawing.Color.White;
            iD_QuestLabel.Location = new System.Drawing.Point(185, 210);
            iD_QuestLabel.Name = "iD_QuestLabel";
            iD_QuestLabel.Size = new System.Drawing.Size(98, 25);
            iD_QuestLabel.TabIndex = 25;
            iD_QuestLabel.Text = "ID заявки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 13;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(405, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Отчет";
            // 
            // SaveBut
            // 
            this.SaveBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.ForeColor = System.Drawing.Color.White;
            this.SaveBut.Location = new System.Drawing.Point(0, 400);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(800, 50);
            this.SaveBut.TabIndex = 14;
            this.SaveBut.Text = "Сохранить";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // датаНаписанияDateTimePicker
            // 
            this.датаНаписанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reportBindingSource, "ДатаНаписания", true));
            this.датаНаписанияDateTimePicker.Location = new System.Drawing.Point(352, 285);
            this.датаНаписанияDateTimePicker.Name = "датаНаписанияDateTimePicker";
            this.датаНаписанияDateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.датаНаписанияDateTimePicker.TabIndex = 22;
            this.датаНаписанияDateTimePicker.Visible = false;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Report);
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(352, 246);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 33);
            this.описаниеTextBox.TabIndex = 24;
            // 
            // iD_IT_EmployeesComboBox
            // 
            this.iD_IT_EmployeesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "ID_IT_Employees", true));
            this.iD_IT_EmployeesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reportBindingSource, "ID_IT_Employees", true));
            this.iD_IT_EmployeesComboBox.DataSource = this.iTEmployeesBindingSource;
            this.iD_IT_EmployeesComboBox.DisplayMember = "Фамилия";
            this.iD_IT_EmployeesComboBox.FormattingEnabled = true;
            this.iD_IT_EmployeesComboBox.Location = new System.Drawing.Point(352, 168);
            this.iD_IT_EmployeesComboBox.Name = "iD_IT_EmployeesComboBox";
            this.iD_IT_EmployeesComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_IT_EmployeesComboBox.TabIndex = 25;
            this.iD_IT_EmployeesComboBox.ValueMember = "Фамилия";
            // 
            // iTEmployeesBindingSource
            // 
            this.iTEmployeesBindingSource.DataSource = typeof(ITHelpWinFrm.EF.IT_Employees);
            // 
            // iD_QuestComboBox
            // 
            this.iD_QuestComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "ID_Quest", true));
            this.iD_QuestComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reportBindingSource, "ID_Quest", true));
            this.iD_QuestComboBox.DataSource = this.questBindingSource;
            this.iD_QuestComboBox.DisplayMember = "ID_Quest";
            this.iD_QuestComboBox.FormattingEnabled = true;
            this.iD_QuestComboBox.Location = new System.Drawing.Point(352, 207);
            this.iD_QuestComboBox.Name = "iD_QuestComboBox";
            this.iD_QuestComboBox.Size = new System.Drawing.Size(200, 33);
            this.iD_QuestComboBox.TabIndex = 26;
            this.iD_QuestComboBox.ValueMember = "ID_Quest";
            // 
            // questBindingSource
            // 
            this.questBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Quest);
            // 
            // ReportAdd_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_QuestLabel);
            this.Controls.Add(this.iD_QuestComboBox);
            this.Controls.Add(iD_IT_EmployeesLabel);
            this.Controls.Add(this.iD_IT_EmployeesComboBox);
            this.Controls.Add(датаНаписанияLabel);
            this.Controls.Add(this.датаНаписанияDateTimePicker);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportAdd_form";
            this.Text = "ReportAdd_form";
            this.Load += new System.EventHandler(this.ReportAdd_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.DateTimePicker датаНаписанияDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.ComboBox iD_IT_EmployeesComboBox;
        private System.Windows.Forms.BindingSource iTEmployeesBindingSource;
        private System.Windows.Forms.ComboBox iD_QuestComboBox;
        private System.Windows.Forms.BindingSource questBindingSource;
    }
}