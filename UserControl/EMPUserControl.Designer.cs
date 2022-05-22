
namespace ITHelpWinFrm
{
    partial class EMPUserControl
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
            this.ID_Label = new System.Windows.Forms.Label();
            this.FIOlabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(15, 14);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(27, 23);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "ID";
            // 
            // FIOlabel
            // 
            this.FIOlabel.AutoSize = true;
            this.FIOlabel.Location = new System.Drawing.Point(225, 14);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(49, 23);
            this.FIOlabel.TabIndex = 0;
            this.FIOlabel.Text = "ФИО";
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Location = new System.Drawing.Point(600, 14);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(99, 23);
            this.PostLabel.TabIndex = 0;
            this.PostLabel.Text = "Должность";
            // 
            // EMPUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.Controls.Add(this.PostLabel);
            this.Controls.Add(this.FIOlabel);
            this.Controls.Add(this.ID_Label);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EMPUserControl";
            this.Size = new System.Drawing.Size(833, 50);
            this.Load += new System.EventHandler(this.EMPUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label FIOlabel;
        private System.Windows.Forms.Label PostLabel;
    }
}
