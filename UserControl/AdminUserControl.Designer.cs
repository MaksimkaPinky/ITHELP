
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.RoleLab = new System.Windows.Forms.Label();
            this.PhoneLab = new System.Windows.Forms.Label();
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
            this.LFPlabel.Location = new System.Drawing.Point(36, 10);
            this.LFPlabel.Name = "LFPlabel";
            this.LFPlabel.Size = new System.Drawing.Size(84, 23);
            this.LFPlabel.TabIndex = 0;
            this.LFPlabel.Text = "Фамилия";
            this.LFPlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Birthday_label
            // 
            this.Birthday_label.AutoSize = true;
            this.Birthday_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Birthday_label.ForeColor = System.Drawing.Color.White;
            this.Birthday_label.Location = new System.Drawing.Point(261, 10);
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
            this.Emaillabel.Location = new System.Drawing.Point(261, 43);
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
            this.Loginlabel.Location = new System.Drawing.Point(558, 10);
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
            this.Passlabel.Location = new System.Drawing.Point(558, 43);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(71, 23);
            this.Passlabel.TabIndex = 0;
            this.Passlabel.Text = "Пароль";
            this.Passlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(36, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelPatronymic.ForeColor = System.Drawing.Color.White;
            this.labelPatronymic.Location = new System.Drawing.Point(37, 75);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(83, 23);
            this.labelPatronymic.TabIndex = 0;
            this.labelPatronymic.Text = "Отчество";
            this.labelPatronymic.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoleLab
            // 
            this.RoleLab.AutoSize = true;
            this.RoleLab.ForeColor = System.Drawing.Color.White;
            this.RoleLab.Location = new System.Drawing.Point(261, 75);
            this.RoleLab.Name = "RoleLab";
            this.RoleLab.Size = new System.Drawing.Size(48, 23);
            this.RoleLab.TabIndex = 1;
            this.RoleLab.Text = "Роль";
            // 
            // PhoneLab
            // 
            this.PhoneLab.AutoSize = true;
            this.PhoneLab.ForeColor = System.Drawing.Color.White;
            this.PhoneLab.Location = new System.Drawing.Point(558, 75);
            this.PhoneLab.Name = "PhoneLab";
            this.PhoneLab.Size = new System.Drawing.Size(77, 23);
            this.PhoneLab.TabIndex = 2;
            this.PhoneLab.Text = "Телефон";
            // 
            // AdminUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PhoneLab);
            this.Controls.Add(this.RoleLab);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Birthday_label);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.LFPlabel);
            this.Controls.Add(this.ID_label);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(831, 128);
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
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label RoleLab;
        private System.Windows.Forms.Label PhoneLab;
    }
}
