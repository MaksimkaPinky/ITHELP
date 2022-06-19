
namespace ITHelpWinFrm
{
    partial class RequestUserControl
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
            this.ReqIDlabel = new System.Windows.Forms.Label();
            this.Office = new System.Windows.Forms.Label();
            this.Hardware = new System.Windows.Forms.Label();
            this.TypeProb = new System.Windows.Forms.Label();
            this.Cab = new System.Windows.Forms.Label();
            this.Crit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReqIDlabel
            // 
            this.ReqIDlabel.AutoSize = true;
            this.ReqIDlabel.Location = new System.Drawing.Point(3, 11);
            this.ReqIDlabel.Name = "ReqIDlabel";
            this.ReqIDlabel.Size = new System.Drawing.Size(27, 23);
            this.ReqIDlabel.TabIndex = 0;
            this.ReqIDlabel.Text = "ID";
            // 
            // Office
            // 
            this.Office.AutoSize = true;
            this.Office.Location = new System.Drawing.Point(36, 11);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(113, 23);
            this.Office.TabIndex = 1;
            this.Office.Text = "Адрес офиса";
            // 
            // Hardware
            // 
            this.Hardware.AutoSize = true;
            this.Hardware.Location = new System.Drawing.Point(445, 11);
            this.Hardware.Name = "Hardware";
            this.Hardware.Size = new System.Drawing.Size(128, 23);
            this.Hardware.TabIndex = 1;
            this.Hardware.Text = "Оборудование";
            // 
            // TypeProb
            // 
            this.TypeProb.AutoSize = true;
            this.TypeProb.Location = new System.Drawing.Point(36, 57);
            this.TypeProb.Name = "TypeProb";
            this.TypeProb.Size = new System.Drawing.Size(128, 23);
            this.TypeProb.TabIndex = 1;
            this.TypeProb.Text = "Тип проблемы";
            // 
            // Cab
            // 
            this.Cab.AutoSize = true;
            this.Cab.Location = new System.Drawing.Point(36, 34);
            this.Cab.Name = "Cab";
            this.Cab.Size = new System.Drawing.Size(143, 23);
            this.Cab.TabIndex = 1;
            this.Cab.Text = "Номер кабинета";
            // 
            // Crit
            // 
            this.Crit.AutoSize = true;
            this.Crit.Location = new System.Drawing.Point(445, 34);
            this.Crit.Name = "Crit";
            this.Crit.Size = new System.Drawing.Size(111, 23);
            this.Crit.TabIndex = 1;
            this.Crit.Text = "Критичность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 1;
            // 
            // RequestUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TypeProb);
            this.Controls.Add(this.Hardware);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Crit);
            this.Controls.Add(this.Cab);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.ReqIDlabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(831, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReqIDlabel;
        private System.Windows.Forms.Label Office;
        private System.Windows.Forms.Label Hardware;
        private System.Windows.Forms.Label TypeProb;
        private System.Windows.Forms.Label Cab;
        private System.Windows.Forms.Label Crit;
        private System.Windows.Forms.Label label2;
    }
}
