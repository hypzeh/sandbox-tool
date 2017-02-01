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
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.groupPermissions = new System.Windows.Forms.GroupBox();
            this.tablePermissions = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.groupApplication = new System.Windows.Forms.GroupBox();
            this.tableApplication = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplicationOpen = new MetroFramework.Controls.MetroLabel();
            this.txtBoxApplicationPath = new MetroFramework.Controls.MetroTextBox();
            this.btnApplicationBrowse = new MetroFramework.Controls.MetroButton();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.openApplicationFile = new System.Windows.Forms.OpenFileDialog();
            this.panelMain.SuspendLayout();
            this.groupPermissions.SuspendLayout();
            this.tablePermissions.SuspendLayout();
            this.groupApplication.SuspendLayout();
            this.tableApplication.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupPermissions);
            this.panelMain.Controls.Add(this.groupApplication);
            this.panelMain.Controls.Add(this.tableButtons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(20, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(410, 170);
            this.panelMain.TabIndex = 0;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // groupPermissions
            // 
            this.groupPermissions.AutoSize = true;
            this.groupPermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPermissions.Controls.Add(this.tablePermissions);
            this.groupPermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPermissions.Location = new System.Drawing.Point(0, 48);
            this.groupPermissions.Name = "groupPermissions";
            this.groupPermissions.Size = new System.Drawing.Size(410, 61);
            this.groupPermissions.TabIndex = 4;
            this.groupPermissions.TabStop = false;
            this.groupPermissions.Text = "Permissions";
            // 
            // tablePermissions
            // 
            this.tablePermissions.AutoSize = true;
            this.tablePermissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePermissions.ColumnCount = 2;
            this.tablePermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.Controls.Add(this.CheckBox1, 0, 0);
            this.tablePermissions.Controls.Add(this.CheckBox2, 0, 1);
            this.tablePermissions.Controls.Add(this.CheckBox3, 1, 0);
            this.tablePermissions.Controls.Add(this.CheckBox4, 1, 1);
            this.tablePermissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePermissions.Location = new System.Drawing.Point(3, 16);
            this.tablePermissions.Name = "tablePermissions";
            this.tablePermissions.RowCount = 2;
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePermissions.Size = new System.Drawing.Size(404, 42);
            this.tablePermissions.TabIndex = 1;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(3, 3);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(81, 15);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "CheckBox1";
            this.CheckBox1.UseSelectable = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(3, 24);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(81, 15);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "CheckBox2";
            this.CheckBox2.UseSelectable = true;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(205, 3);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(81, 15);
            this.CheckBox3.TabIndex = 2;
            this.CheckBox3.Text = "CheckBox3";
            this.CheckBox3.UseSelectable = true;
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(205, 24);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(81, 15);
            this.CheckBox4.TabIndex = 3;
            this.CheckBox4.Text = "CheckBox4";
            this.CheckBox4.UseSelectable = true;
            // 
            // groupApplication
            // 
            this.groupApplication.AutoSize = true;
            this.groupApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupApplication.Controls.Add(this.tableApplication);
            this.groupApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupApplication.Location = new System.Drawing.Point(0, 0);
            this.groupApplication.Name = "groupApplication";
            this.groupApplication.Size = new System.Drawing.Size(410, 48);
            this.groupApplication.TabIndex = 2;
            this.groupApplication.TabStop = false;
            this.groupApplication.Text = "Application";
            // 
            // tableApplication
            // 
            this.tableApplication.AutoSize = true;
            this.tableApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableApplication.ColumnCount = 3;
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableApplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableApplication.Controls.Add(this.lblApplicationOpen, 0, 0);
            this.tableApplication.Controls.Add(this.txtBoxApplicationPath, 1, 0);
            this.tableApplication.Controls.Add(this.btnApplicationBrowse, 2, 0);
            this.tableApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableApplication.Location = new System.Drawing.Point(3, 16);
            this.tableApplication.Name = "tableApplication";
            this.tableApplication.RowCount = 1;
            this.tableApplication.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableApplication.Size = new System.Drawing.Size(404, 29);
            this.tableApplication.TabIndex = 0;
            // 
            // lblApplicationOpen
            // 
            this.lblApplicationOpen.AutoSize = true;
            this.lblApplicationOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblApplicationOpen.Location = new System.Drawing.Point(3, 0);
            this.lblApplicationOpen.Name = "lblApplicationOpen";
            this.lblApplicationOpen.Size = new System.Drawing.Size(45, 29);
            this.lblApplicationOpen.TabIndex = 0;
            this.lblApplicationOpen.Text = "Open:";
            this.lblApplicationOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxApplicationPath
            // 
            // 
            // 
            // 
            this.txtBoxApplicationPath.CustomButton.Image = null;
            this.txtBoxApplicationPath.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txtBoxApplicationPath.CustomButton.Name = "";
            this.txtBoxApplicationPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxApplicationPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxApplicationPath.CustomButton.TabIndex = 1;
            this.txtBoxApplicationPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxApplicationPath.CustomButton.UseSelectable = true;
            this.txtBoxApplicationPath.CustomButton.Visible = false;
            this.txtBoxApplicationPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxApplicationPath.Lines = new string[0];
            this.txtBoxApplicationPath.Location = new System.Drawing.Point(54, 3);
            this.txtBoxApplicationPath.MaxLength = 32767;
            this.txtBoxApplicationPath.Name = "txtBoxApplicationPath";
            this.txtBoxApplicationPath.PasswordChar = '\0';
            this.txtBoxApplicationPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxApplicationPath.SelectedText = "";
            this.txtBoxApplicationPath.SelectionLength = 0;
            this.txtBoxApplicationPath.SelectionStart = 0;
            this.txtBoxApplicationPath.ShortcutsEnabled = true;
            this.txtBoxApplicationPath.Size = new System.Drawing.Size(315, 23);
            this.txtBoxApplicationPath.TabIndex = 1;
            this.txtBoxApplicationPath.UseSelectable = true;
            this.txtBoxApplicationPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxApplicationPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnApplicationBrowse
            // 
            this.btnApplicationBrowse.AutoSize = true;
            this.btnApplicationBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplicationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApplicationBrowse.Location = new System.Drawing.Point(375, 3);
            this.btnApplicationBrowse.Name = "btnApplicationBrowse";
            this.btnApplicationBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnApplicationBrowse.TabIndex = 2;
            this.btnApplicationBrowse.Text = "...";
            this.btnApplicationBrowse.UseSelectable = true;
            this.btnApplicationBrowse.Click += new System.EventHandler(this.btnApplicationBrowse_Click);
            // 
            // tableButtons
            // 
            this.tableButtons.AutoSize = true;
            this.tableButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableButtons.ColumnCount = 3;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableButtons.Controls.Add(this.btnOK, 1, 0);
            this.tableButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableButtons.Location = new System.Drawing.Point(0, 141);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableButtons.Size = new System.Drawing.Size(410, 29);
            this.tableButtons.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(251, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openApplicationFile
            // 
            this.openApplicationFile.FileName = "openApplicationFile";
            this.openApplicationFile.Filter = "Application|*.exe|All|*.*";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Windows Sandbox Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupPermissions.ResumeLayout(false);
            this.groupPermissions.PerformLayout();
            this.tablePermissions.ResumeLayout(false);
            this.tablePermissions.PerformLayout();
            this.groupApplication.ResumeLayout(false);
            this.groupApplication.PerformLayout();
            this.tableApplication.ResumeLayout(false);
            this.tableApplication.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMain;
        private System.Windows.Forms.GroupBox groupApplication;
        private System.Windows.Forms.TableLayoutPanel tableApplication;
        private MetroFramework.Controls.MetroLabel lblApplicationOpen;
        private MetroFramework.Controls.MetroTextBox txtBoxApplicationPath;
        private MetroFramework.Controls.MetroButton btnApplicationBrowse;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.GroupBox groupPermissions;
        private System.Windows.Forms.TableLayoutPanel tablePermissions;
        private MetroFramework.Controls.MetroCheckBox CheckBox1;
        private MetroFramework.Controls.MetroCheckBox CheckBox2;
        private MetroFramework.Controls.MetroCheckBox CheckBox3;
        private MetroFramework.Controls.MetroCheckBox CheckBox4;
        private System.Windows.Forms.OpenFileDialog openApplicationFile;
    }
}

