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
            this.txtApplicationPath = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openApplicaitonDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtApplicaitonParam = new System.Windows.Forms.TextBox();
            this.checkUnrestricted = new System.Windows.Forms.CheckBox();
            this.checkIO = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblParam = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLog = new System.Windows.Forms.TableLayoutPanel();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tablePermissions = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableApplication = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLog.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.tablePermissions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(772, 128);
            this.txtLog.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(700, 3);
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
            this.btnOK.Location = new System.Drawing.Point(619, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtApplicationPath
            // 
            this.txtApplicationPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApplicationPath.FormattingEnabled = true;
            this.txtApplicationPath.Location = new System.Drawing.Point(55, 5);
            this.txtApplicationPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtApplicationPath.Name = "txtApplicationPath";
            this.txtApplicationPath.Size = new System.Drawing.Size(706, 21);
            this.txtApplicationPath.TabIndex = 4;
            this.txtApplicationPath.TextUpdate += new System.EventHandler(this.txtApplicationPath_TextUpdate);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(539, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 23);
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
            this.txtApplicaitonParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApplicaitonParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicaitonParam.Location = new System.Drawing.Point(55, 36);
            this.txtApplicaitonParam.Margin = new System.Windows.Forms.Padding(5);
            this.txtApplicaitonParam.Name = "txtApplicaitonParam";
            this.txtApplicaitonParam.Size = new System.Drawing.Size(706, 20);
            this.txtApplicaitonParam.TabIndex = 6;
            // 
            // checkUnrestricted
            // 
            this.checkUnrestricted.AutoSize = true;
            this.checkUnrestricted.Location = new System.Drawing.Point(6, 6);
            this.checkUnrestricted.Name = "checkUnrestricted";
            this.checkUnrestricted.Size = new System.Drawing.Size(83, 17);
            this.checkUnrestricted.TabIndex = 7;
            this.checkUnrestricted.Text = "Unrestricted";
            this.checkUnrestricted.UseVisualStyleBackColor = true;
            // 
            // checkIO
            // 
            this.checkIO.AutoSize = true;
            this.checkIO.Location = new System.Drawing.Point(6, 29);
            this.checkIO.Name = "checkIO";
            this.checkIO.Size = new System.Drawing.Size(87, 17);
            this.checkIO.TabIndex = 8;
            this.checkIO.Text = "Input/Output";
            this.checkIO.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 80);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblParam, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApplicationPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOpen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtApplicaitonParam, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParam.Location = new System.Drawing.Point(5, 35);
            this.lblParam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(40, 21);
            this.lblParam.TabIndex = 7;
            this.lblParam.Text = "Param:";
            this.lblParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpen.Location = new System.Drawing.Point(5, 4);
            this.lblOpen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(40, 22);
            this.lblOpen.TabIndex = 6;
            this.lblOpen.Text = "Open:";
            this.lblOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLog);
            this.panel1.Controls.Add(this.tableButtons);
            this.panel1.Controls.Add(this.tablePermissions);
            this.panel1.Controls.Add(this.tableApplication);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(784, 361);
            this.panel1.TabIndex = 10;
            // 
            // tableLog
            // 
            this.tableLog.AutoSize = true;
            this.tableLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLog.ColumnCount = 1;
            this.tableLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLog.Controls.Add(this.txtLog, 0, 0);
            this.tableLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLog.Location = new System.Drawing.Point(3, 224);
            this.tableLog.Name = "tableLog";
            this.tableLog.RowCount = 1;
            this.tableLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLog.Size = new System.Drawing.Size(778, 134);
            this.tableLog.TabIndex = 10;
            // 
            // tableButtons
            // 
            this.tableButtons.AutoSize = true;
            this.tableButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableButtons.ColumnCount = 4;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.Controls.Add(this.btnCancel, 3, 0);
            this.tableButtons.Controls.Add(this.btnOK, 2, 0);
            this.tableButtons.Controls.Add(this.btnBrowse, 1, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableButtons.Location = new System.Drawing.Point(3, 195);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableButtons.Size = new System.Drawing.Size(778, 29);
            this.tableButtons.TabIndex = 11;
            // 
            // tablePermissions
            // 
            this.tablePermissions.AutoSize = true;
            this.tablePermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePermissions.ColumnCount = 1;
            this.tablePermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePermissions.Controls.Add(this.tabControl1, 0, 0);
            this.tablePermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePermissions.Location = new System.Drawing.Point(3, 89);
            this.tablePermissions.Name = "tablePermissions";
            this.tablePermissions.RowCount = 1;
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePermissions.Size = new System.Drawing.Size(778, 106);
            this.tablePermissions.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkUnrestricted);
            this.tabPage1.Controls.Add(this.checkIO);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableApplication
            // 
            this.tableApplication.AutoSize = true;
            this.tableApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableApplication.ColumnCount = 1;
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableApplication.Controls.Add(this.groupBox1, 0, 0);
            this.tableApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableApplication.Location = new System.Drawing.Point(3, 3);
            this.tableApplication.Name = "tableApplication";
            this.tableApplication.RowCount = 1;
            this.tableApplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableApplication.Size = new System.Drawing.Size(778, 86);
            this.tableApplication.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "Sandbox Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLog.ResumeLayout(false);
            this.tableLog.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.tablePermissions.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableApplication.ResumeLayout(false);
            this.tableApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox txtApplicationPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openApplicaitonDialog;
        private System.Windows.Forms.TextBox txtApplicaitonParam;
        private System.Windows.Forms.CheckBox checkUnrestricted;
        private System.Windows.Forms.CheckBox checkIO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLog;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tablePermissions;
        private System.Windows.Forms.TableLayoutPanel tableApplication;
    }
}

