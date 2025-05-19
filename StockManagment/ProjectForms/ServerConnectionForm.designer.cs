namespace StockManagment
{
    partial class ServerConnectionForm
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
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ServerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DatabaseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.closebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.IntegratedSecurityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ReportPathTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.MDCDBTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratedSecurityComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDCDBTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.Location = new System.Drawing.Point(145, 37);
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Size = new System.Drawing.Size(158, 20);
            this.UserNameTextEdit.TabIndex = 1;
            // 
            // ServerNameTextEdit
            // 
            this.ServerNameTextEdit.Location = new System.Drawing.Point(145, 11);
            this.ServerNameTextEdit.Name = "ServerNameTextEdit";
            this.ServerNameTextEdit.Size = new System.Drawing.Size(158, 20);
            this.ServerNameTextEdit.TabIndex = 0;
            // 
            // DatabaseTextEdit
            // 
            this.DatabaseTextEdit.Location = new System.Drawing.Point(145, 93);
            this.DatabaseTextEdit.Name = "DatabaseTextEdit";
            this.DatabaseTextEdit.Size = new System.Drawing.Size(158, 20);
            this.DatabaseTextEdit.TabIndex = 4;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.Location = new System.Drawing.Point(145, 63);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Properties.PasswordChar = '*';
            this.PasswordTextEdit.Size = new System.Drawing.Size(158, 20);
            this.PasswordTextEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Server Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "UserName";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Password";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Database";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(145, 248);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(228, 248);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 9;
            this.closebtn.Text = "Close";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Integrated Security";
            // 
            // IntegratedSecurityComboBoxEdit
            // 
            this.IntegratedSecurityComboBoxEdit.Location = new System.Drawing.Point(145, 124);
            this.IntegratedSecurityComboBoxEdit.Name = "IntegratedSecurityComboBoxEdit";
            this.IntegratedSecurityComboBoxEdit.Properties.AutoComplete = false;
            this.IntegratedSecurityComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IntegratedSecurityComboBoxEdit.Properties.Items.AddRange(new object[] {
            "True",
            "False"});
            this.IntegratedSecurityComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IntegratedSecurityComboBoxEdit.Size = new System.Drawing.Size(158, 20);
            this.IntegratedSecurityComboBoxEdit.TabIndex = 11;
            // 
            // ReportPathTextEdit
            // 
            this.ReportPathTextEdit.Location = new System.Drawing.Point(145, 150);
            this.ReportPathTextEdit.Name = "ReportPathTextEdit";
            this.ReportPathTextEdit.Size = new System.Drawing.Size(158, 20);
            this.ReportPathTextEdit.TabIndex = 4;
            this.ReportPathTextEdit.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 153);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Report Path";
            this.labelControl6.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 198);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(71, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "MDC Database";
            // 
            // MDCDBTextEdit
            // 
            this.MDCDBTextEdit.Location = new System.Drawing.Point(145, 195);
            this.MDCDBTextEdit.Name = "MDCDBTextEdit";
            this.MDCDBTextEdit.Size = new System.Drawing.Size(158, 20);
            this.MDCDBTextEdit.TabIndex = 12;
            // 
            // ServerConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 288);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.MDCDBTextEdit);
            this.Controls.Add(this.IntegratedSecurityComboBoxEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PasswordTextEdit);
            this.Controls.Add(this.ReportPathTextEdit);
            this.Controls.Add(this.DatabaseTextEdit);
            this.Controls.Add(this.ServerNameTextEdit);
            this.Controls.Add(this.UserNameTextEdit);
            this.Name = "ServerConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerConnectionForm";
            this.Shown += new System.EventHandler(this.ServerConnectionForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratedSecurityComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPathTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDCDBTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ServerNameTextEdit;
        private DevExpress.XtraEditors.TextEdit DatabaseTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton UpdateBtn;
        private DevExpress.XtraEditors.SimpleButton closebtn;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit IntegratedSecurityComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit ReportPathTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit MDCDBTextEdit;
    }
}