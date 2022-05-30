
namespace ITHelpWinFrm.Forms
{
    partial class IT_Employees_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Employees_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListReportbut = new System.Windows.Forms.Button();
            this.AddEmp = new System.Windows.Forms.PictureBox();
            this.Exitbut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmp)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox2.Image = global::ITHelpWinFrm.Properties.Resources.incom;
            this.pictureBox2.Location = new System.Drawing.Point(13, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 82);
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
            this.label3.Location = new System.Drawing.Point(318, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя сотрудника";
            // 
            // ListReportbut
            // 
            this.ListReportbut.FlatAppearance.BorderSize = 0;
            this.ListReportbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListReportbut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ListReportbut.Image = global::ITHelpWinFrm.Properties.Resources.Отчеты;
            this.ListReportbut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListReportbut.Location = new System.Drawing.Point(0, 91);
            this.ListReportbut.Name = "ListReportbut";
            this.ListReportbut.Size = new System.Drawing.Size(186, 68);
            this.ListReportbut.TabIndex = 14;
            this.ListReportbut.Text = "Список отчетов";
            this.ListReportbut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListReportbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListReportbut.UseVisualStyleBackColor = true;
            // 
            // AddEmp
            // 
            this.AddEmp.Image = global::ITHelpWinFrm.Properties.Resources.PlusAdd;
            this.AddEmp.Location = new System.Drawing.Point(180, 111);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(56, 27);
            this.AddEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddEmp.TabIndex = 24;
            this.AddEmp.TabStop = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // Exitbut
            // 
            this.Exitbut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exitbut.FlatAppearance.BorderSize = 0;
            this.Exitbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbut.Image = global::ITHelpWinFrm.Properties.Resources.Выход;
            this.Exitbut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbut.Location = new System.Drawing.Point(0, 392);
            this.Exitbut.Name = "Exitbut";
            this.Exitbut.Size = new System.Drawing.Size(800, 58);
            this.Exitbut.TabIndex = 26;
            this.Exitbut.Text = "Выйти";
            this.Exitbut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exitbut.UseVisualStyleBackColor = true;
            this.Exitbut.Click += new System.EventHandler(this.Exitbut_Click);
            // 
            // IT_Employees_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbut);
            this.Controls.Add(this.AddEmp);
            this.Controls.Add(this.ListReportbut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IT_Employees_Form";
            this.Text = "Форма сотрудника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ListReportbut;
        private System.Windows.Forms.PictureBox AddEmp;
        private System.Windows.Forms.Button Exitbut;
    }
}