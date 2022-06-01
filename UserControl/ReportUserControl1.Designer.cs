
namespace ITHelpWinFrm
{
    partial class ReportUserControl1
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
            this.ID_report = new System.Windows.Forms.Label();
            this.IDQuest = new System.Windows.Forms.Label();
            this.TitleLAb = new System.Windows.Forms.Label();
            this.dateLab = new System.Windows.Forms.Label();
            this.IdItEMpLab = new System.Windows.Forms.Label();
            this.nameemp = new System.Windows.Forms.Label();
            this.patronimycLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_report
            // 
            this.ID_report.AutoSize = true;
            this.ID_report.Location = new System.Drawing.Point(16, 14);
            this.ID_report.Name = "ID_report";
            this.ID_report.Size = new System.Drawing.Size(27, 23);
            this.ID_report.TabIndex = 0;
            this.ID_report.Text = "ID";
            // 
            // IDQuest
            // 
            this.IDQuest.AutoSize = true;
            this.IDQuest.Location = new System.Drawing.Point(75, 14);
            this.IDQuest.Name = "IDQuest";
            this.IDQuest.Size = new System.Drawing.Size(55, 23);
            this.IDQuest.TabIndex = 0;
            this.IDQuest.Text = "Quest";
            // 
            // TitleLAb
            // 
            this.TitleLAb.AutoSize = true;
            this.TitleLAb.Location = new System.Drawing.Point(201, 14);
            this.TitleLAb.Name = "TitleLAb";
            this.TitleLAb.Size = new System.Drawing.Size(89, 23);
            this.TitleLAb.TabIndex = 0;
            this.TitleLAb.Text = "Описание";
            // 
            // dateLab
            // 
            this.dateLab.AutoSize = true;
            this.dateLab.Location = new System.Drawing.Point(584, 14);
            this.dateLab.Name = "dateLab";
            this.dateLab.Size = new System.Drawing.Size(137, 23);
            this.dateLab.TabIndex = 0;
            this.dateLab.Text = "Дата написания";
            // 
            // IdItEMpLab
            // 
            this.IdItEMpLab.AutoSize = true;
            this.IdItEMpLab.Location = new System.Drawing.Point(75, 64);
            this.IdItEMpLab.Name = "IdItEMpLab";
            this.IdItEMpLab.Size = new System.Drawing.Size(84, 23);
            this.IdItEMpLab.TabIndex = 0;
            this.IdItEMpLab.Text = "Фамилия";
            // 
            // nameemp
            // 
            this.nameemp.AutoSize = true;
            this.nameemp.Location = new System.Drawing.Point(235, 64);
            this.nameemp.Name = "nameemp";
            this.nameemp.Size = new System.Drawing.Size(45, 23);
            this.nameemp.TabIndex = 0;
            this.nameemp.Text = "Имя";
            // 
            // patronimycLab
            // 
            this.patronimycLab.AutoSize = true;
            this.patronimycLab.Location = new System.Drawing.Point(383, 64);
            this.patronimycLab.Name = "patronimycLab";
            this.patronimycLab.Size = new System.Drawing.Size(83, 23);
            this.patronimycLab.TabIndex = 0;
            this.patronimycLab.Text = "Отчество";
            // 
            // ReportUserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.Controls.Add(this.patronimycLab);
            this.Controls.Add(this.nameemp);
            this.Controls.Add(this.IdItEMpLab);
            this.Controls.Add(this.dateLab);
            this.Controls.Add(this.TitleLAb);
            this.Controls.Add(this.IDQuest);
            this.Controls.Add(this.ID_report);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ReportUserControl1";
            this.Size = new System.Drawing.Size(833, 103);
            this.Load += new System.EventHandler(this.ReportUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_report;
        private System.Windows.Forms.Label IDQuest;
        private System.Windows.Forms.Label TitleLAb;
        private System.Windows.Forms.Label dateLab;
        private System.Windows.Forms.Label IdItEMpLab;
        private System.Windows.Forms.Label nameemp;
        private System.Windows.Forms.Label patronimycLab;
    }
}
