namespace Sandbox_Tool
{
    partial class MainForm
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnLogTest = new System.Windows.Forms.Button();
            this.txtApplicationPath = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openApplicaitonDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtApplicaitonParam = new System.Windows.Forms.TextBox();
            this.checkUnrestricted = new System.Windows.Forms.CheckBox();
            this.checkIO = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLog.Location = new System.Drawing.Point(12, 241);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1005, 126);
            this.txtLog.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(609, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(528, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnLogTest
            // 
            this.btnLogTest.Location = new System.Drawing.Point(13, 212);
            this.btnLogTest.Name = "btnLogTest";
            this.btnLogTest.Size = new System.Drawing.Size(75, 23);
            this.btnLogTest.TabIndex = 3;
            this.btnLogTest.Text = "Log+";
            this.btnLogTest.UseVisualStyleBackColor = true;
            this.btnLogTest.Click += new System.EventHandler(this.btnLogTest_Click);
            // 
            // txtApplicationPath
            // 
            this.txtApplicationPath.FormattingEnabled = true;
            this.txtApplicationPath.Location = new System.Drawing.Point(12, 12);
            this.txtApplicationPath.Name = "txtApplicationPath";
            this.txtApplicationPath.Size = new System.Drawing.Size(496, 21);
            this.txtApplicationPath.TabIndex = 4;
            this.txtApplicationPath.TextUpdate += new System.EventHandler(this.txtApplicationPath_TextUpdate);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(447, 212);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openApplicaitonDialog
            // 
            this.openApplicaitonDialog.FileName = "openApplicaitonDialog";
            this.openApplicaitonDialog.Filter = "Application|*.exe|All|*.*";
            // 
            // txtApplicaitonParam
            // 
            this.txtApplicaitonParam.Location = new System.Drawing.Point(12, 40);
            this.txtApplicaitonParam.Name = "txtApplicaitonParam";
            this.txtApplicaitonParam.Size = new System.Drawing.Size(496, 20);
            this.txtApplicaitonParam.TabIndex = 6;
            // 
            // checkUnrestricted
            // 
            this.checkUnrestricted.AutoSize = true;
            this.checkUnrestricted.Location = new System.Drawing.Point(13, 67);
            this.checkUnrestricted.Name = "checkUnrestricted";
            this.checkUnrestricted.Size = new System.Drawing.Size(83, 17);
            this.checkUnrestricted.TabIndex = 7;
            this.checkUnrestricted.Text = "Unrestricted";
            this.checkUnrestricted.UseVisualStyleBackColor = true;
            // 
            // checkIO
            // 
            this.checkIO.AutoSize = true;
            this.checkIO.Location = new System.Drawing.Point(13, 91);
            this.checkIO.Name = "checkIO";
            this.checkIO.Size = new System.Drawing.Size(87, 17);
            this.checkIO.TabIndex = 8;
            this.checkIO.Text = "Input/Output";
            this.checkIO.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1029, 379);
            this.Controls.Add(this.checkIO);
            this.Controls.Add(this.checkUnrestricted);
            this.Controls.Add(this.txtApplicaitonParam);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtApplicationPath);
            this.Controls.Add(this.btnLogTest);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sandbox Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnLogTest;
        private System.Windows.Forms.ComboBox txtApplicationPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openApplicaitonDialog;
        private System.Windows.Forms.TextBox txtApplicaitonParam;
        private System.Windows.Forms.CheckBox checkUnrestricted;
        private System.Windows.Forms.CheckBox checkIO;
    }
}

