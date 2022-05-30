
namespace ITHelpWinFrm.Forms
{
    partial class frmListRequest
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
            this.RequestflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminUserControl2 = new ITHelpWinFrm.AdminUserControl();
            this.FiltrCB = new System.Windows.Forms.ComboBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.AddRequest = new System.Windows.Forms.PictureBox();
            this.ReqSroklabel = new System.Windows.Forms.Label();
            this.ReqFillabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.ReqIDlabel = new System.Windows.Forms.Label();
            this.RequestflowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestflowLayoutPanel1
            // 
            this.RequestflowLayoutPanel1.Controls.Add(this.adminUserControl2);
            this.RequestflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RequestflowLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.RequestflowLayoutPanel1.Name = "RequestflowLayoutPanel1";
            this.RequestflowLayoutPanel1.Size = new System.Drawing.Size(833, 380);
            this.RequestflowLayoutPanel1.TabIndex = 25;
            // 
            // adminUserControl2
            // 
            this.adminUserControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.adminUserControl2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.adminUserControl2.Location = new System.Drawing.Point(6, 6);
            this.adminUserControl2.Margin = new System.Windows.Forms.Padding(6);
            this.adminUserControl2.Name = "adminUserControl2";
            this.adminUserControl2.Size = new System.Drawing.Size(8, 8);
            this.adminUserControl2.TabIndex = 1;
            // 
            // FiltrCB
            // 
            this.FiltrCB.DisplayMember = "ФИО";
            this.FiltrCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrCB.FormattingEnabled = true;
            this.FiltrCB.Location = new System.Drawing.Point(430, 12);
            this.FiltrCB.Name = "FiltrCB";
            this.FiltrCB.Size = new System.Drawing.Size(189, 33);
            this.FiltrCB.TabIndex = 28;
            this.FiltrCB.ValueMember = "ID_IT_Employees";
            this.FiltrCB.SelectedIndexChanged += new System.EventHandler(this.FiltrCB_SelectedIndexChanged);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(4, 12);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(265, 33);
            this.SearchTB.TabIndex = 27;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // AddRequest
            // 
            this.AddRequest.Image = global::ITHelpWinFrm.Properties.Resources.PlusAdd;
            this.AddRequest.Location = new System.Drawing.Point(746, 12);
            this.AddRequest.Name = "AddRequest";
            this.AddRequest.Size = new System.Drawing.Size(56, 27);
            this.AddRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddRequest.TabIndex = 26;
            this.AddRequest.TabStop = false;
            this.AddRequest.Click += new System.EventHandler(this.AddRequest_Click);
            // 
            // ReqSroklabel
            // 
            this.ReqSroklabel.AutoSize = true;
            this.ReqSroklabel.ForeColor = System.Drawing.Color.White;
            this.ReqSroklabel.Location = new System.Drawing.Point(595, 68);
            this.ReqSroklabel.Name = "ReqSroklabel";
            this.ReqSroklabel.Size = new System.Drawing.Size(222, 25);
            this.ReqSroklabel.TabIndex = 30;
            this.ReqSroklabel.Text = "Срочность выполнения";
            // 
            // ReqFillabel
            // 
            this.ReqFillabel.AutoSize = true;
            this.ReqFillabel.ForeColor = System.Drawing.Color.White;
            this.ReqFillabel.Location = new System.Drawing.Point(425, 68);
            this.ReqFillabel.Name = "ReqFillabel";
            this.ReqFillabel.Size = new System.Drawing.Size(81, 25);
            this.ReqFillabel.TabIndex = 31;
            this.ReqFillabel.Text = "Филиал";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.ForeColor = System.Drawing.Color.White;
            this.PriorityLabel.Location = new System.Drawing.Point(173, 68);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(107, 25);
            this.PriorityLabel.TabIndex = 32;
            this.PriorityLabel.Text = "Приоритет";
            // 
            // ReqIDlabel
            // 
            this.ReqIDlabel.AutoSize = true;
            this.ReqIDlabel.ForeColor = System.Drawing.Color.White;
            this.ReqIDlabel.Location = new System.Drawing.Point(7, 68);
            this.ReqIDlabel.Name = "ReqIDlabel";
            this.ReqIDlabel.Size = new System.Drawing.Size(32, 25);
            this.ReqIDlabel.TabIndex = 29;
            this.ReqIDlabel.Text = "ID";
            // 
            // frmListRequest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.ReqSroklabel);
            this.Controls.Add(this.ReqFillabel);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.ReqIDlabel);
            this.Controls.Add(this.FiltrCB);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.AddRequest);
            this.Controls.Add(this.RequestflowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListRequest";
            this.Text = "frmListRequest";
            this.Load += new System.EventHandler(this.frmListRequest_Load);
            this.RequestflowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel RequestflowLayoutPanel1;
        private AdminUserControl adminUserControl2;
        private System.Windows.Forms.ComboBox FiltrCB;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.PictureBox AddRequest;
        private System.Windows.Forms.Label ReqSroklabel;
        private System.Windows.Forms.Label ReqFillabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label ReqIDlabel;
    }
}