
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
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.ReqFillabel = new System.Windows.Forms.Label();
            this.ReqSroklabel = new System.Windows.Forms.Label();
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
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(169, 11);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(96, 23);
            this.PriorityLabel.TabIndex = 1;
            this.PriorityLabel.Text = "Приоритет";
            // 
            // ReqFillabel
            // 
            this.ReqFillabel.AutoSize = true;
            this.ReqFillabel.Location = new System.Drawing.Point(421, 11);
            this.ReqFillabel.Name = "ReqFillabel";
            this.ReqFillabel.Size = new System.Drawing.Size(72, 23);
            this.ReqFillabel.TabIndex = 1;
            this.ReqFillabel.Text = "Филиал";
            // 
            // ReqSroklabel
            // 
            this.ReqSroklabel.AutoSize = true;
            this.ReqSroklabel.Location = new System.Drawing.Point(591, 11);
            this.ReqSroklabel.Name = "ReqSroklabel";
            this.ReqSroklabel.Size = new System.Drawing.Size(200, 23);
            this.ReqSroklabel.TabIndex = 1;
            this.ReqSroklabel.Text = "Срочность выполнения";
            // 
            // RequestUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.Controls.Add(this.ReqSroklabel);
            this.Controls.Add(this.ReqFillabel);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.ReqIDlabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(833, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReqIDlabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label ReqFillabel;
        private System.Windows.Forms.Label ReqSroklabel;
    }
}
