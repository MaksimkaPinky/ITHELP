
namespace ITHelpWinFrm
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butListUsers = new System.Windows.Forms.Button();
            this.Exitbut = new System.Windows.Forms.Button();
            this.ListReportbut = new System.Windows.Forms.Button();
            this.ListEmployeesbut = new System.Windows.Forms.Button();
            this.ListRequestbut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.PanformLoader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.butListUsers);
            this.panel2.Controls.Add(this.Exitbut);
            this.panel2.Controls.Add(this.ListReportbut);
            this.panel2.Controls.Add(this.ListEmployeesbut);
            this.panel2.Controls.Add(this.ListRequestbut);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 576);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.UserNamelabel);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 100);
            this.panel4.TabIndex = 4;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.ForeColor = System.Drawing.Color.White;
            this.UserNamelabel.Location = new System.Drawing.Point(32, 64);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(102, 25);
            this.UserNamelabel.TabIndex = 2;
            this.UserNamelabel.Text = "UserName";
            this.UserNamelabel.Click += new System.EventHandler(this.UserNamelabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITHelpWinFrm.Properties.Resources.Аватар;
            this.pictureBox1.Location = new System.Drawing.Point(54, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butListUsers
            // 
            this.butListUsers.FlatAppearance.BorderSize = 0;
            this.butListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butListUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.butListUsers.Image = global::ITHelpWinFrm.Properties.Resources.Новыеаватары;
            this.butListUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butListUsers.Location = new System.Drawing.Point(-3, 410);
            this.butListUsers.Name = "butListUsers";
            this.butListUsers.Size = new System.Drawing.Size(186, 68);
            this.butListUsers.TabIndex = 2;
            this.butListUsers.Text = "Список пользователей";
            this.butListUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butListUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butListUsers.UseVisualStyleBackColor = true;
            this.butListUsers.Click += new System.EventHandler(this.butListUsers_Click);
            this.butListUsers.Leave += new System.EventHandler(this.butListUsers_Leave);
            // 
            // Exitbut
            // 
            this.Exitbut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exitbut.FlatAppearance.BorderSize = 0;
            this.Exitbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbut.Image = global::ITHelpWinFrm.Properties.Resources.Выход;
            this.Exitbut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbut.Location = new System.Drawing.Point(0, 518);
            this.Exitbut.Name = "Exitbut";
            this.Exitbut.Size = new System.Drawing.Size(186, 58);
            this.Exitbut.TabIndex = 2;
            this.Exitbut.Text = "Выйти";
            this.Exitbut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exitbut.UseVisualStyleBackColor = true;
            this.Exitbut.Click += new System.EventHandler(this.Exitbut_Click);
            // 
            // ListReportbut
            // 
            this.ListReportbut.FlatAppearance.BorderSize = 0;
            this.ListReportbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListReportbut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ListReportbut.Image = global::ITHelpWinFrm.Properties.Resources.Отчеты;
            this.ListReportbut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListReportbut.Location = new System.Drawing.Point(-3, 342);
            this.ListReportbut.Name = "ListReportbut";
            this.ListReportbut.Size = new System.Drawing.Size(186, 68);
            this.ListReportbut.TabIndex = 2;
            this.ListReportbut.Text = "Список отчетов";
            this.ListReportbut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListReportbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListReportbut.UseVisualStyleBackColor = true;
            this.ListReportbut.Click += new System.EventHandler(this.ListReportbut_Click);
            this.ListReportbut.Leave += new System.EventHandler(this.ListReportbut_Leave);
            // 
            // ListEmployeesbut
            // 
            this.ListEmployeesbut.FlatAppearance.BorderSize = 0;
            this.ListEmployeesbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListEmployeesbut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ListEmployeesbut.Image = global::ITHelpWinFrm.Properties.Resources.ИТ_сотрудники;
            this.ListEmployeesbut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListEmployeesbut.Location = new System.Drawing.Point(-3, 274);
            this.ListEmployeesbut.Name = "ListEmployeesbut";
            this.ListEmployeesbut.Size = new System.Drawing.Size(186, 68);
            this.ListEmployeesbut.TabIndex = 2;
            this.ListEmployeesbut.Text = "Список сотрудников";
            this.ListEmployeesbut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListEmployeesbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListEmployeesbut.UseVisualStyleBackColor = true;
            this.ListEmployeesbut.Click += new System.EventHandler(this.ListEmployeesbut_Click);
            this.ListEmployeesbut.Leave += new System.EventHandler(this.ListEmployeesbut_Leave);
            // 
            // ListRequestbut
            // 
            this.ListRequestbut.FlatAppearance.BorderSize = 0;
            this.ListRequestbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListRequestbut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ListRequestbut.Image = global::ITHelpWinFrm.Properties.Resources.Заявка;
            this.ListRequestbut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListRequestbut.Location = new System.Drawing.Point(-3, 206);
            this.ListRequestbut.Name = "ListRequestbut";
            this.ListRequestbut.Size = new System.Drawing.Size(186, 68);
            this.ListRequestbut.TabIndex = 2;
            this.ListRequestbut.Text = "Список заявок";
            this.ListRequestbut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListRequestbut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListRequestbut.UseVisualStyleBackColor = true;
            this.ListRequestbut.Click += new System.EventHandler(this.ListRequestbut_Click);
            this.ListRequestbut.Leave += new System.EventHandler(this.ListRequestbut_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ITHelpWinFrm.Properties.Resources.incom;
            this.pictureBox2.Location = new System.Drawing.Point(14, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.lblTitle.Location = new System.Drawing.Point(243, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 37);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Список пользователей";
            // 
            // butClose
            // 
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.butClose.Location = new System.Drawing.Point(779, 12);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(42, 48);
            this.butClose.TabIndex = 19;
            this.butClose.Text = "x";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // PanformLoader
            // 
            this.PanformLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.PanformLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanformLoader.Location = new System.Drawing.Point(186, 100);
            this.PanformLoader.Name = "PanformLoader";
            this.PanformLoader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanformLoader.Size = new System.Drawing.Size(833, 476);
            this.PanformLoader.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butClose);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(186, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 100);
            this.panel3.TabIndex = 21;
            // 
            // Admin_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 576);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanformLoader);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ListRequestbut;
        private System.Windows.Forms.Button Exitbut;
        private System.Windows.Forms.Button ListReportbut;
        private System.Windows.Forms.Button ListEmployeesbut;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button butListUsers;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Panel PanformLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}