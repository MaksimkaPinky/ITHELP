
namespace ITHelpWinFrm
{
    partial class Aut_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aut_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButExit = new System.Windows.Forms.Button();
            this.ButLogIn = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 88);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label3.Location = new System.Drawing.Point(241, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Авторизация";
            // 
            // ButExit
            // 
            this.ButExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ButExit.FlatAppearance.BorderSize = 0;
            this.ButExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButExit.ForeColor = System.Drawing.Color.White;
            this.ButExit.Location = new System.Drawing.Point(303, 278);
            this.ButExit.Margin = new System.Windows.Forms.Padding(6);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(127, 47);
            this.ButExit.TabIndex = 9;
            this.ButExit.Text = "Закрыть";
            this.ButExit.UseVisualStyleBackColor = false;
            this.ButExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // ButLogIn
            // 
            this.ButLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ButLogIn.FlatAppearance.BorderSize = 0;
            this.ButLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButLogIn.ForeColor = System.Drawing.Color.White;
            this.ButLogIn.Location = new System.Drawing.Point(74, 278);
            this.ButLogIn.Margin = new System.Windows.Forms.Padding(6);
            this.ButLogIn.Name = "ButLogIn";
            this.ButLogIn.Size = new System.Drawing.Size(127, 47);
            this.ButLogIn.TabIndex = 10;
            this.ButLogIn.Text = " Войти";
            this.ButLogIn.UseVisualStyleBackColor = false;
            this.ButLogIn.Click += new System.EventHandler(this.ButLogIn_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(138, 136);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(292, 33);
            this.textBoxLogin.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(138, 201);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(292, 33);
            this.textBoxPassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин:";
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.labelLogIn.ForeColor = System.Drawing.Color.Red;
            this.labelLogIn.Location = new System.Drawing.Point(142, 105);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(0, 25);
            this.labelLogIn.TabIndex = 13;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.Control;
            this.labelPassword.ForeColor = System.Drawing.Color.Red;
            this.labelPassword.Location = new System.Drawing.Point(142, 175);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 25);
            this.labelPassword.TabIndex = 14;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.SystemColors.Control;
            this.labelRole.ForeColor = System.Drawing.Color.Red;
            this.labelRole.Location = new System.Drawing.Point(142, 240);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 25);
            this.labelRole.TabIndex = 15;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Image = global::ITHelpWinFrm.Properties.Resources.ПоказатьГлаз;
            this.pictureBoxEye.Location = new System.Drawing.Point(442, 190);
            this.pictureBoxEye.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(50, 44);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye.TabIndex = 12;
            this.pictureBoxEye.TabStop = false;
            // 
            // Aut_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(501, 340);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.ButLogIn);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Aut_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aut_Form";
            this.Load += new System.EventHandler(this.Aut_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButExit;
        private System.Windows.Forms.Button ButLogIn;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;
    }
}

