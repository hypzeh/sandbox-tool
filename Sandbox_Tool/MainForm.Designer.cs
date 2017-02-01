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
            this.groupApplication = new System.Windows.Forms.GroupBox();
            this.tableApplication = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplicationOpen = new MetroFramework.Controls.MetroLabel();
            this.txtBoxApplicationPath = new MetroFramework.Controls.MetroTextBox();
            this.btnApplicationBrowse = new MetroFramework.Controls.MetroButton();
            this.panelMain.SuspendLayout();
            this.groupApplication.SuspendLayout();
            this.tableApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupApplication);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(20, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(410, 220);
            this.panelMain.TabIndex = 0;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "MainForm";
            this.Text = "Windows Sandbox Tool";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupApplication.ResumeLayout(false);
            this.groupApplication.PerformLayout();
            this.tableApplication.ResumeLayout(false);
            this.tableApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMain;
        private System.Windows.Forms.GroupBox groupApplication;
        private System.Windows.Forms.TableLayoutPanel tableApplication;
        private MetroFramework.Controls.MetroLabel lblApplicationOpen;
        private MetroFramework.Controls.MetroTextBox txtBoxApplicationPath;
        private MetroFramework.Controls.MetroButton btnApplicationBrowse;
    }
}

