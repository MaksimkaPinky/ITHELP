﻿
namespace ITHelpWinFrm
{
    partial class AdminUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID_label = new System.Windows.Forms.Label();
            this.LFPlabel = new System.Windows.Forms.Label();
            this.Birthday_label = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(3, 10);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(27, 23);
            this.ID_label.TabIndex = 0;
            this.ID_label.Text = "ID";
            this.ID_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // LFPlabel
            // 
            this.LFPlabel.AutoSize = true;
            this.LFPlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.LFPlabel.ForeColor = System.Drawing.Color.White;
            this.LFPlabel.Location = new System.Drawing.Point(71, 10);
            this.LFPlabel.Name = "LFPlabel";
            this.LFPlabel.Size = new System.Drawing.Size(49, 23);
            this.LFPlabel.TabIndex = 0;
            this.LFPlabel.Text = "ФИО";
            this.LFPlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Birthday_label
            // 
            this.Birthday_label.AutoSize = true;
            this.Birthday_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Birthday_label.ForeColor = System.Drawing.Color.White;
            this.Birthday_label.Location = new System.Drawing.Point(284, 10);
            this.Birthday_label.Name = "Birthday_label";
            this.Birthday_label.Size = new System.Drawing.Size(135, 23);
            this.Birthday_label.TabIndex = 0;
            this.Birthday_label.Text = "День Рождения";
            this.Birthday_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Emaillabel.ForeColor = System.Drawing.Color.White;
            this.Emaillabel.Location = new System.Drawing.Point(464, 10);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(59, 23);
            this.Emaillabel.TabIndex = 0;
            this.Emaillabel.Text = "Почта";
            this.Emaillabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Loginlabel.ForeColor = System.Drawing.Color.White;
            this.Loginlabel.Location = new System.Drawing.Point(597, 10);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(59, 23);
            this.Loginlabel.TabIndex = 0;
            this.Loginlabel.Text = "Логин";
            this.Loginlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Passlabel.ForeColor = System.Drawing.Color.White;
            this.Passlabel.Location = new System.Drawing.Point(720, 10);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(71, 23);
            this.Passlabel.TabIndex = 0;
            this.Passlabel.Text = "Пароль";
            this.Passlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Birthday_label);
            this.Controls.Add(this.LFPlabel);
            this.Controls.Add(this.ID_label);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(833, 50);
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label LFPlabel;
        private System.Windows.Forms.Label Birthday_label;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Passlabel;
    }
}