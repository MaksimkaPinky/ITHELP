
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LAB_Reg = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Regbut = new System.Windows.Forms.Button();
            this.Closebut = new System.Windows.Forms.Button();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LAB_Reg);
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
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITHelpWinFrm.EF.User);
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
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Role);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(ITHelpWinFrm.EF.Gender);
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
            this.Controls.Add(this.Closebut);
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
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LAB_Reg;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button Regbut;
        private System.Windows.Forms.Button Closebut;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
    }
}